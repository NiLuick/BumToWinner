using Application.Commands;
using Application.CQRSInterfaces;
using Application.Interfaces;

namespace Application.CommandHandlers;

public class CommitSuicideCommandHandler : ICommandHandler<CommitSuicideCommand>
{
    private readonly IGameRepository _repository;
 
    public CommitSuicideCommandHandler(IGameRepository repository)
    {
        _repository = repository;
    }
 
    public void Handle(CommitSuicideCommand command)
    {
        var game = _repository.Get();
 
        game.EndLife();
 
        _repository.Save(game);
    }
}