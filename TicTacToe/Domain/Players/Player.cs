namespace Domain.Players;

public class Player
{
    protected Player()
    {
    }
    
    public Player(Guid id, string name)
    {
        Id = id;
        Name = name;
    }

    public  Guid Id { get; protected set; }
    public string Name { get; set; }
    public char MovementValue { get; set; }
}