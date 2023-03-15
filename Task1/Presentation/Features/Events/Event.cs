namespace Presentation.Features.Events;

public class Event
{
    public Event(Guid id, string name, DateTime start, DateTime end, string description, Guid picture, Guid space)
    {
        Id = id;
        Name = name;
        Start = start;
        End = end;
        Description = description;
        Picture = picture;
        Space = space;
    }

    public Guid Id { get; protected set; }
    public string Name { get; set; }
    public DateTime Start { get; set; }
    public DateTime End { get; set; }
    public string Description { get; set; }
    public Guid Picture { get; set; }
    public Guid Space { get; set; }
}