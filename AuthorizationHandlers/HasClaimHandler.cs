using CityBreaks1.AuthorizationRequirements;
using Microsoft.AspNetCore.Authorization;

namespace CityBreaks1.AuthorizationHandlers
{
    public class HasClaimHandler : AuthorizationHandler<ViewRolesRequirement>
    {
        protected override Task HandleRequirementAsync(AuthorizationHandlerContext context,
            ViewRolesRequirement req)
        {
            var joiningDateClaim =
  context.User.FindFirst(c => c.Type == "Joining Date")?.Value;
            if (joiningDateClaim == null)
            {
                return Task.CompletedTask;
            }
            var joiningDate = Convert.ToDateTime(joiningDateClaim);

            if (context.User.HasClaim("Permission", "View Roles") &&
                  joiningDate < DateTime.Now.AddMonths(req.Months))
            {
                context.Succeed(req);
            }
            return Task.CompletedTask;
        }
    }
}