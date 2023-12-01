namespace SignIn
{
    partial class SignOptions
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
            panelChildFormSign = new Panel();
            btnSinUp = new Guna.UI2.WinForms.Guna2GradientButton();
            btnLogIn = new Guna.UI2.WinForms.Guna2GradientButton();
            label1 = new Label();
            panelChildFormSign.SuspendLayout();
            SuspendLayout();
            // 
            // panelChildFormSign
            // 
            panelChildFormSign.BackColor = Color.Transparent;
            panelChildFormSign.BackgroundImage = Properties.Resources.frame_food_ingredients_baking_gently_pink_pastel_background_cooking_flat_lay_with_copy_space_top_view_baking_concept;
            panelChildFormSign.BackgroundImageLayout = ImageLayout.Stretch;
            panelChildFormSign.Controls.Add(btnSinUp);
            panelChildFormSign.Controls.Add(btnLogIn);
            panelChildFormSign.Controls.Add(label1);
            panelChildFormSign.Dock = DockStyle.Fill;
            panelChildFormSign.Location = new Point(0, 0);
            panelChildFormSign.Name = "panelChildFormSign";
            panelChildFormSign.Size = new Size(1578, 850);
            panelChildFormSign.TabIndex = 2;
            // 
            // btnSinUp
            // 
            btnSinUp.Anchor = AnchorStyles.Top;
            btnSinUp.AutoRoundedCorners = true;
            btnSinUp.BorderColor = Color.Transparent;
            btnSinUp.BorderRadius = 33;
            btnSinUp.CustomizableEdges = customizableEdges1;
            btnSinUp.DisabledState.BorderColor = Color.DarkGray;
            btnSinUp.DisabledState.CustomBorderColor = Color.DarkGray;
            btnSinUp.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnSinUp.DisabledState.FillColor2 = Color.FromArgb(169, 169, 169);
            btnSinUp.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnSinUp.FillColor = Color.RosyBrown;
            btnSinUp.FillColor2 = Color.MistyRose;
            btnSinUp.Font = new Font("Segoe Print", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnSinUp.ForeColor = Color.SaddleBrown;
            btnSinUp.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            btnSinUp.Image = Properties.Resources.SignUp;
            btnSinUp.ImageAlign = HorizontalAlignment.Left;
            btnSinUp.ImageSize = new Size(30, 30);
            btnSinUp.Location = new Point(510, 504);
            btnSinUp.Name = "btnSinUp";
            btnSinUp.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btnSinUp.Size = new Size(182, 68);
            btnSinUp.TabIndex = 47;
            btnSinUp.Text = "Sign Up";
            btnSinUp.TextAlign = HorizontalAlignment.Left;
            btnSinUp.Click += btnSinUp_Click;
            // 
            // btnLogIn
            // 
            btnLogIn.Anchor = AnchorStyles.Top;
            btnLogIn.AutoRoundedCorners = true;
            btnLogIn.BorderColor = Color.Transparent;
            btnLogIn.BorderRadius = 33;
            btnLogIn.CustomizableEdges = customizableEdges3;
            btnLogIn.DisabledState.BorderColor = Color.DarkGray;
            btnLogIn.DisabledState.CustomBorderColor = Color.DarkGray;
            btnLogIn.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnLogIn.DisabledState.FillColor2 = Color.FromArgb(169, 169, 169);
            btnLogIn.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnLogIn.FillColor = Color.RosyBrown;
            btnLogIn.FillColor2 = Color.MistyRose;
            btnLogIn.Font = new Font("Segoe Print", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnLogIn.ForeColor = Color.SaddleBrown;
            btnLogIn.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            btnLogIn.Image = Properties.Resources.logIn;
            btnLogIn.ImageAlign = HorizontalAlignment.Left;
            btnLogIn.ImageSize = new Size(30, 30);
            btnLogIn.Location = new Point(510, 394);
            btnLogIn.Name = "btnLogIn";
            btnLogIn.ShadowDecoration.CustomizableEdges = customizableEdges4;
            btnLogIn.Size = new Size(182, 68);
            btnLogIn.TabIndex = 44;
            btnLogIn.Text = "Log In";
            btnLogIn.TextAlign = HorizontalAlignment.Left;
            btnLogIn.Click += btnLogIn_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.FlatStyle = FlatStyle.Flat;
            label1.Font = new Font("Segoe Print", 28F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.SaddleBrown;
            label1.Location = new Point(510, 247);
            label1.Name = "label1";
            label1.Size = new Size(343, 98);
            label1.TabIndex = 3;
            label1.Text = "Sweet Day";
            // 
            // SignOptions
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(1578, 850);
            Controls.Add(panelChildFormSign);
            DoubleBuffered = true;
            ForeColor = Color.Black;
            FormBorderStyle = FormBorderStyle.None;
            Name = "SignOptions";
            Text = "SignOptions";
            panelChildFormSign.ResumeLayout(false);
            panelChildFormSign.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel panelChildFormSign;
        private Label label1;
        private Guna.UI2.WinForms.Guna2GradientButton btnSinUp;
        private Guna.UI2.WinForms.Guna2GradientButton btnLogIn;
    }
}