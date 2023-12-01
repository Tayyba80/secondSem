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
            pnlSubStk = new Panel();
            btnTHstk = new Button();
            btnStock = new Button();
            lblMName = new Label();
            pnlSubStk.SuspendLayout();
            SuspendLayout();
            // 
            // pnlSubStk
            // 
            pnlSubStk.BackColor = Color.Transparent;
            pnlSubStk.BackgroundImage = Properties.Resources.frame_food_ingredients_baking_gently_pink_pastel_background_cooking_flat_lay_with_copy_space_top_view_baking_concept;
            pnlSubStk.BackgroundImageLayout = ImageLayout.Stretch;
            pnlSubStk.Controls.Add(btnTHstk);
            pnlSubStk.Controls.Add(btnStock);
            pnlSubStk.Controls.Add(lblMName);
            pnlSubStk.Dock = DockStyle.Fill;
            pnlSubStk.Location = new Point(0, 0);
            pnlSubStk.Name = "pnlSubStk";
            pnlSubStk.Size = new Size(960, 568);
            pnlSubStk.TabIndex = 0;
            // 
            // btnTHstk
            // 
            btnTHstk.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnTHstk.FlatStyle = FlatStyle.Flat;
            btnTHstk.Font = new Font("Segoe Print", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnTHstk.ForeColor = Color.SaddleBrown;
            btnTHstk.Location = new Point(623, 307);
            btnTHstk.Name = "btnTHstk";
            btnTHstk.Size = new Size(231, 34);
            btnTHstk.TabIndex = 32;
            btnTHstk.Text = "Threshold Stock";
            btnTHstk.UseVisualStyleBackColor = true;
            btnTHstk.Click += btnTHstk_Click;
            // 
            // btnStock
            // 
            btnStock.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnStock.FlatStyle = FlatStyle.Flat;
            btnStock.Font = new Font("Segoe Print", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnStock.ForeColor = Color.SaddleBrown;
            btnStock.Location = new Point(137, 307);
            btnStock.Name = "btnStock";
            btnStock.Size = new Size(231, 34);
            btnStock.TabIndex = 31;
            btnStock.Text = "Normal Stock";
            btnStock.UseVisualStyleBackColor = true;
            btnStock.Click += btnStock_Click;
            // 
            // lblMName
            // 
            lblMName.AutoSize = true;
            lblMName.Font = new Font("Segoe Print", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lblMName.ForeColor = Color.SaddleBrown;
            lblMName.Location = new Point(261, 103);
            lblMName.Name = "lblMName";
            lblMName.Size = new Size(472, 43);
            lblMName.TabIndex = 26;
            lblMName.Text = "Which stock do you want to Update?";
            // 
            // UpdateStock
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(960, 568);
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
        private Button btnTHstk;
        private Button btnStock;
        private Label lblMName;
    }
}