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
            pplay.Visible = true;
            pplay1.Visible = true;
            pplay2.Visible = true;
            pplay3.Visible = true;
            pplay4.Visible = true;
            pplay5.Visible = true;
            pplay6.Visible = true;
            pplay7.Visible = true;
            pplay8.Visible = true;
            plyr1.Visible = true;
            plyr2.Visible = true;
            restartbtn.Visible = true;
            playbtn.Visible = false;
            tictactoepic.Visible = false;
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void pplay_Click(object sender, EventArgs e)
        {
            pplay.Text = "X";

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_2(object sender, EventArgs e)
        {

        }
    }
}
