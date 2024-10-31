using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Identity.Web;
using Microsoft.Identity.Web.Resource;
using DotNetCoreWebApi.Models;

[Authorize]
[Route("api/requiredscope")]
[RequiredScope("crud")]
[ApiController]
public class RequiredScopeController : ControllerBase
{
    
    [HttpGet]
    [Produces("application/json")]
    public ActionResult<ResponseModel> Get()
    {
        var result = new ResponseModel
        {
            Message = "This is a protected endpoint that requires the crud scope",
            Date = DateTime.UtcNow
        };

        return Ok(result);
    }
}