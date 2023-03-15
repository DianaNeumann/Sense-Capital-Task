using MediatR;

namespace Presentation.Features.Events.GetEvents;

public class GetEvents
{
    public record struct Command : IRequest<Response>;

    public record struct Response(IEnumerable<EventDto> Events);
}