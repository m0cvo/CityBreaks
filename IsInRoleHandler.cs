using CityBreaks1.AuthorizationRequirements;
using Microsoft.AspNetCore.Authorization;

namespace CityBreaks1.AuthorizationHandlers
{
    public class IsInRoleHandler : AuthorizationHandler<ViewRolesRequirement>
    {
        protected override Task
  HandleRequirementAsync(AuthorizationHandlerContext context,
            ViewRolesRequirement req)
        {
            if (context.User.IsInRole("Admin"))
            {
                context.Succeed(req);
            }
            return Task.CompletedTask;
        }
    }
}
