namespace Presentation.Features.Events.Models;

public record UpdateEventModel(
    Guid Id,
    string Name,
    DateTime Start,
    DateTime End,
    string Description,
    Guid Picture,
    Guid Space);
