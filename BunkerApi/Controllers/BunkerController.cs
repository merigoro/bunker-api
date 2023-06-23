using BunkerContracts;
using Microsoft.AspNetCore.Mvc;
using BunkerApi.Services;
using BunkerApi.Models;
using BunkerApi.Mappers;

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
    public async Task<IActionResult> CreateBunker(BunkerCreate bunkerCreate)
    {

        if (bunkerCreate is null)
        {
            return BadRequest();
        }
        Bunker bunker = bunkerCreate.AsModel();

        bunker = await _bunkerService.CreateBunker(bunker);
        return Ok(bunker.AsResponse());
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
    public async Task<IActionResult> UpdateBunker([FromRoute] Guid id, [FromBody] BunkerUpdate bunkerUpdate)
    {
        if (bunkerUpdate is null)
        {
            return BadRequest();
        }
        Bunker bunker = bunkerUpdate.AsModel();

        bunker = await _bunkerService.UpdateBunker(id, bunker);
        return Ok(bunker.AsResponse());
    }
    [HttpDelete("{id:guid}")]
    public async Task<IActionResult> DeleteBunker([FromRoute] Guid id)
    {
        Bunker bunker = await _bunkerService.DeleteBunker(id);
        return Ok(bunker);
    }
    [HttpGet("closest/{latitude}/{longitude}")]
    public async Task<IActionResult> GetClosestBunker([FromRoute] double latitude, [FromRoute] double longitude)
    {
        Bunker bunker = await _bunkerService.GetClosestBunker(latitude, longitude);
        return Ok(bunker);
    }
}
