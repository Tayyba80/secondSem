namespace SignIn
{
    partial class changePassCust
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
            btnAdd = new Guna.UI2.WinForms.Guna2CircleButton();
            pnlComErr = new Panel();
            guna2ImageButton1 = new Guna.UI2.WinForms.Guna2ImageButton();
            btnHide = new Guna.UI2.WinForms.Guna2ImageButton();
            lblCommonErr = new Label();
            txtpassword = new Guna.UI2.WinForms.Guna2TextBox();
            panel2 = new Panel();
            label1 = new Label();
            txtuserName = new Guna.UI2.WinForms.Guna2TextBox();
            pnlErrPas = new Panel();
            lblErrPass = new Label();
            panel1.SuspendLayout();
            pnlComErr.SuspendLayout();
            panel2.SuspendLayout();
            pnlErrPas.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackgroundImage = Properties.Resources.custBack;
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Controls.Add(btnAdd);
            panel1.Controls.Add(pnlComErr);
            panel1.Controls.Add(txtpassword);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(txtuserName);
            panel1.Controls.Add(pnlErrPas);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1278, 793);
            panel1.TabIndex = 0;
            // 
            // btnAdd
            // 
            btnAdd.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnAdd.BackColor = Color.Transparent;
            btnAdd.DisabledState.BorderColor = Color.DarkGray;
            btnAdd.DisabledState.CustomBorderColor = Color.DarkGray;
            btnAdd.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnAdd.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnAdd.FillColor = Color.PeachPuff;
            btnAdd.Font = new Font("Segoe Print", 11F, FontStyle.Bold, GraphicsUnit.Point);
            btnAdd.ForeColor = Color.SaddleBrown;
            btnAdd.Location = new Point(768, 568);
            btnAdd.Name = "btnAdd";
            btnAdd.ShadowDecoration.CustomizableEdges = customizableEdges1;
            btnAdd.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            btnAdd.Size = new Size(135, 87);
            btnAdd.TabIndex = 35;
            btnAdd.Text = "Change";
            btnAdd.Click += btnAdd_Click;
            // 
            // pnlComErr
            // 
            pnlComErr.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            pnlComErr.BackColor = Color.Transparent;
            pnlComErr.Controls.Add(guna2ImageButton1);
            pnlComErr.Controls.Add(btnHide);
            pnlComErr.Controls.Add(lblCommonErr);
            pnlComErr.Location = new Point(374, 483);
            pnlComErr.Name = "pnlComErr";
            pnlComErr.Size = new Size(432, 42);
            pnlComErr.TabIndex = 23;
            pnlComErr.Visible = false;
            // 
            // guna2ImageButton1
            // 
            guna2ImageButton1.Anchor = AnchorStyles.Top;
            guna2ImageButton1.BackColor = Color.Transparent;
            guna2ImageButton1.CheckedState.ImageSize = new Size(64, 64);
            guna2ImageButton1.HoverState.ImageSize = new Size(64, 64);
            guna2ImageButton1.Image = Properties.Resources.showPass;
            guna2ImageButton1.ImageOffset = new Point(0, 0);
            guna2ImageButton1.ImageRotate = 0F;
            guna2ImageButton1.Location = new Point(303, 42);
            guna2ImageButton1.Name = "guna2ImageButton1";
            guna2ImageButton1.PressedState.ImageSize = new Size(64, 64);
            guna2ImageButton1.ShadowDecoration.CustomizableEdges = customizableEdges2;
            guna2ImageButton1.Size = new Size(69, 45);
            guna2ImageButton1.TabIndex = 25;
            // 
            // btnHide
            // 
            btnHide.Anchor = AnchorStyles.Top;
            btnHide.BackColor = Color.Transparent;
            btnHide.CheckedState.ImageSize = new Size(64, 64);
            btnHide.HoverState.ImageSize = new Size(64, 64);
            btnHide.Image = Properties.Resources.hidePass;
            btnHide.ImageOffset = new Point(0, 0);
            btnHide.ImageRotate = 0F;
            btnHide.Location = new Point(303, 42);
            btnHide.Name = "btnHide";
            btnHide.PressedState.ImageSize = new Size(64, 64);
            btnHide.ShadowDecoration.CustomizableEdges = customizableEdges3;
            btnHide.Size = new Size(69, 45);
            btnHide.TabIndex = 24;
            // 
            // lblCommonErr
            // 
            lblCommonErr.AutoSize = true;
            lblCommonErr.Font = new Font("Segoe Print", 11F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lblCommonErr.ForeColor = Color.Crimson;
            lblCommonErr.Location = new Point(42, 4);
            lblCommonErr.Name = "lblCommonErr";
            lblCommonErr.Size = new Size(90, 38);
            lblCommonErr.TabIndex = 10;
            lblCommonErr.Text = "Wrong";
            // 
            // txtpassword
            // 
            txtpassword.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtpassword.AutoRoundedCorners = true;
            txtpassword.BackColor = Color.Transparent;
            txtpassword.BorderColor = Color.SaddleBrown;
            txtpassword.BorderRadius = 32;
            txtpassword.BorderThickness = 3;
            txtpassword.CustomizableEdges = customizableEdges4;
            txtpassword.DefaultText = "";
            txtpassword.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtpassword.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtpassword.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtpassword.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtpassword.FillColor = Color.PeachPuff;
            txtpassword.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtpassword.Font = new Font("Segoe Print", 9F, FontStyle.Bold, GraphicsUnit.Point);
            txtpassword.ForeColor = Color.SaddleBrown;
            txtpassword.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtpassword.IconLeft = Properties.Resources._2639882_password_icon;
            txtpassword.IconLeftSize = new Size(40, 40);
            txtpassword.Location = new Point(393, 320);
            txtpassword.Margin = new Padding(4, 4, 4, 4);
            txtpassword.Name = "txtpassword";
            txtpassword.PasswordChar = '●';
            txtpassword.PlaceholderForeColor = Color.SaddleBrown;
            txtpassword.PlaceholderText = "New Password";
            txtpassword.SelectedText = "";
            txtpassword.ShadowDecoration.CustomizableEdges = customizableEdges5;
            txtpassword.Size = new Size(338, 67);
            txtpassword.TabIndex = 23;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            panel2.BackColor = Color.Transparent;
            panel2.Controls.Add(label1);
            panel2.Location = new Point(374, 405);
            panel2.Name = "panel2";
            panel2.Size = new Size(432, 42);
            panel2.TabIndex = 19;
            panel2.Visible = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe Print", 8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.ForeColor = Color.Crimson;
            label1.Location = new Point(10, 6);
            label1.Name = "label1";
            label1.Size = new Size(419, 28);
            label1.TabIndex = 10;
            label1.Text = "User with this Name and Password does not Exist!";
            // 
            // txtuserName
            // 
            txtuserName.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtuserName.AutoRoundedCorners = true;
            txtuserName.BackColor = Color.Transparent;
            txtuserName.BorderColor = Color.SaddleBrown;
            txtuserName.BorderRadius = 32;
            txtuserName.BorderThickness = 3;
            txtuserName.CustomizableEdges = customizableEdges6;
            txtuserName.DefaultText = "";
            txtuserName.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtuserName.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtuserName.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtuserName.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtuserName.FillColor = Color.PeachPuff;
            txtuserName.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtuserName.Font = new Font("Segoe Print", 9F, FontStyle.Bold, GraphicsUnit.Point);
            txtuserName.ForeColor = Color.SaddleBrown;
            txtuserName.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtuserName.IconLeft = Properties.Resources._2639882_password_icon;
            txtuserName.IconLeftSize = new Size(40, 40);
            txtuserName.Location = new Point(393, 182);
            txtuserName.Margin = new Padding(4, 4, 4, 4);
            txtuserName.Name = "txtuserName";
            txtuserName.PasswordChar = '\0';
            txtuserName.PlaceholderForeColor = Color.SaddleBrown;
            txtuserName.PlaceholderText = "Previous Password";
            txtuserName.SelectedText = "";
            txtuserName.ShadowDecoration.CustomizableEdges = customizableEdges7;
            txtuserName.Size = new Size(338, 67);
            txtuserName.TabIndex = 22;
            // 
            // pnlErrPas
            // 
            pnlErrPas.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            pnlErrPas.BackColor = Color.Transparent;
            pnlErrPas.Controls.Add(lblErrPass);
            pnlErrPas.Location = new Point(371, 256);
            pnlErrPas.Name = "pnlErrPas";
            pnlErrPas.Size = new Size(432, 42);
            pnlErrPas.TabIndex = 15;
            pnlErrPas.Visible = false;
            // 
            // lblErrPass
            // 
            lblErrPass.AutoSize = true;
            lblErrPass.Font = new Font("Segoe Print", 8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lblErrPass.ForeColor = Color.Crimson;
            lblErrPass.Location = new Point(3, 0);
            lblErrPass.Name = "lblErrPass";
            lblErrPass.Size = new Size(419, 28);
            lblErrPass.TabIndex = 10;
            lblErrPass.Text = "User with this Name and Password does not Exist!";
            // 
            // changePassCust
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1278, 793);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "changePassCust";
            Text = "changePassCust";
            panel1.ResumeLayout(false);
            pnlComErr.ResumeLayout(false);
            pnlComErr.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            pnlErrPas.ResumeLayout(false);
            pnlErrPas.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label label1;
        private Panel pnlErrPas;
        private Label lblErrPass;
        private Panel pnlComErr;
        private Label lblCommonErr;
        private Guna.UI2.WinForms.Guna2ImageButton guna2ImageButton1;
        private Guna.UI2.WinForms.Guna2ImageButton btnHide;
        private Guna.UI2.WinForms.Guna2TextBox txtpassword;
        private Guna.UI2.WinForms.Guna2TextBox txtuserName;
        private Guna.UI2.WinForms.Guna2CircleButton btnAdd;
    }
}