using Bunker.Contracts;
using Microsoft.AspNetCore.Mvc;

namespace BunkerApi.Controllers;

[ApiController]
[Route("[controller]")]
public class BunkerController : ControllerBase
{
    private readonly ILogger<BunkerController> _logger;

    public BunkerController(ILogger<BunkerController> logger)
    {
        _logger = logger;
    }

    [HttpGet("{id:guid}")]
    public IActionResult GetBunkers(Guid id)
    {
        return Ok();
    }
}
