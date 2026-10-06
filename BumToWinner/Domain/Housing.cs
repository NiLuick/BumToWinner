namespace Domain;

public class Housing
{
    public string Description { get; set; }     // Description of the Housing
    public decimal MonthlyRent { get; set; }    // Monthly Rent of the Housing

    public Housing (string descripiton, decimal monthlyRent)
    {
        Description = descripiton;
        MonthlyRent = monthlyRent;
    }
}