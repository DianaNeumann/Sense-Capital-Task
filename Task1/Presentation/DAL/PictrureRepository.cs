using Presentation.Abstractions;
using Presentation.Features.Pictures;

namespace Presentation.DAL;

public class PictureRepository : IRepository<Picture>
{
    private readonly List<Picture> _pictures;
    
    public PictureRepository()
    {
        _pictures = new List<Picture>()
        {
            new Picture(Guid.Parse("ca0fd933-d88f-4442-b9e1-c163d7fcdfae"), "/img/1.png"),
            new Picture(Guid.Parse("202188a1-a4da-48a9-a200-3217cf9aa76e"), "/img/2.png"),
            new Picture(Guid.Parse("6b1c8af5-f99e-4a90-84d9-5e73039467b9"), "/img/3.png"),
        };
    }

    public IReadOnlyCollection<Picture> GetAll() => _pictures;
    
    public void Add(Picture entity)
    {
        _pictures.Add(entity);
    }

    public void Delete(Picture entity)
    {
        _pictures.Remove(entity);
    }
}