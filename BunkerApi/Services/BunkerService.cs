using BunkerApi.Models;
using BunkerApi.Repositories;
using System.Drawing;

namespace BunkerApi.Services;

public class BunkerService : IBunkerService
{
    private readonly IBunkerRepository _bunkerRepository;
    public BunkerService(IBunkerRepository bunkerRepository)
    {
        _bunkerRepository = bunkerRepository;
    }
    public async Task<Bunker> CreateBunker(Guid id)
    {
        return await _bunkerRepository.CreateBunker(id);
    }
    public async Task<Bunker> GetBunker(Guid id)
    {
         return await _bunkerRepository.GetBunker(id);
    }
    public async Task<List<Bunker>> GetBunkers()
    {
         return await _bunkerRepository.GetBunkers();
    }
    public async Task<Bunker> GetClosestBunker(double latitudine, double longitude)
    {
        List<Bunker> bunkers = await _bunkerRepository.GetBunkers();

        //I don't use Math.Pow because is slower
        Bunker closest = bunkers.OrderBy(b =>
        (longitude - b.Longitude) * (longitude - b.Longitude)
        + (latitudine - b.Latitudine) * (latitudine - b.Latitudine))
                     .First();

        return closest;
    }
    public async Task<Bunker> UpdateBunker(Guid id)
    {
        return await _bunkerRepository.UpdateBunker(id);
    }
    public async Task<Bunker> DeleteBunker(Guid id)
    {
        return await _bunkerRepository.DeleteBunker(id);
    }
}