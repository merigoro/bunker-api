using BunkerApi.Models;
using BunkerApi.Repositories;

namespace BunkerApi.Services;

public class BunkerService : IBunkerService
{
    private readonly IBunkerRepository _bunkerRepository;
    public BunkerService(IBunkerRepository bunkerRepository)
    {
        _bunkerRepository = bunkerRepository;
    }
    public async Task<Bunker> CreateBunker(Bunker bunker)
    {
        return await _bunkerRepository.CreateBunker(bunker);
    }
    public async Task<Bunker> GetBunker(Guid id)
    {
        return await _bunkerRepository.GetBunker(id);
    }
    public async Task<List<Bunker>> GetBunkers()
    {
        return await _bunkerRepository.GetBunkers();
    }
    public async Task<Bunker> GetClosestBunker(double latitude, double longitude)
    {
        List<Bunker> bunkers = await _bunkerRepository.GetBunkers();

        //I don't use Math.Pow because is slower
        Bunker closest = bunkers.OrderBy(b =>
        (longitude - b.Longitude) * (longitude - b.Longitude)
        + (latitude - b.Latitude) * (latitude - b.Latitude))
                     .First();

        return closest;
    }
    public async Task<Bunker> UpdateBunker(Guid id, Bunker bunker)
    {
        return await _bunkerRepository.UpdateBunker(id, bunker);
    }
    public async Task<Bunker> DeleteBunker(Guid id)
    {
        return await _bunkerRepository.DeleteBunker(id);
    }
}