using System.Threading.Tasks;
using MessageMonitor.Api.Controllers.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace MessageMonitor.Api.Controllers;

[ApiController]
[Route("[controller]")]
public sealed class MessagesController(ILogger<MessagesController> logger) : ControllerBase
{
    [HttpPost]
    public Task<IActionResult> Post(Message message)
    {
        logger.LogInformation($"Received message {message.Content}.");

        return Task.FromResult<IActionResult>(Ok());
    }
}