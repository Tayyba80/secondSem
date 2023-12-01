namespace SignIn
{
    partial class frmSignIn
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            panel1 = new Panel();
            panel4 = new Panel();
            linkLabel1 = new LinkLabel();
            panel3 = new Panel();
            btnopen = new Guna.UI2.WinForms.Guna2ImageButton();
            btnClose = new Guna.UI2.WinForms.Guna2ImageButton();
            txtpassword = new Guna.UI2.WinForms.Guna2TextBox();
            panel2 = new Panel();
            txtuserName = new Guna.UI2.WinForms.Guna2TextBox();
            btnLogIn = new Guna.UI2.WinForms.Guna2ImageButton();
            btnBack = new Guna.UI2.WinForms.Guna2ImageButton();
            pnlErrPas = new Panel();
            lblErrPass = new Label();
            label1 = new Label();
            panel1.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            pnlErrPas.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.MistyRose;
            panel1.BackgroundImage = Properties.Resources.frame_food_ingredients_baking_gently_pink_pastel_background_cooking_flat_lay_with_copy_space_top_view_baking_concept;
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(btnLogIn);
            panel1.Controls.Add(btnBack);
            panel1.Controls.Add(pnlErrPas);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1578, 850);
            panel1.TabIndex = 0;
            // 
            // panel4
            // 
            panel4.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            panel4.BackColor = Color.Transparent;
            panel4.Controls.Add(linkLabel1);
            panel4.Location = new Point(362, 452);
            panel4.Name = "panel4";
            panel4.Size = new Size(717, 45);
            panel4.TabIndex = 25;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.BackColor = Color.Transparent;
            linkLabel1.DisabledLinkColor = Color.PeachPuff;
            linkLabel1.Font = new Font("Segoe Print", 9F, FontStyle.Bold, GraphicsUnit.Point);
            linkLabel1.LinkColor = Color.Navy;
            linkLabel1.Location = new Point(5, 5);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(175, 31);
            linkLabel1.TabIndex = 24;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Forgot Password?";
            linkLabel1.VisitedLinkColor = Color.SaddleBrown;
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            panel3.BackColor = Color.Transparent;
            panel3.Controls.Add(btnopen);
            panel3.Controls.Add(btnClose);
            panel3.Controls.Add(txtpassword);
            panel3.Location = new Point(350, 359);
            panel3.Name = "panel3";
            panel3.Size = new Size(828, 71);
            panel3.TabIndex = 23;
            // 
            // btnopen
            // 
            btnopen.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnopen.BackColor = Color.MistyRose;
            btnopen.CheckedState.ImageSize = new Size(64, 64);
            btnopen.HoverState.ImageSize = new Size(64, 64);
            btnopen.Image = Properties.Resources.showPass;
            btnopen.ImageOffset = new Point(0, 0);
            btnopen.ImageRotate = 0F;
            btnopen.Location = new Point(723, 14);
            btnopen.Name = "btnopen";
            btnopen.PressedState.ImageSize = new Size(64, 64);
            btnopen.ShadowDecoration.CustomizableEdges = customizableEdges1;
            btnopen.Size = new Size(68, 47);
            btnopen.TabIndex = 25;
            btnopen.Click += btnopen_Click;
            // 
            // btnClose
            // 
            btnClose.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnClose.BackColor = Color.MistyRose;
            btnClose.CheckedState.ImageSize = new Size(64, 64);
            btnClose.HoverState.ImageSize = new Size(64, 64);
            btnClose.Image = Properties.Resources.hidePass;
            btnClose.ImageOffset = new Point(0, 0);
            btnClose.ImageRotate = 0F;
            btnClose.Location = new Point(723, 13);
            btnClose.Name = "btnClose";
            btnClose.PressedState.ImageSize = new Size(64, 64);
            btnClose.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btnClose.Size = new Size(69, 47);
            btnClose.TabIndex = 26;
            btnClose.Click += btnClose_Click;
            // 
            // txtpassword
            // 
            txtpassword.AutoRoundedCorners = true;
            txtpassword.BackColor = Color.Transparent;
            txtpassword.BorderColor = Color.RosyBrown;
            txtpassword.BorderRadius = 34;
            txtpassword.BorderThickness = 3;
            txtpassword.CustomizableEdges = customizableEdges3;
            txtpassword.DefaultText = "";
            txtpassword.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtpassword.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtpassword.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtpassword.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtpassword.Dock = DockStyle.Top;
            txtpassword.FillColor = Color.MistyRose;
            txtpassword.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtpassword.Font = new Font("Segoe Print", 9F, FontStyle.Bold, GraphicsUnit.Point);
            txtpassword.ForeColor = Color.SaddleBrown;
            txtpassword.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtpassword.IconLeft = Properties.Resources._2639882_password_icon;
            txtpassword.IconLeftSize = new Size(40, 40);
            txtpassword.Location = new Point(0, 0);
            txtpassword.Margin = new Padding(4, 4, 4, 4);
            txtpassword.Name = "txtpassword";
            txtpassword.PasswordChar = '●';
            txtpassword.PlaceholderForeColor = Color.SaddleBrown;
            txtpassword.PlaceholderText = "Password";
            txtpassword.SelectedText = "";
            txtpassword.ShadowDecoration.CustomizableEdges = customizableEdges4;
            txtpassword.Size = new Size(828, 71);
            txtpassword.TabIndex = 18;
            txtpassword.TextChanged += txtpassword_TextChanged;
            txtpassword.KeyPress += txtpassword_KeyPress;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            panel2.BackColor = Color.Transparent;
            panel2.Controls.Add(txtuserName);
            panel2.Location = new Point(350, 261);
            panel2.Name = "panel2";
            panel2.Size = new Size(828, 69);
            panel2.TabIndex = 22;
            // 
            // txtuserName
            // 
            txtuserName.AutoRoundedCorners = true;
            txtuserName.BackColor = Color.Transparent;
            txtuserName.BorderColor = Color.RosyBrown;
            txtuserName.BorderRadius = 31;
            txtuserName.BorderThickness = 3;
            txtuserName.CustomizableEdges = customizableEdges5;
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
            txtuserName.ShadowDecoration.CustomizableEdges = customizableEdges6;
            txtuserName.Size = new Size(828, 65);
            txtuserName.TabIndex = 17;
            txtuserName.TextChanged += txtuserName_TextChanged;
            txtuserName.KeyPress += txtuserName_KeyPress;
            // 
            // btnLogIn
            // 
            btnLogIn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnLogIn.BackColor = Color.Transparent;
            btnLogIn.CheckedState.ImageSize = new Size(64, 64);
            btnLogIn.HoverState.ImageSize = new Size(64, 64);
            btnLogIn.Image = Properties.Resources.logIn;
            btnLogIn.ImageOffset = new Point(0, 0);
            btnLogIn.ImageRotate = 0F;
            btnLogIn.Location = new Point(1123, 596);
            btnLogIn.Name = "btnLogIn";
            btnLogIn.PressedState.ImageSize = new Size(64, 64);
            btnLogIn.ShadowDecoration.CustomizableEdges = customizableEdges7;
            btnLogIn.Size = new Size(80, 68);
            btnLogIn.TabIndex = 16;
            btnLogIn.Click += btnLogIn_Click;
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.Transparent;
            btnBack.CheckedState.ImageSize = new Size(64, 64);
            btnBack.HoverState.ImageSize = new Size(64, 64);
            btnBack.Image = Properties.Resources.back;
            btnBack.ImageOffset = new Point(0, 0);
            btnBack.ImageRotate = 0F;
            btnBack.Location = new Point(334, 608);
            btnBack.Name = "btnBack";
            btnBack.PressedState.ImageSize = new Size(64, 64);
            btnBack.ShadowDecoration.CustomizableEdges = customizableEdges8;
            btnBack.Size = new Size(64, 56);
            btnBack.TabIndex = 15;
            btnBack.Click += btnBack_Click;
            // 
            // pnlErrPas
            // 
            pnlErrPas.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            pnlErrPas.BackColor = Color.Transparent;
            pnlErrPas.Controls.Add(lblErrPass);
            pnlErrPas.Location = new Point(362, 510);
            pnlErrPas.Name = "pnlErrPas";
            pnlErrPas.Size = new Size(831, 36);
            pnlErrPas.TabIndex = 10;
            pnlErrPas.Visible = false;
            // 
            // lblErrPass
            // 
            lblErrPass.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            lblErrPass.AutoSize = true;
            lblErrPass.Font = new Font("Segoe Print", 8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lblErrPass.ForeColor = Color.Crimson;
            lblErrPass.Location = new Point(0, 0);
            lblErrPass.Name = "lblErrPass";
            lblErrPass.Size = new Size(419, 28);
            lblErrPass.TabIndex = 10;
            lblErrPass.Text = "User with this Name and Password does not Exist!";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe Print", 16F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.ForeColor = Color.SaddleBrown;
            label1.Location = new Point(648, 167);
            label1.Name = "label1";
            label1.Size = new Size(111, 57);
            label1.TabIndex = 14;
            label1.Text = "Login";
            // 
            // frmSignIn
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PapayaWhip;
            ClientSize = new Size(1578, 850);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmSignIn";
            Text = "signInForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel3.ResumeLayout(false);
            panel2.ResumeLayout(false);
            pnlErrPas.ResumeLayout(false);
            pnlErrPas.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TextBox txtUserName;
        private Panel panel3;
        private Panel panel2;
        private Panel pnlErrorNameIn;
        private Label lblName;
        private Label lblPass;
        private PictureBox pictureBox2;
        private Panel mainPnlPass;
        private Panel pnlErrPas;
        private Label lblErrPass;
        private Panel panel7;
        private Panel panel8;
        private TextBox txtPass;
        private PictureBox pictureBox1;
        private Label label1;
        private Guna.UI2.WinForms.Guna2ImageButton btnBack;
        private Guna.UI2.WinForms.Guna2ImageButton btnLogIn;
        private Guna.UI2.WinForms.Guna2TextBox txtuserName;
        private Guna.UI2.WinForms.Guna2TextBox txtpassword;
        private Guna.UI2.WinForms.Guna2ImageButton btnopen;
        private Guna.UI2.WinForms.Guna2ImageButton btnClose;
        private LinkLabel linkLabel1;
        private Panel panel4;
    }
}