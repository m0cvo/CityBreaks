using CityBreaks.PageRouteModelConventions;
using CityBreaks.ParameterTransformers;
using CityBreaks.RouteContraints;
using CityBreaks.Services;
using Microsoft.AspNetCore.Mvc.ApplicationModels;
using Microsoft.EntityFrameworkCore;
using CityBreaks.Data;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages().AddRazorPagesOptions(options => {
    options.Conventions.AddPageRoute("/Index", "FindMe");
    options.Conventions.Add(new CultureTemplatePageRouteModelConvention());
    options.Conventions.Add(new PageRouteTransformerConvention(
       new KebabPageRouteParameterTransformer()));
});
builder.Services.AddScoped<ICityService, CityService>();
builder.Services.AddTransient<LifetimeDemoService>();
builder.Services.AddSingleton<SingletonService>();
builder.Services.Configure<RouteOptions>(options =>
{
    options.LowercaseUrls= true;
    options.ConstraintMap.Add("city", typeof(CityRouteConstraint));
    options.ConstraintMap.Add("slug", typeof(SlugParameterTransformer));
});
builder.Services.AddDbContext<CityBreaksContext>(options =>
{
    options.UseSqlite(builder.Configuration.GetConnectionString ("CityBreaksContext"));
});
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

app.UseAuthorization();

app.MapRazorPages();

app.Run();
