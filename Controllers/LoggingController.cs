
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.ObjectPool;

namespace Api.Controllers;

[ApiController]
[Route("[controller]")]
public class LoggingController : ControllerBase
{
    private readonly ILogger<LoggingController> _logger;

    public LoggingController(ILogger<LoggingController> logger)
    {
        _logger = logger;
    }

    [HttpGet]
    [Route("error")]
    public string LogError()
    {
        string errorMessage = "Log Error";

        _logger.LogError(errorMessage);
        return errorMessage;
    }

    [HttpGet]
    [Route("5xx")]
    public IActionResult LogHttp5xxError()
    {
        return StatusCode(500, "500 internal error");

    }

    [HttpGet]
    [Route("4xx")]
    public IActionResult LogHttp4xxError()
    {
        return StatusCode(403, "403 permission error");
    }

    [HttpGet]
    [Route("exception")]
    public string LogException()
    {
        throw new Exception("Custom exception");
    }

}