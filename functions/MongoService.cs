using MongoDB.Bson;
using MongoDB.Driver;

public class MongoService
{
    private readonly IMongoDatabase _database;

    public MongoService()
    {
        var connectionString = Environment.GetEnvironmentVariable("MONGODB_URI");
        var client = new MongoClient(connectionString); // Substitua pela sua connection string
        _database = client.GetDatabase("barber"); // Substitua pelo seu nome de banco de dados
    }

    public void PerformOperation<T>(string collectionName, Action<IMongoCollection<T>> operation)
    {
        var collection = _database.GetCollection<T>(collectionName);
        operation(collection);
    }
}
