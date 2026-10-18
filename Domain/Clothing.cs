namespace Domain;

public class Clothing
{
    public string Description { get; set; }         // Description of the Clothing
    public decimal MonthlyExpenses { get; set; }    // Monthly Costs of the Clothing
    
    public Clothing (string description, decimal monthlyExpenses)
    {
        Description = description;
        MonthlyExpenses = monthlyExpenses;
    }
}