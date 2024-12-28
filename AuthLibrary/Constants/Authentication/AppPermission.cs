namespace AuthLibrary.Constants.Authentication
{
    public record AppPermission(string Service, string Feature, string Action, string Group, string Description, string IsBasic)
    {
        public string Name => NameFor(Service, Feature, Action);
        public static string NameFor(string service, string feature, string action)
        {
            return (new PermissionNameFormatter ()).Format(service, feature, action);
        }
    }
}
