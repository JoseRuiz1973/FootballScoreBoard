using System.Collections.Generic;

namespace FootballLibrary
{
    public interface IScoreBoard
    {
        Result StartGame(string json);

        Result UpdateGame(string json);

        Result FinishGame(string json);

        List<Game> GetCurrentGames();

        List<Game> GetSummaryGamesByTotalScore();
    }
}
