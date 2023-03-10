using Application.Contracts.Game;
using Application.Dto;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Presentation.Models.Games;

namespace Presentation.Controllers;

[ApiController]
[Route("api/[controller]")]
public class GameController : ControllerBase
{
    private readonly IMediator _mediator;

    public GameController(IMediator mediator)
    {
        _mediator = mediator;
    }
    
    public CancellationToken CancellationToken => HttpContext.RequestAborted;

    
    [HttpPost("CreateGame")]
    public async Task<ActionResult<GameDto>> CreateGameAsync([FromBody] CreateGameModel model)
    {
        var command = new CreateGame.Command(model.PlayerOneId, model.PlayerTwoId);
        var response = await _mediator.Send(command, CancellationToken);

        return Ok(response.Game);
    }
}