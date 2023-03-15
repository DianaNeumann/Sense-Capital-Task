using MediatR;
using Microsoft.AspNetCore.Mvc;
using Presentation.Features.Events.Models;

namespace Presentation.Features.Events;

[ApiController]
[Route("api/[controller]")]
public class EventController : ControllerBase
{
    private readonly IMediator _mediator;

    public EventController(IMediator mediator)
    {
        _mediator = mediator;
    }
    
    public CancellationToken CancellationToken => HttpContext.RequestAborted;

    [HttpPost("CreateEvent")]
    public async Task<ActionResult<Event>> CreateEventAsync([FromBody] CreateEventModel model)
    {
        var command = new AddEvent.AddEvent.Command(
            model.Name,
            model.Start,
            model.End,
            model.Description,
            model.Picture,
            model.Space);
        var response = await _mediator.Send(command, CancellationToken);
        return Ok(response.Event);
    }
    
    [HttpGet("GetAllEvents")]
    public async Task<ActionResult<Event>> GetAllEventsAsync()
    {
        var command = new GetEvents.GetEvents.Command();
        var response = await _mediator.Send(command, CancellationToken);
        return Ok(response.Events);
    }
}