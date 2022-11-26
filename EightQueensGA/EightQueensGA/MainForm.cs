using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace EightQueensGA
{
    public partial class MainForm : Form
    {
        int Algo = 0;
        public MainForm()
        {
            InitializeComponent();
           
        }
        
        private void btnStart_Click(object sender, EventArgs e)
        {
            GeneticAlgo geneticAlgo = new GeneticAlgo();
            geneticAlgo.progress += new Progress(updateProgress);
            //progressBar1.Maximum = (int)txtGen.Value;
            //progressBar1.Value = 0;
        
            if (Algo == 0)
            {
              
                SolveHillClimbing((int)numericUpDown1.Value);
            }
            else if (Algo == 2)
            {

                List<Chromosome> initPopulation = GetInitialPopulation((int)txtPop.Value);
                //if(chkPorgress.Checked)

                geneticAlgo.DoMating(ref initPopulation, (int)txtGen.Value, (double)txtCrosProb.Value, (double)txtMutProb.Value);

                dgResults.Rows.Clear();
                for (int i = 0; i < initPopulation.Count - 1; i++)
                {
                    label8.Text = i.ToString();
                    String sol = "| ";
                    for (int j = 0; j < 8; j++)
                    {
                        sol = sol + initPopulation[i].genes[j] + " | ";
                    }
                    dgResults.Rows.Add(new Object[] { sol, initPopulation[i].fitness });

                }
                //int[] x = new int[]{ 1, 2 };
                board1.Genes = initPopulation[0].genes;
            }
            else if (Algo == 1)
            {
                SolveBavkTracking();

            }
        }

        private void updateProgress(int progress)
        {
            //if (Algo == 3)
            //{
            //    progressBar1.Value = progress;

            //    int percent = (int)(((double)(progressBar1.Value - progressBar1.Minimum) /
            //    (double)(progressBar1.Maximum - progressBar1.Minimum)) * 100);
            //    using (Graphics gr = progressBar1.CreateGraphics())
            //    {
            //        gr.DrawString(percent.ToString() + "%",
            //            SystemFonts.DefaultFont,
            //            Brushes.Black,
            //            new PointF(progressBar1.Width / 2 - (gr.MeasureString(percent.ToString() + "%",
            //                SystemFonts.DefaultFont).Width / 2.0F),
            //            progressBar1.Height / 2 - (gr.MeasureString(percent.ToString() + "%",
            //                SystemFonts.DefaultFont).Height / 2.0F)));
            //    }
            //}else if(Algo == 2)
            //{

            //}
        }

        private List<Chromosome> GetInitialPopulation(int population)
        {
            List<Chromosome> initPop = new List<Chromosome>();
            GeneticAlgo RandomGen = new GeneticAlgo();
            for (int i = 0; i < population; i++)
            {
                List<int> genes = new List<int>(new int[] { 0, 1, 2, 3, 4, 5, 6, 7 });
                Chromosome chromosome = new Chromosome();
                chromosome.genes = new int[8];
                for (int j = 0; j < 8; j++)
                {
                    int geneIndex = (int)(RandomGen.GetRandomVal(0, genes.Count - 1) + 0.5);
                    chromosome.genes[j] = genes[geneIndex];
                    genes.RemoveAt(geneIndex);
                }

                initPop.Add(chromosome);
            }
            return initPop;
        }

        private void Form1_Load(object sender, EventArgs e)
        {


        }

        private void chkPorgress_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void board1_Load(object sender, EventArgs e)
        {

        }
        const int BT_N = 8;
        void SolveBavkTracking()
        {
            label8.Text = 0.ToString();
            int count = 0;
            int[,] board = new int[BT_N, BT_N];

            //Initialize the board array to 0
            for (int i = 0; i < BT_N; i++)
            {
                for (int j = 0; j < BT_N; j++)
                {
                    board[i, j] = 0;
                }
            }

            //Initialize the pointer array
            int[] pointer = new int[BT_N];
            for (int i = 0; i < BT_N; i++)
            {
                pointer[i] = -1;
            }

            //Implementation of Back Tracking Algorithm
            for (int j = 0; ;)
            {
                pointer[j]++;
                //Reset and move one column back 
                if (pointer[j] == BT_N)
                {
                    board[pointer[j] - 1, j] = 0;
                    pointer[j] = -1;
                    j--;
                    if (j == -1)
                    {
                        Console.WriteLine("All possible configurations have been examined...");
                        break;
                    }
                }
                else
                {
                    board[pointer[j], j] = 1;
                    if (pointer[j] != 0)
                    {
                        board[pointer[j] - 1, j] = 0;
                    }
                    if (SolutionCheck(board))
                    {
                        j++;//move to next column
                        if (j == BT_N)
                        {
                            j--;
                            count++;
                            Console.WriteLine("Solution" + count.ToString() + ":");
                            for (int p = 0; p < BT_N; p++)
                            {
                                for (int q = 0; q < BT_N; q++)
                                {
                                    Console.Write(board[p, q] + " ");
                                }
                                Console.WriteLine();
                            }
                            int[] sol = new int[BT_N];
                            for (int p = 0; p < BT_N; p++)
                            {
                                for (int q = 0; q < BT_N; q++)
                                {
                                    if (board[p, q] == 1)
                                    {
                                        sol[p] = q;
                                    }
                                }
                                label8.Text = (int.Parse(label8.Text) + 1).ToString();
                                board1.Genes = sol;
                            }
                        }
                    }
                }
            }
        }
        public static bool SolutionCheck(int[,] board)
        {

            //Row check
            for (int i = 0; i < BT_N; i++)
            {
                int sum = 0;
                for (int j = 0; j < BT_N; j++)
                {
                    sum = sum + board[i, j];
                }
                if (sum > 1)
                {
                    return false;
                }
            }
            //Main diagonal check
            //above
            for (int i = 0, j = BT_N - 2; j >= 0; j--)
            {
                int sum = 0;
                for (int p = i, q = j; q < BT_N; p++, q++)
                {
                    sum = sum + board[p, q];
                }
                if (sum > 1)
                {
                    return false;
                }
            }
            //below
            for (int i = 1, j = 0; i < BT_N - 1; i++)
            {
                int sum = 0;
                for (int p = i, q = j; p < BT_N; p++, q++)
                {
                    sum = sum + board[p, q];
                }
                if (sum > 1)
                {
                    return false;
                }
            }
            //Minor diagonal check
            //above
            for (int i = 0, j = 1; j < BT_N; j++)
            {
                int sum = 0;
                for (int p = i, q = j; q >= 0; p++, q--)
                {
                    sum = sum + board[p, q];
                }
                if (sum > 1)
                {
                    return false;
                }
            }
            //below
            for (int i = 1, j = BT_N - 1; i < BT_N - 1; i++)
            {
                int sum = 0;
                for (int p = i, q = j; p < BT_N; p++, q--)
                {
                    sum = sum + board[p, q];
                }
                if (sum > 1)
                {
                    return false;
                }
            }
            return true;
        }
        public static int TOTAL_QUEENS = 8;
        int[][] HC_board   = new int[8][];
        private int[] queenPositions = new int[8];
        void SolveHillClimbing( int count)
        {
            for (int i = 0; i < 8; i++)
            {
                HC_board[i] = new int[8];
            }
            Boolean climb = true;
            int climbCount = 0;

            // 5 restarts
            while (climb)
            {

             
                // randomly place queens
                placeQueens();
                Console.WriteLine("Trial #: " + (climbCount + 1));
                Console.WriteLine("Original board:");
                printBoard();
                Console.WriteLine("# pairs of queens attacking each other: "
                        + h() + "\n");

                // score to be compared against
                int localMin = h();
                Boolean best = false;
                // array to store best queen positions by row (array index is column)
                int[] bestQueenPositions = new int[8];

                // iterate through each column 
                for (int j = 0; j < HC_board.Count(); j++)
                {
                    Console.WriteLine("Iterating through COLUMN " + j + ":");
                    best = false;
                    //  iterate through each row
                    for (int i = 0; i < HC_board.Count(); i++)
                    {

                        // skip score calculated by original board
                        if (i != queenPositions[j])
                        {

                            // move queen 
                            moveQueen(i, j);
                            printBoard();
                            Console.WriteLine();
                            // calculate score, if best seen then store queen position
                            if (h() < localMin)
                            {
                                best = true;
                                localMin = h();
                                bestQueenPositions[j] = i;
                            }
                            // reset to original queen position
                            resetQueen(i, j);

                        }
                    }

                    // change 2 back to 1
                    resetBoard(j);
                    if (best)
                    {
                        // if a best score was found, place queen in this position
                        placeBestQueen(j, bestQueenPositions[j]);
                        Console.WriteLine("Best board found this iteration: ");
                        printBoard();
                        Console.WriteLine("# pairs of queens attacking each other: "
                                    + h() + "\n");
                    }
                    else {
                        Console.WriteLine("No better board found.");
                        printBoard();
                        Console.WriteLine("# pairs of queens attacking each other: "
                                    + h() + "\n");
                    }
                }

                // if score = 0, hill climbing has solved problem
                if (h() == 0)
                    climb = false;

                climbCount++;

                
                if (climbCount == count)
                {
                  label8.Text = climbCount.ToString();
                    climb = false;
                }
                Console.WriteLine("Done in " + (climbCount - 1) + " restarts.");
               // break;
            }
        }

        private int[] generateQueens()
        {

            List<int> randomPos = new List<int>();

            Random r = new Random();
            for (int i = 0; i < TOTAL_QUEENS; i++)
            {
                randomPos.Add(r.Next(8));
            }

            int[] randomPositions = new int[TOTAL_QUEENS];

            for (int i = 0; i < randomPos.Count(); i++)
            {
                randomPositions[i] = randomPos.ElementAt(i);
            }

            return randomPositions;
        }
        public void placeQueens()
        {

            queenPositions = generateQueens();
            
            for (int i = 0; i < HC_board.Count(); i++)
            {
                HC_board[queenPositions[i]][i] = 1;
            }

        }

        public int h()
        {

            int totalPairs = 0;

            // checking rows
            for (int i = 0; i < HC_board.Count(); i++)
            {
                List<Boolean> pairs = new List<Boolean>();
                for (int j = 0; j < HC_board[i].Count(); j++)
                {

                    if (HC_board[i][j] == 1)
                    {
                        pairs.Add(true);
                    }

                }
                if (pairs.Count() != 0)
                    totalPairs = totalPairs + (pairs.Count() - 1);
            }

            // check diagonal from top left
            int rows = HC_board.Count();
            int cols = HC_board.Count();
            int maxSum = rows + cols - 2;

            for (int sum = 0; sum <= maxSum; sum++)
            {
                List<Boolean> pairs = new List<Boolean>();
                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < cols; j++)
                    {
                        if (i + j - sum == 0)
                        {
                            if (HC_board[i][j] == 1)
                            {
                                pairs.Add(true);
                            }
                        }
                    }

                }
                if (pairs.Count() != 0)
                    totalPairs = totalPairs + (pairs.Count() - 1);
            }

            // check mirrored diagonal. couldn't figure out algorithm so solved brute force.
            int pairss = checkMirrorDiagonal();

            return totalPairs + pairss;
        }

        private int checkMirrorDiagonal()
        {

            int[] b1 = { HC_board[7][0] };
            int[] b2 = { HC_board[7][1], HC_board[6][0] };
            int[] b3 = { HC_board[7][2], HC_board[6][1], HC_board[5][0] };
            int[] b4 = { HC_board[7][3], HC_board[6][2], HC_board[5][1], HC_board[4][0] };
            int[] b5 = { HC_board[7][4], HC_board[6][3], HC_board[5][2], HC_board[4][1],
                HC_board[3][0] };
            int[] b6 = { HC_board[7][5], HC_board[6][4], HC_board[5][3], HC_board[4][2],
                HC_board[3][1], HC_board[2][0] };
            int[] b7 = { HC_board[7][6], HC_board[6][5], HC_board[5][4], HC_board[4][3],
                HC_board[3][2], HC_board[2][1], HC_board[1][0] };
            int[] b8 = { HC_board[7][7], HC_board[6][6], HC_board[5][5], HC_board[4][4],
                HC_board[3][3], HC_board[2][2], HC_board[1][1], HC_board[0][0] };
            int[] b9 = { HC_board[6][7], HC_board[5][6], HC_board[4][5], HC_board[3][4],
                HC_board[2][3], HC_board[1][2], HC_board[0][1] };
            int[] b10 = { HC_board[5][7], HC_board[4][6], HC_board[3][5], HC_board[2][4],
                HC_board[1][3], HC_board[0][2] };
            int[] b11 = { HC_board[4][7], HC_board[3][6], HC_board[2][5], HC_board[1][4],
                HC_board[0][3] };
            int[] b12 = { HC_board[3][7], HC_board[2][6], HC_board[1][5], HC_board[0][4] };
            int[] b13 = { HC_board[2][7], HC_board[1][6], HC_board[0][5] };
            int[] b14 = { HC_board[1][7], HC_board[0][6] };
            int[] b15 = { HC_board[0][7] };

            int totalPairs = 0;

            totalPairs += checkMirrorHorizontal(b1);
            totalPairs += checkMirrorHorizontal(b2);
            totalPairs += checkMirrorHorizontal(b3);
            totalPairs += checkMirrorHorizontal(b4);
            totalPairs += checkMirrorHorizontal(b5);
            totalPairs += checkMirrorHorizontal(b6);
            totalPairs += checkMirrorHorizontal(b7);
            totalPairs += checkMirrorHorizontal(b8);
            totalPairs += checkMirrorHorizontal(b9);
            totalPairs += checkMirrorHorizontal(b10);
            totalPairs += checkMirrorHorizontal(b11);
            totalPairs += checkMirrorHorizontal(b12);
            totalPairs += checkMirrorHorizontal(b13);
            totalPairs += checkMirrorHorizontal(b14);
            totalPairs += checkMirrorHorizontal(b15);

            return totalPairs;

        }

        public void moveQueen(int row, int col)
        {

            // original queen will become a 2 and act as a marker
            HC_board[queenPositions[col]][col] = 2;

            HC_board[row][col] = 1;

        }



        private int checkMirrorHorizontal(int[] b)
        {

            int totalPairs = 0;

            List<Boolean> pairs = new List<Boolean>();
            for (int i = 0; i < b.Count(); i++)
            {
                if (b[i] == 1)
                    pairs.Add(true);

            }

            if (pairs.Count() != 0)
                totalPairs = (pairs.Count() - 1);

            return totalPairs;
        }

        public void resetQueen(int row, int col)
        {

            if (HC_board[row][col] == 1)
                HC_board[row][col] = 0;
        }

        public void resetBoard(int col)
        {

            for (int i = 0; i < HC_board.Count(); i++)
            {
                if (HC_board[i][col] == 2)
                    HC_board[i][col] = 1;
            }
        }

        public void placeBestQueen(int col, int queenPos)
        {

            for (int i = 0; i < HC_board.Count(); i++)
            {
                if (HC_board[i][col] == 1)
                    HC_board[i][col] = 2;

            }
            HC_board[queenPos][col] = 1;
            for (int i = 0; i < HC_board.Count(); i++)
            {
                if (HC_board[i][col] == 2)
                    HC_board[i][col] = 0;

            }
        }

        public void printBoard()
        {

            for (int i = 0; i < HC_board.Count(); i++)
            {
                for (int j = 0; j < HC_board[i].Count(); j++)
                {
                    Console.Write(HC_board[i][j] + " ");
                }
                Console.WriteLine();
            }
            int[] sol = new int[BT_N];
            for (int p = 0; p < BT_N; p++)
            {
                for (int q = 0; q < BT_N; q++)
                {
                    if (HC_board[p][q] == 1)
                    {
                        sol[p] = q;
                    }
                }
                board1.Genes = sol;
            }
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Console.WriteLine(tabControl1.TabIndex);
                Algo = tabControl1.SelectedIndex;
            switch (Algo)
            {
                case 0:
                    label7.Text = "No. of Restarts: ";
                    break;
                default:
                    label7.Text = "No. of Iterations: ";
                    break;
            }
            Console.WriteLine(Algo);
        }

        private void tabControl1_MouseClick(object sender, MouseEventArgs e)
        {
        }
    }

}


