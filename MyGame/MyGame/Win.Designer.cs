namespace MyGame
{
    partial class Win
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            panel1 = new Panel();
            panel4 = new Panel();
            panel3 = new Panel();
            btnMin = new Guna.UI2.WinForms.Guna2ImageButton();
            btnMax = new Guna.UI2.WinForms.Guna2ImageButton();
            btnClose = new Guna.UI2.WinForms.Guna2ImageButton();
            guna2GradientButton2 = new Guna.UI2.WinForms.Guna2GradientButton();
            btnStart = new Guna.UI2.WinForms.Guna2GradientButton();
            panel2 = new Panel();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.BackgroundImage = Properties.Resources.wallPaper;
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(guna2GradientButton2);
            panel1.Controls.Add(btnStart);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1638, 1050);
            panel1.TabIndex = 0;
            // 
            // panel4
            // 
            panel4.BackgroundImage = Properties.Resources.youwin;
            panel4.BackgroundImageLayout = ImageLayout.Stretch;
            panel4.Location = new Point(584, 496);
            panel4.Name = "panel4";
            panel4.Size = new Size(467, 150);
            panel4.TabIndex = 25;
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            panel3.Controls.Add(btnMin);
            panel3.Controls.Add(btnMax);
            panel3.Controls.Add(btnClose);
            panel3.Location = new Point(1460, 3);
            panel3.Name = "panel3";
            panel3.Size = new Size(175, 60);
            panel3.TabIndex = 24;
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
            // guna2GradientButton2
            // 
            guna2GradientButton2.Anchor = AnchorStyles.Top;
            guna2GradientButton2.AutoRoundedCorners = true;
            guna2GradientButton2.BorderRadius = 39;
            guna2GradientButton2.CustomizableEdges = customizableEdges4;
            guna2GradientButton2.DisabledState.BorderColor = Color.DarkGray;
            guna2GradientButton2.DisabledState.CustomBorderColor = Color.DarkGray;
            guna2GradientButton2.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            guna2GradientButton2.DisabledState.FillColor2 = Color.FromArgb(169, 169, 169);
            guna2GradientButton2.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            guna2GradientButton2.FillColor = SystemColors.HotTrack;
            guna2GradientButton2.FillColor2 = SystemColors.ActiveCaptionText;
            guna2GradientButton2.Font = new Font("Impact", 12F, FontStyle.Italic, GraphicsUnit.Point);
            guna2GradientButton2.ForeColor = Color.White;
            guna2GradientButton2.Image = Properties.Resources.exit;
            guna2GradientButton2.Location = new Point(1092, 806);
            guna2GradientButton2.Name = "guna2GradientButton2";
            guna2GradientButton2.ShadowDecoration.CustomizableEdges = customizableEdges5;
            guna2GradientButton2.Size = new Size(243, 80);
            guna2GradientButton2.TabIndex = 23;
            guna2GradientButton2.Text = "Restart";
            guna2GradientButton2.Click += guna2GradientButton2_Click;
            // 
            // btnStart
            // 
            btnStart.Anchor = AnchorStyles.Top;
            btnStart.AutoRoundedCorners = true;
            btnStart.BorderRadius = 39;
            btnStart.CustomizableEdges = customizableEdges6;
            btnStart.DisabledState.BorderColor = Color.DarkGray;
            btnStart.DisabledState.CustomBorderColor = Color.DarkGray;
            btnStart.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnStart.DisabledState.FillColor2 = Color.FromArgb(169, 169, 169);
            btnStart.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnStart.FillColor = SystemColors.HotTrack;
            btnStart.FillColor2 = SystemColors.ActiveCaptionText;
            btnStart.Font = new Font("Impact", 12F, FontStyle.Italic, GraphicsUnit.Point);
            btnStart.ForeColor = Color.White;
            btnStart.Image = Properties.Resources.play;
            btnStart.Location = new Point(384, 806);
            btnStart.Name = "btnStart";
            btnStart.ShadowDecoration.CustomizableEdges = customizableEdges7;
            btnStart.Size = new Size(243, 80);
            btnStart.TabIndex = 1;
            btnStart.Text = "Level 2";
            btnStart.Click += btnStart_Click;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top;
            panel2.BackgroundImage = Properties.Resources.pxfuel_removebg_preview;
            panel2.BackgroundImageLayout = ImageLayout.Stretch;
            panel2.Location = new Point(327, 146);
            panel2.Name = "panel2";
            panel2.Size = new Size(1042, 305);
            panel2.TabIndex = 0;
            // 
            // Win
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1638, 1050);
            Controls.Add(panel1);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Name = "Win";
            Text = "Win";
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Guna.UI2.WinForms.Guna2GradientButton btnStart;
        private Guna.UI2.WinForms.Guna2GradientButton guna2GradientButton2;
        private Panel panel3;
        private Guna.UI2.WinForms.Guna2ImageButton btnMin;
        private Guna.UI2.WinForms.Guna2ImageButton btnMax;
        private Guna.UI2.WinForms.Guna2ImageButton btnClose;
        private Panel panel4;
    }
}