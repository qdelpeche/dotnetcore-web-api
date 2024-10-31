using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using DotNetCoreWebApi.Models;

[Authorize]
[Route("api/noscope")]
[ApiController]
public class NoScopeController : ControllerBase
{

    [HttpGet]
    [Produces("application/json")]
    public ActionResult<ResponseModel> Get()
    {
        var result = new ResponseModel
        {
            Message = "This is a protected endpoint but requires no scope",
            Date = DateTime.UtcNow
        };
        
        return Ok(result);
    }
}