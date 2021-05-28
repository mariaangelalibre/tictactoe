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
                xo8.Text = "X";
                plyr1.ForeColor = Color.Black;
                plyr2.ForeColor = Color.Red;
                xo8.Enabled = false;
            }
            else if (plyr2.ForeColor == Color.Red)
            {
                xo8.Text = "O";
                plyr1.ForeColor = Color.Red;
                plyr2.ForeColor = Color.Black;
                xo8.Enabled = false;
            }
            if ((xo7.Text == xo8.Text) && (xo8.Text == xo9.Text))
            {
                result.Visible = true;
                result.Text = "WINNER";
            }
            else if ((xo2.Text == xo5.Text) && (xo5.Text == xo8.Text))
            {
                result.Visible = true;
                result.Text = "WINNER";
            }
            else if (xo1.Text != "" && xo2.Text != "" && xo3.Text != "" && xo4.Text != "" && xo5.Text != "" && xo6.Text != "" && xo7.Text != "" && xo8.Text != "" && xo9.Text != "" && result.Text != "WINNER")
            {
                result.Visible = true;
                result.Text = "TIE";
            }
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            xo1.Text = "";
            xo2.Text = "";
            xo3.Text = "";
            xo4.Text = "";
            xo5.Text = "";
            xo6.Text = "";
            xo7.Text = "";
            xo8.Text = "";
            xo9.Text = "";
            xo1.Enabled = true;
            xo2.Enabled = true;
            xo3.Enabled = true;
            xo4.Enabled = true;
            xo5.Enabled = true;
            xo6.Enabled = true;
            xo7.Enabled = true;
            xo8.Enabled = true;
            xo9.Enabled = true;
            xo1.Visible = true;
            xo2.Visible = true;
            xo3.Visible = true;
            xo4.Visible = true;
            xo5.Visible = true;
            xo6.Visible = true;
            xo7.Visible = true;
            xo8.Visible = true;
            xo9.Visible = true;
            result.Visible = false;
            plyr1.ForeColor = Color.Red;
            plyr2.ForeColor = Color.Black;
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
                plyr2.ForeColor = Color.Red;
                xo1.Enabled = false;
            }
            else if (plyr2.ForeColor == Color.Red)
            {
                xo1.Text = "O";
                plyr1.ForeColor = Color.Red;
                plyr2.ForeColor = Color.Black;
                xo1.Enabled = false;
            }
            if ((xo1.Text == xo2.Text) && (xo2.Text == xo3.Text))
            {
                result.Visible = true;
                result.Text = "WINNER";
                xo4.Visible = false;
                xo1.Visible = false;
                xo3.Visible = false;
                xo2.Visible = false;
                xo6.Visible = false;
                xo7.Visible = false;
                xo5.Visible = false;
                xo8.Visible = false;
                xo9.Visible = false;
            }
            else if ((xo1.Text == xo4.Text) && (xo4.Text == xo7.Text))
            {
                result.Visible = true;
                result.Text = "WINNER";

            }
            else if ((xo1.Text == xo5.Text) && (xo5.Text == xo9.Text))
            {
                result.Visible = true;
                result.Text = "WINNER";
            }
            else if (xo1.Text != "" && xo2.Text != "" && xo3.Text != "" && xo4.Text != "" && xo5.Text != "" && xo6.Text != "" && xo7.Text != "" && xo8.Text != "" && xo9.Text != "" && result.Text != "WINNER")
            {
                result.Visible = true;
                result.Text = "TIE";
            }

        }

        private void xo3_Click(object sender, EventArgs e)
        {
            if (plyr1.ForeColor == Color.Red)
            {
                xo3.Text = "X";
                plyr1.ForeColor = Color.Black;
                plyr2.ForeColor = Color.Red;
                xo3.Enabled = false;
            }
            else if (plyr2.ForeColor == Color.Red)
            {
                xo3.Text = "O";
                plyr1.ForeColor = Color.Red;
                plyr2.ForeColor = Color.Black;
                xo3.Enabled = false;
            }
            if ((xo1.Text == xo2.Text) && (xo2.Text == xo3.Text))
            {
                result.Visible = true;
                result.Text = "WINNER";
            }
            else if ((xo3.Text == xo5.Text) && (xo5.Text == xo7.Text))
            {
                result.Visible = true;
                result.Text = "WINNER";
            }
            else if ((xo3.Text == xo6.Text) && (xo6.Text == xo9.Text))
            {
                result.Visible = true;
                result.Text = "WINNER";
            }
            else if (xo1.Text != "" && xo2.Text != "" && xo3.Text != "" && xo4.Text != "" && xo5.Text != "" && xo6.Text != "" && xo7.Text != "" && xo8.Text != "" && xo9.Text != "" && result.Text != "WINNER")
            {
                result.Visible = true;
                result.Text = "TIE";
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
                plyr2.ForeColor = Color.Red;
                xo7.Enabled = false;
            }
            else if (plyr2.ForeColor == Color.Red)
            {
                xo7.Text = "O";
                plyr1.ForeColor = Color.Red;
                plyr2.ForeColor = Color.Black;
                xo7.Enabled = false;
            }
            if ((xo1.Text == xo4.Text) && (xo4.Text == xo7.Text))
            {
                result.Visible = true;
                result.Text = "WINNER";
            }
            else if ((xo3.Text == xo5.Text) && (xo5.Text == xo7.Text))
            {
                result.Visible = true;
                result.Text = "WINNER";
            }
            else if ((xo7.Text == xo8.Text) && (xo8.Text == xo9.Text))
            {
                result.Visible = true;
                result.Text = "WINNER";
            }
            else if (xo1.Text != "" && xo2.Text != "" && xo3.Text != "" && xo4.Text != "" && xo5.Text != "" && xo6.Text != "" && xo7.Text != "" && xo8.Text != "" && xo9.Text != "" && result.Text != "WINNER")
            {
                result.Visible = true;
                result.Text = "TIE";
            }

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (plyr1.ForeColor == Color.Red)
            {
                xo4.Text = "X";
                plyr1.ForeColor = Color.Black;
                plyr2.ForeColor = Color.Red;
                xo4.Enabled = false;
            }
            else if (plyr2.ForeColor == Color.Red)
            {
                xo4.Text = "O";
                plyr1.ForeColor = Color.Red;
                plyr2.ForeColor = Color.Black;
                xo4.Enabled = false;
            }
            if ((xo1.Text == xo4.Text) && (xo4.Text == xo7.Text))
            {
                result.Visible = true;
                result.Text = "WINNER";
            }
            else if ((xo4.Text == xo5.Text) && (xo5.Text == xo6.Text))
            {
                result.Visible = true;
                result.Text = "WINNER";
            }
            else if (xo1.Text != "" && xo2.Text != "" && xo3.Text != "" && xo4.Text != "" && xo5.Text != "" && xo6.Text != "" && xo7.Text != "" && xo8.Text != "" && xo9.Text != "" && result.Text != "WINNER")
            {
                result.Visible = true;
                result.Text = "TIE";
            }

        }

        private void xo9_Click(object sender, EventArgs e)
        {
            if (plyr1.ForeColor == Color.Red)
            {
                xo9.Text = "X";
                plyr1.ForeColor = Color.Black;
                plyr2.ForeColor = Color.Red;
                xo9.Enabled = false;
            }
            else if (plyr2.ForeColor == Color.Red)
            {
                xo9.Text = "O";
                plyr1.ForeColor = Color.Red;
                plyr2.ForeColor = Color.Black;
                xo9.Enabled = false;
            }
            if ((xo1.Text == xo5.Text) && (xo5.Text == xo9.Text))
            {
                result.Visible = true;
                result.Text = "WINNER";
            }
            else if ((xo3.Text == xo6.Text) && (xo6.Text == xo9.Text))
            {
                result.Visible = true;
                result.Text = "WINNER";
            }
            else if ((xo7.Text == xo8.Text) && (xo8.Text == xo9.Text))
            {
                result.Visible = true;
                result.Text = "WINNER";
            }
            else if (xo1.Text != "" && xo2.Text != "" && xo3.Text != "" && xo4.Text != "" && xo5.Text != "" && xo6.Text != "" && xo7.Text != "" && xo8.Text != "" && xo9.Text != "" && result.Text != "WINNER")
            {
                result.Visible = true;
                result.Text = "TIE";
            }

        }

        private void xo2_Click_1(object sender, EventArgs e)
        {
            if (plyr1.ForeColor == Color.Red)
            {
                xo2.Text = "X";
                plyr1.ForeColor = Color.Black;
                plyr2.ForeColor = Color.Red;
                xo2.Enabled = false;
            }
            else if (plyr2.ForeColor == Color.Red)
            {
                xo2.Text = "O";
                plyr1.ForeColor = Color.Red;
                plyr2.ForeColor = Color.Black;
                xo2.Enabled = false;
            }
            if ((xo1.Text == xo2.Text) && (xo2.Text == xo3.Text))
            {
                result.Visible = true;
                result.Text = "WINNER";
            }
            else if ((xo2.Text == xo5.Text) && (xo5.Text == xo8.Text))
            {
                result.Visible = true;
                result.Text = "WINNER";
            }
            else if (xo1.Text != "" && xo2.Text != "" && xo3.Text != "" && xo4.Text != "" && xo5.Text != "" && xo6.Text != "" && xo7.Text != "" && xo8.Text != "" && xo9.Text != "" && result.Text != "WINNER")
            {
                result.Visible = true;
                result.Text = "TIE";
            }
        }

        private void xo5_Click_1(object sender, EventArgs e)
        {
            if (plyr1.ForeColor == Color.Red)
            {
                xo5.Text = "X";
                plyr1.ForeColor = Color.Black;
                plyr2.ForeColor = Color.Red;
                xo5.Enabled = false;
            }
            else if (plyr2.ForeColor == Color.Red)
            {
                xo5.Text = "O";
                plyr1.ForeColor = Color.Red;
                plyr2.ForeColor = Color.Black;
                xo5.Enabled = false;
            }
            if ((xo1.Text == xo5.Text) && (xo5.Text == xo9.Text))
            {
                result.Visible = true;
                result.Text = "WINNER";
            }
            else if ((xo3.Text == xo5.Text) && (xo5.Text == xo7.Text))
            {
                result.Visible = true;
                result.Text = "WINNER";
            }
            else if ((xo2.Text == xo5.Text) && (xo5.Text == xo8.Text))
            {
                result.Visible = true;
                result.Text = "WINNER";
            }
            else if ((xo4.Text == xo5.Text) && (xo5.Text == xo6.Text))
            {
                result.Visible = true;
                result.Text = "WINNER";
            }
            else if (xo1.Text != "" && xo2.Text != "" && xo3.Text != "" && xo4.Text != "" && xo5.Text != "" && xo6.Text != "" && xo7.Text != "" && xo8.Text != "" && xo9.Text != "" && result.Text != "WINNER")
            {
                result.Visible = true;
                result.Text = "TIE";
            }
        }

        private void xo6_Click_1(object sender, EventArgs e)
        {
            if (plyr1.ForeColor == Color.Red)
            {
                xo6.Text = "X";
                plyr1.ForeColor = Color.Black;
                plyr2.ForeColor = Color.Red;
                xo6.Enabled = false;
            }
            else if (plyr2.ForeColor == Color.Red)
            {
                xo6.Text = "O";
                plyr1.ForeColor = Color.Red;
                plyr2.ForeColor = Color.Black;
                xo6.Enabled = false;
            }
            if ((xo3.Text == xo6.Text) && (xo6.Text == xo9.Text))
            {
                result.Visible = true;
                result.Text = "WINNER";
            }
            else if ((xo4.Text == xo5.Text) && (xo5.Text == xo6.Text))
            {
                result.Visible = true;
                result.Text = "WINNER";
            }
            else if (xo1.Text != "" && xo2.Text != "" && xo3.Text != "" && xo4.Text != "" && xo5.Text != "" && xo6.Text != "" && xo7.Text != "" && xo8.Text != "" && xo9.Text != "" && result.Text != "WINNER")
            {
                result.Visible = true;
                result.Text = "TIE";
            }
        }

        private void result_Click(object sender, EventArgs e)
        {
            if (result.Text != "")
            {
                xo4.Visible = false;
                xo1.Visible = false;
                xo3.Visible = false;
                xo2.Visible = false;
                xo6.Visible = false;
                xo7.Visible = false;
                xo5.Visible = false;
                xo8.Visible = false;
                xo9.Visible = false;
                plyr1.ForeColor = Color.Black;
                plyr2.ForeColor = Color.Black;
            }
        }
    }
}