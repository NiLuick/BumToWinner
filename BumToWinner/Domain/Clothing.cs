namespace Domain;

public class Clothing
{
    public string Descripiton { get; set; }         // Description of the Clothing
    public decimal MonthlyExpenses { get; set; }    // Monthly Costs of the Clothing
    
    public Clothing (string descripiton, decimal monthlyExpenses)
    {
        Descripiton = descripiton;
        MonthlyExpenses = monthlyExpenses;
    }
}