namespace SignIn
{
    partial class AddAdmin
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges10 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            panel1 = new Panel();
            lblstk = new Label();
            btnLogIn = new Guna.UI2.WinForms.Guna2ImageButton();
            pnlCommnerrAD = new Panel();
            lblUpComnErrAD = new Label();
            mainPnlPass = new Panel();
            txtpassword = new Guna.UI2.WinForms.Guna2TextBox();
            pnlErrPasUpAD = new Panel();
            lblErrPassUpAD = new Label();
            panel3 = new Panel();
            panel2 = new Panel();
            txtuserName = new Guna.UI2.WinForms.Guna2TextBox();
            pnlerrUpNameAD = new Panel();
            lblnameAD = new Label();
            panel4 = new Panel();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label1 = new Label();
            panel1.SuspendLayout();
            pnlCommnerrAD.SuspendLayout();
            mainPnlPass.SuspendLayout();
            pnlErrPasUpAD.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            pnlerrUpNameAD.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.BackgroundImage = Properties.Resources.frame_food_ingredients_baking_gently_pink_pastel_background_cooking_flat_lay_with_copy_space_top_view_baking_concept;
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(lblstk);
            panel1.Controls.Add(btnLogIn);
            panel1.Controls.Add(pnlCommnerrAD);
            panel1.Controls.Add(mainPnlPass);
            panel1.Controls.Add(panel3);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1278, 850);
            panel1.TabIndex = 0;
            // 
            // lblstk
            // 
            lblstk.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            lblstk.AutoSize = true;
            lblstk.Font = new Font("Segoe Print", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lblstk.ForeColor = Color.LightCoral;
            lblstk.Image = Properties.Resources.tick;
            lblstk.ImageAlign = ContentAlignment.MiddleLeft;
            lblstk.Location = new Point(920, 572);
            lblstk.Name = "lblstk";
            lblstk.Size = new Size(182, 31);
            lblstk.TabIndex = 44;
            lblstk.Text = "     Admin Added!";
            lblstk.Visible = false;
            // 
            // btnLogIn
            // 
            btnLogIn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnLogIn.BackColor = Color.Transparent;
            btnLogIn.CheckedState.ImageSize = new Size(64, 64);
            btnLogIn.HoverState.ImageSize = new Size(64, 64);
            btnLogIn.Image = Properties.Resources.SignUp;
            btnLogIn.ImageOffset = new Point(0, 0);
            btnLogIn.ImageRotate = 0F;
            btnLogIn.Location = new Point(972, 592);
            btnLogIn.Name = "btnLogIn";
            btnLogIn.PressedState.ImageSize = new Size(64, 64);
            btnLogIn.ShadowDecoration.CustomizableEdges = customizableEdges6;
            btnLogIn.Size = new Size(80, 68);
            btnLogIn.TabIndex = 26;
            btnLogIn.Click += btnLogIn_Click;
            // 
            // pnlCommnerrAD
            // 
            pnlCommnerrAD.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pnlCommnerrAD.BackColor = Color.Transparent;
            pnlCommnerrAD.Controls.Add(lblUpComnErrAD);
            pnlCommnerrAD.Location = new Point(244, 538);
            pnlCommnerrAD.Name = "pnlCommnerrAD";
            pnlCommnerrAD.Size = new Size(772, 31);
            pnlCommnerrAD.TabIndex = 33;
            pnlCommnerrAD.Visible = false;
            // 
            // lblUpComnErrAD
            // 
            lblUpComnErrAD.AutoSize = true;
            lblUpComnErrAD.Font = new Font("Segoe Print", 8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lblUpComnErrAD.ForeColor = Color.Crimson;
            lblUpComnErrAD.Location = new Point(3, 3);
            lblUpComnErrAD.Name = "lblUpComnErrAD";
            lblUpComnErrAD.Size = new Size(53, 28);
            lblUpComnErrAD.TabIndex = 0;
            lblUpComnErrAD.Text = "Lable";
            // 
            // mainPnlPass
            // 
            mainPnlPass.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            mainPnlPass.BackColor = Color.Transparent;
            mainPnlPass.Controls.Add(txtpassword);
            mainPnlPass.Controls.Add(pnlErrPasUpAD);
            mainPnlPass.Location = new Point(244, 411);
            mainPnlPass.Name = "mainPnlPass";
            mainPnlPass.Size = new Size(772, 109);
            mainPnlPass.TabIndex = 31;
            // 
            // txtpassword
            // 
            txtpassword.Anchor = AnchorStyles.Top;
            txtpassword.AutoRoundedCorners = true;
            txtpassword.BackColor = Color.Transparent;
            txtpassword.BorderColor = Color.RosyBrown;
            txtpassword.BorderRadius = 32;
            txtpassword.BorderThickness = 3;
            txtpassword.CustomizableEdges = customizableEdges7;
            txtpassword.DefaultText = "";
            txtpassword.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtpassword.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtpassword.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtpassword.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtpassword.FillColor = Color.MistyRose;
            txtpassword.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtpassword.Font = new Font("Segoe Print", 9F, FontStyle.Bold, GraphicsUnit.Point);
            txtpassword.ForeColor = Color.SaddleBrown;
            txtpassword.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtpassword.IconLeft = Properties.Resources._2639882_password_icon;
            txtpassword.IconLeftSize = new Size(40, 40);
            txtpassword.Location = new Point(173, -2);
            txtpassword.Margin = new Padding(4, 4, 4, 4);
            txtpassword.Name = "txtpassword";
            txtpassword.PasswordChar = '●';
            txtpassword.PlaceholderForeColor = Color.SaddleBrown;
            txtpassword.PlaceholderText = "Password";
            txtpassword.SelectedText = "";
            txtpassword.ShadowDecoration.CustomizableEdges = customizableEdges8;
            txtpassword.Size = new Size(396, 67);
            txtpassword.TabIndex = 20;
            txtpassword.TextChanged += txtpassword_TextChanged;
            // 
            // pnlErrPasUpAD
            // 
            pnlErrPasUpAD.BackColor = Color.Transparent;
            pnlErrPasUpAD.Controls.Add(lblErrPassUpAD);
            pnlErrPasUpAD.Dock = DockStyle.Bottom;
            pnlErrPasUpAD.Location = new Point(0, 75);
            pnlErrPasUpAD.Name = "pnlErrPasUpAD";
            pnlErrPasUpAD.Size = new Size(772, 34);
            pnlErrPasUpAD.TabIndex = 10;
            pnlErrPasUpAD.Visible = false;
            // 
            // lblErrPassUpAD
            // 
            lblErrPassUpAD.AutoSize = true;
            lblErrPassUpAD.Font = new Font("Segoe Print", 8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lblErrPassUpAD.ForeColor = Color.Crimson;
            lblErrPassUpAD.Location = new Point(3, 3);
            lblErrPassUpAD.Name = "lblErrPassUpAD";
            lblErrPassUpAD.Size = new Size(149, 28);
            lblErrPassUpAD.TabIndex = 10;
            lblErrPassUpAD.Text = "Invalid Password";
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel3.BackColor = Color.Transparent;
            panel3.Controls.Add(panel2);
            panel3.Controls.Add(pnlerrUpNameAD);
            panel3.Location = new Point(244, 296);
            panel3.Name = "panel3";
            panel3.Size = new Size(772, 109);
            panel3.TabIndex = 29;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Transparent;
            panel2.Controls.Add(txtuserName);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(772, 68);
            panel2.TabIndex = 11;
            // 
            // txtuserName
            // 
            txtuserName.Anchor = AnchorStyles.Top;
            txtuserName.AutoRoundedCorners = true;
            txtuserName.BackColor = Color.Transparent;
            txtuserName.BorderColor = Color.RosyBrown;
            txtuserName.BorderRadius = 32;
            txtuserName.BorderThickness = 3;
            txtuserName.CustomizableEdges = customizableEdges9;
            txtuserName.DefaultText = "";
            txtuserName.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtuserName.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtuserName.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtuserName.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtuserName.FillColor = Color.MistyRose;
            txtuserName.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtuserName.Font = new Font("Segoe Print", 9F, FontStyle.Bold, GraphicsUnit.Point);
            txtuserName.ForeColor = Color.SaddleBrown;
            txtuserName.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtuserName.IconLeft = Properties.Resources._1727545;
            txtuserName.IconLeftSize = new Size(40, 40);
            txtuserName.Location = new Point(170, 1);
            txtuserName.Margin = new Padding(4, 4, 4, 4);
            txtuserName.Name = "txtuserName";
            txtuserName.PasswordChar = '\0';
            txtuserName.PlaceholderForeColor = Color.SaddleBrown;
            txtuserName.PlaceholderText = "UserName";
            txtuserName.SelectedText = "";
            txtuserName.ShadowDecoration.CustomizableEdges = customizableEdges10;
            txtuserName.Size = new Size(399, 67);
            txtuserName.TabIndex = 18;
            txtuserName.TextChanged += txtuserName_TextChanged;
            // 
            // pnlerrUpNameAD
            // 
            pnlerrUpNameAD.BackColor = Color.Transparent;
            pnlerrUpNameAD.Controls.Add(lblnameAD);
            pnlerrUpNameAD.Dock = DockStyle.Bottom;
            pnlerrUpNameAD.Location = new Point(0, 75);
            pnlerrUpNameAD.Name = "pnlerrUpNameAD";
            pnlerrUpNameAD.Size = new Size(772, 34);
            pnlerrUpNameAD.TabIndex = 10;
            pnlerrUpNameAD.Visible = false;
            // 
            // lblnameAD
            // 
            lblnameAD.AutoSize = true;
            lblnameAD.Font = new Font("Segoe Print", 8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lblnameAD.ForeColor = Color.Crimson;
            lblnameAD.Location = new Point(3, 6);
            lblnameAD.Name = "lblnameAD";
            lblnameAD.Size = new Size(160, 28);
            lblnameAD.TabIndex = 10;
            lblnameAD.Text = "Invalid User Name";
            // 
            // panel4
            // 
            panel4.Anchor = AnchorStyles.Right;
            panel4.BackColor = Color.RosyBrown;
            panel4.Controls.Add(label5);
            panel4.Controls.Add(label4);
            panel4.Controls.Add(label3);
            panel4.Controls.Add(label1);
            panel4.Location = new Point(2, 1);
            panel4.Name = "panel4";
            panel4.Size = new Size(298, 233);
            panel4.TabIndex = 45;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe Script", 14F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label5.ForeColor = Color.MistyRose;
            label5.Location = new Point(101, 54);
            label5.Name = "label5";
            label5.Size = new Size(129, 46);
            label5.TabIndex = 3;
            label5.Text = "Affraid";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe Script", 14F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label4.ForeColor = Color.MistyRose;
            label4.Location = new Point(112, 143);
            label4.Name = "label4";
            label4.Size = new Size(155, 46);
            label4.TabIndex = 2;
            label4.Text = "Whisks :)";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe Script", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label3.ForeColor = Color.MistyRose;
            label3.Location = new Point(57, 97);
            label3.Name = "label3";
            label3.Size = new Size(101, 40);
            label3.TabIndex = 1;
            label3.Text = "to take";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe Script", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.ForeColor = Color.MistyRose;
            label1.Location = new Point(47, 8);
            label1.Name = "label1";
            label1.Size = new Size(125, 40);
            label1.TabIndex = 0;
            label1.Text = "Don't be";
            // 
            // AddAdmin
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1278, 850);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AddAdmin";
            Text = "AddAdmin";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            pnlCommnerrAD.ResumeLayout(false);
            pnlCommnerrAD.PerformLayout();
            mainPnlPass.ResumeLayout(false);
            pnlErrPasUpAD.ResumeLayout(false);
            pnlErrPasUpAD.PerformLayout();
            panel3.ResumeLayout(false);
            panel2.ResumeLayout(false);
            pnlerrUpNameAD.ResumeLayout(false);
            pnlerrUpNameAD.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel pnlCommnerrAD;
        private Label lblUpComnErrAD;
        private Panel mainPnlPass;
        private Panel pnlErrPasUpAD;
        private Label lblErrPassUpAD;
        private Panel panel3;
        private Panel pnlerrUpNameAD;
        private Label lblnameAD;
        private Panel panel2;
        private Guna.UI2.WinForms.Guna2TextBox txtuserName;
        private Guna.UI2.WinForms.Guna2TextBox txtpassword;
        private Guna.UI2.WinForms.Guna2ImageButton btnLogIn;
        private Label lblstk;
        private Panel panel4;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label1;
    }
}