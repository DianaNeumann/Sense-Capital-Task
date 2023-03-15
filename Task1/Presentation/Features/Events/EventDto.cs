namespace Presentation.Features.Events;

public record EventDto(
    Guid Id,
    string Name,
    DateTime Start,
    DateTime End,
    string Description,
    Guid Picture,
    Guid Space);