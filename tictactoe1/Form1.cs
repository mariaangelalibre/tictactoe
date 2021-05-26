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

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (plyr1.ForeColor == Color.Red)
            {
                xo1.Text = "X";
            }
            else
            {
                xo1.Text = "O";
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void pplay_Click(object sender, EventArgs e)
        {
            xo4.Text = "X";

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
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
            }
            else
            {
                xo1.Text = "O";
            }


        }
    }
}
