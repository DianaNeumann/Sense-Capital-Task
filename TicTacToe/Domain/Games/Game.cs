using Domain.Boards;
using Domain.Games.GameStates;
using Domain.Players;

namespace Domain.Games;

public class Game
{
    protected Game()
    {
    }

    public Game(Guid id, Player playerOne, Player playerTwo)
    {
        Id = id;
        PlayerOne = playerOne;
        PlayerTwo = playerTwo;
        Board = new Board();
    }

    public Guid Id { get; protected set; }
    
    public virtual Board Board { get; set; }
    public virtual Player PlayerOne { get; private set; }
    public virtual Player PlayerTwo { get; private set; }

    public GameState FillTheBoard(int position, char value)
    {
        var currentStatus = Board.FillTheBoardAndGetStatus(position, value);
        var currentField = Board.Field;
        return new GameState(currentStatus, currentField);
    }
}