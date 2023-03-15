using MediatR;

namespace Presentation.Features.Events.UpdateEvent;

public class UpdateEvent
{
    public record struct Command(
        Guid Id,
        string Name,
        DateTime Start,
        DateTime End,
        string Description,
        Guid Picture,
        Guid Space) : IRequest<Response>;

    public record struct Response(EventDto Event);
}