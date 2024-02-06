using Microsoft.AspNetCore.Mvc;
namespace webapi.Controllers;

[ApiController]
[Route("[controller]")]
public class HelloWorldController : ControllerBase
{
    IHelloWorldService helloWorldService;
    private readonly ILogger<HelloWorldController> _logger;

    public HelloWorldController(IHelloWorldService IHello, ILogger<HelloWorldController> _logger)
    {
        this._logger = _logger;
        helloWorldService = IHello;
    }


    [HttpGet(Name = "GetHelloWorld")]
    public IActionResult Get()
    {
        _logger.LogInformation("Api retornando hola mundo");
        return Ok(helloWorldService.GetHelloWorld());
    }
}