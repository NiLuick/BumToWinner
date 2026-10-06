namespace Domain;

public class Education
{
    public string Description { get; set; }         // Description of the Education
    public string Degree { get; set; }              // Degree at the End of the Course
    public decimal MonthlyExpenses { get; set; }    // Monthly Costs of the Education
    public int Duration { get; set; }               // Duration of the Education in Months

    public Education (string descripiton, string degree, decimal monthlyExpenses, int duration)
    {
        Description = descripiton;
        Degree = degree;
        MonthlyExpenses = monthlyExpenses;
        Duration = duration;
    }
}