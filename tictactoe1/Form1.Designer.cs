
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
            this.pplay = new System.Windows.Forms.Button();
            this.pplay1 = new System.Windows.Forms.Button();
            this.pplay2 = new System.Windows.Forms.Button();
            this.pplay3 = new System.Windows.Forms.Button();
            this.pplay6 = new System.Windows.Forms.Button();
            this.pplay4 = new System.Windows.Forms.Button();
            this.pplay5 = new System.Windows.Forms.Button();
            this.pplay7 = new System.Windows.Forms.Button();
            this.pplay8 = new System.Windows.Forms.Button();
            this.tictactoepic = new System.Windows.Forms.PictureBox();
            this.plyr1 = new System.Windows.Forms.TextBox();
            this.plyr2 = new System.Windows.Forms.TextBox();
            this.restartbtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tictactoepic)).BeginInit();
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
            // pplay
            // 
            this.pplay.Location = new System.Drawing.Point(12, 104);
            this.pplay.Name = "pplay";
            this.pplay.Size = new System.Drawing.Size(102, 86);
            this.pplay.TabIndex = 1;
            this.pplay.UseVisualStyleBackColor = true;
            this.pplay.Visible = false;
            this.pplay.Click += new System.EventHandler(this.pplay_Click);
            // 
            // pplay1
            // 
            this.pplay1.Location = new System.Drawing.Point(12, 12);
            this.pplay1.Name = "pplay1";
            this.pplay1.Size = new System.Drawing.Size(102, 86);
            this.pplay1.TabIndex = 2;
            this.pplay1.UseVisualStyleBackColor = true;
            this.pplay1.Visible = false;
            // 
            // pplay2
            // 
            this.pplay2.Location = new System.Drawing.Point(228, 12);
            this.pplay2.Name = "pplay2";
            this.pplay2.Size = new System.Drawing.Size(102, 86);
            this.pplay2.TabIndex = 3;
            this.pplay2.UseVisualStyleBackColor = true;
            this.pplay2.Visible = false;
            // 
            // pplay3
            // 
            this.pplay3.Location = new System.Drawing.Point(120, 12);
            this.pplay3.Name = "pplay3";
            this.pplay3.Size = new System.Drawing.Size(102, 86);
            this.pplay3.TabIndex = 4;
            this.pplay3.UseVisualStyleBackColor = true;
            this.pplay3.Visible = false;
            // 
            // pplay6
            // 
            this.pplay6.Location = new System.Drawing.Point(120, 104);
            this.pplay6.Name = "pplay6";
            this.pplay6.Size = new System.Drawing.Size(102, 86);
            this.pplay6.TabIndex = 7;
            this.pplay6.UseVisualStyleBackColor = true;
            this.pplay6.Visible = false;
            // 
            // pplay4
            // 
            this.pplay4.Location = new System.Drawing.Point(228, 104);
            this.pplay4.Name = "pplay4";
            this.pplay4.Size = new System.Drawing.Size(102, 86);
            this.pplay4.TabIndex = 8;
            this.pplay4.UseVisualStyleBackColor = true;
            this.pplay4.Visible = false;
            // 
            // pplay5
            // 
            this.pplay5.Location = new System.Drawing.Point(12, 196);
            this.pplay5.Name = "pplay5";
            this.pplay5.Size = new System.Drawing.Size(102, 86);
            this.pplay5.TabIndex = 9;
            this.pplay5.UseVisualStyleBackColor = true;
            this.pplay5.Visible = false;
            // 
            // pplay7
            // 
            this.pplay7.Location = new System.Drawing.Point(120, 196);
            this.pplay7.Name = "pplay7";
            this.pplay7.Size = new System.Drawing.Size(102, 86);
            this.pplay7.TabIndex = 10;
            this.pplay7.UseVisualStyleBackColor = true;
            this.pplay7.Visible = false;
            this.pplay7.Click += new System.EventHandler(this.button7_Click);
            // 
            // pplay8
            // 
            this.pplay8.Location = new System.Drawing.Point(228, 196);
            this.pplay8.Name = "pplay8";
            this.pplay8.Size = new System.Drawing.Size(102, 86);
            this.pplay8.TabIndex = 11;
            this.pplay8.UseVisualStyleBackColor = true;
            this.pplay8.Visible = false;
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
            // plyr1
            // 
            this.plyr1.Font = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.plyr1.Location = new System.Drawing.Point(26, 299);
            this.plyr1.Name = "plyr1";
            this.plyr1.Size = new System.Drawing.Size(139, 20);
            this.plyr1.TabIndex = 13;
            this.plyr1.Text = "PLAYER 1 -  X";
            this.plyr1.Visible = false;
            // 
            // plyr2
            // 
            this.plyr2.Font = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.plyr2.Location = new System.Drawing.Point(180, 299);
            this.plyr2.Name = "plyr2";
            this.plyr2.Size = new System.Drawing.Size(139, 20);
            this.plyr2.TabIndex = 14;
            this.plyr2.Text = "PLAYER 2 -  O";
            this.plyr2.Visible = false;
            this.plyr2.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
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
            // tform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(341, 370);
            this.Controls.Add(this.restartbtn);
            this.Controls.Add(this.plyr2);
            this.Controls.Add(this.plyr1);
            this.Controls.Add(this.playbtn);
            this.Controls.Add(this.tictactoepic);
            this.Controls.Add(this.pplay8);
            this.Controls.Add(this.pplay7);
            this.Controls.Add(this.pplay5);
            this.Controls.Add(this.pplay4);
            this.Controls.Add(this.pplay6);
            this.Controls.Add(this.pplay3);
            this.Controls.Add(this.pplay2);
            this.Controls.Add(this.pplay1);
            this.Controls.Add(this.pplay);
            this.Font = new System.Drawing.Font("Vineta BT", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.MaximizeBox = false;
            this.Name = "tform";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tictactoepic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button playbtn;
        private System.Windows.Forms.Button pplay;
        private System.Windows.Forms.Button pplay1;
        private System.Windows.Forms.Button pplay2;
        private System.Windows.Forms.Button pplay3;
        private System.Windows.Forms.Button pplay6;
        private System.Windows.Forms.Button pplay4;
        private System.Windows.Forms.Button pplay5;
        private System.Windows.Forms.Button pplay7;
        private System.Windows.Forms.Button pplay8;
        private System.Windows.Forms.PictureBox tictactoepic;
        private System.Windows.Forms.TextBox plyr1;
        private System.Windows.Forms.TextBox plyr2;
        private System.Windows.Forms.Button restartbtn;
    }
}

