using Domain;

namespace Application.Interfaces;

public interface IGameRepository
{
    Game Get();
 
    void Save(Game game);
}