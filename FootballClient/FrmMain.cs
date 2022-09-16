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

        private void cmdGetSummaryGamesByOrder_Click(object sender, EventArgs e)
        {
            GetSummaryGamesByOrder();
        }

        private void GetSummaryGamesByOrder()
        {
            try
            {
                //Clear Score Board
                rtbScoreBoard.Clear();

                //Get Summary Games
                List<Game> scoreBoard = _scoreBoard.GetSummaryGamesByOrder();
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

        private void cmdGetSummaryGamesByTotalScore_Click(object sender, EventArgs e)
        {
            GetSummaryGamesByTotalScore();
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
                    rtbScoreBoard.Text += game.Id + ". " + game.HomeTeam + " - " + game.AwayTeam + ": " + game.HomeScore.ToString() + " - " + game.AwayScore.ToString() + Environment.NewLine;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Football", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmdStartMexicoCanada_Click(object sender, EventArgs e)
        {
            string json = string.Empty;
            Result result = new Result();

            try
            {
                json = @"{""HomeTeam"":""Mexico"",""AwayTeam"":""Canada""}";
                result = _scoreBoard.StartGame(json);
                if (result.Id > 0)
                {
                    MessageBox.Show("Error: " + result.Description, "Football", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    GetSummaryGamesByOrder();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message,"Football",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }            
        }

        private void cmdSpainBrazil_Click(object sender, EventArgs e)
        {
            string json = string.Empty;
            Result result = new Result();

            try
            {
                json = @"{""HomeTeam"":""Spain"",""AwayTeam"":""Brazil""}";
                result = _scoreBoard.StartGame(json);
                if (result.Id > 0)
                {
                    MessageBox.Show("Error: " + result.Description, "Football", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    GetSummaryGamesByOrder();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Football", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmdGermanyFrance_Click(object sender, EventArgs e)
        {
            string json = string.Empty;
            Result result = new Result();

            try
            {
                json = @"{""HomeTeam"":""Germany"",""AwayTeam"":""France""}";
                result = _scoreBoard.StartGame(json);
                if (result.Id > 0)
                {
                    MessageBox.Show("Error: " + result.Description, "Football", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    GetSummaryGamesByOrder();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Football", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmdUruguayItaly_Click(object sender, EventArgs e)
        {
            string json = string.Empty;
            Result result = new Result();

            try
            {
                json = @"{""HomeTeam"":""Uruguay"",""AwayTeam"":""Italy""}";
                result = _scoreBoard.StartGame(json);
                if (result.Id > 0)
                {
                    MessageBox.Show("Error: " + result.Description, "Football", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    GetSummaryGamesByOrder();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Football", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmdArgentinaAustralia_Click(object sender, EventArgs e)
        {
            string json = string.Empty;
            Result result = new Result();

            try
            {
                json = @"{""HomeTeam"":""Argentina"",""AwayTeam"":""Australia""}";
                result = _scoreBoard.StartGame(json);
                if (result.Id > 0)
                {
                    MessageBox.Show("Error: " + result.Description, "Football", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    GetSummaryGamesByOrder();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Football", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmdUpdateMexicoCanada_Click(object sender, EventArgs e)
        {
            string json = string.Empty;
            Result result = new Result();

            try
            {
                json = @"{""HomeTeam"":""Mexico"",""AwayTeam"":""Canada"",""HomeScore"":""0"",""AwayScore"":""5""}";
                result = _scoreBoard.UpdateGame(json);
                if (result.Id > 0)
                {
                    MessageBox.Show("Error: " + result.Description, "Football", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    GetSummaryGamesByOrder();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Football", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmdUpdateSpainBrazil_Click(object sender, EventArgs e)
        {
            string json = string.Empty;
            Result result = new Result();

            try
            {
                json = @"{""HomeTeam"":""Spain"",""AwayTeam"":""Brazil"",""HomeScore"":""10"",""AwayScore"":""2""}";
                result = _scoreBoard.UpdateGame(json);
                if (result.Id > 0)
                {
                    MessageBox.Show("Error: " + result.Description, "Football", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    GetSummaryGamesByOrder();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Football", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmdUpdateGermanyFrance_Click(object sender, EventArgs e)
        {
            string json = string.Empty;
            Result result = new Result();

            try
            {
                json = @"{""HomeTeam"":""Germany"",""AwayTeam"":""France"",""HomeScore"":""2"",""AwayScore"":""2""}";
                result = _scoreBoard.UpdateGame(json);
                if (result.Id > 0)
                {
                    MessageBox.Show("Error: " + result.Description, "Football", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    GetSummaryGamesByOrder();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Football", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmdUpdateUruguayItaly_Click(object sender, EventArgs e)
        {
            string json = string.Empty;
            Result result = new Result();

            try
            {
                json = @"{""HomeTeam"":""Uruguay"",""AwayTeam"":""Italy"",""HomeScore"":""6"",""AwayScore"":""6""}";
                result = _scoreBoard.UpdateGame(json);
                if (result.Id > 0)
                {
                    MessageBox.Show("Error: " + result.Description, "Football", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    GetSummaryGamesByOrder();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Football", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmdUpdateArgentinaAustralia_Click(object sender, EventArgs e)
        {
            string json = string.Empty;
            Result result = new Result();

            try
            {
                json = @"{""HomeTeam"":""Argentina"",""AwayTeam"":""Australia"",""HomeScore"":""3"",""AwayScore"":""1""}";
                result = _scoreBoard.UpdateGame(json);
                if (result.Id > 0)
                {
                    MessageBox.Show("Error: " + result.Description, "Football", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    GetSummaryGamesByOrder();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Football", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmdFinishMexicoCanada_Click(object sender, EventArgs e)
        {
            string json = string.Empty;
            Result result = new Result();

            try
            {
                json = @"{""HomeTeam"":""Mexico"",""AwayTeam"":""Canada""}";
                result = _scoreBoard.FinishGame(json);
                if (result.Id > 0)
                {
                    MessageBox.Show("Error: " + result.Description, "Football", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    GetSummaryGamesByOrder();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Football", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmdFinishSpainBrazil_Click(object sender, EventArgs e)
        {
            string json = string.Empty;
            Result result = new Result();

            try
            {
                json = @"{""HomeTeam"":""Spain"",""AwayTeam"":""Brazil""}";
                result = _scoreBoard.FinishGame(json);
                if (result.Id > 0)
                {
                    MessageBox.Show("Error: " + result.Description, "Football", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    GetSummaryGamesByOrder();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Football", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmdFinishGermanyFrance_Click(object sender, EventArgs e)
        {
            string json = string.Empty;
            Result result = new Result();

            try
            {
                json = @"{""HomeTeam"":""Germany"",""AwayTeam"":""France""}";
                result = _scoreBoard.FinishGame(json);
                if (result.Id > 0)
                {
                    MessageBox.Show("Error: " + result.Description, "Football", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    GetSummaryGamesByOrder();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Football", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmdFinishUruguayItaly_Click(object sender, EventArgs e)
        {
            string json = string.Empty;
            Result result = new Result();

            try
            {
                json = @"{""HomeTeam"":""Uruguay"",""AwayTeam"":""Italy""}";
                result = _scoreBoard.FinishGame(json);
                if (result.Id > 0)
                {
                    MessageBox.Show("Error: " + result.Description, "Football", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    GetSummaryGamesByOrder();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Football", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmdFinishArgentinaAustralia_Click(object sender, EventArgs e)
        {
            string json = string.Empty;
            Result result = new Result();

            try
            {
                json = @"{""HomeTeam"":""Argentina"",""AwayTeam"":""Australia""}";
                result = _scoreBoard.FinishGame(json);
                if (result.Id > 0)
                {
                    MessageBox.Show("Error: " + result.Description, "Football", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    GetSummaryGamesByOrder();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Football", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }        
    }
}
