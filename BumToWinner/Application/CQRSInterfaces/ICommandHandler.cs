namespace Application.CQRSInterfaces;

public interface ICommandHandler<in TCommand>
{
    void Handle(TCommand command);
}