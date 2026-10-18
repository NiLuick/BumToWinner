using Application.CQRSInterfaces;
using Application.DTOs;

namespace Application.Queries;

public record GetGameStateQuery() : IQuery<GameStateDTO>;