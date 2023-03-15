using FluentValidation;
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

    /// <summary>
    ///  Creates a new event
    /// </summary>
    /// <param name="model"></param>
    /// <param name="validator"></param>
    /// <returns>Returns result event</returns>
    [HttpPost("CreateEvent")]
    public async Task<ActionResult<Event>> CreateEventAsync(
        [FromBody] CreateEventModel model, 
        [FromServices] IValidator<AddEvent.AddEvent.Command> validator)
    {
        var command = new AddEvent.AddEvent.Command(
            model.Name,
            model.Start,
            model.End,
            model.Description,
            model.Picture,
            model.Space);

        var validationResult = await validator.ValidateAsync(command, CancellationToken);
        if (!validationResult.IsValid)
        {
            return BadRequest(validationResult.Errors);
        }
        
        var response = await _mediator.Send(command, CancellationToken);
        
        return Ok(response.Event);
    }
    
    /// <summary>
    ///  Delete event by ID
    /// </summary>
    /// <param name="model"></param>
    /// <returns>Returns deleted event</returns>
    [HttpDelete("DeleteEvent")]
    public async Task<ActionResult<Event>> DeleteEventAsync([FromBody] DeleteEventModel model)
    {
        var command = new DeleteEvent.DeleteEvent.Command(model.Id);
        var response = await _mediator.Send(command, CancellationToken);
        
        return Ok(response.Event);
    }
    
    /// <summary>
    ///  Update event by ID
    /// </summary>
    /// <param name="model"></param>
    /// <param name="validator"></param>
    /// <returns>Кeturns the object that was just deleted</returns>
    [HttpPatch("UpdateEvent")]
    public async Task<ActionResult<Event>> CreateEventAsync(
        [FromBody] UpdateEventModel model, 
        [FromServices] IValidator<UpdateEvent.UpdateEvent.Command> validator)
    {

        var command = new UpdateEvent.UpdateEvent.Command(
            model.Id,
            model.Name,
            model.Start,
            model.End,
            model.Description,
            model.Picture,
            model.Space);
        
        var validationResult = await validator.ValidateAsync(command, CancellationToken);
        if (!validationResult.IsValid)
        {
            return BadRequest(validationResult.Errors);
        }
        
        var response = await _mediator.Send(command, CancellationToken);
        
        return Ok(response.Event);
    }
    
    /// <summary>
    /// Getting events
    /// </summary>
    /// <returns>Return all event</returns>
    [HttpGet("GetAllEvents")]
    public async Task<ActionResult<Event>> GetAllEventsAsync()
    {
        var command = new GetEvents.GetEvents.Command();
        var response = await _mediator.Send(command, CancellationToken);
        
        return Ok(response.Events);
    }


}