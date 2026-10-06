namespace Domain;

public class Job
{
    public string Description { get; set; }             // Description of the Job
    public decimal MonthlySalary { get; set; }          // Monthly Salary paid for the Job
    public Job RequiredJob { get; set; }                // Required Job for getting the Job
    public Housing RequiredHousing { get; set; }        // Required Housing for having the Job
    public Vehicle RequiredVehicle { get; set; }        // Required Vehicle for having the Job
    public Food RequiredFood { get; set; }              // Required Food for having the Job
    public Education RequiredEducation { get; set; }    // Required finished Education for the Job
    public Clothing RequiredClothing { get; set; }      // Required Clothing for the Job

    public Job (string description, decimal monthlySalary, Job requiredJob, Housing requiredHousing, Vehicle requiredVehicle,
        Food requiredFood, Education requiredEducation, Clothing requiredClothing)
    {
        Description = description;
        MonthlySalary = monthlySalary;
        RequiredJob = requiredJob;
        RequiredHousing = requiredHousing;
        RequiredVehicle = requiredVehicle;
        RequiredFood = requiredFood;
        RequiredEducation = requiredEducation;
        RequiredClothing = requiredClothing;
    }
}