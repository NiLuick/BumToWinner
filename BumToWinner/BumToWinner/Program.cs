using Domain;

Console.WriteLine("Bum to Winner");
Console.WriteLine("^^^^^^^^^^^^^\n");

// Constants
int monthsToLive = 984; // Starting age 18 => Live untill 100

// Initial Settings
var street = new Housing("Street", 0.00m);
var noVehicle = new Vehicle("None", 0.00m, 0.00m);
var trash = new Food("Trash", 0.00m, -3, -3);
var noEducation = new Education("None", "None", 0.00m, 0);
var naked = new Clothing("Naked", 0.00m);

var noJob = new Job("None", 0.00m, null, street, noVehicle, trash, noEducation, naked);

Bum player = new Bum("Player Bum", 18, 0.00m, 100, 100, noJob, street, noVehicle, trash, 
                     noEducation, naked);

while (true)
{
    // Selection Tool for Actions
    Console.WriteLine($"Weekly Actions (Player {player.Name}, Wealth {player.Wealth})");
    Console.WriteLine($"Months remaining: {monthsToLive}\n");
    Console.WriteLine("(0)  None");
    Console.WriteLine("(1)  Do something for your Happiness");
    Console.WriteLine("(2)  Do something for your Health");
    Console.WriteLine("(3)  Change your Job");
    Console.WriteLine("(4)  Change your Housing");
    Console.WriteLine("(5)  Change your Vehicle");
    Console.WriteLine("(6)  Change your Food");
    Console.WriteLine("(7)  Change your Education");
    Console.WriteLine("(8)  Change your Clothing");
    Console.WriteLine("(9)  Commit Suicide");
    
    int input = Int32.Parse(Console.ReadLine());

    if (input >= 0 && input <= 9)
    {
        Console.WriteLine("Correct");
    }
    else
    {
        Console.WriteLine("Error");
    }
}