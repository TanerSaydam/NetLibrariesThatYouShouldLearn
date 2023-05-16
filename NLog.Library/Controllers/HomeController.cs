using Microsoft.AspNetCore.Mvc;

namespace NLog.Library.Controllers;

[Route("api/[controller]")]
[ApiController]
public class HomeController : ControllerBase
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
        //_logger.LogDebug(1, "NLog enjected into HomeController");
    }

    [HttpGet("[action]")]
    public IActionResult Get()
    {
        //_logger.LogInformation("Hello, this is the GetApi Log");
        int x = 0;
        int y = 0;
        try
        {
            int result = x / y;
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Bir hata aldık!");
            return BadRequest();
        }        
        return NoContent();
    }
}
