using MediatR;
using Presentation.Abstractions;
using Presentation.Mapping;
using static Presentation.Features.Events.AddEvent.AddEvent;

namespace Presentation.Features.Events.AddEvent;

public class AddEventHandler : IRequestHandler<Command, Response>
{
    private readonly IRepository<Event> _repository;

    public AddEventHandler(IRepository<Event> repository)
    {
        _repository = repository;
    }

    public async Task<Response> Handle(Command request, CancellationToken cancellationToken)
    {
        var tempEvent = new Event(
            Guid.NewGuid(),
            request.Name,
            request.Start,
            request.End,
            request.Description,
            request.Picture,
            request.Space);
        
        _repository.Add(tempEvent);
        return new Response(tempEvent.AsDto());
    }
}