using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("api/[controller]")]
public class SecureController : ControllerBase
{
    [HttpGet("data")]
    [Authorize]  // Protect this endpoint with JWT authentication
    public IActionResult GetSecureData()
    {
        return Ok("This is protected data.");
    }
}
