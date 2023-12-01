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
            panel1 = new Panel();
            pnlErrPas = new Panel();
            lblErrPass = new Label();
            label1 = new Label();
            pictureBox2 = new PictureBox();
            mainPnlPass = new Panel();
            panel7 = new Panel();
            panel8 = new Panel();
            txtPass = new TextBox();
            pictureBox1 = new PictureBox();
            panel3 = new Panel();
            panel2 = new Panel();
            pnlErrorNameIn = new Panel();
            txtUserName = new TextBox();
            lblName = new Label();
            lblPass = new Label();
            button2 = new Button();
            btnLogIn = new Button();
            panel1.SuspendLayout();
            pnlErrPas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            mainPnlPass.SuspendLayout();
            panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkSalmon;
            panel1.BackgroundImage = Properties.Resources.frame_food_ingredients_baking_gently_pink_pastel_background_cooking_flat_lay_with_copy_space_top_view_baking_concept;
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Controls.Add(pnlErrPas);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(mainPnlPass);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(lblName);
            panel1.Controls.Add(lblPass);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(btnLogIn);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(889, 563);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // pnlErrPas
            // 
            pnlErrPas.BackColor = Color.Transparent;
            pnlErrPas.Controls.Add(lblErrPass);
            pnlErrPas.Location = new Point(317, 322);
            pnlErrPas.Name = "pnlErrPas";
            pnlErrPas.Size = new Size(432, 42);
            pnlErrPas.TabIndex = 10;
            pnlErrPas.Visible = false;
            pnlErrPas.Paint += pnlErrPas_Paint;
            // 
            // lblErrPass
            // 
            lblErrPass.AutoSize = true;
            lblErrPass.Font = new Font("Segoe Print", 8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lblErrPass.ForeColor = Color.Crimson;
            lblErrPass.Location = new Point(10, 6);
            lblErrPass.Name = "lblErrPass";
            lblErrPass.Size = new Size(419, 28);
            lblErrPass.TabIndex = 10;
            lblErrPass.Text = "User with this Name and Password does not Exist!";
            lblErrPass.Click += lblErrPass_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe Print", 16F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.ForeColor = Color.SaddleBrown;
            label1.Location = new Point(414, 41);
            label1.Name = "label1";
            label1.Size = new Size(111, 57);
            label1.TabIndex = 14;
            label1.Text = "Login";
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Image = Properties.Resources._2639882_password_icon;
            pictureBox2.Location = new Point(102, 249);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(67, 51);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 13;
            pictureBox2.TabStop = false;
            // 
            // mainPnlPass
            // 
            mainPnlPass.BackColor = Color.Transparent;
            mainPnlPass.Controls.Add(panel7);
            mainPnlPass.Location = new Point(317, 239);
            mainPnlPass.Name = "mainPnlPass";
            mainPnlPass.Size = new Size(432, 77);
            mainPnlPass.TabIndex = 12;
            // 
            // panel7
            // 
            panel7.Controls.Add(panel8);
            panel7.Controls.Add(txtPass);
            panel7.Dock = DockStyle.Top;
            panel7.Location = new Point(0, 0);
            panel7.Name = "panel7";
            panel7.Size = new Size(432, 68);
            panel7.TabIndex = 8;
            // 
            // panel8
            // 
            panel8.BackColor = Color.RosyBrown;
            panel8.Location = new Point(18, 55);
            panel8.Name = "panel8";
            panel8.Size = new Size(400, 1);
            panel8.TabIndex = 9;
            // 
            // txtPass
            // 
            txtPass.BackColor = Color.MistyRose;
            txtPass.BorderStyle = BorderStyle.None;
            txtPass.Font = new Font("Segoe Print", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            txtPass.ForeColor = Color.SaddleBrown;
            txtPass.Location = new Point(14, 10);
            txtPass.Name = "txtPass";
            txtPass.Size = new Size(400, 32);
            txtPass.TabIndex = 0;
            txtPass.TextChanged += txtPass_TextChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = Properties.Resources._1727545;
            pictureBox1.Location = new Point(102, 141);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(67, 51);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Transparent;
            panel3.Controls.Add(panel2);
            panel3.Location = new Point(317, 124);
            panel3.Name = "panel3";
            panel3.Size = new Size(432, 77);
            panel3.TabIndex = 9;
            // 
            // panel2
            // 
            panel2.Controls.Add(pnlErrorNameIn);
            panel2.Controls.Add(txtUserName);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(432, 68);
            panel2.TabIndex = 8;
            // 
            // pnlErrorNameIn
            // 
            pnlErrorNameIn.BackColor = Color.RosyBrown;
            pnlErrorNameIn.Location = new Point(18, 55);
            pnlErrorNameIn.Name = "pnlErrorNameIn";
            pnlErrorNameIn.Size = new Size(400, 1);
            pnlErrorNameIn.TabIndex = 9;
            // 
            // txtUserName
            // 
            txtUserName.BackColor = Color.MistyRose;
            txtUserName.BorderStyle = BorderStyle.None;
            txtUserName.Font = new Font("Segoe Print", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            txtUserName.ForeColor = Color.SaddleBrown;
            txtUserName.Location = new Point(18, 17);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(400, 32);
            txtUserName.TabIndex = 0;
            txtUserName.TextChanged += textBox1_TextChanged;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.BackColor = Color.Transparent;
            lblName.Font = new Font("Segoe Print", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lblName.ForeColor = Color.SaddleBrown;
            lblName.Location = new Point(175, 149);
            lblName.Name = "lblName";
            lblName.Size = new Size(121, 31);
            lblName.TabIndex = 6;
            lblName.Text = "User Name ";
            lblName.Click += lblName_Click;
            // 
            // lblPass
            // 
            lblPass.AutoSize = true;
            lblPass.BackColor = Color.Transparent;
            lblPass.Font = new Font("Segoe Print", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lblPass.ForeColor = Color.SaddleBrown;
            lblPass.Location = new Point(175, 264);
            lblPass.Name = "lblPass";
            lblPass.Size = new Size(101, 31);
            lblPass.TabIndex = 7;
            lblPass.Text = "Password";
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.None;
            button2.BackColor = Color.Transparent;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe Print", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button2.ForeColor = Color.SaddleBrown;
            button2.Location = new Point(164, 413);
            button2.Name = "button2";
            button2.Size = new Size(112, 34);
            button2.TabIndex = 5;
            button2.Text = "Back";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // btnLogIn
            // 
            btnLogIn.Anchor = AnchorStyles.None;
            btnLogIn.BackColor = Color.Transparent;
            btnLogIn.FlatStyle = FlatStyle.Flat;
            btnLogIn.Font = new Font("Segoe Print", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnLogIn.ForeColor = Color.SaddleBrown;
            btnLogIn.Location = new Point(637, 413);
            btnLogIn.Name = "btnLogIn";
            btnLogIn.Size = new Size(112, 34);
            btnLogIn.TabIndex = 4;
            btnLogIn.Text = "Log In";
            btnLogIn.UseVisualStyleBackColor = false;
            btnLogIn.Click += button1_Click;
            // 
            // frmSignIn
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PapayaWhip;
            ClientSize = new Size(889, 563);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmSignIn";
            Text = "signInForm";
            Load += frmSignIn_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            pnlErrPas.ResumeLayout(false);
            pnlErrPas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            mainPnlPass.ResumeLayout(false);
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel3.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TextBox txtUserName;
        private Button button2;
        private Button btnLogIn;
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
    }
}