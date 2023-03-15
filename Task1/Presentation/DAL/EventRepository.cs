using Presentation.Abstractions;
using Presentation.Features;
using Presentation.Features.Events;

namespace Presentation.DAL;

public class EventRepository : IRepository<Event>
{
    private readonly List<Event> _events;
    
    public EventRepository()
    {
        _events = new List<Event>();
    }

    public IReadOnlyCollection<Event> GetAll() => _events;
    
    public void Add(Event entity)
    {
        _events.Add(entity);
        
    }

    public void Delete(Event entity)
    {
        _events.Remove(entity);
    }
}