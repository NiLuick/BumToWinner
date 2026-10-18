using System.ComponentModel;
using BumToWinner.ViewModels;

namespace BumToWinner.ConsoleWindow;

public class GameConsoleWindow
{
    private readonly GameViewModel _viewModel;

    public GameConsoleWindow(GameViewModel viewModel)
    {
        _viewModel = viewModel;
        _viewModel.PropertyChanged += OnViewModelPropertyChanged;
    }

    public void Run()
    {
        ShowTitle();
        ShowGameState();

        while (!_viewModel.IsGameOver)
        {
            var item = ReadAction();

            if (item is null)
            {
                Console.WriteLine("Invalid action.");
                continue;
            }

            if (item.Command.CanExecute(null))
            {
                item.Command.Execute(null);
            }
        }
    }

    private void OnViewModelPropertyChanged(object? sender, PropertyChangedEventArgs e)
    {
        switch (e.PropertyName)
        {
            case nameof(GameViewModel.StatusMessage) when !string.IsNullOrEmpty(_viewModel.StatusMessage):
                Console.WriteLine(_viewModel.StatusMessage);
                Console.WriteLine();
                break;

            case nameof(GameViewModel.MonthsRemaining) when !_viewModel.IsGameOver:
                ShowGameState();
                break;

            case nameof(GameViewModel.IsGameOver) when _viewModel.IsGameOver:
                Console.WriteLine("Game Over!");
                break;
        }
    }

    private static void ShowTitle()
    {
        Console.WriteLine("Bum to Winner");
        Console.WriteLine("^^^^^^^^^^^^^\n");
    }

    private void ShowGameState()
    {
        Console.WriteLine($"Weekly Actions (Player {_viewModel.PlayerName}, Wealth {_viewModel.Wealth})");
        Console.WriteLine($"Health {_viewModel.Health}%, Happiness {_viewModel.Happiness}%");
        Console.WriteLine($"Months remaining: {_viewModel.MonthsRemaining}\n");

        foreach (var action in _viewModel.Actions)
        {
            Console.WriteLine($"({action.Id}) {action.DisplayName}");
        }
    }

    private ActionItemViewModel? ReadAction()
    {
        Console.Write("\nChoose an action: ");

        return int.TryParse(Console.ReadLine(), out int id)
            ? _viewModel.Actions.FirstOrDefault(a => a.Id == id)
            : null;
    }
}