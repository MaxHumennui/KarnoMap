using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KarnOMap
{
    public partial class Form2 : Form
    {
        public Form2(string vall, int n)
        {
            InitializeComponent();

            panel1.Visible = false;
            panel2.Visible = false;

            label1.Text = vall; //x̅ y̅ z̅ w̅

            if (n == 3)
            {
                string[] formul2 = ParserForThree();
                int[,] res = MapThree(formul2);
                printBoard(tabl1, res);
                tabl1.Width = 30 * 4;
                panel1.Visible = true;
            }
            else
            {
                string[] formul2 = ParserForFour();
                int[,] res = MapFour(formul2);
                printBoard(tabl2, res);
                tabl2.Width = 30 * 4;
                panel2.Visible = true;
            }

        }
        public string[] ParserForThree()
        {
            string formul = label1.Text;
            string vall = "";

             int c = 0;

            foreach (char i in formul)
            {
                c++;
            }

            string[] formul2 = new string[c + 1];
            c = 0;

            foreach(char i in formul)
            {
                vall += i;
                if (vall == "X1")
                {
                    formul2[c] += "x";
                    vall = "";
                }
                if (vall == "X̅1")
                {
                    formul2[c] += "x̅";
                    vall = "";
                }
                if (vall == "X2")
                {
                    formul2[c] += "y";
                    vall = "";
                }
                if (vall == "X̅2")
                {
                    formul2[c] += "y̅";
                    vall = "";
                }
                if (vall == "X3")
                {
                    formul2[c] += "z";
                    vall = "";
                }
                if (vall == "X̅3")
                {
                    formul2[c] += "z̅";
                    vall = "";
                }
                if(vall == " ∨ ")
                {
                    formul2[c] += "∨";
                    vall = "";
                }
                c++;
            }
            formul2[c] += " ";
            string formul3 = "";

            foreach (string i in formul2)
            {
                formul3 += i;
            }

            lab.Text = formul3;
            return formul2;
        }
        public string[] ParserForFour()
        {
            string formul = label1.Text;
            string vall = "";

            int c = 0;

            foreach (char i in formul)
            {
                c++;
            }

            string[] formul2 = new string[c + 1];
            c = 0;

            foreach (char i in formul)
            {
                vall += i;
                if (vall == "X1")
                {
                    formul2[c] += "x";
                    vall = "";
                }
                if (vall == "X̅1")
                {
                    formul2[c] += "x̅";
                    vall = "";
                }
                if (vall == "X2")
                {
                    formul2[c] += "y";
                    vall = "";
                }
                if (vall == "X̅2")
                {
                    formul2[c] += "y̅";
                    vall = "";
                }
                if (vall == "X3")
                {
                    formul2[c] += "z";
                    vall = "";
                }
                if (vall == "X̅3")
                {
                    formul2[c] += "z̅";
                    vall = "";
                }
                if (vall == "X4")
                {
                    formul2[c] += "w";
                    vall = "";
                }
                if (vall == "X̅4")
                {
                    formul2[c] += "w̅";
                    vall = "";
                }
                if(vall == " ∨ ")
                {
                    formul2[c] += "∨";
                    vall = "";
                }
                c++;
            }

            formul2[c] += " ";
            string formul3 = "";

            foreach(string i in formul2)
            {
                formul3 += i;
            }

            lab.Text = formul3;
            return formul2;
        }

        public int[,] MapThree(string[] formul2)
        {
            int[,] x = { {1, 1, 1, 1},
                         {0, 0, 0, 0} };

            int[,] nx = { {0, 0, 0, 0},
                          {1, 1, 1, 1} };

            int[,] y = { {1, 1, 0, 0},
                         {1, 1, 0, 0} };

            int[,] ny = { {0, 0, 1, 1},
                          {0, 0, 1, 1} };

            int[,] z = { {1, 0, 0, 1},
                         {1, 0, 0, 1} };

            int[,] nz = { {0, 1, 1, 0},
                          {0, 1, 1, 0} };

            int[,] step = new int[2,4];
            int[,] res = { {0, 0, 0, 0},
                           {0, 0, 0, 0} };

            foreach (string i in formul2)
            {
                if(i == "x")
                    step = x;
                if(i == "x̅")
                    step = nx;

                if(i == "y")
                    step = EqMatrixThree(step, y);
                if(i == "y̅")
                    step = EqMatrixThree(step, ny);
                
                if(i == "z")
                    step = EqMatrixThree(step, z);
                if(i == "z̅")
                    step = EqMatrixThree(step, nz);

                if (i == "∨" || i == " ")
                    res = SummMatrixThree(step, res);

            }
            return res;
        }
        public int[,] MapFour(string[] formul2)
        {
            int[,] x = { {1, 1, 1, 1},
                         {0, 0, 0, 0},
                         {0, 0, 0, 0 },
                         {1, 1, 1, 1 } };

            int[,] nx = { {0, 0, 0, 0},
                          {1, 1, 1, 1},
                          {1, 1, 1, 1 },
                          {0, 0, 0, 0 } };

            int[,] y = { {1, 1, 0, 0},
                         {1, 1, 0, 0},
                         {1, 1, 0, 0},
                         {1, 1, 0, 0} };

            int[,] ny = { {0, 0, 1, 1},
                          {0, 0, 1, 1},
                          {0, 0, 1, 1},
                          {0, 0, 1, 1} };

            int[,] z = { {1, 0, 0, 1},
                         {1, 0, 0, 1},
                         {1, 0, 0, 1},
                         {1, 0, 0, 1} };

            int[,] nz = { {0, 1, 1, 0},
                          {0, 1, 1, 0},
                          {0, 1, 1, 0},
                          {0, 1, 1, 0} };

            int[,] w = { {1, 0, 0, 1},
                         {1, 0, 0, 1},
                         {1, 0, 0, 1},
                         {1, 0, 0, 1} };

            int[,] nw = { {0, 1, 1, 0},
                          {0, 1, 1, 0},
                          {0, 1, 1, 0},
                          {0, 1, 1, 0} };

            int[,] step = x;
            int[,] res = { {0, 0, 0, 0},
                           {0, 0, 0, 0},
                           {0, 0, 0, 0},
                           {0, 0, 0, 0} };

            foreach (string i in formul2)
            {
                if (i == "x")
                    step = x;
                if (i == "x̅")
                    step = nx;

                if (i == "y")
                    step = EqMatrixFour(step, y);
                if (i == "y̅")
                    step = EqMatrixFour(step, ny);

                if (i == "z")
                    step = EqMatrixFour(step, z);
                if (i == "z̅")
                    step = EqMatrixFour(step, nz);
                
                if (i == "w")
                    step = EqMatrixFour(step, w);
                if (i == "w̅")
                    step = EqMatrixFour(step, nw);

                if (i == "∨")
                    res = SummMatrixFour(step, res);

            }
            return res;
        }

        public int[,] EqMatrixThree(int[,] x, int[,] y)
        {
            int[,] res = new int[2, 4];

            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    res[i, j] = x[i, j] * y[i, j];
                }
            }

            return res;
        }
        
        public int[,] SummMatrixThree(int[,] arr1, int[,] arr2)
        {
            int[,] res = new int[2, 4];

            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    res[i, j] = arr1[i, j] + arr2[i, j];
                }
            }

            return res;
        }

        public int[,] EqMatrixFour(int[,] x, int[,] y)
        {
            int[,] res = new int[4,4];

            for(int i = 0; i < 4; i++)
            {
                for(int j = 0; j < 4; j++)
                {
                    res[i, j] = x[i, j] * y[i, j];
                }
            }

            return res;
        }
        public int[,] SummMatrixFour(int[,] x, int[,] y)
        {
            int[,] res = new int[4,4];

            for(int i = 0; i < 4; i++)
            {
                for(int j = 0; j < 4; j++)
                {
                    res[i, j] = x[i, j] + y[i, j];
                }
            }

            return res;
        }
        void printBoard(DataGridView dgv, int[,] board)
        {
            var columns = board.GetUpperBound(1) + 1; //Number of columns
            var rows = board.GetUpperBound(0) + 1;    //Number of rows

            //Add columns (name, text)
            for (int c = 0; c < columns; c++)
            {

                if (c == columns - 1)
                {
                    dgv.Columns.Add($"{columns + 1}", $"ƒ(Ꭓn)");
                    dgv.Columns[columns - 1].Width = 30;
                    dgv.Columns[c].SortMode = DataGridViewColumnSortMode.NotSortable;
                    break;
                }

                dgv.Columns.Add($"{c + 1}", $"Ꭓ{c + 1}");
                dgv.Columns[c].Width = 30;
                dgv.Columns[c].SortMode = DataGridViewColumnSortMode.NotSortable;

            }

            //Add rows
            for (int r = 0; r < rows; r++)
            {
                //Slice 2d array and get the row
                var row = Enumerable.Range(0, columns).Select(c => (object)board[r, c]).ToArray();
                //Add the row
                dgv.Rows.Add(row);
            }
        }

    }
}
