using Application.Commands;
using Application.CQRSInterfaces;
using Application.DTOs;
using Application.Queries;
using BumToWinner.MVVMHelperClasses;
using Domain;

namespace BumToWinner.ViewModels;

public class GameViewModel : ViewModelBase
{
    private readonly ICommandHandler<PassMonthCommand> _passMonth;
    private readonly ICommandHandler<CommitSuicideCommand> _commitSuicide;
    private readonly IQueryHandler<GetGameStateQuery, GameStateDTO> _getGameState;

    private string _playerName = string.Empty;
    private decimal _wealth;
    private int _happiness;
    private int _health;
    private int _monthsRemaining;
    private bool _isGameOver;
    private string _statusMessage = string.Empty;

    public string PlayerName
    {
        get => _playerName;
        private set => SetProperty(ref _playerName, value);
    }

    public decimal Wealth
    {
        get => _wealth;
        private set => SetProperty(ref _wealth, value);
    }

    public int Happiness
    {
        get => _happiness;
        private set => SetProperty(ref _happiness, value);
    }

    public int Health
    {
        get => _health;
        private set => SetProperty(ref _health, value);
    }

    public int MonthsRemaining
    {
        get => _monthsRemaining;
        private set => SetProperty(ref _monthsRemaining, value);
    }

    public bool IsGameOver
    {
        get => _isGameOver;
        private set => SetProperty(ref _isGameOver, value);
    }

    public string StatusMessage
    {
        get => _statusMessage;
        private set => SetProperty(ref _statusMessage, value);
    }

    public IReadOnlyList<ActionItemViewModel> Actions { get; }

    public GameViewModel(
        ICommandHandler<PassMonthCommand> passMonth,
        ICommandHandler<CommitSuicideCommand> commitSuicide,
        IQueryHandler<GetGameStateQuery, GameStateDTO> getGameState)
    {
        _passMonth = passMonth;
        _commitSuicide = commitSuicide;
        _getGameState = getGameState;

        Actions = Enum.GetValues<PlayerAction>()
            .Select(action => new ActionItemViewModel(
                action,
                GetDisplayName(action),
                new RelayCommand(() => Perform(action), () => !IsGameOver)))
            .ToList();

        Refresh();
    }

    private void Perform(PlayerAction action)
    {
        // Reset first so an identical message twice in a row still raises PropertyChanged.
        StatusMessage = string.Empty;

        switch (action)
        {
            case PlayerAction.None:
                _passMonth.Handle(new PassMonthCommand());
                StatusMessage = "You let the month pass.";
                break;

            case PlayerAction.EndLife:
                _commitSuicide.Handle(new CommitSuicideCommand());
                StatusMessage = "You ended your life.";
                break;

            default:
                StatusMessage = $"'{action}' is not implemented yet.";
                break;
        }

        Refresh();
    }

    private void Refresh()
    {
        var state = _getGameState.Handle(new GetGameStateQuery());

        // IsGameOver first, so observers reacting to MonthsRemaining see the final state.
        IsGameOver = state.IsGameOver;
        PlayerName = state.PlayerName;
        Wealth = state.Wealth;
        Happiness = state.Happiness;
        Health = state.Health;
        MonthsRemaining = state.MonthsRemaining;
    }

    private static string GetDisplayName(PlayerAction action) => action switch
    {
        PlayerAction.None => "None",
        PlayerAction.Happiness => "Do something for your Happiness",
        PlayerAction.Health => "Do something for your Health",
        PlayerAction.Job => "Change your Job",
        PlayerAction.Housing => "Change your Housing",
        PlayerAction.Vehicle => "Change your Vehicle",
        PlayerAction.Food => "Change your Food",
        PlayerAction.Education => "Change your Education",
        PlayerAction.Clothing => "Change your Clothing",
        PlayerAction.EndLife => "Commit Suicide",
        _ => action.ToString()
    };
}