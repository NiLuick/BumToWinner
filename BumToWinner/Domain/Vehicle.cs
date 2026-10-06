namespace Domain;

public class Vehicle
{
    public string Description { get; set; }         // Description of the Vehicle
    public decimal InitialCost { get; set; }        // Initial Costs of the Vehicle
    public decimal MonthlyExpenses { get; set; }    // Monthly Expenses of the Vehicle
    
    public Vehicle (string description, decimal initialCost, decimal monthlyExpenses)
    {
        Description = description;
        InitialCost = initialCost;
        MonthlyExpenses = monthlyExpenses;
    }
}