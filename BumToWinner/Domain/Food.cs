namespace Domain;

public class Food
{
    public string Descripiton { get; set; }             // Description of the Food
    public decimal MonthlyExpenses { get; set; }        // Monthly Costs of the Food
    public int MonthlyHappinessInfluence { get; set; }  // Monthly Influence of the Happiness
    public int MonthlyHealthInfluence { get; set; }     // Monthly Influence of the Health

    public Food (string descripiton, decimal monthlyExpenses, int monthlyHealthInfluence, int monthlyHappinessInfluence)
    {
        Descripiton = descripiton;
        MonthlyExpenses = monthlyExpenses;
        MonthlyHappinessInfluence = monthlyHappinessInfluence;
        MonthlyHealthInfluence = monthlyHealthInfluence;
    }
}