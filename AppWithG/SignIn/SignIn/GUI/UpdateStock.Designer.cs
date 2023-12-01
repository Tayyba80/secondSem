namespace SignIn
{
    partial class UpdateStock
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
            pnlSubStk = new Panel();
            btnT = new Guna.UI2.WinForms.Guna2GradientButton();
            btnNor = new Guna.UI2.WinForms.Guna2GradientButton();
            lblMName = new Label();
            pnlSubStk.SuspendLayout();
            SuspendLayout();
            // 
            // pnlSubStk
            // 
            pnlSubStk.BackColor = Color.Transparent;
            pnlSubStk.BackgroundImage = Properties.Resources.frame_food_ingredients_baking_gently_pink_pastel_background_cooking_flat_lay_with_copy_space_top_view_baking_concept;
            pnlSubStk.BackgroundImageLayout = ImageLayout.Stretch;
            pnlSubStk.Controls.Add(btnT);
            pnlSubStk.Controls.Add(btnNor);
            pnlSubStk.Controls.Add(lblMName);
            pnlSubStk.Dock = DockStyle.Fill;
            pnlSubStk.Location = new Point(0, 0);
            pnlSubStk.Name = "pnlSubStk";
            pnlSubStk.Size = new Size(1278, 850);
            pnlSubStk.TabIndex = 0;
            // 
            // btnT
            // 
            btnT.Anchor = AnchorStyles.Top;
            btnT.AutoRoundedCorners = true;
            btnT.BorderColor = Color.Transparent;
            btnT.BorderRadius = 33;
            btnT.CustomizableEdges = customizableEdges1;
            btnT.DisabledState.BorderColor = Color.DarkGray;
            btnT.DisabledState.CustomBorderColor = Color.DarkGray;
            btnT.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnT.DisabledState.FillColor2 = Color.FromArgb(169, 169, 169);
            btnT.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnT.FillColor = Color.RosyBrown;
            btnT.FillColor2 = Color.MistyRose;
            btnT.Font = new Font("Segoe Print", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnT.ForeColor = Color.SaddleBrown;
            btnT.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            btnT.Image = Properties.Resources.updata;
            btnT.ImageAlign = HorizontalAlignment.Left;
            btnT.ImageSize = new Size(30, 30);
            btnT.Location = new Point(510, 431);
            btnT.Name = "btnT";
            btnT.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btnT.Size = new Size(220, 68);
            btnT.TabIndex = 49;
            btnT.Text = "Threshold Stock";
            btnT.TextAlign = HorizontalAlignment.Left;
            btnT.Click += btnT_Click;
            // 
            // btnNor
            // 
            btnNor.Anchor = AnchorStyles.Top;
            btnNor.AutoRoundedCorners = true;
            btnNor.BorderColor = Color.Transparent;
            btnNor.BorderRadius = 33;
            btnNor.CustomizableEdges = customizableEdges3;
            btnNor.DisabledState.BorderColor = Color.DarkGray;
            btnNor.DisabledState.CustomBorderColor = Color.DarkGray;
            btnNor.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnNor.DisabledState.FillColor2 = Color.FromArgb(169, 169, 169);
            btnNor.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnNor.FillColor = Color.RosyBrown;
            btnNor.FillColor2 = Color.MistyRose;
            btnNor.Font = new Font("Segoe Print", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnNor.ForeColor = Color.SaddleBrown;
            btnNor.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            btnNor.Image = Properties.Resources.updata;
            btnNor.ImageAlign = HorizontalAlignment.Left;
            btnNor.ImageSize = new Size(30, 30);
            btnNor.Location = new Point(510, 340);
            btnNor.Name = "btnNor";
            btnNor.ShadowDecoration.CustomizableEdges = customizableEdges4;
            btnNor.Size = new Size(220, 68);
            btnNor.TabIndex = 48;
            btnNor.Text = "Normal Stock";
            btnNor.TextAlign = HorizontalAlignment.Left;
            btnNor.Click += btnNor_Click;
            // 
            // lblMName
            // 
            lblMName.Anchor = AnchorStyles.Top;
            lblMName.AutoSize = true;
            lblMName.Font = new Font("Segoe Print", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lblMName.ForeColor = Color.SaddleBrown;
            lblMName.Location = new Point(351, 243);
            lblMName.Name = "lblMName";
            lblMName.Size = new Size(472, 43);
            lblMName.TabIndex = 26;
            lblMName.Text = "Which stock do you want to Update?";
            // 
            // UpdateStock
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1278, 850);
            Controls.Add(pnlSubStk);
            FormBorderStyle = FormBorderStyle.None;
            Name = "UpdateStock";
            Text = "UpdateStock";
            pnlSubStk.ResumeLayout(false);
            pnlSubStk.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlSubStk;
        private Label lblMName;
        private Guna.UI2.WinForms.Guna2GradientButton btnT;
        private Guna.UI2.WinForms.Guna2GradientButton btnNor;
    }
}