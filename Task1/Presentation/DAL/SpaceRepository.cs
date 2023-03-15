using Presentation.Abstractions;
using Presentation.Features.Spaces;

namespace Presentation.DAL;

public class SpaceRepository : IRepository<Space>
{
    private readonly List<Space> _spaces;
    
    public SpaceRepository()
    {
        _spaces = new List<Space>()
        {
            new Space(Guid.Parse("4c02d210-c586-4deb-9df0-185dc4b09803")),
            new Space(Guid.Parse("4b82e55e-bfc1-4312-8858-dc39faad00da")),
            new Space(Guid.Parse("7eb5a8cb-1645-44a5-8d18-e483fe1c17ba")),
        };
    }

    public IReadOnlyCollection<Space> GetAll() => _spaces;
    
    public void Add(Space entity)
    {
        _spaces.Add(entity);
    }
    
    public void Delete(Space entity)
    {
        _spaces.Remove(entity);
    }
}