using Application.Dto;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Presentation.WebApi.Models.Games;
using static Application.Contracts.Game.CreateGame;
using static Application.Contracts.Game.GetGameById;

namespace Presentation.WebApi.Controllers;

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
        var command = new Command(model.PlayerOneId, model.PlayerTwoId);
        var response = await _mediator.Send(command, CancellationToken);

        return Ok(response.Game);
    }
    
    [HttpGet("{id:guid}")]
    public async Task<ActionResult<GameDto>> GetGameByIdAsync(Guid id)
    {
        var query = new Query(id);
        var response = await _mediator.Send(query, CancellationToken);
        
        return Ok(response.Game);
    }
}