using BunkerApi.Models;


namespace BunkerApi.Repositories;
public class BunkerRepository : IBunkerRepository
{
    public Task<Bunker> CreateBunker(Guid id)
    {
        throw new NotImplementedException();
    }
    public Task<Bunker> GetBunker(Guid id)
    {
        Bunker bunker = new Bunker
        {
            Id = new(),
            Name = "Bunker Prova",
            Description = "Des",
            Country = "Ita",
            Region = "Lombardia",
            Province = "Brescia",
            City = "Ghedi",
            Latitudine = 1,
            Longitude = 1,
            CreatedDateTime = new DateTime(),
            LastModifiedDateTime = new DateTime()
        };
        return Task.FromResult(bunker);
    }
    public Task<List<Bunker>> GetBunkers()
    {
        throw new NotImplementedException();
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