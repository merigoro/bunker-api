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
    public async Task<Bunker> UpdateBunker(Guid id)
    {
        return await _bunkerRepository.UpdateBunker(id);
    }
    public async Task<Bunker> DeleteBunker(Guid id)
    {
        return await _bunkerRepository.DeleteBunker(id);
    }
}