using MediatR;

namespace Presentation.Features.Events.DeleteEvent;

public class DeleteEvent
{
    public record struct Command(Guid Id) : IRequest<Response>;

    public record struct Response(EventDto Event);
}