namespace Domain;

public class Job
{
    public string Description { get; set; }
    public decimal MonthlySalary { get; set; }
    public Job RequiredJob { get; set; }
    public Housing RequiredHousing { get; set; }
    public Vehicle RequiredVehicle { get; set; }
    public Food RequiredFood { get; set; }
    public Education RequiredEducation { get; set; }
    public Clothing RequiredClothing { get; set; }
}