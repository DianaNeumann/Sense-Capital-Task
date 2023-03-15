using MediatR;

namespace Presentation.Features.Events.AddEvent;

public class AddEvent
{
    public record struct Command(
        string Name,
        DateTime Start,
        DateTime End,
        string Description,
        Guid Picture,
        Guid Space) : IRequest<Response>;

    public record struct Response(EventDto Event);
}
