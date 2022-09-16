using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.ComponentModel;
using System.Threading.Tasks;
using System.Collections.Generic;
using FootballLibrary;

namespace FootballClient
{
    public partial class FrmMain : Form
    {
        IScoreBoard _scoreBoard = new ScoreBoard();

        public FrmMain()
        {
            InitializeComponent();
        }             

        private void GetCurrentGames()
        {
            try
            {
                //Clear Score Board
                rtbScoreBoard.Clear();

                //Get Current Games
                List<Game> scoreBoard = _scoreBoard.GetCurrentGames();
                foreach(Game game in scoreBoard)
                {
                    rtbScoreBoard.Text += game.Id + ". " + game.HomeTeam + " - " + game.AwayTeam + ": " + game.HomeScore.ToString() + " - " + game.AwayScore.ToString() + Environment.NewLine;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Football", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }        

        private void GetSummaryGamesByTotalScore()
        {
            try
            {
                //Clear Score Board
                rtbScoreBoard.Clear();

                //Get Summary Games By Total Score
                List<Game> scoreBoard = _scoreBoard.GetSummaryGamesByTotalScore();
                foreach (Game game in scoreBoard)
                {
                    rtbScoreBoard.Text += game.HomeTeam + " " + game.HomeScore.ToString() + " - " + game.AwayTeam + " " + game.AwayScore.ToString() + Environment.NewLine;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Football", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void StartGame(string homeTeam, string awayTeam)
        {
            string json = string.Empty;
            Result result = new Result();

            try
            {
                //Build json
                json = @"{""HomeTeam"":""{homeTeam}"",""AwayTeam"":""{awayTeam}""}";
                json = json.Replace("{homeTeam}", homeTeam);
                json = json.Replace("{awayTeam}", awayTeam);

                //Call to Start Game
                result = _scoreBoard.StartGame(json);
                if (result.Id > 0)
                {
                    MessageBox.Show("Error: " + result.Description, "Football", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    //Get Current Games
                    GetCurrentGames();                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Football", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UpdateGame(string homeTeam, string awayTeam, string homeScore, string awayScore)
        {
            string json = string.Empty;
            Result result = new Result();

            try
            {
                //Validate
                int number;
                if (!Int32.TryParse(homeScore, out number)) homeScore = "0";
                if (!Int32.TryParse(awayScore, out number)) awayScore = "0";

                //Build json
                json = @"{""HomeTeam"":""{homeTeam}"",""AwayTeam"":""{awayTeam}"",""HomeScore"":""{homeScore}"",""AwayScore"":""{awayScore}""}";
                json = json.Replace("{homeTeam}", homeTeam);
                json = json.Replace("{awayTeam}", awayTeam);
                json = json.Replace("{homeScore}", homeScore);
                json = json.Replace("{awayScore}", awayScore);

                //Call to Update Game
                result = _scoreBoard.UpdateGame(json);
                if (result.Id > 0)
                {
                    MessageBox.Show("Error: " + result.Description, "Football", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    //Get Current Games
                    GetCurrentGames();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Football", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FinishGame(string homeTeam, string awayTeam)
        {
            string json = string.Empty;
            Result result = new Result();

            try
            {
                //Build json
                json = @"{""HomeTeam"":""{homeTeam}"",""AwayTeam"":""{awayTeam}""}";
                json = json.Replace("{homeTeam}", homeTeam);
                json = json.Replace("{awayTeam}", awayTeam);

                //Call to Finish Game
                result = _scoreBoard.FinishGame(json);
                if (result.Id > 0)
                {
                    MessageBox.Show("Error: " + result.Description, "Football", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    //Get Current Games
                    GetCurrentGames();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Football", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmdStartMexicoCanada_Click(object sender, EventArgs e)
        {
            StartGame("Mexico", "Canada");
        }

        private void cmdSpainBrazil_Click(object sender, EventArgs e)
        {
            StartGame("Spain", "Brazil");
        }

        private void cmdGermanyFrance_Click(object sender, EventArgs e)
        {
            StartGame("Germany", "France");
        }

        private void cmdUruguayItaly_Click(object sender, EventArgs e)
        {
            StartGame("Uruguay", "Italy");
        }

        private void cmdArgentinaAustralia_Click(object sender, EventArgs e)
        {
            StartGame("Argentina", "Australia");
        }

        private void cmdUpdateMexicoCanada_Click(object sender, EventArgs e)
        {
            UpdateGame("Mexico", "Canada", "0", "5");            
        }

        private void cmdUpdateSpainBrazil_Click(object sender, EventArgs e)
        {
            UpdateGame("Spain", "Brazil", "10", "2");           
        }

        private void cmdUpdateGermanyFrance_Click(object sender, EventArgs e)
        {
            UpdateGame("Germany", "France", "2", "2");            
        }

        private void cmdUpdateUruguayItaly_Click(object sender, EventArgs e)
        {
            UpdateGame("Uruguay", "Italy", "6", "6");            
        }

        private void cmdUpdateArgentinaAustralia_Click(object sender, EventArgs e)
        {
            UpdateGame("Argentina", "Australia", "3", "1");
        }

        private void cmdFinishMexicoCanada_Click(object sender, EventArgs e)
        {
            FinishGame("Mexico", "Canada");
        }

        private void cmdFinishSpainBrazil_Click(object sender, EventArgs e)
        {
            FinishGame("Spain", "Brazil");
        }

        private void cmdFinishGermanyFrance_Click(object sender, EventArgs e)
        {
            FinishGame("Germany", "France");
        }

        private void cmdFinishUruguayItaly_Click(object sender, EventArgs e)
        {
            FinishGame("Uruguay", "Italy");
        }

        private void cmdFinishArgentinaAustralia_Click(object sender, EventArgs e)
        {
            FinishGame("Argentina", "Australia");
        }

        private void cmdStartGame_Click(object sender, EventArgs e)
        {
            StartGame(txtHomeTeam.Text, txtAwayTeam.Text);            
        }

        private void cmdUpdateScore_Click(object sender, EventArgs e)
        {
            UpdateGame(txtHomeTeam.Text, txtAwayTeam.Text, txtHomeScore.Text, txtAwayScore.Text);
        }

        private void cmdFinishGame_Click(object sender, EventArgs e)
        {
            FinishGame(txtHomeTeam.Text, txtAwayTeam.Text);
        }

        private void cmdGetCurrentGames_Click(object sender, EventArgs e)
        {
            GetCurrentGames();
        }

        private void cmdGetSummaryGamesByTotalScore_Click(object sender, EventArgs e)
        {
            GetSummaryGamesByTotalScore();
        }

        private void txtHomeScore_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtAwayScore_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
