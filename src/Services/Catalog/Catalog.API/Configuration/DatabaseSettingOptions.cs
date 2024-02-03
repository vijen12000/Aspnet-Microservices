namespace Catalog.API.Configuration
{
    public class DatabaseSettingOptions
    {
        public const string DatabaseSettings = "DatabaseSettings";
        public string ConnectionString { get; set; } =string.Empty;
        public string DatabaseName { get; set; } =string.Empty;
        public string CollectionName { get; set; } =string.Empty;
    }
}
