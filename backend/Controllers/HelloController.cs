using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("[controller]")]
public class HelloController : ControllerBase
{
    [HttpGet]
    public string Get()
    {
        return "Hello, ASP.NET CORE with Docker!"
    }
}