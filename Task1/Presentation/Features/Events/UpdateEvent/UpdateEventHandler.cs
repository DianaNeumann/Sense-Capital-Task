using MediatR;
using Presentation.Abstractions;
using Presentation.Mapping;
using static Presentation.Features.Events.UpdateEvent.UpdateEvent;

namespace Presentation.Features.Events.UpdateEvent;

public class UpdateEventHandler : IRequestHandler<Command, Response>
{
    private readonly IRepository<Event> _repository;

    public UpdateEventHandler(IRepository<Event> repository)
    {
        _repository = repository;
    }

    public async Task<Response> Handle(Command request, CancellationToken cancellationToken)
    {
        var eventToUpdate = _repository.FindById(request.Id)!;
        
        eventToUpdate.Name = request.Name;
        eventToUpdate.Start = request.Start;
        eventToUpdate.End = request.End;
        eventToUpdate.Description = request.Description;
        eventToUpdate.Picture = request.Picture;
        eventToUpdate.Space = request.Space;

        return new Response(eventToUpdate.AsDto());
    }
}