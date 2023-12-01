namespace MyGame
{
    partial class Menu
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
            panel1 = new Panel();
            guna2GradientButton2 = new Guna.UI2.WinForms.Guna2GradientButton();
            guna2GradientButton1 = new Guna.UI2.WinForms.Guna2GradientButton();
            pictureBox7 = new PictureBox();
            btnStart = new Guna.UI2.WinForms.Guna2GradientButton();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.BackgroundImage = Properties.Resources.wallPaper;
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Controls.Add(guna2GradientButton2);
            panel1.Controls.Add(guna2GradientButton1);
            panel1.Controls.Add(pictureBox7);
            panel1.Controls.Add(btnStart);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1616, 931);
            panel1.TabIndex = 0;
            // 
            // guna2GradientButton2
            // 
            guna2GradientButton2.AutoRoundedCorners = true;
            guna2GradientButton2.BorderRadius = 39;
            guna2GradientButton2.CustomizableEdges = customizableEdges1;
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
            guna2GradientButton2.Location = new Point(561, 649);
            guna2GradientButton2.Name = "guna2GradientButton2";
            guna2GradientButton2.ShadowDecoration.CustomizableEdges = customizableEdges2;
            guna2GradientButton2.Size = new Size(243, 80);
            guna2GradientButton2.TabIndex = 22;
            guna2GradientButton2.Text = "Exit";
            guna2GradientButton2.Click += guna2GradientButton2_Click;
            // 
            // guna2GradientButton1
            // 
            guna2GradientButton1.AutoRoundedCorners = true;
            guna2GradientButton1.BorderRadius = 39;
            guna2GradientButton1.CustomizableEdges = customizableEdges3;
            guna2GradientButton1.DisabledState.BorderColor = Color.DarkGray;
            guna2GradientButton1.DisabledState.CustomBorderColor = Color.DarkGray;
            guna2GradientButton1.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            guna2GradientButton1.DisabledState.FillColor2 = Color.FromArgb(169, 169, 169);
            guna2GradientButton1.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            guna2GradientButton1.FillColor = SystemColors.HotTrack;
            guna2GradientButton1.FillColor2 = SystemColors.ActiveCaptionText;
            guna2GradientButton1.Font = new Font("Impact", 12F, FontStyle.Italic, GraphicsUnit.Point);
            guna2GradientButton1.ForeColor = Color.White;
            guna2GradientButton1.Image = Properties.Resources.toPurch;
            guna2GradientButton1.Location = new Point(561, 524);
            guna2GradientButton1.Name = "guna2GradientButton1";
            guna2GradientButton1.ShadowDecoration.CustomizableEdges = customizableEdges4;
            guna2GradientButton1.Size = new Size(243, 80);
            guna2GradientButton1.TabIndex = 21;
            guna2GradientButton1.Text = "Instructions";
            guna2GradientButton1.Click += guna2GradientButton1_Click;
            // 
            // pictureBox7
            // 
            pictureBox7.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox7.BackColor = Color.Transparent;
            pictureBox7.BackgroundImage = Properties.Resources.name;
            pictureBox7.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox7.Location = new Point(378, 59);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(819, 211);
            pictureBox7.TabIndex = 20;
            pictureBox7.TabStop = false;
            // 
            // btnStart
            // 
            btnStart.AutoRoundedCorners = true;
            btnStart.BorderRadius = 39;
            btnStart.CustomizableEdges = customizableEdges5;
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
            btnStart.Location = new Point(561, 400);
            btnStart.Name = "btnStart";
            btnStart.ShadowDecoration.CustomizableEdges = customizableEdges6;
            btnStart.Size = new Size(243, 80);
            btnStart.TabIndex = 0;
            btnStart.Text = "Play";
            btnStart.Click += btnStart_Click;
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1616, 931);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Menu";
            Text = "Menu";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Guna.UI2.WinForms.Guna2GradientButton btnStart;
        private Guna.UI2.WinForms.Guna2GradientButton guna2GradientButton2;
        private Guna.UI2.WinForms.Guna2GradientButton guna2GradientButton1;
        private PictureBox pictureBox7;
    }
}