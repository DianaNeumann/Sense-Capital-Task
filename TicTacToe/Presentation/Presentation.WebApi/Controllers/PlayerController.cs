using Application.Contracts.Player;
using Application.Dto;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Presentation.Models.Players;

namespace Presentation.WebApi.Controllers;

[ApiController]
[Route("api/[controller]")]
public class PlayerController : ControllerBase
{
 
    private readonly IMediator _mediator;

    public PlayerController(IMediator mediator)
    {
        _mediator = mediator;
    }
    
    public CancellationToken CancellationToken => HttpContext.RequestAborted;
    
    [HttpPost("CreatePlayer")]
    public async Task<ActionResult<PlayerDto>> CreatePlayerAsync([FromBody] CreatePlayerModel model)
    {
        var command = new CreatePlayer.Command(model.Name);
        var response = await _mediator.Send(command, CancellationToken);

        return Ok(response.Player);
    }
    
    
    
}