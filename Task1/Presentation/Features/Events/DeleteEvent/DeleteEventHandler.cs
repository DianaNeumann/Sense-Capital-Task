using MediatR;
using Presentation.Abstractions;
using Presentation.Mapping;
using static Presentation.Features.Events.DeleteEvent.DeleteEvent;

namespace Presentation.Features.Events.DeleteEvent;

public class DeleteEventHandler : IRequestHandler<Command, Response>
{
    private readonly IRepository<Event> _repository;

    public DeleteEventHandler(IRepository<Event> repository)
    {
        _repository = repository;
    }

    public async Task<Response> Handle(Command request, CancellationToken cancellationToken)
    {
        var eventToDelete = _repository.FindById(request.Id)!;
        _repository.Delete(eventToDelete);

        return new Response(eventToDelete.AsDto());
    }
}