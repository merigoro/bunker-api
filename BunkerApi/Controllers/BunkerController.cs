using BunkerContracts;
using Microsoft.AspNetCore.Mvc;
using BunkerApi.Services;
using BunkerApi.Models;

namespace BunkerApi.Controllers;

[ApiController]
[Route("v{version:apiVersion}/[controller]")]
[ApiVersion("1.0")]
public class BunkerController : ControllerBase
{
    private readonly ILogger<BunkerController> _logger;
    private readonly IBunkerService _bunkerService;

    public BunkerController(ILogger<BunkerController> logger, IBunkerService bunkerService)
    {
        _logger = logger;
        _bunkerService = bunkerService;
    }

    [HttpPost]
    public async Task<IActionResult> CreateBunker(Guid id)
    {
        Bunker bunker = await _bunkerService.CreateBunker(id);
        return Ok(bunker);
    }
    [HttpGet("{id}")]
    public async Task<IActionResult> GetBunker([FromRoute] Guid id)
    {
        Bunker bunker = await _bunkerService.GetBunker(id);
        return Ok(bunker);
    }
    [HttpGet("bunkers")]
    public async Task<IActionResult> GetBunkers()
    {
        List<Bunker> bunkers = await _bunkerService.GetBunkers();
        return Ok(bunkers);
    }
    [HttpPut("{id:guid}")]
    public async Task<IActionResult> UpdateBunker([FromRoute] Guid id)
    {
        Bunker bunker = await _bunkerService.UpdateBunker(id);
        return Ok(bunker);
    }
    [HttpDelete("{id:guid}")]
    public async Task<IActionResult> DeleteBunker([FromRoute] Guid id)
    {
        Bunker bunker = await _bunkerService.DeleteBunker(id);
        return Ok();
    }
    [HttpGet("closest/{latitude}/{longitude}")]
    public async Task<IActionResult> GetClosestBunker([FromRoute] double latitude, [FromRoute] double longitude)
    {
        Bunker bunker = await _bunkerService.GetClosestBunker(latitude, longitude);
        return Ok(bunker);
    }
}
