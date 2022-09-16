﻿using System;
using System.Linq;
using System.Text;
using Newtonsoft.Json;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace FootballLibrary
{
    public class ScoreBoard : IScoreBoard
    {
        List<Game> _games = new List<Game>();                

        public Result StartGame(string jsonMatch)
        {
            Result result = new Result();

            try
            {
                //Deserialize json match
                Match match = JsonConvert.DeserializeObject<Match>(jsonMatch);

                //Check input values
                if (string.IsNullOrEmpty(match.HomeTeam))
                {                    
                    result.Description = "Home Team is empty";
                    result.Id = 100;
                    return result;
                }
                else if (string.IsNullOrEmpty(match.AwayTeam))
                {
                    result.Description = "Away Team is empty";
                    result.Id = 101;
                    return result;
                }

                //Check game not exists
                Game game = (from g in _games
                             where g.HomeTeam == match.HomeTeam
                             && g.AwayTeam == match.AwayTeam
                             select g).FirstOrDefault();

                if (game != null)
                {
                    result.Description = "Game already exists";
                    result.Id = 200;
                    return result;
                }
                else
                {
                    //Create the game
                    Game newGame = new Game();
                    newGame.Id = _games.Count + 1;
                    newGame.HomeTeam = match.HomeTeam;
                    newGame.AwayTeam = match.AwayTeam;
                    newGame.HomeScore = 0;
                    newGame.AwayScore = 0;

                    //Add game to collection                    
                    _games.Add(newGame);
                }                     
            }
            catch (Exception ex)
            {
                result.Description = ex.Message;
                result.Id = 500;
            }

            //Return result
            return result;
        }

        public Result UpdateGame(string jsonGame)
        {
            Result result = new Result();

            try
            {
                //Deserialize json match
                Game score = JsonConvert.DeserializeObject<Game>(jsonGame);

                //Check input values
                if (string.IsNullOrEmpty(score.HomeTeam))
                {
                    result.Description = "Home Team is empty";
                    result.Id = 100;
                    return result;
                }
                else if (string.IsNullOrEmpty(score.AwayTeam))
                {
                    result.Description = "Away Team is empty";
                    result.Id = 101;
                    return result;
                }

                //Find and modify the game
                Game game = (from g in _games
                             where g.HomeTeam == score.HomeTeam
                             && g.AwayTeam == score.AwayTeam
                             select g).FirstOrDefault();

                if (game == null)
                {
                    result.Description = "Game not found";
                    result.Id = 200;
                    return result;
                }
                else
                {
                    game.HomeScore = score.HomeScore;
                    game.AwayScore = score.AwayScore;
                }                
            }
            catch (Exception ex)
            {
                result.Description = ex.Message;
                result.Id = 500;
            }

            //Return result
            return result;
        }

        public Result FinishGame(string jsonMatch)
        {
            Result result = new Result();

            try
            {
                //Deserialize json match
                Match match = JsonConvert.DeserializeObject<Match>(jsonMatch);

                //Check input values
                if (string.IsNullOrEmpty(match.HomeTeam))
                {
                    result.Description = "Home Team is empty";
                    result.Id = 100;
                    return result;
                }
                else if (string.IsNullOrEmpty(match.AwayTeam))
                {
                    result.Description = "Away Team is empty";
                    result.Id = 101;
                    return result;
                }

                //Find and remove the game
                Game game = (from g in _games
                             where g.HomeTeam == match.HomeTeam
                             && g.AwayTeam == match.AwayTeam
                             select g).FirstOrDefault();

                if (game == null)
                {
                    result.Description = "Game not found";
                    result.Id = 200;
                    return result;
                }
                else
                {
                    _games.RemoveAll((g) => g.HomeTeam == match.HomeTeam && g.AwayTeam == match.AwayTeam);
                }
            }
            catch (Exception ex)
            {
                result.Description = ex.Message;
                result.Id = 500;
            }

            //Return result
            return result;
        }

        public List<Game> GetSummaryGamesByOrder()
        {
            List<Game> list = new List<Game>();

            try
            {
                //Get Summary Games
                list = (from g in _games orderby g.Id ascending select g).ToList();
            }
            catch {
            }

            //Return list
            return list;
        }

        public List<Game> GetSummaryGamesByTotalScore()
        {
            List<Game> list = new List<Game>();

            try
            {
                //Get Summary Games By Total Score
                list = (from g in _games orderby g.HomeScore + g.AwayScore descending, g.Id descending select g).ToList();
            }
            catch {
            }

            //Return list
            return list;
        }
    }
}
