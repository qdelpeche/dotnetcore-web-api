using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Identity.Web;
using Microsoft.Identity.Web.Resource;

[Authorize]
[Route("api/requiredscope")]
[RequiredScope("crud")]
[ApiController]
public class RequiredScopeController : ControllerBase
{
    
    [HttpGet]
    public IActionResult Get()
    {
        var result = new
        {
            Message = "This is a protected endpoint that requires the crud scope",
            Date = DateTime.UtcNow
        };

        return Ok(result);
    }
}