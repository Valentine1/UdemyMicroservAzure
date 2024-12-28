namespace AuthLibrary.Constants.Authentication
{
    public interface IPermissionNameFormatter
    {
        string Format(string service, string feature, string action);
    }
}
