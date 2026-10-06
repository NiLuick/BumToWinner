namespace Application.DTOs;

public record GameStateDTO(string PlayerName, decimal Wealth, int Happiness, int Health, int MonthsRemaining, bool IsGameOver);