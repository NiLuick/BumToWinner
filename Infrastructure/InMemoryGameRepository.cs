using Application.Interfaces;
using Domain;

namespace Infrastructure;

public class InMemoryGameRepository : IGameRepository
{
    private Game _game = Game.CreateNew();
 
    public Game Get() => _game;
 
    public void Save(Game game) => _game = game;
}