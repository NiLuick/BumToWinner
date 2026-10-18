using Application;
using BumToWinner.ConsoleWindow;
using BumToWinner.ViewModels;
using Infrastructure;
using Microsoft.Extensions.DependencyInjection;

// Composition root: the only place that knows every layer.
var services = new ServiceCollection().AddApplication().AddInfrastructure().AddSingleton<GameViewModel>()
                                                    .AddSingleton<GameConsoleWindow>().BuildServiceProvider();

services.GetRequiredService<GameConsoleWindow>().Run();