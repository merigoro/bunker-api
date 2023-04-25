using BunkerApi.Models;
using Dapper;
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
    public async Task<Bunker> GetBunker(Guid id)
    {
        try
        {
            string query = "Select * from bunkers Where id = @id ";

            var result = await _connection.QuerySingleOrDefault(query, new
            {
                id = id
            }) ;
            return result;
        }
        catch
        {
            throw new Exception("Error to connect to database");
        }
    }
    public async Task<List<Bunker>> GetBunkers()
    {
        try
        {
            string query = "Select * from bunkers ";

            var result = await _connection.QueryAsync<Bunker>(query);
            return result.ToList();
        }
        catch(Exception e)
        {
            throw new Exception(e.Message);
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