using Microsoft.AspNetCore.Authorization;

namespace AuthLibrary.Constants.Permissions
{
    public class PermissionRequirement: IAuthorizationRequirement
    {
        public string Permission { get; set; }

        public PermissionRequirement(string permission)
        {
            Permission = permission;
        }
    }
}
