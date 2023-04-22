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
        string query = "Select * from Bunkers ";
        var result = await _connection.QueryAsync<Bunker>(query);


        //List<Bunker> bunkers = new List<Bunker>();
        //Bunker bunker = new Bunker
        //{
        //    Id = new(),
        //    Name = "Bunker Brescia",
        //    Description = "Des",
        //    Country = "Ita",
        //    Region = "Lombardia",
        //    Province = "Brescia",
        //    City = "Brescia",
        //    Latitude = 45.5416,
        //    Longitude = 10.2118,
        //    CreatedDateTime = new DateTime(),
        //    LastModifiedDateTime = new DateTime()
        //};
        //Bunker bunker2 = new Bunker
        //{
        //    Id = new(),
        //    Name = "Bunker Dublino",
        //    Description = "Des",
        //    Country = "Ire",
        //    Region = "Irlanda",
        //    Province = "Dublino",
        //    City = "Dublino",
        //    Latitude = 53.3498,
        //    Longitude = -6.2603,
        //    CreatedDateTime = new DateTime(),
        //    LastModifiedDateTime = new DateTime()
        //};
        //Bunker bunker3 = new Bunker
        //{
        //    Id = new(),
        //    Name = "Bunker Manerbio",
        //    Description = "Des",
        //    Country = "Ita",
        //    Region = "Italy",
        //    Province = "Manerbio",
        //    City = "Manerbio",
        //    Latitude = 45.3534,
        //    Longitude = 10.1408,
        //    CreatedDateTime = new DateTime(),
        //    LastModifiedDateTime = new DateTime()
        //};
        //bunkers.Add(bunker);
        //bunkers.Add(bunker2);
        //bunkers.Add(bunker3);
        return result.ToList();
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