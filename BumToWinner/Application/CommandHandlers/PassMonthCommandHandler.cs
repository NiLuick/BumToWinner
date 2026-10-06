using Application.Commands;
using Application.CQRSInterfaces;
using Application.Interfaces;

namespace Application.CommandHandlers;

public class PassMonthCommandHandler : ICommandHandler<PassMonthCommand>
{
    private readonly IGameRepository _repository;
 
    public PassMonthCommandHandler(IGameRepository repository)
    {
        _repository = repository;
    }
 
    public void Handle(PassMonthCommand command)
    {
        var game = _repository.Get();
 
        game.PassMonth();
 
        _repository.Save(game);
    }
}