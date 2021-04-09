using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;

namespace KarnOMap
{
    public partial class Form1 : System.Windows.Forms.Form
    {
        public Form1()
        {
            InitializeComponent();

            variables.Items.Add(3);
            variables.Items.Add(4);
        }

        void printBoard(DataGridView dgv, byte[,] board)
        {
            var columns = board.GetUpperBound(1) + 1; //Number of columns
            var rows = board.GetUpperBound(0) + 1;    //Number of rows

            //Add columns (name, text)
            for (int c = 0; c < columns; c++)
            {

                if (c == columns - 1)
                {
                    dgv.Columns.Add($"{columns + 1}", $"ƒ(Ꭓn)");
                    dgv.Columns[columns - 1].Width = 36;
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

        private void OK_Click(object sender, EventArgs e)
        {
            int n = Convert.ToInt32(variables.Text);

            int m = Convert.ToInt32(Math.Pow(2, n));

            byte[,] arr = new byte[m, n + 1];

            int vall;

            int k;
            int k2;

            for (int i = 0; i < m; i += 2)
            {
                k = i;
                k2 = i + 1;

                for (int j = n - 1; j >= 0; j--)
                {
                    vall = k % 2;
                    k = k / 2;
                    arr[i, j] = Convert.ToByte(vall);

                    vall = k2 % 2;
                    k2 = k2 / 2;
                    arr[i + 1, j] = Convert.ToByte(vall);
                }
            }


            tabl.Rows.Clear();
            tabl.Columns.Clear();

            printBoard(tabl, arr);

            int marg;

            if (n > 4)
            {
                marg = 30 * n + 17 + 36;
                tabl.Width = marg;
            }
            else
            {
                marg = 30 * n + 36;
                tabl.Width = marg;
            }

            marg = (600 - marg) / 2;
            tabl.Left = marg;
        }

        private void Calc_Click(object sender, EventArgs e)
        {
            int[,] data = new int[tabl.RowCount, tabl.ColumnCount];

            int cnt = 0;

            for (int i = 0; i < tabl.RowCount; i++)
            {
                for (int j = 0; j < tabl.ColumnCount; j++)
                {
                    data[i, j] = Convert.ToInt32(tabl[j, i].Value);
                }
                if (data[i, tabl.ColumnCount - 1] == 1)
                    cnt++;
            }

            string[] result = new string[cnt];
            string vall = "";
            cnt = 0;

            for (int i = 0; i < tabl.RowCount; i++)
            {
                if (data[i, tabl.ColumnCount - 1] == 1)
                {
                    for (int j = 0; j < tabl.ColumnCount - 1; j++)
                    {
                        if (j == 0)
                        {
                            if (data[i, j] == 0)
                                vall += "X̅" + (j + 1).ToString();
                            if (data[i, j] == 1)
                                vall += "X" + (j + 1).ToString();
                        }
                        else
                        {
                            if (data[i, j] == 0)
                                vall += "X̅" + (j + 1).ToString();
                            if (data[i, j] == 1)
                                vall += "X" + (j + 1).ToString();
                        }
                    }

                    result[cnt] = vall;
                    vall = "";
                    cnt++;
                }
            }

            cnt = 0;

            foreach (string r in result)
            {
                if (r == null)
                {
                    break;
                }
                if (cnt > 0)
                    vall += " ∨ " + r;
                if (cnt == 0)
                {
                    vall += r;
                    cnt++;
                }
            }

            int n = Convert.ToInt32(variables.Text);
            Form2 newForm = new Form2(vall, n);
            newForm.Show();
        }

        private void variables_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private string pattern = "^[0-1]{0,2}$";

        private void tabl_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            tabl.EditingControl.KeyPress -= EditingControl_KeyPress;
            tabl.EditingControl.KeyPress += EditingControl_KeyPress;
        }

        private void EditingControl_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar))
            {
                Control editingControl = (Control)sender;
                if (!Regex.IsMatch(editingControl.Text + e.KeyChar, pattern))
                    e.Handled = true;
            }
        }
    }
}
