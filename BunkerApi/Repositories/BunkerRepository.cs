using BunkerApi.Models;
using Dapper;
using MySql.Data.MySqlClient;
using System.Data;

namespace BunkerApi.Repositories;
public class BunkerRepository : IBunkerRepository
{
    private readonly IDbConnection _connection;
    public BunkerRepository(IDbConnection connection) 
    { 
        _connection = connection;
    }
    public Task<Bunker> CreateBunker(Guid id)
    {
        throw new NotImplementedException();
    }
    public Task<Bunker> GetBunker(Guid id)
    {
        Bunker bunker = new Bunker
        {
            Id = id,
            Name = "Bunker Prova",
            Description = "Des",
            Country = "Ita",
            Region = "Lombardia",
            Province = "Brescia",
            City = "Ghedi",
            Latitude = 45.4060,
            Longitude = 10.2755,
            CreatedDateTime = new DateTime(),
            LastModifiedDateTime = new DateTime()
        };
        return Task.FromResult(bunker);
    }
    public async Task<List<Bunker>> GetBunkers()
    {
        try
        {
            string query = "Select * from Bunkers ";

            var result = await _connection.QueryAsync<Bunker>(query);
            return result.ToList();
        }
        catch
        {
            throw new Exception("Error to connect to database");
        }
    }
    public Task<Bunker> UpdateBunker(Guid id)
    {
        throw new NotImplementedException();
    }
    public Task<Bunker> DeleteBunker(Guid id)
    {
        throw new NotImplementedException();
    }
}