using Presentation.Features.Events;

namespace Presentation.Mapping;

public static class EventMapping
{
    public static EventDto AsDto(this Event someEvent)
        => new EventDto(
            someEvent.Id,
            someEvent.Name,
            someEvent.Start,
            someEvent.End,
            someEvent.Description,
            someEvent.Picture,
            someEvent.Space);
}