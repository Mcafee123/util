namespace Winforms.Base.Core.Interfaces.Config
{
    public interface IConfigReader
    {
        string GetConnectionString(string key, string defaultValue);
        string GetString(string key, string defaultValue);
        int GetInt(string key, int defaultValue);
        bool GetBool(string key, bool defaultValue);
    }
}