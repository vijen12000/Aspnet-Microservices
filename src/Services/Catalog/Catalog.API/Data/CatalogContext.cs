using Amazon.Util.Internal.PlatformServices;
using Catalog.API.Configuration;
using Catalog.API.Entities;
using Microsoft.Extensions.Options;
using MongoDB.Driver;

namespace Catalog.API.Data
{
    public class CatalogContext : ICatalogContext        
    {
        public CatalogContext(IOptions<DatabaseSettingOptions> databaseSettings)
        {            
            var client = new MongoClient(databaseSettings.Value.ConnectionString);
            var database = client.GetDatabase(databaseSettings.Value.DatabaseName);
            Products = database.GetCollection<Product>(databaseSettings.Value.CollectionName);
            CatalogContextSeed.SeedData(Products);
        }
        public IMongoCollection<Product> Products { get; }        
    }
}
