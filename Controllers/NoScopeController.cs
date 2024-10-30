using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

[Authorize]
[Route("api/[controller]")]
[ApiController]
public class NoScopeController : ControllerBase
{
    [HttpGet]
    public IActionResult Get()
    {
        return Ok("This is a protected endpoint but requires no scope");
    }
}