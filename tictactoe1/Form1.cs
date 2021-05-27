using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tictactoe1
{
    public partial class tform : Form
    {
        public tform()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            xo4.Visible = true;
            xo1.Visible = true;
            xo3.Visible = true;
            xo2.Visible = true;
            xo6.Visible = true;
            xo7.Visible = true;
            xo5.Visible = true;
            xo8.Visible = true;
            xo9.Visible = true;
            plyr1.Visible = true;
            plyr2.Visible = true;
            restartbtn.Visible = true;
            playbtn.Visible = false;
            tictactoepic.Visible = false;
            plyr1.ForeColor = Color.Red;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (plyr1.ForeColor == Color.Red)
            {
                xo7.Text = "X";
                plyr1.ForeColor = Color.Black;
                xo7.Enabled = false;
                plyr2.ForeColor = Color.Red;
            }
            else
            {
                xo7.Text = "O";
                plyr1.ForeColor = Color.Black;
                xo7.Enabled = false;
                plyr2.ForeColor = Color.Red;
            }

        }

        private void pplay_Click(object sender, EventArgs e)
        {
        }


        private void button1_Click_2(object sender, EventArgs e)
        {

        }

        private void plyr1_Click(object sender, EventArgs e)
        {

        }

        private void xo1_Click(object sender, EventArgs e)
        {
            if (plyr1.ForeColor == Color.Red)
            {
                xo1.Text = "X";
                plyr1.ForeColor = Color.Black;
                xo1.Enabled = false;
                plyr2.ForeColor = Color.Red;
            }
            else
            {
                xo1.Text = "O";
                plyr1.ForeColor = Color.Black;
                xo1.Enabled = false;
                plyr2.ForeColor = Color.Red;
            }

        }

        private void xo3_Click(object sender, EventArgs e)
        {
            if (plyr1.ForeColor == Color.Red)
            {
                xo3.Text = "X";
                plyr1.ForeColor = Color.Black;
                xo3.Enabled = false;
                plyr2.ForeColor = Color.Red;
            }
            else
            {
                xo3.Text = "O";
                plyr1.ForeColor = Color.Black;
                xo3.Enabled = false;
                plyr2.ForeColor = Color.Red;
            }
        }

        private void xo2_Click(object sender, EventArgs e)
        {
            if (plyr1.ForeColor == Color.Red)
            {
                xo2.Text = "X";
                plyr1.ForeColor = Color.Black;
                xo2.Enabled = false;
                plyr2.ForeColor = Color.Red;
            }
            else
            {
                xo2.Text = "O";
                plyr1.ForeColor = Color.Black;
                xo2.Enabled = false;
                plyr2.ForeColor = Color.Red;
            }
        }

        private void xo5_Click(object sender, EventArgs e)
        {
            if (plyr1.ForeColor == Color.Red)
            {
                xo5.Text = "X";
                plyr1.ForeColor = Color.Black;
                xo5.Enabled = false;
                plyr2.ForeColor = Color.Red;
            }
            else
            {
                xo5.Text = "O";
                plyr1.ForeColor = Color.Black;
                xo5.Enabled = false;
                plyr2.ForeColor = Color.Red;
            }
        }

        private void xo6_Click(object sender, EventArgs e)
        {
            if (plyr1.ForeColor == Color.Red)
            {
                xo6.Text = "X";
                plyr1.ForeColor = Color.Black;
                xo6.Enabled = false;
                plyr2.ForeColor = Color.Red;
            }
            else
            {
                xo6.Text = "O";
                plyr1.ForeColor = Color.Black;
                xo6.Enabled = false;
                plyr2.ForeColor = Color.Red;
            }

        }

        private void xo7_Click(object sender, EventArgs e)
        {
            if (plyr1.ForeColor == Color.Red)
            {
                xo7.Text = "X";
                plyr1.ForeColor = Color.Black;
                xo7.Enabled = false;
                plyr2.ForeColor = Color.Red;
            }
            else
            {
                xo7.Text = "O";
                plyr1.ForeColor = Color.Black;
                xo7.Enabled = false;
                plyr2.ForeColor = Color.Red;
            }

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (plyr1.ForeColor == Color.Red)
            {
                xo4.Text = "X";
                plyr1.ForeColor = Color.Black;
                xo4.Enabled = false;
                plyr2.ForeColor = Color.Red;
            }
            else
            {
                xo4.Text = "O";
                plyr1.ForeColor = Color.Black;
                xo4.Enabled = false;
                plyr2.ForeColor = Color.Red;
            }

        }

        private void xo9_Click(object sender, EventArgs e)
        {
            if (plyr1.ForeColor == Color.Red)
            {
                xo9.Text = "X";
                plyr1.ForeColor = Color.Black;
                xo9.Enabled = false;
                plyr2.ForeColor = Color.Red;
            }
            else
            {
                xo9.Text = "O";
                plyr1.ForeColor = Color.Black;
                xo9.Enabled = false;
                plyr2.ForeColor = Color.Red;
            }

        }
    }
}