using CityBreaks.RouteContraints;
using CityBreaks.Data;
using CityBreaks.Models;
using CityBreaks.PageRouteModelConventions;
using CityBreaks.ParameterTransformers;
using CityBreaks.RouteContraints;
using CityBreaks.Services;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc.ApplicationModels;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;

var builder = WebApplication.CreateBuilder(args);

// Add builder.Services to the container.
builder.Services.AddRazorPages(options => {
    options.Conventions.AuthorizePage("/Index");
    options.Conventions.AuthorizeFolder("/CityManager");
    options.Conventions.AuthorizeFolder("/CountryManager");
    options.Conventions.AuthorizeFolder("/PropertyManager");
    options.Conventions.Add(new CultureTemplatePageRouteModelConvention());
    options.Conventions.Add(new PageRouteTransformerConvention(new KebabPageRouteParameterTransformer()));
});
builder.Services.Configure<RouteOptions>(options =>
{
    options.LowercaseUrls = true;
    options.ConstraintMap.Add("city", typeof(CityRouteConstraint));
    options.ConstraintMap.Add("slug", typeof(SlugParameterTransformer));
});

builder.Services.AddDbContext<CityBreaksContext>(options =>
{
    options.UseSqlite(builder.Configuration.GetConnectionString("CityBreaksContext"));
});
//builder.Services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
//.AddCookie(options =>
//{
//    options.LoginPath = "/login";
//});
builder.Services.AddDefaultIdentity<CityBreaksUser>(options => {
    //options.User.RequireUniqueEmail = false;
    //options.Password.RequiredLength = 6;
    options.Password.RequireDigit = false;
    options.Password.RequireLowercase = false;
    options.Password.RequireNonAlphanumeric = false;
    options.Password.RequireUppercase = false;
    options.SignIn.RequireConfirmedAccount = true;
})
    .AddRoles<IdentityRole>()
    .AddEntityFrameworkStores<CityBreaksContext>();

builder.Services.AddScoped<ICityService, CityService>();
builder.Services.AddTransient<LifetimeDemoService>();
builder.Services.AddSingleton<SingletonService>();
builder.Services.AddScoped<IPriceService, FrPriceService>();
builder.Services.AddScoped<IPriceService, GbPriceService>();
builder.Services.AddScoped<IPriceService, UsPriceService>();
builder.Services.AddScoped<IPriceService, DefaultPriceService>();
builder.Services.AddScoped<IPropertyService, PropertyService>();
builder.Services.AddTransient<IEmailSender, EmailService>();
builder.Services.AddAuthorization();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();
app.UseAuthentication();
app.UseAuthorization();

app.MapRazorPages();

app.Run();