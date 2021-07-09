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

        private void xos(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (b.Text == "")
            {
                if (plyr1.ForeColor == Color.Red)
                {
                    b.Text = "X";
                    plyr1.ForeColor = Color.Black;
                    plyr2.ForeColor = Color.Red;
                }
                else if (plyr2.ForeColor == Color.Red)
                {
                    b.Text = "O";
                    plyr1.ForeColor = Color.Red;
                    plyr2.ForeColor = Color.Black;
                }
                if (b == xo1)
                {
                    if (((xo1.Text == xo2.Text) && (xo2.Text == xo3.Text)) || ((xo1.Text == xo4.Text) && (xo4.Text == xo7.Text)) || ((xo1.Text == xo5.Text) && (xo5.Text == xo9.Text)))
                    {
                        result.Visible = true;
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
                        if (b.Text == "O")
                        {
                            opic.Visible = true;
                        }
                        else if (b.Text == "X")
                        {
                            xpic.Visible = true;
                        }
                    }
                }
                else if (b == xo2)
                {
                    if (((xo1.Text == xo2.Text) && (xo2.Text == xo3.Text)) || ((xo8.Text == xo5.Text) && (xo5.Text == xo2.Text)))
                    {
                        generateResult();
                        if (b.Text == "O")
                        {
                            opic.Visible = true;
                        }
                        else if (b.Text == "X")
                        {
                            xpic.Visible = true;
                        }
                    }
                }
                else if (b == xo3)
                {
                    if (((xo1.Text == xo2.Text) && (xo2.Text == xo3.Text)) || ((xo3.Text == xo6.Text) && (xo6.Text == xo9.Text)) || ((xo3.Text == xo5.Text) && (xo5.Text == xo7.Text)))
                    {
                        generateResult();
                        if (b.Text == "O")
                        {
                            opic.Visible = true;
                        }
                        else if (b.Text == "X")
                        {
                            xpic.Visible = true;
                        }
                    }
                }
                else if (b == xo4)
                {
                    if (((xo1.Text == xo4.Text) && (xo4.Text == xo7.Text)) || ((xo4.Text == xo5.Text) && (xo5.Text == xo6.Text)))
                    {
                        generateResult();
                        if (b.Text == "O")
                        {
                            opic.Visible = true;
                        }
                        else if (b.Text == "X")
                        {
                            xpic.Visible = true;
                        }
                    }
                }
                else if (b == xo5)
                {
                    if (((xo4.Text == xo5.Text) && (xo5.Text == xo6.Text)) || ((xo1.Text == xo5.Text) && (xo5.Text == xo9.Text)) || ((xo3.Text == xo5.Text) && (xo5.Text == xo7.Text)) || ((xo8.Text == xo5.Text) && (xo5.Text == xo2.Text)))
                    {
                        generateResult();
                        if (b.Text == "O")
                        {
                            opic.Visible = true;
                        }
                        else if (b.Text == "X")
                        {
                            xpic.Visible = true;
                        }
                    }
                }
                else if (b == xo6)
                {
                    if (((xo4.Text == xo5.Text) && (xo5.Text == xo6.Text)) || ((xo3.Text == xo6.Text) && (xo6.Text == xo9.Text)))
                    {
                        generateResult();
                        if (b.Text == "O")
                        {
                            opic.Visible = true;
                        }
                        else if (b.Text == "X")
                        {
                            xpic.Visible = true;
                        }
                    }
                }
                else if (b == xo7)
                {
                    if (((xo1.Text == xo4.Text) && (xo4.Text == xo7.Text)) || ((xo3.Text == xo5.Text) && (xo5.Text == xo7.Text)) || ((xo7.Text == xo8.Text) && (xo8.Text == xo9.Text)))
                    {
                        generateResult();
                        if (b.Text == "O")
                        {
                            opic.Visible = true;
                        }
                        else if (b.Text == "X")
                        {
                            xpic.Visible = true;
                        }
                    }
                }
                else if (b == xo8)
                {
                    if (((xo7.Text == xo8.Text) && (xo8.Text == xo9.Text)) || ((xo8.Text == xo5.Text) && (xo5.Text == xo2.Text)))
                    {
                        generateResult();
                        if (b.Text == "O")
                        {
                            opic.Visible = true;
                        }
                        else if (b.Text == "X")
                        {
                            xpic.Visible = true;
                        }
                    }
                }
                else if (b == xo9)
                {
                    if (((xo7.Text == xo8.Text) && (xo8.Text == xo9.Text)) || ((xo1.Text == xo5.Text) && (xo5.Text == xo9.Text)) || ((xo3.Text == xo6.Text) && (xo6.Text == xo9.Text)))
                    {
                        generateResult();
                        if (b.Text == "O")
                        {
                            opic.Visible = true;
                        }
                        else if (b.Text == "X")
                        {
                            xpic.Visible = true;
                        }
                    }
                }
            }
            if (xo1.Text != "" && xo2.Text != "" && xo3.Text != "" && xo4.Text != "" && xo5.Text != "" && xo6.Text != "" && xo7.Text != "" && xo8.Text != "" && xo9.Text != "" && result.Visible == false)
            { 
                tieresult.Visible = true;
                xo4.Visible = false;
                xo1.Visible = false;
                xo3.Visible = false;
                xo2.Visible = false;
                xo6.Visible = false;
                xo7.Visible = false;
                xo5.Visible = false;
                xo8.Visible = false;
                xo9.Visible = false;
                xopic.Visible = true;
                plyr1.ForeColor = Color.Black;
                plyr2.ForeColor = Color.Black;
            }
        }

        private void restartbtn_Click(object sender, EventArgs e)
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
            xpic.Visible = false;
            opic.Visible = false;
            xopic.Visible = false;
            tieresult.Visible = false;
        }
        private void playbtn_Click(object sender, EventArgs e)
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
            exitbtn.Visible = true;
        }
        private void generateResult()
        {
            result.Visible = true;
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
        private void exitbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}