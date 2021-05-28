
namespace tictactoe1
{
    partial class tform
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(tform));
            this.playbtn = new System.Windows.Forms.Button();
            this.xo1 = new System.Windows.Forms.Button();
            this.xo3 = new System.Windows.Forms.Button();
            this.xo6 = new System.Windows.Forms.Button();
            this.xo7 = new System.Windows.Forms.Button();
            this.xo8 = new System.Windows.Forms.Button();
            this.xo9 = new System.Windows.Forms.Button();
            this.tictactoepic = new System.Windows.Forms.PictureBox();
            this.restartbtn = new System.Windows.Forms.Button();
            this.plyr2 = new System.Windows.Forms.Label();
            this.plyr1 = new System.Windows.Forms.Label();
            this.xo4 = new System.Windows.Forms.Button();
            this.result = new System.Windows.Forms.Label();
            this.xo2 = new System.Windows.Forms.Button();
            this.xo5 = new System.Windows.Forms.Button();
            this.opic = new System.Windows.Forms.PictureBox();
            this.xpic = new System.Windows.Forms.PictureBox();
            this.xopic = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.tictactoepic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.opic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xpic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xopic)).BeginInit();
            this.SuspendLayout();
            // 
            // playbtn
            // 
            this.playbtn.Font = new System.Drawing.Font("Lucida Console", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.playbtn.Location = new System.Drawing.Point(23, 196);
            this.playbtn.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.playbtn.Name = "playbtn";
            this.playbtn.Size = new System.Drawing.Size(298, 81);
            this.playbtn.TabIndex = 0;
            this.playbtn.Text = "Play";
            this.playbtn.UseVisualStyleBackColor = true;
            this.playbtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // xo1
            // 
            this.xo1.Font = new System.Drawing.Font("Lucida Console", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.xo1.Location = new System.Drawing.Point(12, 12);
            this.xo1.Name = "xo1";
            this.xo1.Size = new System.Drawing.Size(102, 86);
            this.xo1.TabIndex = 2;
            this.xo1.UseVisualStyleBackColor = true;
            this.xo1.Visible = false;
            this.xo1.Click += new System.EventHandler(this.xo1_Click);
            // 
            // xo3
            // 
            this.xo3.Font = new System.Drawing.Font("Lucida Console", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.xo3.Location = new System.Drawing.Point(228, 12);
            this.xo3.Name = "xo3";
            this.xo3.Size = new System.Drawing.Size(102, 86);
            this.xo3.TabIndex = 3;
            this.xo3.UseVisualStyleBackColor = true;
            this.xo3.Visible = false;
            this.xo3.Click += new System.EventHandler(this.xo3_Click);
            // 
            // xo6
            // 
            this.xo6.Font = new System.Drawing.Font("Lucida Console", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.xo6.Location = new System.Drawing.Point(228, 104);
            this.xo6.Name = "xo6";
            this.xo6.Size = new System.Drawing.Size(102, 86);
            this.xo6.TabIndex = 8;
            this.xo6.UseVisualStyleBackColor = true;
            this.xo6.Visible = false;
            this.xo6.Click += new System.EventHandler(this.xo6_Click_1);
            // 
            // xo7
            // 
            this.xo7.Font = new System.Drawing.Font("Lucida Console", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.xo7.Location = new System.Drawing.Point(12, 196);
            this.xo7.Name = "xo7";
            this.xo7.Size = new System.Drawing.Size(102, 86);
            this.xo7.TabIndex = 9;
            this.xo7.UseVisualStyleBackColor = true;
            this.xo7.Visible = false;
            this.xo7.Click += new System.EventHandler(this.xo7_Click);
            // 
            // xo8
            // 
            this.xo8.Font = new System.Drawing.Font("Lucida Console", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.xo8.Location = new System.Drawing.Point(120, 196);
            this.xo8.Name = "xo8";
            this.xo8.Size = new System.Drawing.Size(102, 86);
            this.xo8.TabIndex = 10;
            this.xo8.UseVisualStyleBackColor = true;
            this.xo8.Visible = false;
            this.xo8.Click += new System.EventHandler(this.button7_Click);
            // 
            // xo9
            // 
            this.xo9.Font = new System.Drawing.Font("Lucida Console", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.xo9.Location = new System.Drawing.Point(228, 196);
            this.xo9.Name = "xo9";
            this.xo9.Size = new System.Drawing.Size(102, 86);
            this.xo9.TabIndex = 11;
            this.xo9.UseVisualStyleBackColor = true;
            this.xo9.Visible = false;
            this.xo9.Click += new System.EventHandler(this.xo9_Click);
            // 
            // tictactoepic
            // 
            this.tictactoepic.Image = ((System.Drawing.Image)(resources.GetObject("tictactoepic.Image")));
            this.tictactoepic.Location = new System.Drawing.Point(15, 80);
            this.tictactoepic.Name = "tictactoepic";
            this.tictactoepic.Size = new System.Drawing.Size(317, 73);
            this.tictactoepic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.tictactoepic.TabIndex = 12;
            this.tictactoepic.TabStop = false;
            // 
            // restartbtn
            // 
            this.restartbtn.Font = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.restartbtn.Location = new System.Drawing.Point(111, 325);
            this.restartbtn.Name = "restartbtn";
            this.restartbtn.Size = new System.Drawing.Size(120, 33);
            this.restartbtn.TabIndex = 15;
            this.restartbtn.Text = "RESTART";
            this.restartbtn.UseVisualStyleBackColor = true;
            this.restartbtn.Visible = false;
            this.restartbtn.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // plyr2
            // 
            this.plyr2.AutoSize = true;
            this.plyr2.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.plyr2.Location = new System.Drawing.Point(182, 299);
            this.plyr2.Name = "plyr2";
            this.plyr2.Size = new System.Drawing.Size(139, 16);
            this.plyr2.TabIndex = 16;
            this.plyr2.Text = "PLAYER 2 - O";
            this.plyr2.Visible = false;
            // 
            // plyr1
            // 
            this.plyr1.AutoSize = true;
            this.plyr1.BackColor = System.Drawing.Color.White;
            this.plyr1.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.plyr1.Location = new System.Drawing.Point(23, 299);
            this.plyr1.Name = "plyr1";
            this.plyr1.Size = new System.Drawing.Size(139, 16);
            this.plyr1.TabIndex = 16;
            this.plyr1.Text = "PLAYER 1 - X";
            this.plyr1.Visible = false;
            this.plyr1.Click += new System.EventHandler(this.plyr1_Click);
            // 
            // xo4
            // 
            this.xo4.Font = new System.Drawing.Font("Lucida Console", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.xo4.Location = new System.Drawing.Point(12, 104);
            this.xo4.Name = "xo4";
            this.xo4.Size = new System.Drawing.Size(102, 86);
            this.xo4.TabIndex = 17;
            this.xo4.UseVisualStyleBackColor = true;
            this.xo4.Visible = false;
            this.xo4.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // result
            // 
            this.result.AutoSize = true;
            this.result.Font = new System.Drawing.Font("Lucida Console", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.result.Location = new System.Drawing.Point(42, 196);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(0, 65);
            this.result.TabIndex = 18;
            this.result.Visible = false;
            this.result.Click += new System.EventHandler(this.result_Click);
            // 
            // xo2
            // 
            this.xo2.Font = new System.Drawing.Font("Lucida Console", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.xo2.Location = new System.Drawing.Point(120, 12);
            this.xo2.Name = "xo2";
            this.xo2.Size = new System.Drawing.Size(102, 86);
            this.xo2.TabIndex = 4;
            this.xo2.UseVisualStyleBackColor = true;
            this.xo2.Visible = false;
            this.xo2.Click += new System.EventHandler(this.xo2_Click_1);
            // 
            // xo5
            // 
            this.xo5.Font = new System.Drawing.Font("Lucida Console", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.xo5.Location = new System.Drawing.Point(120, 104);
            this.xo5.Name = "xo5";
            this.xo5.Size = new System.Drawing.Size(102, 86);
            this.xo5.TabIndex = 7;
            this.xo5.UseVisualStyleBackColor = true;
            this.xo5.Visible = false;
            this.xo5.Click += new System.EventHandler(this.xo5_Click_1);
            // 
            // opic
            // 
            this.opic.Image = ((System.Drawing.Image)(resources.GetObject("opic.Image")));
            this.opic.Location = new System.Drawing.Point(103, 71);
            this.opic.Name = "opic";
            this.opic.Size = new System.Drawing.Size(135, 119);
            this.opic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.opic.TabIndex = 19;
            this.opic.TabStop = false;
            this.opic.Visible = false;
            // 
            // xpic
            // 
            this.xpic.Image = ((System.Drawing.Image)(resources.GetObject("xpic.Image")));
            this.xpic.Location = new System.Drawing.Point(103, 71);
            this.xpic.Name = "xpic";
            this.xpic.Size = new System.Drawing.Size(135, 119);
            this.xpic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.xpic.TabIndex = 20;
            this.xpic.TabStop = false;
            this.xpic.Visible = false;
            // 
            // xopic
            // 
            this.xopic.Image = ((System.Drawing.Image)(resources.GetObject("xopic.Image")));
            this.xopic.Location = new System.Drawing.Point(72, 71);
            this.xopic.Name = "xopic";
            this.xopic.Size = new System.Drawing.Size(197, 119);
            this.xopic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.xopic.TabIndex = 22;
            this.xopic.TabStop = false;
            this.xopic.Visible = false;
            // 
            // tform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(341, 370);
            this.Controls.Add(this.result);
            this.Controls.Add(this.xo5);
            this.Controls.Add(this.xo4);
            this.Controls.Add(this.plyr1);
            this.Controls.Add(this.plyr2);
            this.Controls.Add(this.restartbtn);
            this.Controls.Add(this.xo9);
            this.Controls.Add(this.xo8);
            this.Controls.Add(this.xo7);
            this.Controls.Add(this.xo6);
            this.Controls.Add(this.xo2);
            this.Controls.Add(this.xo3);
            this.Controls.Add(this.xo1);
            this.Controls.Add(this.playbtn);
            this.Controls.Add(this.tictactoepic);
            this.Controls.Add(this.opic);
            this.Controls.Add(this.xopic);
            this.Controls.Add(this.xpic);
            this.Font = new System.Drawing.Font("Vineta BT", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.MaximizeBox = false;
            this.Name = "tform";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tictactoepic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.opic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xpic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xopic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button playbtn;
        private System.Windows.Forms.Button xo1;
        private System.Windows.Forms.Button xo3;
        private System.Windows.Forms.Button xo6;
        private System.Windows.Forms.Button xo7;
        private System.Windows.Forms.Button xo8;
        private System.Windows.Forms.Button xo9;
        private System.Windows.Forms.PictureBox tictactoepic;
        private System.Windows.Forms.Button restartbtn;
        private System.Windows.Forms.Label plyr2;
        private System.Windows.Forms.Label plyr1;
        private System.Windows.Forms.Button xo4;
        private System.Windows.Forms.Label result;
        private System.Windows.Forms.Button xo2;
        private System.Windows.Forms.Button xo5;
        private System.Windows.Forms.PictureBox opic;
        private System.Windows.Forms.PictureBox xpic;
        private System.Windows.Forms.PictureBox xopic;
    }
}

