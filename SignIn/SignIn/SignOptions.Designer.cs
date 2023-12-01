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
            panelChildFormSign = new Panel();
            label1 = new Label();
            btnSignUp = new Button();
            btnLogIn = new Button();
            panelChildFormSign.SuspendLayout();
            SuspendLayout();
            // 
            // panelChildFormSign
            // 
            panelChildFormSign.BackColor = Color.Transparent;
            panelChildFormSign.BackgroundImage = Properties.Resources.frame_food_ingredients_baking_gently_pink_pastel_background_cooking_flat_lay_with_copy_space_top_view_baking_concept;
            panelChildFormSign.BackgroundImageLayout = ImageLayout.Stretch;
            panelChildFormSign.Controls.Add(label1);
            panelChildFormSign.Controls.Add(btnSignUp);
            panelChildFormSign.Controls.Add(btnLogIn);
            panelChildFormSign.Dock = DockStyle.Fill;
            panelChildFormSign.Location = new Point(0, 0);
            panelChildFormSign.Name = "panelChildFormSign";
            panelChildFormSign.Size = new Size(1189, 614);
            panelChildFormSign.TabIndex = 2;
            panelChildFormSign.Paint += panelChildFormSign_Paint;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.FlatStyle = FlatStyle.Flat;
            label1.Font = new Font("Segoe Print", 28F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.SaddleBrown;
            label1.Location = new Point(419, 191);
            label1.Name = "label1";
            label1.Size = new Size(343, 98);
            label1.TabIndex = 3;
            label1.Text = "Sweet Day";
            // 
            // btnSignUp
            // 
            btnSignUp.Anchor = AnchorStyles.None;
            btnSignUp.BackColor = Color.Transparent;
            btnSignUp.FlatStyle = FlatStyle.Flat;
            btnSignUp.Font = new Font("Segoe Print", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnSignUp.ForeColor = Color.SaddleBrown;
            btnSignUp.Location = new Point(673, 452);
            btnSignUp.Name = "btnSignUp";
            btnSignUp.Size = new Size(112, 34);
            btnSignUp.TabIndex = 2;
            btnSignUp.Text = "Sign Up";
            btnSignUp.UseVisualStyleBackColor = false;
            btnSignUp.Click += btnSignUp_Click;
            // 
            // btnLogIn
            // 
            btnLogIn.Anchor = AnchorStyles.None;
            btnLogIn.BackColor = Color.Transparent;
            btnLogIn.FlatStyle = FlatStyle.Flat;
            btnLogIn.Font = new Font("Segoe Print", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnLogIn.ForeColor = Color.SaddleBrown;
            btnLogIn.Location = new Point(376, 452);
            btnLogIn.Name = "btnLogIn";
            btnLogIn.Size = new Size(112, 34);
            btnLogIn.TabIndex = 1;
            btnLogIn.Text = "Log In";
            btnLogIn.UseVisualStyleBackColor = false;
            btnLogIn.Click += button1_Click;
            // 
            // SignOptions
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(1189, 614);
            Controls.Add(panelChildFormSign);
            ForeColor = Color.Black;
            Name = "SignOptions";
            Text = "SignOptions";
            Load += SignOptions_Load;
            panelChildFormSign.ResumeLayout(false);
            panelChildFormSign.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel panelChildFormSign;
        private Button btnSignUp;
        private Button btnLogIn;
        private Label label1;
    }
}