using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace Sudoku
{
    public partial class Main : Form
    {
        #region Variables

        private bool started = false;
        private Stopwatch sw = new Stopwatch();
        static int[,] grid = new int[9, 9];
        private int mistakes = 0;
        ToolTip toolTip = new ToolTip();
        List<string> unhiddenCells = new List<string>();

        #endregion

        public Main()
        {
            InitializeComponent();
            generateNums();
            toolTip.SetToolTip(this.button_close, "Close");
            toolTip.SetToolTip(this.button_min, "Minimize");
            toolTip.SetToolTip(this.button_help, "Help");
            toolTip.SetToolTip(this.button_delete, "Delete");
        }

        #region Events

        private void button_close_MouseHover(object sender, EventArgs e)
        {
            button_close.Image = Properties.Resources.close_red;
        }

        private void button_close_MouseLeave(object sender, EventArgs e)
        {
            button_close.Image = Properties.Resources.close;
        }

        private void button_min_MouseHover(object sender, EventArgs e)
        {
            button_min.Image = Properties.Resources.minimize_2;
        }

        private void button_min_MouseLeave(object sender, EventArgs e)
        {
            button_min.Image = Properties.Resources.minimize;
        }

        private void button_close_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do You really want to quit?", "Exit", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Dispose();
                this.Close();
            }
        }

        private void button_min_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button_play_Click(object sender, EventArgs e)
        {
            if (datagridview.Columns.Count == 0)
            {
                GameLevel gl = new GameLevel();
                if (gl.ShowDialog() == DialogResult.OK)
                {
                    createGrid();
                    generateNums();
                    datagridview.Enabled = true;
                    datagridview.Visible = true;
                    switch (gl.gameLevel)
                    {
                        case 1:
                            label_game_level.Text = "Easy";
                            break;
                        case 2:
                            label_game_level.Text = "Normal";
                            break;
                        case 3:
                            label_game_level.Text = "Hard";
                            break;
                        case 4:
                            label_game_level.Text = "Expert";
                            break;
                        default:
                            break;
                    }
                    unhideNums(gl.gameLevel);
                    started = true;
                    timer1.Start();
                    sw.Start();
                }
            }
            else
            {
                datagridview.Enabled = true;
                datagridview.Visible = true;
                started = true;
                timer1.Start();
                sw.Start();
            }
            button_play.Visible = false;
            button_pause.Visible = true;
        }

        private void button_pause_Click(object sender, EventArgs e)
        {
            button_play.Visible = true;
            button_pause.Visible = false;
            datagridview.Visible = false;
            started = false;
            timer1.Stop();
            sw.Stop();
        }

        private void button_stop_Click(object sender, EventArgs e)
        {
            mistakes = 0;
            label_game_level.Text = "";
            label_mistakes.Text = mistakes.ToString() + "/3";
            datagridview.Rows.Clear();
            datagridview.Columns.Clear();
            datagridview.Enabled = false;
            sw.Reset();
            started = false;
            button_play.Visible = true;
            button_pause.Visible = false;
            label_timer.Text = sw.Elapsed.ToString(@"hh\:mm\:ss");
            enableAllNums();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label_timer.Text = sw.Elapsed.ToString(@"hh\:mm\:ss");

        }

        private void button_help_Click(object sender, EventArgs e)
        {
            MessageBox.Show("", "", MessageBoxButtons.OKCancel);
        }

        private void datagridview_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int num = 0;
            if (unhiddenCells.Contains(e.RowIndex.ToString() + e.ColumnIndex.ToString()))
            {
                num = grid[e.RowIndex, e.ColumnIndex];
            }
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    if (num == grid[i, j])
                    {
                        datagridview.Rows[i].Cells[j].Selected = unhiddenCells.Contains(i.ToString() + j.ToString());
                    }
                }
            }
        }

        private void datagridview_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (unhiddenCells.Count == 81)
            {
                sw.Stop();
                timer1.Stop();
                datagridview.Enabled = false;
                string congrats = "Congratulations You won" + Environment.NewLine + "Game level: " + label_game_level.Text + Environment.NewLine +
                "Time: " + label_timer.Text + Environment.NewLine + "Do You want to start new game?";
                if (MessageBox.Show(congrats, "Sudoku", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    object sen = null;
                    EventArgs ev = new EventArgs();
                    button_stop_Click(sen, ev);
                    button_play_Click(sen, ev);
                }
            }
        }
       
         private void datagridview_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            Pen breakLines = new Pen(Color.Red, 2.0f);
            Pen insideLines = new Pen(Color.Black, 1.0f);
            e.Paint(e.CellBounds, DataGridViewPaintParts.All);

            if (e.RowIndex == 2 || e.RowIndex == 5)
            {
                e.Graphics.DrawLine(breakLines, 0, e.CellBounds.Bottom - 1, e.CellBounds.Right, e.CellBounds.Bottom - 1);
            }
            else
            {
                e.Graphics.DrawLine(insideLines, 0, e.CellBounds.Bottom - 1, e.CellBounds.Right, e.CellBounds.Bottom - 1);
            }
            if (e.ColumnIndex == 2 || e.ColumnIndex == 5)
            {
                e.Graphics.DrawLine(breakLines, e.CellBounds.Right - 1, 0,
                                              e.CellBounds.Right - 1, e.CellBounds.Bottom - 1);
            }
            else
            {
                e.Graphics.DrawLine(insideLines, e.CellBounds.Right - 1, 0,
                                                  e.CellBounds.Right - 1, e.CellBounds.Bottom - 1);
            }

            e.Handled = true;
        }

        #endregion

        #region Datagridview

        private void createGrid()
        {
            datagridview.Rows.Clear();
            datagridview.Columns.Clear();
            datagridview.Refresh();
            for (int i = 0; i < 9; i++)
            {
                DataGridViewImageColumn ic = new DataGridViewImageColumn();
                ic.HeaderText = "";
                ic.Name = "col" + (i + 1).ToString();
                ic.Width = datagridview.Width / 9;
                ic.Image = Properties.Resources.help_36px;
                datagridview.Columns.Add(ic);
                datagridview.Rows.Add();
                datagridview.Rows[i].Height = datagridview.Height / 9;
            }
        }

        #endregion       

        #region NumsClick     

        private void num1_Click(object sender, EventArgs e)
        {
            if (!num_1.Enabled)
            {
                return;
            }
            foreach (DataGridViewImageCell item in datagridview.SelectedCells)
            {
                if (isSafe(1, item.RowIndex, item.ColumnIndex))
                {
                    unhiddenCells.Add(item.RowIndex.ToString() + item.ColumnIndex.ToString());
                    num_1.Enabled = !checkCount(1);
                    DataGridViewImageCell cell = item as DataGridViewImageCell;
                    cell.Value = Properties.Resources.num1;
                   
                }
            }
        }

        private void num2_Click(object sender, EventArgs e)
        {
            if (!num_2.Enabled)
            {
                return;
            }
            foreach (DataGridViewImageCell item in datagridview.SelectedCells)
            {
                if (isSafe(2, item.RowIndex, item.ColumnIndex))
                {
                    unhiddenCells.Add(item.RowIndex.ToString() + item.ColumnIndex.ToString());
                    num_2.Enabled = !checkCount(2);
                    DataGridViewImageCell cell = item as DataGridViewImageCell;
                    cell.Value = Properties.Resources.num2;
                   
                }
            }
        }

        private void num3_Click(object sender, EventArgs e)
        {
            if (!num_3.Enabled)
            {
                return;
            }
            foreach (DataGridViewImageCell item in datagridview.SelectedCells)
            {
                if (isSafe(3, item.RowIndex, item.ColumnIndex))
                {
                    unhiddenCells.Add(item.RowIndex.ToString() + item.ColumnIndex.ToString());
                    num_3.Enabled = !checkCount(3);
                    DataGridViewImageCell cell = item as DataGridViewImageCell;
                    cell.Value = Properties.Resources.num3;
                    
                }
            }
        }

        private void num4_Click(object sender, EventArgs e)
        {
            if (!num_4.Enabled)
            {
                return;
            }
            foreach (DataGridViewImageCell item in datagridview.SelectedCells)
            {
                if (isSafe(4, item.RowIndex, item.ColumnIndex))
                {
                    unhiddenCells.Add(item.RowIndex.ToString() + item.ColumnIndex.ToString());
                    num_4.Enabled = !checkCount(4);
                    DataGridViewImageCell cell = item as DataGridViewImageCell;
                    cell.Value = Properties.Resources.num4;
                    
                }
            }
        }

        private void num5_Click(object sender, EventArgs e)
        {
            if (!num_5.Enabled)
            {
                return;
            }
            foreach (DataGridViewImageCell item in datagridview.SelectedCells)
            {
                if (isSafe(5, item.RowIndex, item.ColumnIndex))
                {
                    unhiddenCells.Add(item.RowIndex.ToString() + item.ColumnIndex.ToString());
                    num_5.Enabled = !checkCount(5);
                    DataGridViewImageCell cell = item as DataGridViewImageCell;
                    cell.Value = Properties.Resources.num5;
                    
                }
            }
        }

        private void num6_Click(object sender, EventArgs e)
        {
            if (!num_6.Enabled)
            {
                return;
            }
            foreach (DataGridViewImageCell item in datagridview.SelectedCells)
            {
                if (isSafe(6, item.RowIndex, item.ColumnIndex))
                {
                    unhiddenCells.Add(item.RowIndex.ToString() + item.ColumnIndex.ToString());
                    num_6.Enabled = !checkCount(6);
                    DataGridViewImageCell cell = item as DataGridViewImageCell;
                    cell.Value = Properties.Resources.num6;                    
                }
            }
        }

        private void num7_Click(object sender, EventArgs e)
        {
            if (!num_7.Enabled)
            {
                return;
            }
            foreach (DataGridViewImageCell item in datagridview.SelectedCells)
            {
                if (isSafe(7, item.RowIndex, item.ColumnIndex))
                {
                    unhiddenCells.Add(item.RowIndex.ToString() + item.ColumnIndex.ToString());
                    DataGridViewImageCell cell = item as DataGridViewImageCell;
                    num_7.Enabled = !checkCount(7);
                    cell.Value = Properties.Resources.num7;
                    
                }
            }
        }

        private void num8_Click(object sender, EventArgs e)
        {
            if (!num_8.Enabled)
            {
                return;
            }
            foreach (DataGridViewImageCell item in datagridview.SelectedCells)
            {
                if (isSafe(8, item.RowIndex, item.ColumnIndex))
                {
                    unhiddenCells.Add(item.RowIndex.ToString() + item.ColumnIndex.ToString());
                    DataGridViewImageCell cell = item as DataGridViewImageCell;
                    num_8.Enabled = !checkCount(8);
                    cell.Value = Properties.Resources.num8;
                    
                }
            }
        }

        private void num9_Click(object sender, EventArgs e)
        {
            if (!num_9.Enabled)
            {
                return;
            }
            foreach (DataGridViewImageCell item in datagridview.SelectedCells)
            {
                if (isSafe(9, item.RowIndex, item.ColumnIndex))
                {
                    unhiddenCells.Add(item.RowIndex.ToString() + item.ColumnIndex.ToString());
                    DataGridViewImageCell cell = item as DataGridViewImageCell;
                    num_9.Enabled = !checkCount(9);
                    cell.Value = Properties.Resources.num9;
                    
                }
            }
        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewImageCell item in datagridview.SelectedCells)
            {
                DataGridViewImageCell cell = item as DataGridViewImageCell;
                cell.Value = Properties.Resources.help_36px;
                if (unhiddenCells.Contains(item.RowIndex.ToString() + item.ColumnIndex.ToString()))
                {
                    unhiddenCells.Remove(item.RowIndex.ToString() + item.ColumnIndex.ToString());
                }
            }
        }

        private void datagridview_KeyPress(object sender, KeyPressEventArgs e)
        {
            EventArgs ev = new EventArgs();
            switch (e.KeyChar.ToString())
            {
                case "1":
                    num1_Click(sender, ev);
                    break;
                case "2":
                    num2_Click(sender, ev);
                    break;
                case "3":
                    num3_Click(sender, ev);
                    break;
                case "4":
                    num4_Click(sender, ev);
                    break;
                case "5":
                    num5_Click(sender, ev);
                    break;
                case "6":
                    num6_Click(sender, ev);
                    break;
                case "7":
                    num7_Click(sender, ev);
                    break;
                case "8":
                    num8_Click(sender, ev);
                    break;
                case "9":
                    num9_Click(sender, ev);
                    break;
                case "\b":
                    button_delete_Click(sender, ev);
                    break;
                default:
                    break;
            }
        }

        #endregion

        #region Methods

     
        private bool checkCount(int num)
        {
            int count = 0;
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    if (num == grid[i, j] && unhiddenCells.Contains(i.ToString() + j.ToString()))
                    {
                        count++;
                    }
                }
            }
            return count == 9;
        }

        private void unhideNums(int level)
        {
            Random rnd = new Random();
            int col = 0;
            int row = 0;
            int unhideCount = 0;

            switch (level)
            {
                case 1:
                    unhideCount = 38;
                    break;
                case 2:
                    unhideCount = 30;
                    break;
                case 3:
                    unhideCount = 26;
                    break;
                case 4:
                    unhideCount = 22;
                    break;
                default:
                    break;
            }
            unhiddenCells.Clear();
            for (int i = 0; i < unhideCount; i++)
            {
                col = rnd.Next(0, 8);
                row = rnd.Next(0, 8);
                while (unhiddenCells.Contains(row.ToString() + col.ToString()))
                {
                    col = rnd.Next(0, 8);
                    row = rnd.Next(0, 8);
                }
                unhiddenCells.Add(row.ToString() + col.ToString());
                switch (grid[row, col])
                {
                    case 1:
                        datagridview.Rows[row].Cells[col].Value = Properties.Resources.num1;
                        break;
                    case 2:
                        datagridview.Rows[row].Cells[col].Value = Properties.Resources.num2;
                        break;
                    case 3:
                        datagridview.Rows[row].Cells[col].Value = Properties.Resources.num3;
                        break;
                    case 4:
                        datagridview.Rows[row].Cells[col].Value = Properties.Resources.num4;
                        break;
                    case 5:
                        datagridview.Rows[row].Cells[col].Value = Properties.Resources.num5;
                        break;
                    case 6:
                        datagridview.Rows[row].Cells[col].Value = Properties.Resources.num6;
                        break;
                    case 7:
                        datagridview.Rows[row].Cells[col].Value = Properties.Resources.num7;
                        break;
                    case 8:
                        datagridview.Rows[row].Cells[col].Value = Properties.Resources.num8;
                        break;
                    case 9:
                        datagridview.Rows[row].Cells[col].Value = Properties.Resources.num9;
                        break;
                    default:
                        break;
                }
            }
        }

        private bool isSafe(int num, int row, int col)
        {
            if (datagridview.Columns.Count == 0)
            {
                return false;
            }
            bool issafe = true;
            for (int i = 0; i < 9; i++)
            {
                if (grid[row, i] == num && i != col)
                {
                    issafe = false;
                    break;
                }
                if (grid[i, col] == num && i != row)
                {
                    issafe = false;
                    break;
                }
            }
            if (!issafe)
            {
                mistakes++;
                if (mistakes == 3)
                {
                    object sender = null;
                    EventArgs ev = null;
                    MessageBox.Show("You do maximum mistakes.", "Game over", MessageBoxButtons.OK);
                    button_stop_Click(sender, ev);
                    return false;
                }
                else
                {
                    label_mistakes.Text = mistakes.ToString() + "/3";
                    MessageBox.Show("Wrong num in " + (row + 1).ToString() + "x" + (col + 1).ToString() + " cell", "Wrong", MessageBoxButtons.OK);
                }

            }
            else
            {
                datagridview.Rows[row].Cells[col].Selected = false;
            }
            return issafe;
        }

        private void enableAllNums() {
            num_1.Enabled = true;
            num_2.Enabled = true;
            num_3.Enabled = true;
            num_4.Enabled = true;
            num_5.Enabled = true;
            num_6.Enabled = true;
            num_7.Enabled = true;
            num_8.Enabled = true;
            num_9.Enabled = true;
        }

        #endregion

        #region numsGenerator

        private void generateNums()
        {
            Init(ref grid);
            Update(ref grid, 10);
        }

        private void Update(ref int[,] grid, int shuffleLevel)
        {
            for (int repeat = 0; repeat < shuffleLevel; repeat++)
            {
                Random rand = new Random(Guid.NewGuid().GetHashCode());
                Random rand2 = new Random(Guid.NewGuid().GetHashCode());
                ChangeTwoCell(ref grid, rand.Next(1, 9), rand2.Next(1, 9));
            }
        }

        private void Init(ref int[,] grid)
        {
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    grid[i, j] = (i * 3 + i / 3 + j) % 9 + 1;

                }
            }
        }

        private void ChangeTwoCell(ref int[,] grid, int findValue1, int findValue2)
        {
            int xParm1, yParm1, xParm2, yParm2;
            xParm1 = yParm1 = xParm2 = yParm2 = 0;
            for (int i = 0; i < 9; i += 3)
            {
                for (int k = 0; k < 9; k += 3)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        for (int z = 0; z < 3; z++)
                        {
                            if (grid[i + j, k + z] == findValue1)
                            {
                                xParm1 = i + j;
                                yParm1 = k + z;

                            }
                            if (grid[i + j, k + z] == findValue2)
                            {
                                xParm2 = i + j;
                                yParm2 = k + z;

                            }
                        }
                    }
                    grid[xParm1, yParm1] = findValue2;
                    grid[xParm2, yParm2] = findValue1;
                }
            }
        }
       
         #endregion
       
        
        

    }
}
