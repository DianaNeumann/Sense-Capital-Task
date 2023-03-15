using Presentation.Abstractions;
using Presentation.Features.Events;

namespace Presentation.Repositories;

public class EventRepository : IRepository<Event>
{
    private readonly List<Event> _events;
    
    public EventRepository()
    {
        _events = new List<Event>();
    }

    public void Add(Event entity)
    {
        _events.Add(entity);
        
    }

    public void Delete(Event entity)
    {
        _events.Remove(entity);
    }
    
    public IReadOnlyCollection<Event> GetAll() => _events;
    public Event? FindById(Guid id) => _events.First(e => e.Id.Equals(id));
    
}