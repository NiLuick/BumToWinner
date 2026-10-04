namespace Domain;

public class Clothing
{
    public string Descripiton { get; set; }
    public decimal MonthlyExpenses { get; set; }
    
    public Clothing (string descripiton, decimal monthlyExpenses)
    {
        Descripiton = descripiton;
        MonthlyExpenses = monthlyExpenses;
    }
}