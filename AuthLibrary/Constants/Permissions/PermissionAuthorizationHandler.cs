using AuthLibrary.Constants.Authentication;
using Microsoft.AspNetCore.Authorization;

namespace AuthLibrary.Constants.Permissions
{
    public class PermissionAuthorizationHandler : AuthorizationHandler<PermissionRequirement>
    {
        public PermissionAuthorizationHandler()
        {
            
        }

        protected override async Task HandleRequirementAsync(AuthorizationHandlerContext context, PermissionRequirement requirement)
        {
            if(context.User is null)
            {
                await Task.CompletedTask;
            }

            var permissions = context.User.Claims
                .Where(c => c.Type == AppClaim.Permission
                    && c.Value == requirement.Permission
                    && c.Value == AppClaim.Issuer);
            if(permissions.Any())
            {
                context.Succeed(requirement);
                await Task.CompletedTask;
            }
        }
    }
}
