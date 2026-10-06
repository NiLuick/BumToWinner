using Application.CommandHandlers;
using Application.Commands;
using Application.CQRSInterfaces;
using Application.DTOs;
using Application.Queries;
using Application.QueryHandlers;
using Microsoft.Extensions.DependencyInjection;

namespace Application;

public static class DependencyInjection
{
    public static IServiceCollection AddApplication(this IServiceCollection services)
    {
        // AdTransient Registration so Registration will only Last for the Task
        services.AddTransient<ICommandHandler<PassMonthCommand>, PassMonthCommandHandler>();
        services.AddTransient<ICommandHandler<CommitSuicideCommand>, CommitSuicideCommandHandler>();
        services.AddTransient<IQueryHandler<GetGameStateQuery, GameStateDTO>, GetGameStateQueryHandler>();
        
        return  services;
    }
}