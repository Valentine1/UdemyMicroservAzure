namespace AuthLibrary.Constants.Authentication
{
    public class PermissionNameFormatter : IPermissionNameFormatter
    {
        public string Format(string service, string feature, string action)
        {
            ArgumentNullException.ThrowIfNull(service);
            ArgumentNullException.ThrowIfNull(feature);
            ArgumentNullException.ThrowIfNull(action);

            return $"Permission.{service}.{feature}.{action}";
        }
    }
}
