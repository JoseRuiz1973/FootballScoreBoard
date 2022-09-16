namespace FootballClient
{
    partial class FrmMain
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblScoreBoard = new System.Windows.Forms.Label();
            this.cmdStartMexicoCanada = new System.Windows.Forms.Button();
            this.cmdStartSpainBrazil = new System.Windows.Forms.Button();
            this.cmdStartGermanyFrance = new System.Windows.Forms.Button();
            this.cmdStartUruguayItaly = new System.Windows.Forms.Button();
            this.cmdStartArgentinaAustralia = new System.Windows.Forms.Button();
            this.rtbScoreBoard = new System.Windows.Forms.RichTextBox();
            this.cmdUpdateArgentinaAustralia = new System.Windows.Forms.Button();
            this.cmdUpdateUruguayItaly = new System.Windows.Forms.Button();
            this.cmdUpdateGermanyFrance = new System.Windows.Forms.Button();
            this.cmdUpdateSpainBrazil = new System.Windows.Forms.Button();
            this.cmdUpdateMexicoCanada = new System.Windows.Forms.Button();
            this.cmdFinishArgentinaAustralia = new System.Windows.Forms.Button();
            this.cmdFinishUruguayItaly = new System.Windows.Forms.Button();
            this.cmdFinishGermanyFrance = new System.Windows.Forms.Button();
            this.cmdFinishSpainBrazil = new System.Windows.Forms.Button();
            this.cmdFinishMexicoCanada = new System.Windows.Forms.Button();
            this.cmdGetSummaryGamesByTotalScore = new System.Windows.Forms.Button();
            this.cmdGetCurrentGames = new System.Windows.Forms.Button();
            this.txtHomeTeam = new System.Windows.Forms.TextBox();
            this.txtHomeScore = new System.Windows.Forms.TextBox();
            this.txtAwayTeam = new System.Windows.Forms.TextBox();
            this.txtAwayScore = new System.Windows.Forms.TextBox();
            this.cmdStartGame = new System.Windows.Forms.Button();
            this.cmdUpdateScore = new System.Windows.Forms.Button();
            this.cmdFinishGame = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblScoreBoard
            // 
            this.lblScoreBoard.AutoSize = true;
            this.lblScoreBoard.Location = new System.Drawing.Point(13, 13);
            this.lblScoreBoard.Name = "lblScoreBoard";
            this.lblScoreBoard.Size = new System.Drawing.Size(66, 13);
            this.lblScoreBoard.TabIndex = 0;
            this.lblScoreBoard.Text = "Score Board";
            // 
            // cmdStartMexicoCanada
            // 
            this.cmdStartMexicoCanada.Location = new System.Drawing.Point(16, 205);
            this.cmdStartMexicoCanada.Name = "cmdStartMexicoCanada";
            this.cmdStartMexicoCanada.Size = new System.Drawing.Size(163, 23);
            this.cmdStartMexicoCanada.TabIndex = 2;
            this.cmdStartMexicoCanada.Text = "Start Mexico - Canada";
            this.cmdStartMexicoCanada.UseVisualStyleBackColor = true;
            this.cmdStartMexicoCanada.Click += new System.EventHandler(this.cmdStartMexicoCanada_Click);
            // 
            // cmdStartSpainBrazil
            // 
            this.cmdStartSpainBrazil.Location = new System.Drawing.Point(16, 234);
            this.cmdStartSpainBrazil.Name = "cmdStartSpainBrazil";
            this.cmdStartSpainBrazil.Size = new System.Drawing.Size(163, 23);
            this.cmdStartSpainBrazil.TabIndex = 3;
            this.cmdStartSpainBrazil.Text = "Start Spain - Brazil";
            this.cmdStartSpainBrazil.UseVisualStyleBackColor = true;
            this.cmdStartSpainBrazil.Click += new System.EventHandler(this.cmdSpainBrazil_Click);
            // 
            // cmdStartGermanyFrance
            // 
            this.cmdStartGermanyFrance.Location = new System.Drawing.Point(16, 263);
            this.cmdStartGermanyFrance.Name = "cmdStartGermanyFrance";
            this.cmdStartGermanyFrance.Size = new System.Drawing.Size(163, 23);
            this.cmdStartGermanyFrance.TabIndex = 4;
            this.cmdStartGermanyFrance.Text = "Start Germany - France";
            this.cmdStartGermanyFrance.UseVisualStyleBackColor = true;
            this.cmdStartGermanyFrance.Click += new System.EventHandler(this.cmdGermanyFrance_Click);
            // 
            // cmdStartUruguayItaly
            // 
            this.cmdStartUruguayItaly.Location = new System.Drawing.Point(16, 292);
            this.cmdStartUruguayItaly.Name = "cmdStartUruguayItaly";
            this.cmdStartUruguayItaly.Size = new System.Drawing.Size(163, 23);
            this.cmdStartUruguayItaly.TabIndex = 5;
            this.cmdStartUruguayItaly.Text = "Start Uruguay - Italy";
            this.cmdStartUruguayItaly.UseVisualStyleBackColor = true;
            this.cmdStartUruguayItaly.Click += new System.EventHandler(this.cmdUruguayItaly_Click);
            // 
            // cmdStartArgentinaAustralia
            // 
            this.cmdStartArgentinaAustralia.Location = new System.Drawing.Point(16, 321);
            this.cmdStartArgentinaAustralia.Name = "cmdStartArgentinaAustralia";
            this.cmdStartArgentinaAustralia.Size = new System.Drawing.Size(163, 23);
            this.cmdStartArgentinaAustralia.TabIndex = 6;
            this.cmdStartArgentinaAustralia.Text = "Start Argentina - Australia";
            this.cmdStartArgentinaAustralia.UseVisualStyleBackColor = true;
            this.cmdStartArgentinaAustralia.Click += new System.EventHandler(this.cmdArgentinaAustralia_Click);
            // 
            // rtbScoreBoard
            // 
            this.rtbScoreBoard.Location = new System.Drawing.Point(16, 29);
            this.rtbScoreBoard.Name = "rtbScoreBoard";
            this.rtbScoreBoard.Size = new System.Drawing.Size(746, 170);
            this.rtbScoreBoard.TabIndex = 7;
            this.rtbScoreBoard.Text = "";
            // 
            // cmdUpdateArgentinaAustralia
            // 
            this.cmdUpdateArgentinaAustralia.Location = new System.Drawing.Point(204, 321);
            this.cmdUpdateArgentinaAustralia.Name = "cmdUpdateArgentinaAustralia";
            this.cmdUpdateArgentinaAustralia.Size = new System.Drawing.Size(163, 23);
            this.cmdUpdateArgentinaAustralia.TabIndex = 12;
            this.cmdUpdateArgentinaAustralia.Text = "Update Argentina - Australia";
            this.cmdUpdateArgentinaAustralia.UseVisualStyleBackColor = true;
            this.cmdUpdateArgentinaAustralia.Click += new System.EventHandler(this.cmdUpdateArgentinaAustralia_Click);
            // 
            // cmdUpdateUruguayItaly
            // 
            this.cmdUpdateUruguayItaly.Location = new System.Drawing.Point(204, 292);
            this.cmdUpdateUruguayItaly.Name = "cmdUpdateUruguayItaly";
            this.cmdUpdateUruguayItaly.Size = new System.Drawing.Size(163, 23);
            this.cmdUpdateUruguayItaly.TabIndex = 11;
            this.cmdUpdateUruguayItaly.Text = "Update Uruguay - Italy";
            this.cmdUpdateUruguayItaly.UseVisualStyleBackColor = true;
            this.cmdUpdateUruguayItaly.Click += new System.EventHandler(this.cmdUpdateUruguayItaly_Click);
            // 
            // cmdUpdateGermanyFrance
            // 
            this.cmdUpdateGermanyFrance.Location = new System.Drawing.Point(204, 263);
            this.cmdUpdateGermanyFrance.Name = "cmdUpdateGermanyFrance";
            this.cmdUpdateGermanyFrance.Size = new System.Drawing.Size(163, 23);
            this.cmdUpdateGermanyFrance.TabIndex = 10;
            this.cmdUpdateGermanyFrance.Text = "Update Germany - France";
            this.cmdUpdateGermanyFrance.UseVisualStyleBackColor = true;
            this.cmdUpdateGermanyFrance.Click += new System.EventHandler(this.cmdUpdateGermanyFrance_Click);
            // 
            // cmdUpdateSpainBrazil
            // 
            this.cmdUpdateSpainBrazil.Location = new System.Drawing.Point(204, 234);
            this.cmdUpdateSpainBrazil.Name = "cmdUpdateSpainBrazil";
            this.cmdUpdateSpainBrazil.Size = new System.Drawing.Size(163, 23);
            this.cmdUpdateSpainBrazil.TabIndex = 9;
            this.cmdUpdateSpainBrazil.Text = "Update Spain - Brazil";
            this.cmdUpdateSpainBrazil.UseVisualStyleBackColor = true;
            this.cmdUpdateSpainBrazil.Click += new System.EventHandler(this.cmdUpdateSpainBrazil_Click);
            // 
            // cmdUpdateMexicoCanada
            // 
            this.cmdUpdateMexicoCanada.Location = new System.Drawing.Point(204, 205);
            this.cmdUpdateMexicoCanada.Name = "cmdUpdateMexicoCanada";
            this.cmdUpdateMexicoCanada.Size = new System.Drawing.Size(163, 23);
            this.cmdUpdateMexicoCanada.TabIndex = 8;
            this.cmdUpdateMexicoCanada.Text = "Update Mexico - Canada";
            this.cmdUpdateMexicoCanada.UseVisualStyleBackColor = true;
            this.cmdUpdateMexicoCanada.Click += new System.EventHandler(this.cmdUpdateMexicoCanada_Click);
            // 
            // cmdFinishArgentinaAustralia
            // 
            this.cmdFinishArgentinaAustralia.Location = new System.Drawing.Point(388, 321);
            this.cmdFinishArgentinaAustralia.Name = "cmdFinishArgentinaAustralia";
            this.cmdFinishArgentinaAustralia.Size = new System.Drawing.Size(163, 23);
            this.cmdFinishArgentinaAustralia.TabIndex = 17;
            this.cmdFinishArgentinaAustralia.Text = "Finish Argentina - Australia";
            this.cmdFinishArgentinaAustralia.UseVisualStyleBackColor = true;
            this.cmdFinishArgentinaAustralia.Click += new System.EventHandler(this.cmdFinishArgentinaAustralia_Click);
            // 
            // cmdFinishUruguayItaly
            // 
            this.cmdFinishUruguayItaly.Location = new System.Drawing.Point(388, 292);
            this.cmdFinishUruguayItaly.Name = "cmdFinishUruguayItaly";
            this.cmdFinishUruguayItaly.Size = new System.Drawing.Size(163, 23);
            this.cmdFinishUruguayItaly.TabIndex = 16;
            this.cmdFinishUruguayItaly.Text = "Finish Uruguay - Italy";
            this.cmdFinishUruguayItaly.UseVisualStyleBackColor = true;
            this.cmdFinishUruguayItaly.Click += new System.EventHandler(this.cmdFinishUruguayItaly_Click);
            // 
            // cmdFinishGermanyFrance
            // 
            this.cmdFinishGermanyFrance.Location = new System.Drawing.Point(388, 263);
            this.cmdFinishGermanyFrance.Name = "cmdFinishGermanyFrance";
            this.cmdFinishGermanyFrance.Size = new System.Drawing.Size(163, 23);
            this.cmdFinishGermanyFrance.TabIndex = 15;
            this.cmdFinishGermanyFrance.Text = "Finish Germany - France";
            this.cmdFinishGermanyFrance.UseVisualStyleBackColor = true;
            this.cmdFinishGermanyFrance.Click += new System.EventHandler(this.cmdFinishGermanyFrance_Click);
            // 
            // cmdFinishSpainBrazil
            // 
            this.cmdFinishSpainBrazil.Location = new System.Drawing.Point(388, 234);
            this.cmdFinishSpainBrazil.Name = "cmdFinishSpainBrazil";
            this.cmdFinishSpainBrazil.Size = new System.Drawing.Size(163, 23);
            this.cmdFinishSpainBrazil.TabIndex = 14;
            this.cmdFinishSpainBrazil.Text = "Finish Spain - Brazil";
            this.cmdFinishSpainBrazil.UseVisualStyleBackColor = true;
            this.cmdFinishSpainBrazil.Click += new System.EventHandler(this.cmdFinishSpainBrazil_Click);
            // 
            // cmdFinishMexicoCanada
            // 
            this.cmdFinishMexicoCanada.Location = new System.Drawing.Point(388, 205);
            this.cmdFinishMexicoCanada.Name = "cmdFinishMexicoCanada";
            this.cmdFinishMexicoCanada.Size = new System.Drawing.Size(163, 23);
            this.cmdFinishMexicoCanada.TabIndex = 13;
            this.cmdFinishMexicoCanada.Text = "Finish Mexico - Canada";
            this.cmdFinishMexicoCanada.UseVisualStyleBackColor = true;
            this.cmdFinishMexicoCanada.Click += new System.EventHandler(this.cmdFinishMexicoCanada_Click);
            // 
            // cmdGetSummaryGamesByTotalScore
            // 
            this.cmdGetSummaryGamesByTotalScore.Location = new System.Drawing.Point(575, 205);
            this.cmdGetSummaryGamesByTotalScore.Name = "cmdGetSummaryGamesByTotalScore";
            this.cmdGetSummaryGamesByTotalScore.Size = new System.Drawing.Size(187, 23);
            this.cmdGetSummaryGamesByTotalScore.TabIndex = 18;
            this.cmdGetSummaryGamesByTotalScore.Text = "Get Summary Games By Total Score";
            this.cmdGetSummaryGamesByTotalScore.UseVisualStyleBackColor = true;
            this.cmdGetSummaryGamesByTotalScore.Click += new System.EventHandler(this.cmdGetSummaryGamesByTotalScore_Click);
            // 
            // cmdGetCurrentGames
            // 
            this.cmdGetCurrentGames.Location = new System.Drawing.Point(575, 368);
            this.cmdGetCurrentGames.Name = "cmdGetCurrentGames";
            this.cmdGetCurrentGames.Size = new System.Drawing.Size(187, 23);
            this.cmdGetCurrentGames.TabIndex = 19;
            this.cmdGetCurrentGames.Text = "Get Current Games in the System";
            this.cmdGetCurrentGames.UseVisualStyleBackColor = true;
            this.cmdGetCurrentGames.Click += new System.EventHandler(this.cmdGetCurrentGames_Click);
            // 
            // txtHomeTeam
            // 
            this.txtHomeTeam.Location = new System.Drawing.Point(16, 371);
            this.txtHomeTeam.Name = "txtHomeTeam";
            this.txtHomeTeam.Size = new System.Drawing.Size(100, 20);
            this.txtHomeTeam.TabIndex = 20;
            // 
            // txtHomeScore
            // 
            this.txtHomeScore.Location = new System.Drawing.Point(122, 371);
            this.txtHomeScore.Name = "txtHomeScore";
            this.txtHomeScore.Size = new System.Drawing.Size(57, 20);
            this.txtHomeScore.TabIndex = 21;
            this.txtHomeScore.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtHomeScore_KeyPress);
            // 
            // txtAwayTeam
            // 
            this.txtAwayTeam.Location = new System.Drawing.Point(204, 371);
            this.txtAwayTeam.Name = "txtAwayTeam";
            this.txtAwayTeam.Size = new System.Drawing.Size(100, 20);
            this.txtAwayTeam.TabIndex = 22;
            // 
            // txtAwayScore
            // 
            this.txtAwayScore.Location = new System.Drawing.Point(310, 371);
            this.txtAwayScore.Name = "txtAwayScore";
            this.txtAwayScore.Size = new System.Drawing.Size(57, 20);
            this.txtAwayScore.TabIndex = 23;
            this.txtAwayScore.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAwayScore_KeyPress);
            // 
            // cmdStartGame
            // 
            this.cmdStartGame.Location = new System.Drawing.Point(388, 369);
            this.cmdStartGame.Name = "cmdStartGame";
            this.cmdStartGame.Size = new System.Drawing.Size(163, 23);
            this.cmdStartGame.TabIndex = 24;
            this.cmdStartGame.Text = "Start Game";
            this.cmdStartGame.UseVisualStyleBackColor = true;
            this.cmdStartGame.Click += new System.EventHandler(this.cmdStartGame_Click);
            // 
            // cmdUpdateScore
            // 
            this.cmdUpdateScore.Location = new System.Drawing.Point(388, 398);
            this.cmdUpdateScore.Name = "cmdUpdateScore";
            this.cmdUpdateScore.Size = new System.Drawing.Size(163, 23);
            this.cmdUpdateScore.TabIndex = 25;
            this.cmdUpdateScore.Text = "Update Score";
            this.cmdUpdateScore.UseVisualStyleBackColor = true;
            this.cmdUpdateScore.Click += new System.EventHandler(this.cmdUpdateScore_Click);
            // 
            // cmdFinishGame
            // 
            this.cmdFinishGame.Location = new System.Drawing.Point(388, 427);
            this.cmdFinishGame.Name = "cmdFinishGame";
            this.cmdFinishGame.Size = new System.Drawing.Size(163, 23);
            this.cmdFinishGame.TabIndex = 26;
            this.cmdFinishGame.Text = "Finish Game";
            this.cmdFinishGame.UseVisualStyleBackColor = true;
            this.cmdFinishGame.Click += new System.EventHandler(this.cmdFinishGame_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(774, 458);
            this.Controls.Add(this.cmdFinishGame);
            this.Controls.Add(this.cmdUpdateScore);
            this.Controls.Add(this.cmdStartGame);
            this.Controls.Add(this.txtAwayScore);
            this.Controls.Add(this.txtAwayTeam);
            this.Controls.Add(this.txtHomeScore);
            this.Controls.Add(this.txtHomeTeam);
            this.Controls.Add(this.cmdGetCurrentGames);
            this.Controls.Add(this.cmdGetSummaryGamesByTotalScore);
            this.Controls.Add(this.cmdFinishArgentinaAustralia);
            this.Controls.Add(this.cmdFinishUruguayItaly);
            this.Controls.Add(this.cmdFinishGermanyFrance);
            this.Controls.Add(this.cmdFinishSpainBrazil);
            this.Controls.Add(this.cmdFinishMexicoCanada);
            this.Controls.Add(this.cmdUpdateArgentinaAustralia);
            this.Controls.Add(this.cmdUpdateUruguayItaly);
            this.Controls.Add(this.cmdUpdateGermanyFrance);
            this.Controls.Add(this.cmdUpdateSpainBrazil);
            this.Controls.Add(this.cmdUpdateMexicoCanada);
            this.Controls.Add(this.rtbScoreBoard);
            this.Controls.Add(this.cmdStartArgentinaAustralia);
            this.Controls.Add(this.cmdStartUruguayItaly);
            this.Controls.Add(this.cmdStartGermanyFrance);
            this.Controls.Add(this.cmdStartSpainBrazil);
            this.Controls.Add(this.cmdStartMexicoCanada);
            this.Controls.Add(this.lblScoreBoard);
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Test Football Library";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblScoreBoard;
        private System.Windows.Forms.Button cmdStartMexicoCanada;
        private System.Windows.Forms.Button cmdStartSpainBrazil;
        private System.Windows.Forms.Button cmdStartGermanyFrance;
        private System.Windows.Forms.Button cmdStartUruguayItaly;
        private System.Windows.Forms.Button cmdStartArgentinaAustralia;
        private System.Windows.Forms.RichTextBox rtbScoreBoard;
        private System.Windows.Forms.Button cmdUpdateArgentinaAustralia;
        private System.Windows.Forms.Button cmdUpdateUruguayItaly;
        private System.Windows.Forms.Button cmdUpdateGermanyFrance;
        private System.Windows.Forms.Button cmdUpdateSpainBrazil;
        private System.Windows.Forms.Button cmdUpdateMexicoCanada;
        private System.Windows.Forms.Button cmdFinishArgentinaAustralia;
        private System.Windows.Forms.Button cmdFinishUruguayItaly;
        private System.Windows.Forms.Button cmdFinishGermanyFrance;
        private System.Windows.Forms.Button cmdFinishSpainBrazil;
        private System.Windows.Forms.Button cmdFinishMexicoCanada;
        private System.Windows.Forms.Button cmdGetSummaryGamesByTotalScore;
        private System.Windows.Forms.Button cmdGetCurrentGames;
        private System.Windows.Forms.TextBox txtHomeTeam;
        private System.Windows.Forms.TextBox txtHomeScore;
        private System.Windows.Forms.TextBox txtAwayTeam;
        private System.Windows.Forms.TextBox txtAwayScore;
        private System.Windows.Forms.Button cmdStartGame;
        private System.Windows.Forms.Button cmdUpdateScore;
        private System.Windows.Forms.Button cmdFinishGame;
    }
}

