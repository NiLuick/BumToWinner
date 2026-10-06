namespace Domain;

/// <summary>
/// Aggregate root: the state and the rules of one game.    DUMMY
/// </summary>
/// 
public class Game
{
    public const int StartingMonths = 984;

    private bool _lifeEnded;

    public Bum Player { get; }

    public int MonthsRemaining { get; private set; }

    public bool IsGameOver => _lifeEnded || Player.Health <= 0 || MonthsRemaining <= 0;

    public Game(Bum player, int monthsRemaining = StartingMonths)
    {
        Player = player;
        MonthsRemaining = monthsRemaining;
    }

    public static Game CreateNew()
    {
        var street = new Housing("Street", 0.00m);
        var noVehicle = new Vehicle("None", 0.00m, 0.00m);
        var trash = new Food("Trash", 0.00m, -3, -3);
        var noEducation = new Education("None", "None", 0.00m, 0);
        var naked = new Clothing("Naked", 0.00m);

        var noJob = new Job("None", 0.00m, null, street, noVehicle, trash, noEducation, naked);
        var player = new Bum("Player Bum", 18, 0.00m, 100, 100, noJob, street, noVehicle, trash, noEducation, naked);

        return new Game(player);
    }

    public void PassMonth()
    {
        EnsureRunning();

        var income = Player.Job.MonthlySalary;
        var expenses = Player.Housing.MonthlyRent
                       + Player.Vehicle.MonthlyExpenses
                       + Player.Food.MonthlyExpenses
                       + Player.Education.MonthlyExpenses
                       + Player.Clothing.MonthlyExpenses;

        Player.Wealth += income - expenses;
        Player.Health = ClampPercent(Player.Health + Player.Food.MonthlyHealthInfluence);
        Player.Happiness = ClampPercent(Player.Happiness + Player.Food.MonthlyHappinessInfluence);

        MonthsRemaining--;
    }

    public void EndLife()
    {
        EnsureRunning();
        _lifeEnded = true;
    }

    private void EnsureRunning()
    {
        if (IsGameOver)
        {
            throw new InvalidOperationException("The game is already over.");
        }
    }

    private static int ClampPercent(int value) => Math.Clamp(value, 0, 100);
}