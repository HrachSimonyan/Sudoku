using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sudoku
{
    public partial class GameLevel : Form
    {
        public GameLevel()
        {
            InitializeComponent();
            button_start.DialogResult = DialogResult.OK;
            button_cancel.DialogResult = DialogResult.Cancel;
        }
        public int gameLevel = 1;

        private void radioButton_easy_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton_easy.Checked)
            {
                radioButton_hard.Checked = false;
                radioButton_normal.Checked = false;
                radioButton_expert.Checked = false;
                gameLevel = 1;
            }
        }

        private void radioButton_normal_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton_normal.Checked)
            {
                gameLevel = 2;
                radioButton_hard.Checked = false;
                radioButton_easy.Checked = false;
                radioButton_expert.Checked = false;
            }
        }

        private void radioButton_hard_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton_hard.Checked)
            {
                gameLevel = 3;
                radioButton_easy.Checked = false;
                radioButton_normal.Checked = false;
                radioButton_expert.Checked = false;
            }
        }

        private void radioButton_expert_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton_expert.Checked)
            {
                gameLevel = 4;
                radioButton_easy.Checked = false;
                radioButton_normal.Checked = false;
                radioButton_hard.Checked = false;
            }
        }

        private void button_start_Click(object sender, EventArgs e)
        {            
            this.Close();
            this.Dispose();
        }

        private void button_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }

        
    }
}
