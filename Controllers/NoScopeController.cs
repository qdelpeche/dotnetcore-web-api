using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

[Authorize]
[Route("api/noscope")]
[ApiController]
public class NoScopeController : ControllerBase
{

    [HttpGet]
    public IActionResult Get()
    {
        var result = new
        {
            Message = "This is a protected endpoint but requires no scope",
            Date = DateTime.UtcNow
        };
        
        return Ok(result);
    }
}