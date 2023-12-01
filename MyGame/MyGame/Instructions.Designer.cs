namespace MyGame
{
    partial class Instructions
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            panel1 = new Panel();
            guna2ImageButton1 = new Guna.UI2.WinForms.Guna2ImageButton();
            label1 = new Label();
            panel2 = new Panel();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label11 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.BackgroundImage = Properties.Resources.wallPaper;
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Controls.Add(guna2ImageButton1);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1594, 875);
            panel1.TabIndex = 0;
            // 
            // guna2ImageButton1
            // 
            guna2ImageButton1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            guna2ImageButton1.BackColor = SystemColors.HotTrack;
            guna2ImageButton1.BackgroundImageLayout = ImageLayout.Stretch;
            guna2ImageButton1.CheckedState.ImageSize = new Size(64, 64);
            guna2ImageButton1.HoverState.ImageSize = new Size(64, 64);
            guna2ImageButton1.Image = Properties.Resources.back;
            guna2ImageButton1.ImageOffset = new Point(0, 0);
            guna2ImageButton1.ImageRotate = 0F;
            guna2ImageButton1.Location = new Point(288, 763);
            guna2ImageButton1.Name = "guna2ImageButton1";
            guna2ImageButton1.PressedState.ImageSize = new Size(64, 64);
            guna2ImageButton1.ShadowDecoration.CustomizableEdges = customizableEdges1;
            guna2ImageButton1.Size = new Size(96, 81);
            guna2ImageButton1.TabIndex = 23;
            guna2ImageButton1.Click += guna2ImageButton1_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Impact", 18F, FontStyle.Italic, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.HotTrack;
            label1.Location = new Point(649, 109);
            label1.Name = "label1";
            label1.Size = new Size(230, 44);
            label1.TabIndex = 22;
            label1.Text = "INSTRUCTIONS";
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top;
            panel2.Controls.Add(label11);
            panel2.Controls.Add(label10);
            panel2.Controls.Add(label9);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(490, 232);
            panel2.Name = "panel2";
            panel2.Size = new Size(759, 532);
            panel2.TabIndex = 0;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Impact", 12F, FontStyle.Italic, GraphicsUnit.Point);
            label10.ForeColor = Color.White;
            label10.Location = new Point(33, 475);
            label10.Name = "label10";
            label10.Size = new Size(155, 29);
            label10.TabIndex = 8;
            label10.Text = "the value of 25";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Impact", 12F, FontStyle.Italic, GraphicsUnit.Point);
            label9.ForeColor = Color.White;
            label9.Location = new Point(33, 446);
            label9.Name = "label9";
            label9.Size = new Size(617, 29);
            label9.TabIndex = 7;
            label9.Text = "their Power Decrease,But by doing this your score decrease by";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Impact", 12F, FontStyle.Italic, GraphicsUnit.Point);
            label8.ForeColor = Color.White;
            label8.Location = new Point(19, 417);
            label8.Name = "label8";
            label8.Size = new Size(653, 29);
            label8.TabIndex = 6;
            label8.Text = "8-If your score is more than  25 then by touching the Enemy Robot,";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Impact", 12F, FontStyle.Italic, GraphicsUnit.Point);
            label7.ForeColor = Color.White;
            label7.Location = new Point(19, 365);
            label7.Name = "label7";
            label7.Size = new Size(366, 29);
            label7.TabIndex = 5;
            label7.Text = "7-Kill the Enemy Robots to get Scores";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Impact", 12F, FontStyle.Italic, GraphicsUnit.Point);
            label6.ForeColor = Color.White;
            label6.Location = new Point(19, 311);
            label6.Name = "label6";
            label6.Size = new Size(633, 29);
            label6.TabIndex = 4;
            label6.Text = "6- Collect the Batteries to increase the power of the Player Robot";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Impact", 12F, FontStyle.Italic, GraphicsUnit.Point);
            label5.ForeColor = Color.White;
            label5.Location = new Point(19, 203);
            label5.Name = "label5";
            label5.Size = new Size(561, 29);
            label5.TabIndex = 3;
            label5.Text = "4- Press RIGHT-Arrow key to move the player toward Right";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Impact", 12F, FontStyle.Italic, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(19, 147);
            label4.Name = "label4";
            label4.Size = new Size(529, 29);
            label4.TabIndex = 2;
            label4.Text = "3- Press LEFT-Arrow key to move the player toward Left";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Impact", 12F, FontStyle.Italic, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(19, 91);
            label3.Name = "label3";
            label3.Size = new Size(496, 29);
            label3.TabIndex = 1;
            label3.Text = "2- Press DOWN-Arrow key to move the player Down";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Impact", 12F, FontStyle.Italic, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(19, 39);
            label2.Name = "label2";
            label2.Size = new Size(431, 29);
            label2.TabIndex = 0;
            label2.Text = "1- Press UP-Arrow key to move the player Up";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Impact", 12F, FontStyle.Italic, GraphicsUnit.Point);
            label11.ForeColor = Color.White;
            label11.Location = new Point(19, 257);
            label11.Name = "label11";
            label11.Size = new Size(313, 29);
            label11.TabIndex = 9;
            label11.Text = "5- Press 'B' key to fire the Bullet";
            // 
            // Instructions
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1594, 875);
            Controls.Add(panel1);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Name = "Instructions";
            Text = "Instructions";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label label1;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Guna.UI2.WinForms.Guna2ImageButton guna2ImageButton1;
        private Label label11;
    }
}