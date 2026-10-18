namespace Domain;

/// <summary>
/// Domain Object for a Bum
/// </summary>

public class Bum
{
    public string Name { get; set; }            // Name of the Bum
    public int Age { get; set; }                // Age of the Bum
    public decimal Wealth { get; set; }         // Wealth of the Bum
    public int Happiness { get; set; }          // Happiness of the Bum in Percent
    public int Health { get; set; }             // Health of the Bum in Percent
    public Job Job { get; set; }                // Job of the Bum
    public Housing Housing { get; set; }        // Housing of the Bum
    public Vehicle Vehicle { get; set; }        // Vehicle of the Bum
    public Food Food { get; set; }              // Food that the Bum consumes
    public Education Education { get; set; }    // Education the Bum received
    public Clothing Clothing { get; set; }      // Clothing the Bum is wearing
    
    public Bum (string name, int age, decimal wealth, int happiness, int health, Job job, Housing housing, 
                Vehicle vehicle, Food food, Education education, Clothing clothing)
    {
        Name = name;
        Age = age;
        Wealth = wealth;
        Health = health;
        Happiness = happiness;
        Job = job;
        Housing = housing;
        Vehicle = vehicle;
        Food = food;
        Education = education;
        Clothing = clothing;
    }
}