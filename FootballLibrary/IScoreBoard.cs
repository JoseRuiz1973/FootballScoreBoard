using System.Collections.Generic;

namespace FootballLibrary
{
    public interface IScoreBoard
    {
        Result StartGame(string jsonMatch);

        Result UpdateGame(string jsonGame);

        Result FinishGame(string jsonMatch);

        List<Game> GetSummaryGamesByOrder();

        List<Game> GetSummaryGamesByTotalScore();
    }
}
