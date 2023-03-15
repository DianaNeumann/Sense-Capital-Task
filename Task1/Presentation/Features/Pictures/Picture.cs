namespace Presentation.Features.Pictures;

public class Picture
{
    public Picture(Guid id, string path)
    {
        Id = id;
        Path = path;
    }

    public Guid Id { get; init; }
    public string Path { get; set; }
}