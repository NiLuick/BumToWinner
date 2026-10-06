namespace Domain;

public class Food
{
    public string Description { get; set; }             // Description of the Food
    public decimal MonthlyExpenses { get; set; }        // Monthly Costs of the Food
    public int MonthlyHappinessInfluence { get; set; }  // Monthly Influence of the Happiness
    public int MonthlyHealthInfluence { get; set; }     // Monthly Influence of the Health

    public Food (string description, decimal monthlyExpenses, int monthlyHealthInfluence, int monthlyHappinessInfluence)
    {
        Description = description;
        MonthlyExpenses = monthlyExpenses;
        MonthlyHappinessInfluence = monthlyHappinessInfluence;
        MonthlyHealthInfluence = monthlyHealthInfluence;
    }
}