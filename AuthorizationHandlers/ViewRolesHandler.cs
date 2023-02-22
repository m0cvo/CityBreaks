using CityBreaks1.AuthorizationRequirements;
using Microsoft.AspNetCore.Authorization;

namespace CityBreaks1.AuthorizationHandlers
{
    public class ViewRolesHandler : IAuthorizationHandler
    {
        public Task HandleAsync(AuthorizationHandlerContext context)
        {
            foreach (var requirement in
     context.PendingRequirements.ToList())
            {
                if (requirement is ViewRolesRequirement req)
                {
                    var joiningDateClaim =
     context.User.FindFirst(c => c.Type ==
     "Joining Date")?.Value;
                    if (joiningDateClaim == null)
                    {
                        return Task.CompletedTask;
                    }
                    var joiningDate = Convert.ToDateTime(joiningDateClaim);

                    if (context.User.HasClaim("Permission", "View Roles") &&
                            joiningDate < DateTime.Now.AddMonths(req.Months))
                    {
                        context.Succeed(requirement);
                    }
                }
            }
            return Task.CompletedTask;
        }
    }
}
