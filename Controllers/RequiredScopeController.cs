using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Identity.Web;
using Microsoft.Identity.Web.Resource;

[Authorize]
[Route("api/[controller]")]
[RequiredScope("Access.User")]
[ApiController]
public class RequiredScopeController : ControllerBase
{
    [HttpGet]
    public IActionResult Get()
    {
        return Ok("This is a protected endpoint that requires the Access.User scope");
    }
}