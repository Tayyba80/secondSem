namespace SignIn
{
    partial class forgotPass
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
            panel1 = new Panel();
            panel3 = new Panel();
            label2 = new Label();
            btnBack = new Guna.UI2.WinForms.Guna2ImageButton();
            pnlErrPas = new Panel();
            lblErrPass = new Label();
            btnLogIn = new Guna.UI2.WinForms.Guna2ImageButton();
            panel2 = new Panel();
            txtuserName = new Guna.UI2.WinForms.Guna2TextBox();
            label1 = new Label();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            pnlErrPas.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackgroundImage = Properties.Resources.frame_food_ingredients_baking_gently_pink_pastel_background_cooking_flat_lay_with_copy_space_top_view_baking_concept;
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(btnBack);
            panel1.Controls.Add(pnlErrPas);
            panel1.Controls.Add(btnLogIn);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1578, 850);
            panel1.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Transparent;
            panel3.Controls.Add(label2);
            panel3.Location = new Point(324, 248);
            panel3.Name = "panel3";
            panel3.Size = new Size(473, 50);
            panel3.TabIndex = 27;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe Print", 10F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label2.ForeColor = Color.SaddleBrown;
            label2.Location = new Point(0, 0);
            label2.Name = "label2";
            label2.Size = new Size(459, 35);
            label2.TabIndex = 10;
            label2.Text = "Enter your User name to get your Password";
            // 
            // btnBack
            // 
            btnBack.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnBack.BackColor = Color.Transparent;
            btnBack.CheckedState.ImageSize = new Size(64, 64);
            btnBack.HoverState.ImageSize = new Size(64, 64);
            btnBack.Image = Properties.Resources.back;
            btnBack.ImageOffset = new Point(0, 0);
            btnBack.ImageRotate = 0F;
            btnBack.Location = new Point(196, 737);
            btnBack.Name = "btnBack";
            btnBack.PressedState.ImageSize = new Size(64, 64);
            btnBack.ShadowDecoration.CustomizableEdges = customizableEdges1;
            btnBack.Size = new Size(64, 56);
            btnBack.TabIndex = 26;
            btnBack.Click += btnBack_Click;
            // 
            // pnlErrPas
            // 
            pnlErrPas.BackColor = Color.Transparent;
            pnlErrPas.Controls.Add(lblErrPass);
            pnlErrPas.Location = new Point(311, 451);
            pnlErrPas.Name = "pnlErrPas";
            pnlErrPas.Size = new Size(522, 43);
            pnlErrPas.TabIndex = 25;
            pnlErrPas.Visible = false;
            // 
            // lblErrPass
            // 
            lblErrPass.AutoSize = true;
            lblErrPass.Font = new Font("Segoe Print", 10F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lblErrPass.ForeColor = Color.LightCoral;
            lblErrPass.Location = new Point(0, 0);
            lblErrPass.Name = "lblErrPass";
            lblErrPass.Size = new Size(521, 35);
            lblErrPass.TabIndex = 10;
            lblErrPass.Text = "User with this Name and Password does not Exist!";
            // 
            // btnLogIn
            // 
            btnLogIn.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnLogIn.BackColor = Color.Transparent;
            btnLogIn.CheckedState.ImageSize = new Size(64, 64);
            btnLogIn.HoverState.ImageSize = new Size(64, 64);
            btnLogIn.Image = Properties.Resources.logIn;
            btnLogIn.ImageOffset = new Point(0, 0);
            btnLogIn.ImageRotate = 0F;
            btnLogIn.Location = new Point(1351, 725);
            btnLogIn.Name = "btnLogIn";
            btnLogIn.PressedState.ImageSize = new Size(64, 64);
            btnLogIn.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btnLogIn.Size = new Size(80, 68);
            btnLogIn.TabIndex = 18;
            btnLogIn.Click += btnLogIn_Click;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            panel2.BackColor = Color.Transparent;
            panel2.Controls.Add(txtuserName);
            panel2.Location = new Point(311, 348);
            panel2.Name = "panel2";
            panel2.Size = new Size(702, 69);
            panel2.TabIndex = 24;
            // 
            // txtuserName
            // 
            txtuserName.AutoRoundedCorners = true;
            txtuserName.BackColor = Color.Transparent;
            txtuserName.BorderColor = Color.RosyBrown;
            txtuserName.BorderRadius = 31;
            txtuserName.BorderThickness = 3;
            txtuserName.CustomizableEdges = customizableEdges3;
            txtuserName.DefaultText = "";
            txtuserName.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtuserName.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtuserName.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtuserName.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtuserName.Dock = DockStyle.Top;
            txtuserName.FillColor = Color.MistyRose;
            txtuserName.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtuserName.Font = new Font("Segoe Print", 9F, FontStyle.Bold, GraphicsUnit.Point);
            txtuserName.ForeColor = Color.SaddleBrown;
            txtuserName.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtuserName.IconLeft = Properties.Resources._1727545;
            txtuserName.IconLeftSize = new Size(40, 40);
            txtuserName.Location = new Point(0, 0);
            txtuserName.Margin = new Padding(4, 4, 4, 4);
            txtuserName.Name = "txtuserName";
            txtuserName.PasswordChar = '\0';
            txtuserName.PlaceholderForeColor = Color.SaddleBrown;
            txtuserName.PlaceholderText = "UserName";
            txtuserName.SelectedText = "";
            txtuserName.ShadowDecoration.CustomizableEdges = customizableEdges4;
            txtuserName.Size = new Size(702, 65);
            txtuserName.TabIndex = 17;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe Print", 16F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.ForeColor = Color.SaddleBrown;
            label1.Location = new Point(368, 186);
            label1.Name = "label1";
            label1.Size = new Size(295, 57);
            label1.TabIndex = 23;
            label1.Text = "Forgot Password";
            // 
            // forgotPass
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1578, 850);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "forgotPass";
            Text = "forgotPass";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            pnlErrPas.ResumeLayout(false);
            pnlErrPas.PerformLayout();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Guna.UI2.WinForms.Guna2TextBox txtuserName;
        private Label label1;
        private Guna.UI2.WinForms.Guna2ImageButton btnLogIn;
        private Panel pnlErrPas;
        private Label lblErrPass;
        private Guna.UI2.WinForms.Guna2ImageButton btnBack;
        private Panel panel3;
        private Label label2;
    }
}