/****************************************************************************************
 * Darien Cortez
 * 10/1/2018
 * This program utilizes classes and forms to allow users to input dimensions for an 
 * evidence grid. The evidence grid is displayed as an array of rows and columns provided
 * by the user. After getting the rows and columns, the program displays the array, asks
 * the user to guess where two random samples were placed on the grid, displays hints if
 * the guess was incorrect, prints an 'X' if the guess was correct, and keeps track of the
 * users stats. The form is ran in a full screen mode so a quit button is displayed to
 * terminate the program at anytime. The program utilizes buttons to lead perform different
 * actions and textboxes to display those actions.
 * ***************************************************************************************/

using System;
using System.Windows.Forms;

namespace FindSampleGame
{
    public partial class FindSampleGame : Form
    {
        ScanAnalyzer scan;//initialize a scanAnalyzer
        int row, col, rowG, colG;//row & col =>  grid dimensions | rowG & colG => guess dimensions
        private string[] sample;//array for different samples
        public FindSampleGame()
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;//maximizes the screen

            //initializes row and col to -1 to produce error message later on
            //list of samples
            sample = new string[] { "body fluids", "fibers", "a hair strand", "fingerprints", "shoe prints",
            "a firearm", "a crumbled document", "a bloody knife", "pry marks", "chemicals"};
        }

        private void FindSampleGame_Load(object sender, EventArgs e)
        {

        }

        //after clicking the let's begin button the row and column 
        private void Playbutton_Click(object sender, EventArgs e)
        {
            //gets rid of Welcome page after button click
            Welcome.Visible = false;
            Playbutton.Visible = false;
            //displays row and col Boxes after dectective starts the game
            rowBox.Visible = true;
            columnBox.Visible = true;
            restart.Visible = true;
        }

        //**********************************************************************
        //user input for how many rows and columns they want on the grid
        //something_Enter and something_Leave makes input act as placeholder 
        //**********************************************************************
        private void rowBox_Enter(object sender, EventArgs e)
        {
            if (rowBox.Text == "Enter the number of rows:")
                rowBox.Text = "";
        }
        //sets inpute answer equal to row
        private void rowBox_Leave(object sender, EventArgs e)
        {
            if (rowBox.Text == "")
                rowBox.Text = "Enter the number of rows:";

            Int32.TryParse(rowBox.Text, out row);
        }

        private void columnBox_Enter(object sender, EventArgs e)
        {
            if (columnBox.Text == "Enter the number of columns:")
                columnBox.Text = "";
        }
        //sets input answer equal to column
        private void columnBox_Leave(object sender, EventArgs e)
        {
            if (columnBox.Text == "")
                columnBox.Text = "Enter the number of columns:";

            Int32.TryParse(columnBox.Text, out col);
        }
        //**************************************************************************

        
        //************************************************************************
        //same idea as above but for the users guesses
        //something_Enter and something_Leave makes input act as placeholder 
        //************************************************************************
        private void RGuess_Enter(object sender, EventArgs e)
        {
            if (RGuess.Text == "Rows Guess:")
                RGuess.Text = "";
        }
        //sets input answer equal to rowG based on the users guess
        private void RGuess_Leave(object sender, EventArgs e)
        {
            if (RGuess.Text == "")
                RGuess.Text = "Rows Guess:";

            Int32.TryParse(RGuess.Text, out rowG);
        }
         
        private void CGuess_Enter(object sender, EventArgs e)
        {
            if (CGuess.Text == "Columns Guess:")
                CGuess.Text = "";
        }
        //sets input answer equal to colG based on the users guess
        private void CGuess_Leave(object sender, EventArgs e)
        {
            if (CGuess.Text == "")
                CGuess.Text = "Columns Guess:";

            Int32.TryParse(CGuess.Text, out colG);
        }
        //**********************************************************************

        private void restart_Click(object sender, EventArgs e)
        {
            DoOver();
        }
        
        private void columnBox_TextChanged(object sender, EventArgs e)
        {
            //shows the display grid button after the user enters columns
            DisplayGrid.Visible = true;
        }
        
        private void rowBox_TextChanged(object sender, EventArgs e)
        {
            //lets user input columns after inputting rows
            columnBox.Enabled = true;
        }

