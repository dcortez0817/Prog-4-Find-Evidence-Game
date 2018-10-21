using System;

namespace FindSampleGame
{
    class ScanAnalyzer
    {
        private char[,] grid;
        private readonly int r, c;
        private int rg, cg, count, evNum;
        private string SG;//string version of grid
        private bool found;
        private int[] rSample;//holds random evidence rows
        private int[] cSample;//holds random evidence columns

        //constructor
        public ScanAnalyzer(int row, int col)
        {
            found = false;
            count = 0;//keeps track of guesses
            evNum = 0;//keeps track of sample #
            rSample = new int[2];
            cSample = new int[2];
            this.r = row;
            this.c = col;
        }

        public void getguess(int rguess, int cguess)
        {
            rg = rguess;
            cg = cguess;
        }

        //returns the evidence grid in a string
        public string CreateGrid()
        { 
            //dimensions are increased by one to provide numbers to the grid
            //manipulates ascii characters to display numbers between 0-9
            grid = new char[r+1, c+1];  

            for (int i = 0; i <= r; i++){
                for (int j = 0; j <= c; j++)
                {

                    if (i == 0 && j == 0)
                        grid[i, j] = ' ';

                    //prints the column numbers
                    else if (i == 0)
                        grid[i, j] = (char)(j + 48);

                    //prints the row numbers
                    else if (j == 0)
                        grid[i, j] = (char)(i + 48);

                    //fills grid with ~
                    else
                        grid[i, j] = '~';
                    SG += grid[i, j];
                }
                SG += System.Environment.NewLine;
            }
            return SG;
        }
        
        private char Hint()
        {
            char c;
            //uses ternary operator to see if guess is above or below the sample
            if (count % 2 == 0)
                c = rg > rSample[evNum] ? '^' : 'v';

            //uses ternary operator to see if guess is to the left or to the right of the sample
            else
                c = cg > cSample[evNum] ? '<' : '>';

            return c;
        }
        
        //gives random values for the dimensions of the samples (between 1 and r or 1 and c)
        public void fillRandomly()
        {
            Random rnd = new Random();//allows for use of random numbers
            
            for(int i = 0; i < 2; i++)
                rSample[i] = rnd.Next(1, r);//sample rows

            for (int i = 0; i < 2; i++)
                cSample[i] = rnd.Next(1, c);//sample columns


        }

        public void EvaluateGuess()
        {
            Random rnd = new Random();
            count++;//keeps track of guesses

            //if guess is correct do the following
            if (rSample[evNum] == rg && cSample[evNum] == cg)
            {
                found = true;
                ResetEvidenceGrid();
                grid[rg, cg] = 'X';
                evNum++;//increments to next piece of evidence
            }

            else
            {
                //if guess is incorrect this puts a hint in the grid
                grid[rg, cg] = Hint();
            }
        }

        public string GaveUp()
        {
            string NG = "";
            
            grid[rSample[0], cSample[0]] = 'X';
            grid[rSample[1], cSample[1]] = 'X';
            NG = DisplayNewGrid();
            
            return NG;
        }

        public string DisplayNewGrid()
        {
            string NG = "";
            
            for (int i = 0; i <= r; i++)
            {
                for (int j = 0; j <= c; j++)
                    NG += grid[i, j];
                NG += System.Environment.NewLine;
            }
            return NG;
        }

        //resets the board after finding one sample
        public void ResetEvidenceGrid()
        {
            for (int i = 0; i < r; i++)
                for (int j = 0; j < c; j++)
                {
                    if (grid[i, j] != 'X' && i != 0 && j != 0)
                    {
                        grid[i, j] = '~';
                    }
                }
        }

        public int GetEvidenceNumber()
        {
            return evNum;
        }

        public bool SampleFound()
        {
            return found;
        }

        public void NotFound()
        {
            found = false;
        }

        public int Counter()
        {
            return count;
        }
    }
}
