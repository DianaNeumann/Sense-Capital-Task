namespace Presentation.Features.Events.Models;

public record CreateEventModel(
    string Name,
    DateTime Start,
    DateTime End,
    string Description,
    Guid Picture,
    Guid Space);