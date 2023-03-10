using Application.Abstractions.DataAccess;
using Application.Mapping;
using MediatR;
using static Application.Contracts.Player.CreatePlayer;

namespace Application.Player;

public class CreatePlayerHandler  : IRequestHandler<Command, Response>
{
    private readonly IDatabaseContext _context;

    public CreatePlayerHandler(IDatabaseContext context)
    {
        _context = context;
    }


    public async Task<Response> Handle(Command request, CancellationToken cancellationToken)
    {
        var player = new Domain.Players.Player(Guid.NewGuid(), request.Name);
        _context.Players.Add(player);
        await _context.SaveChangesAsync(cancellationToken);

        return new Response(player.AsDto());
    }
}