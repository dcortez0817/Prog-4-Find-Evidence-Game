namespace FindSampleGame
{
    partial class FindSampleGame
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FindSampleGame));
            this.Welcome = new System.Windows.Forms.TextBox();
            this.rowBox = new System.Windows.Forms.TextBox();
            this.columnBox = new System.Windows.Forms.TextBox();
            this.Playbutton = new System.Windows.Forms.Button();
            this.DisplayGrid = new System.Windows.Forms.Button();
            this.grid = new System.Windows.Forms.TextBox();
            this.guess = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.quit = new System.Windows.Forms.Button();
            this.restart = new System.Windows.Forms.Button();
            this.RGuess = new System.Windows.Forms.TextBox();
            this.CGuess = new System.Windows.Forms.TextBox();
            this.newGrid = new System.Windows.Forms.TextBox();
            this.stats = new System.Windows.Forms.GroupBox();
            this.SampleAns = new System.Windows.Forms.Label();
            this.guessAns = new System.Windows.Forms.Label();
            this.guessesFound = new System.Windows.Forms.Label();
            this.NumGuess = new System.Windows.Forms.Label();
            this.lastGAns = new System.Windows.Forms.Label();
            this.lastGuess = new System.Windows.Forms.Label();
            this.Again = new System.Windows.Forms.Button();
            this.GiveUp = new System.Windows.Forms.Button();
            this.stats.SuspendLayout();
            this.SuspendLayout();
            // 
            // Welcome
            // 
            this.Welcome.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Welcome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(54)))), ((int)(((byte)(74)))));
            this.Welcome.ForeColor = System.Drawing.Color.Lime;
            this.Welcome.Location = new System.Drawing.Point(288, 92);
            this.Welcome.Multiline = true;
            this.Welcome.Name = "Welcome";
            this.Welcome.ReadOnly = true;
            this.Welcome.Size = new System.Drawing.Size(918, 509);
            this.Welcome.TabIndex = 1;
            this.Welcome.Text = resources.GetString("Welcome.Text");
            // 
            // rowBox
            // 
            this.rowBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rowBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(54)))), ((int)(((byte)(74)))));
            this.rowBox.ForeColor = System.Drawing.Color.Lime;
            this.rowBox.Location = new System.Drawing.Point(324, 121);
            this.rowBox.Name = "rowBox";
            this.rowBox.Size = new System.Drawing.Size(918, 30);
            this.rowBox.TabIndex = 2;
            this.rowBox.Text = "Enter the number of rows:";
            this.rowBox.Visible = false;
            this.rowBox.TextChanged += new System.EventHandler(this.rowBox_TextChanged);
            this.rowBox.Enter += new System.EventHandler(this.rowBox_Enter);
            this.rowBox.Leave += new System.EventHandler(this.rowBox_Leave);
            // 
            // columnBox
            // 
            this.columnBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.columnBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(54)))), ((int)(((byte)(74)))));
            this.columnBox.Enabled = false;
            this.columnBox.ForeColor = System.Drawing.Color.Lime;
            this.columnBox.Location = new System.Drawing.Point(324, 178);
            this.columnBox.Name = "columnBox";
            this.columnBox.Size = new System.Drawing.Size(918, 30);
            this.columnBox.TabIndex = 3;
            this.columnBox.Text = "Enter the number of columns:";
            this.columnBox.Visible = false;
            this.columnBox.TextChanged += new System.EventHandler(this.columnBox_TextChanged);
            this.columnBox.Enter += new System.EventHandler(this.columnBox_Enter);
            this.columnBox.Leave += new System.EventHandler(this.columnBox_Leave);
            // 
            // Playbutton
            // 
            this.Playbutton.BackColor = System.Drawing.Color.Aquamarine;
            this.Playbutton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Playbutton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(54)))), ((int)(((byte)(74)))));
            this.Playbutton.Location = new System.Drawing.Point(0, 775);
            this.Playbutton.Margin = new System.Windows.Forms.Padding(5);
            this.Playbutton.Name = "Playbutton";
            this.Playbutton.Size = new System.Drawing.Size(1666, 40);
            this.Playbutton.TabIndex = 0;
            this.Playbutton.Text = "Begin";
            this.Playbutton.UseVisualStyleBackColor = false;
            this.Playbutton.Click += new System.EventHandler(this.Playbutton_Click);
            // 
            // DisplayGrid
            // 
            this.DisplayGrid.BackColor = System.Drawing.Color.Aquamarine;
            this.DisplayGrid.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.DisplayGrid.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(54)))), ((int)(((byte)(74)))));
            this.DisplayGrid.Location = new System.Drawing.Point(0, 735);
            this.DisplayGrid.Name = "DisplayGrid";
            this.DisplayGrid.Size = new System.Drawing.Size(1666, 40);
            this.DisplayGrid.TabIndex = 4;
            this.DisplayGrid.Text = "Display Evidence Grid";
            this.DisplayGrid.UseVisualStyleBackColor = false;
            this.DisplayGrid.Visible = false;
            this.DisplayGrid.Click += new System.EventHandler(this.DisplayGrid_Click);
            // 
            // grid
            // 
            this.grid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grid.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(54)))), ((int)(((byte)(74)))));
            this.grid.ForeColor = System.Drawing.Color.Lime;
            this.grid.Location = new System.Drawing.Point(324, 260);
            this.grid.Multiline = true;
            this.grid.Name = "grid";
            this.grid.ReadOnly = true;
            this.grid.Size = new System.Drawing.Size(918, 255);
            this.grid.TabIndex = 5;
            this.grid.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.grid.Visible = false;
            // 
            // guess
            // 
            this.guess.BackColor = System.Drawing.Color.Aquamarine;
            this.guess.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.guess.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(54)))), ((int)(((byte)(74)))));
            this.guess.Location = new System.Drawing.Point(0, 695);
            this.guess.Name = "guess";
            this.guess.Size = new System.Drawing.Size(1666, 40);
            this.guess.TabIndex = 6;
            this.guess.Text = "Guess";
            this.guess.UseVisualStyleBackColor = false;
            this.guess.Visible = false;
            this.guess.Click += new System.EventHandler(this.guess_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // quit
            // 
            this.quit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.quit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(54)))), ((int)(((byte)(74)))));
            this.quit.ForeColor = System.Drawing.Color.Lime;
            this.quit.Location = new System.Drawing.Point(1500, 12);
            this.quit.Name = "quit";
            this.quit.Size = new System.Drawing.Size(126, 59);
            this.quit.TabIndex = 8;
            this.quit.Text = "Quit mission";
            this.quit.UseVisualStyleBackColor = false;
            this.quit.Click += new System.EventHandler(this.quit_Click);
            // 
            // restart
            // 
            this.restart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(54)))), ((int)(((byte)(74)))));
            this.restart.ForeColor = System.Drawing.Color.Lime;
            this.restart.Location = new System.Drawing.Point(20, 12);
            this.restart.Name = "restart";
            this.restart.Size = new System.Drawing.Size(126, 56);
            this.restart.TabIndex = 9;
            this.restart.Text = "restart mission";
            this.restart.UseVisualStyleBackColor = false;
            this.restart.Visible = false;
            this.restart.Click += new System.EventHandler(this.restart_Click);
            // 
            // RGuess
            // 
            this.RGuess.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.RGuess.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(54)))), ((int)(((byte)(74)))));
            this.RGuess.ForeColor = System.Drawing.Color.Lime;
            this.RGuess.Location = new System.Drawing.Point(324, 92);
            this.RGuess.Name = "RGuess";
            this.RGuess.Size = new System.Drawing.Size(918, 30);
            this.RGuess.TabIndex = 10;
            this.RGuess.Text = "Rows Guess:";
            this.RGuess.Visible = false;
            this.RGuess.Enter += new System.EventHandler(this.RGuess_Enter);
            this.RGuess.Leave += new System.EventHandler(this.RGuess_Leave);
            // 
            // CGuess
            // 
            this.CGuess.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CGuess.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(54)))), ((int)(((byte)(74)))));
            this.CGuess.ForeColor = System.Drawing.Color.Lime;
            this.CGuess.Location = new System.Drawing.Point(324, 161);
            this.CGuess.Name = "CGuess";
            this.CGuess.Size = new System.Drawing.Size(918, 30);
            this.CGuess.TabIndex = 11;
            this.CGuess.Text = "Columns Guess:";
            this.CGuess.Visible = false;
            this.CGuess.Enter += new System.EventHandler(this.CGuess_Enter);
            this.CGuess.Leave += new System.EventHandler(this.CGuess_Leave);
            // 
            // newGrid
            // 
            this.newGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.newGrid.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(54)))), ((int)(((byte)(74)))));
            this.newGrid.ForeColor = System.Drawing.Color.Lime;
            this.newGrid.Location = new System.Drawing.Point(324, 260);
            this.newGrid.Multiline = true;
            this.newGrid.Name = "newGrid";
            this.newGrid.ReadOnly = true;
            this.newGrid.Size = new System.Drawing.Size(918, 255);
            this.newGrid.TabIndex = 12;
            this.newGrid.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.newGrid.Visible = false;
            // 
            // stats
            // 
            this.stats.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(54)))), ((int)(((byte)(74)))));
            this.stats.Controls.Add(this.SampleAns);
            this.stats.Controls.Add(this.guessAns);
            this.stats.Controls.Add(this.guessesFound);
            this.stats.Controls.Add(this.NumGuess);
            this.stats.Controls.Add(this.lastGAns);
            this.stats.Controls.Add(this.lastGuess);
            this.stats.ForeColor = System.Drawing.Color.Lime;
            this.stats.Location = new System.Drawing.Point(1248, 156);
            this.stats.Name = "stats";
            this.stats.Size = new System.Drawing.Size(278, 387);
            this.stats.TabIndex = 13;
            this.stats.TabStop = false;
            this.stats.Text = "Stats";
            this.stats.Visible = false;
            // 
            // SampleAns
            // 
            this.SampleAns.Location = new System.Drawing.Point(179, 248);
            this.SampleAns.Name = "SampleAns";
            this.SampleAns.Size = new System.Drawing.Size(83, 47);
            this.SampleAns.TabIndex = 5;
            // 
            // guessAns
            // 
            this.guessAns.Location = new System.Drawing.Point(179, 162);
            this.guessAns.Name = "guessAns";
            this.guessAns.Size = new System.Drawing.Size(83, 47);
            this.guessAns.TabIndex = 4;
            // 
            // guessesFound
            // 
            this.guessesFound.Location = new System.Drawing.Point(20, 248);
            this.guessesFound.Name = "guessesFound";
            this.guessesFound.Size = new System.Drawing.Size(252, 47);
            this.guessesFound.TabIndex = 3;
            this.guessesFound.Text = "Samples found: ";
            // 
            // NumGuess
            // 
            this.NumGuess.Font = new System.Drawing.Font("Lucida Sans Typewriter", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumGuess.Location = new System.Drawing.Point(20, 162);
            this.NumGuess.Name = "NumGuess";
            this.NumGuess.Size = new System.Drawing.Size(252, 47);
            this.NumGuess.TabIndex = 2;
            this.NumGuess.Text = "Guesses: ";
            // 
            // lastGAns
            // 
            this.lastGAns.AutoSize = true;
            this.lastGAns.Location = new System.Drawing.Point(151, 86);
            this.lastGAns.Name = "lastGAns";
            this.lastGAns.Size = new System.Drawing.Size(0, 22);
            this.lastGAns.TabIndex = 1;
            this.lastGAns.Click += new System.EventHandler(this.lastGAns_Click);
            // 
            // lastGuess
            // 
            this.lastGuess.Location = new System.Drawing.Point(20, 86);
            this.lastGuess.Name = "lastGuess";
            this.lastGuess.Size = new System.Drawing.Size(252, 34);
            this.lastGuess.TabIndex = 0;
            this.lastGuess.Text = "Last Guess:";
            // 
            // Again
            // 
            this.Again.BackColor = System.Drawing.Color.Aquamarine;
            this.Again.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Again.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(54)))), ((int)(((byte)(74)))));
            this.Again.Location = new System.Drawing.Point(0, 655);
            this.Again.Name = "Again";
            this.Again.Size = new System.Drawing.Size(1666, 40);
            this.Again.TabIndex = 14;
            this.Again.Text = "Play Again?";
            this.Again.UseVisualStyleBackColor = false;
            this.Again.Visible = false;
            this.Again.Click += new System.EventHandler(this.Again_Click);
            // 
            // GiveUp
            // 
            this.GiveUp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(54)))), ((int)(((byte)(74)))));
            this.GiveUp.ForeColor = System.Drawing.Color.Lime;
            this.GiveUp.Location = new System.Drawing.Point(682, 569);
            this.GiveUp.Name = "GiveUp";
            this.GiveUp.Size = new System.Drawing.Size(130, 43);
            this.GiveUp.TabIndex = 15;
            this.GiveUp.Text = "Give Up";
            this.GiveUp.UseVisualStyleBackColor = false;
            this.GiveUp.Visible = false;
            this.GiveUp.Click += new System.EventHandler(this.GiveUp_Click);
            // 
            // FindSampleGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1666, 815);
            this.Controls.Add(this.GiveUp);
            this.Controls.Add(this.Again);
            this.Controls.Add(this.stats);
            this.Controls.Add(this.newGrid);
            this.Controls.Add(this.CGuess);
            this.Controls.Add(this.RGuess);
            this.Controls.Add(this.restart);
            this.Controls.Add(this.quit);
            this.Controls.Add(this.guess);
            this.Controls.Add(this.grid);
            this.Controls.Add(this.DisplayGrid);
            this.Controls.Add(this.columnBox);
            this.Controls.Add(this.rowBox);
            this.Controls.Add(this.Welcome);
            this.Controls.Add(this.Playbutton);
            this.Font = new System.Drawing.Font("Lucida Sans Typewriter", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "FindSampleGame";
            this.Text = "Find The Evidence";
            this.Load += new System.EventHandler(this.FindSampleGame_Load);
            this.stats.ResumeLayout(false);
            this.stats.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox Welcome;
        private System.Windows.Forms.TextBox rowBox;
        private System.Windows.Forms.TextBox columnBox;
        private System.Windows.Forms.Button Playbutton;
        private System.Windows.Forms.Button DisplayGrid;
        private System.Windows.Forms.TextBox grid;
        private System.Windows.Forms.Button guess;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button quit;
        private System.Windows.Forms.Button restart;
        private System.Windows.Forms.TextBox RGuess;
        private System.Windows.Forms.TextBox CGuess;
        private System.Windows.Forms.TextBox newGrid;
        private System.Windows.Forms.GroupBox stats;
        private System.Windows.Forms.Label guessesFound;
        private System.Windows.Forms.Label NumGuess;
        private System.Windows.Forms.Label lastGAns;
        private System.Windows.Forms.Label lastGuess;
        private System.Windows.Forms.Label SampleAns;
        private System.Windows.Forms.Label guessAns;
        private System.Windows.Forms.Button Again;
        private System.Windows.Forms.Button GiveUp;
    }
}

