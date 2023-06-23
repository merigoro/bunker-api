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
    public async Task<Bunker> CreateBunker(Bunker bunker)
    {
        try
        {
            string query = "Insert into bunkers (name, description, country, region" +
                ", province, city, latitude, longitude, image)" +
                " values (@name, @description, @country, @region, @province, @city, @latitude, @longitude, @image) " +
                "Returning *";
            
            var result = await _connection.QuerySingleOrDefaultAsync<Bunker>(query, new
            {
                name = bunker.Name,
                description = bunker.Description,
                country = bunker.Country,
                region = bunker.Region,
                province = bunker.Province,
                city = bunker.City, 
                latitude = bunker.Latitude,
                longitude = bunker.Longitude, 
                image = bunker.Image
            });
            return result;
        }
        catch
        {
            throw new Exception("Error to connect to database");
        }
    }
    public async Task<Bunker> GetBunker(Guid id)
    {
        try
        {
            string query = "Select * from bunkers Where id = @id ";

            var result = await _connection.QuerySingleOrDefaultAsync<Bunker>(query, new
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
    public async Task<Bunker> UpdateBunker(Guid id, Bunker bunker)
    {
        try
        {
            string query = "Update bunkers set name = @name, description = @description" +
                ", country = @country, region = @region, province = @province, city = @city" +
                ", latitude = @latitude, longitude = @longitude, image = @image " +
                " where id = @id " +
                "Returning *";

            var result = await _connection.QuerySingleOrDefaultAsync<Bunker>(query, new
            {
                id = id,
                name = bunker.Name,
                description = bunker.Description,
                country = bunker.Country,
                region = bunker.Region,
                province = bunker.Province,
                city = bunker.City,
                latitude = bunker.Latitude,
                longitude = bunker.Longitude,
                image = bunker.Image
            });
            return result;
        }
        catch
        {
            throw new Exception("Error to connect to database");
        }
    }
    public async Task<Bunker> DeleteBunker(Guid id)
    {
        try
        {
            Bunker bunker = new();
            bunker = await GetBunker(id);
                
            string query = "Delete from bunkers where id = @id";

            await _connection.ExecuteAsync(query, new
            {
                id = id
            });

            return bunker;
        }
        catch
        {
            throw new Exception("Error to connect to database");
        }
    }
}