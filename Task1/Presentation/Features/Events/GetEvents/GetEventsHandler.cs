using MediatR;
using Presentation.Abstractions;
using Presentation.Mapping;
using static Presentation.Features.Events.GetEvents.GetEvents;

namespace Presentation.Features.Events.GetEvents;

public class GetEventsHandler : IRequestHandler<Command, Response>
{
    private readonly IRepository<Event> _repository;

    public GetEventsHandler(IRepository<Event> repository)
    {
        _repository = repository;
    }

    public async Task<Response> Handle(Command request, CancellationToken cancellationToken)
    {
        var allEvents = _repository.GetAll().Select(e => e.AsDto());
        return new Response(allEvents);
    }
}