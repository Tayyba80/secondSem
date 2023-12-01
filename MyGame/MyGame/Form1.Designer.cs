﻿namespace MyGame
{
    partial class Form1
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
            components = new System.ComponentModel.Container();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            timer1 = new System.Windows.Forms.Timer(components);
            lblroboPower = new Label();
            pbPlayer = new ProgressBar();
            lblScore = new Label();
            pbSniper = new ProgressBar();
            lblSniperPower = new Label();
            pbScorpious = new ProgressBar();
            lblScorpious = new Label();
            pbMech = new ProgressBar();
            label1 = new Label();
            pbRavan = new ProgressBar();
            label2 = new Label();
            panel1 = new Panel();
            btnMin = new Guna.UI2.WinForms.Guna2ImageButton();
            btnMax = new Guna.UI2.WinForms.Guna2ImageButton();
            btnClose = new Guna.UI2.WinForms.Guna2ImageButton();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 400;
            timer1.Tick += timer1_Tick;
            // 
            // lblroboPower
            // 
            lblroboPower.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblroboPower.AutoSize = true;
            lblroboPower.FlatStyle = FlatStyle.Flat;
            lblroboPower.Font = new Font("NSimSun", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lblroboPower.ForeColor = Color.RoyalBlue;
            lblroboPower.Location = new Point(1440, 214);
            lblroboPower.Name = "lblroboPower";
            lblroboPower.Size = new Size(119, 20);
            lblroboPower.TabIndex = 0;
            lblroboPower.Text = "Robo Power";
            // 
            // pbPlayer
            // 
            pbPlayer.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pbPlayer.BackColor = Color.Black;
            pbPlayer.ForeColor = Color.SeaGreen;
            pbPlayer.Location = new Point(1475, 248);
            pbPlayer.Maximum = 50;
            pbPlayer.Name = "pbPlayer";
            pbPlayer.Size = new Size(150, 12);
            pbPlayer.Step = 2;
            pbPlayer.TabIndex = 1;
            // 
            // lblScore
            // 
            lblScore.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblScore.AutoSize = true;
            lblScore.Font = new Font("NSimSun", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lblScore.ForeColor = Color.SeaShell;
            lblScore.Location = new Point(1440, 151);
            lblScore.Name = "lblScore";
            lblScore.Size = new Size(75, 20);
            lblScore.TabIndex = 2;
            lblScore.Text = "Score:";
            // 
            // pbSniper
            // 
            pbSniper.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pbSniper.BackColor = Color.Black;
            pbSniper.ForeColor = Color.SeaGreen;
            pbSniper.Location = new Point(1475, 320);
            pbSniper.Maximum = 40;
            pbSniper.Name = "pbSniper";
            pbSniper.Size = new Size(150, 12);
            pbSniper.Step = 2;
            pbSniper.TabIndex = 4;
            // 
            // lblSniperPower
            // 
            lblSniperPower.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblSniperPower.AutoSize = true;
            lblSniperPower.FlatStyle = FlatStyle.Flat;
            lblSniperPower.Font = new Font("NSimSun", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lblSniperPower.ForeColor = Color.Gray;
            lblSniperPower.Location = new Point(1440, 282);
            lblSniperPower.Name = "lblSniperPower";
            lblSniperPower.Size = new Size(163, 20);
            lblSniperPower.TabIndex = 3;
            lblSniperPower.Text = "Sniper's Power";
            // 
            // pbScorpious
            // 
            pbScorpious.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pbScorpious.BackColor = Color.Black;
            pbScorpious.ForeColor = Color.SeaGreen;
            pbScorpious.Location = new Point(1475, 391);
            pbScorpious.Maximum = 40;
            pbScorpious.Name = "pbScorpious";
            pbScorpious.Size = new Size(150, 12);
            pbScorpious.Step = 2;
            pbScorpious.TabIndex = 6;
            // 
            // lblScorpious
            // 
            lblScorpious.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblScorpious.AutoSize = true;
            lblScorpious.FlatStyle = FlatStyle.Flat;
            lblScorpious.Font = new Font("NSimSun", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lblScorpious.ForeColor = Color.Gray;
            lblScorpious.Location = new Point(1440, 357);
            lblScorpious.Name = "lblScorpious";
            lblScorpious.Size = new Size(185, 20);
            lblScorpious.TabIndex = 5;
            lblScorpious.Text = "Scorpiou's Power";
            // 
            // pbMech
            // 
            pbMech.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pbMech.BackColor = Color.Black;
            pbMech.ForeColor = Color.SeaGreen;
            pbMech.Location = new Point(1475, 466);
            pbMech.Maximum = 50;
            pbMech.Name = "pbMech";
            pbMech.Size = new Size(150, 12);
            pbMech.Step = 2;
            pbMech.TabIndex = 8;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.FlatStyle = FlatStyle.Flat;
            label1.Font = new Font("NSimSun", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Gray;
            label1.Location = new Point(1440, 432);
            label1.Name = "label1";
            label1.Size = new Size(141, 20);
            label1.TabIndex = 7;
            label1.Text = "Mech's Power";
            // 
            // pbRavan
            // 
            pbRavan.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pbRavan.BackColor = Color.Black;
            pbRavan.ForeColor = Color.SeaGreen;
            pbRavan.Location = new Point(1475, 540);
            pbRavan.Maximum = 10;
            pbRavan.Name = "pbRavan";
            pbRavan.Size = new Size(150, 12);
            pbRavan.Step = 2;
            pbRavan.TabIndex = 10;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.FlatStyle = FlatStyle.Flat;
            label2.Font = new Font("NSimSun", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Gray;
            label2.Location = new Point(1440, 506);
            label2.Name = "label2";
            label2.Size = new Size(152, 20);
            label2.TabIndex = 9;
            label2.Text = "Ravan's Power";
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            panel1.Controls.Add(btnMin);
            panel1.Controls.Add(btnMax);
            panel1.Controls.Add(btnClose);
            panel1.Location = new Point(1461, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(175, 60);
            panel1.TabIndex = 11;
            // 
            // btnMin
            // 
            btnMin.BackColor = Color.Transparent;
            btnMin.CheckedState.ImageSize = new Size(64, 64);
            btnMin.Dock = DockStyle.Right;
            btnMin.HoverState.ImageSize = new Size(64, 64);
            btnMin.Image = Properties.Resources.mini;
            btnMin.ImageOffset = new Point(0, 0);
            btnMin.ImageRotate = 0F;
            btnMin.ImageSize = new Size(44, 44);
            btnMin.Location = new Point(7, 0);
            btnMin.Name = "btnMin";
            btnMin.PressedState.ImageSize = new Size(64, 64);
            btnMin.ShadowDecoration.CustomizableEdges = customizableEdges1;
            btnMin.Size = new Size(55, 60);
            btnMin.TabIndex = 23;
            btnMin.Click += btnMin_Click;
            // 
            // btnMax
            // 
            btnMax.BackColor = Color.Transparent;
            btnMax.CheckedState.ImageSize = new Size(64, 64);
            btnMax.Dock = DockStyle.Right;
            btnMax.HoverState.ImageSize = new Size(64, 64);
            btnMax.Image = Properties.Resources.maxi;
            btnMax.ImageOffset = new Point(0, 0);
            btnMax.ImageRotate = 0F;
            btnMax.ImageSize = new Size(44, 44);
            btnMax.Location = new Point(62, 0);
            btnMax.Name = "btnMax";
            btnMax.PressedState.ImageSize = new Size(64, 64);
            btnMax.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btnMax.Size = new Size(55, 60);
            btnMax.TabIndex = 22;
            btnMax.Click += btnMax_Click;
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.Transparent;
            btnClose.CheckedState.ImageSize = new Size(64, 64);
            btnClose.Dock = DockStyle.Right;
            btnClose.HoverState.ImageSize = new Size(64, 64);
            btnClose.Image = Properties.Resources.closeApp;
            btnClose.ImageOffset = new Point(0, 0);
            btnClose.ImageRotate = 0F;
            btnClose.ImageSize = new Size(44, 44);
            btnClose.Location = new Point(117, 0);
            btnClose.Name = "btnClose";
            btnClose.PressedState.ImageSize = new Size(64, 64);
            btnClose.ShadowDecoration.CustomizableEdges = customizableEdges3;
            btnClose.Size = new Size(58, 60);
            btnClose.TabIndex = 21;
            btnClose.Click += btnClose_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(1638, 1050);
            Controls.Add(panel1);
            Controls.Add(pbRavan);
            Controls.Add(label2);
            Controls.Add(pbMech);
            Controls.Add(label1);
            Controls.Add(pbScorpious);
            Controls.Add(lblScorpious);
            Controls.Add(pbSniper);
            Controls.Add(lblSniperPower);
            Controls.Add(lblScore);
            Controls.Add(pbPlayer);
            Controls.Add(lblroboPower);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private Label lblroboPower;
        private ProgressBar pbPlayer;
        private Label lblScore;
        private ProgressBar pbSniper;
        private Label lblSniperPower;
        private ProgressBar pbScorpious;
        private Label lblScorpious;
        private ProgressBar pbMech;
        private Label label1;
        private ProgressBar pbRavan;
        private Label label2;
        private Panel panel1;
        private Guna.UI2.WinForms.Guna2ImageButton btnClose;
        private Guna.UI2.WinForms.Guna2ImageButton btnMax;
        private Guna.UI2.WinForms.Guna2ImageButton btnMin;
    }
}