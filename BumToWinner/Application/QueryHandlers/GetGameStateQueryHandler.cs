using Application.CQRSInterfaces;
using Application.DTOs;
using Application.Interfaces;
using Application.Queries;

namespace Application.QueryHandlers;

public class GetGameStateQueryHandler : IQueryHandler<GetGameStateQuery, GameStateDTO>
{
    private readonly IGameRepository _repository;
 
    public GetGameStateQueryHandler(IGameRepository repository)
    {
        _repository = repository;
    }
 
    public GameStateDTO Handle(GetGameStateQuery query)
    {
        var game = _repository.Get();
 
        return new GameStateDTO(game.Player.Name, game.Player.Wealth, game.Player.Happiness, game.Player.Health,
                                game.MonthsRemaining, game.IsGameOver);
    }
}