        //can't find the textbox to get rid of this
        private void lastGAns_Click(object sender, EventArgs e)
        {
            
        }

        //*******************************************************************************
        //button to display the grid. After entering the dimensions it makes the
        //grid, the textbox for row and column guesses, and the guess button visible
        //*******************************************************************************
        private void DisplayGrid_Click(object sender, EventArgs e)
        {
            //only allows the dimensions to be between 1x1 and 9x9
            if (row > 9 || row < 1 || col > 9 || col < 1)
                MessageBox.Show("You must enter numbers between 1 and 9, Detective.", 
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            else
            {
                //passes row and col to scanAnalyzer
                scan = new ScanAnalyzer(row, col);
                scan.fillRandomly();
                grid.Text = scan.CreateGrid();

                grid.Visible = true;//shows evidence grid
                DisplayGrid.Visible = false;
                guess.Visible = true;//shows guess button
                rowBox.Visible = false;
                columnBox.Visible = false;

                //allows guesses, keeps track of stats
                //, and gives user the ability to give up
                RGuess.Visible = true;
                CGuess.Visible = true;
                stats.Visible = true;
                
            }
        }
        //********************************************************************************

        private void Again_Click(object sender, EventArgs e)
        {
            DoOver();
        }

        private void GiveUp_Click(object sender, EventArgs e)
        {
            newGrid.Text = scan.GaveUp();//shows answer
            GiveUp.Visible = false;
            MessageBox.Show("Here is the answer.", "You failed us Detective", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            guess.Visible = false;
            Again.Visible = true;
        }

        //********************************************************************************

        //********************************************************************************
        //button to display a new grid, a textbox for row guesses, and column guesses. The 
        //new grid updates the old grid with a hint or 'X' after the user enters the guess 
        //dimensions.
        //********************************************************************************
        private void guess_Click(object sender, EventArgs e)
        {
            //only allows the guesses for dimensions to be between 1x1 and 9x9
            Random rnd = new Random();
            if (rowG > row || rowG < 1 || colG > col || colG < 1)
                MessageBox.Show("You must enter a guess within the dimensions of the evidence " +
                    "grid, Detective.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            else
            {
                grid.Visible = false;//gets rid of old grid
                newGrid.Visible = true;//updates old grid with new grid characters
                
                scan.getguess(rowG, colG);
                scan.EvaluateGuess();

                newGrid.Text = scan.DisplayNewGrid();//displays new grid in the textbox
                RGuess.Text = "Rows Guess:";//resets text to allow row guess input
                CGuess.Text = "Columns Guess:";//resets text to allow column guess input
                

                //updates stats board
                lastGAns.Text = "[" + rowG + ", " + colG + "]";
                guessAns.Text = scan.Counter().ToString();
                SampleAns.Text = scan.GetEvidenceNumber().ToString();
                GiveUp.Visible = true;

                //prints messagebox if a piece of evidence is found
                if (scan.SampleFound())
                {
                    MessageBox.Show("You discovered " + sample[rnd.Next(0, 9)], "Nice Going Detective!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    scan.NotFound();
                }

                //prints messagebox if both pieces of evidence are found
                if (scan.GetEvidenceNumber() == 2)
                {
                    MessageBox.Show("You discovered both evidence samples.", "Good Job Detective!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    guess.Visible = false;
                    Again.Visible = true;
                }
            }
        }

        //terminates game
        private void quit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //restarts the game
        private void DoOver()
        {
            //makes anything other than the "enter dimensions for
            //rows and columns" page equal to false
            RGuess.Visible = false;
            CGuess.Visible = false;
            guess.Visible = false;
            stats.Visible = false;
            Again.Visible = false;
            grid.Visible = false;
            newGrid.Visible = false;
            GiveUp.Visible = false;

            //redisplays "enter dimensions for rows and columns" page 
            rowBox.Visible = true;
            columnBox.Visible = true;
            DisplayGrid.Visible = true;

            //reinitializes all the enterrow and col textboxes
            rowBox.Text = "Enter the number of rows:";
            columnBox.Text = "Enter the number of columns:";
            RGuess.Text = "Rows Guess:";
            CGuess.Text = "Columns Guess:";
        }
    }
}