using Application.Dto;
using MediatR;

namespace Application.Contracts.Player;

public class CreatePlayer
{
    public record struct Command(string Name) : IRequest<Response>;

    public record struct Response(PlayerDto Player);
}