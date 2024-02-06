namespace Catalog.API.Configuration
{
    public class CacheSettingOptions
    {
        public const string CacheSettings = "CacheSettings";
        public string ConnectionString { get; set; } =string.Empty;        
    }
}
