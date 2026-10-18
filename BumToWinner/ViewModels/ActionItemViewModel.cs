using System.Windows.Input;
using Domain;

namespace BumToWinner.ViewModels;

public class ActionItemViewModel
{
    public int Id { get; }
    public string DisplayName { get; }
    public ICommand Command { get; }
 
    public ActionItemViewModel(PlayerAction action, string displayName, ICommand command)
    {
        Id = (int)action;
        DisplayName = displayName;
        Command = command;
    }
}