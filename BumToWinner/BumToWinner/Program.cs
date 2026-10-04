using Domain;

Console.WriteLine("Bum to Winner");
Console.WriteLine("^^^^^^^^^^^^^\n");

// Initial Settings
Bum player = new Bum("Player Bum", 18, 0.00m, 100, 100, new Job(), new Housing(), 
                     new Vehicle(), new Food(), new Education(), new Clothing("Naked", 0.00m)); 

// Selection Tool for Actions
Console.WriteLine($"Weekly Actions (Player {player.Name}, Wealth {player.Wealth})\n");
Console.WriteLine("(0)  None");
Console.WriteLine("(1)  Do something for your Happiness");
Console.WriteLine("(2)  Do something for your Health");
Console.WriteLine("(3)  Change your Job");
Console.WriteLine("(4)  Change your Housing");
Console.WriteLine("(5)  Change your Vehicle");
Console.WriteLine("(6)  Change your Food");
Console.WriteLine("(7)  Change your Education");
Console.WriteLine("(8)  Change your Clothing");