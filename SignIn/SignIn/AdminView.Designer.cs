namespace SignIn
{
    partial class AdminView
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
            pnlViewAdmin = new Panel();
            gridVieMenu = new DataGridView();
            pnlViewAdmin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gridVieMenu).BeginInit();
            SuspendLayout();
            // 
            // pnlViewAdmin
            // 
            pnlViewAdmin.BackColor = Color.Transparent;
            pnlViewAdmin.BackgroundImage = Properties.Resources.frame_food_ingredients_baking_gently_pink_pastel_background_cooking_flat_lay_with_copy_space_top_view_baking_concept;
            pnlViewAdmin.BackgroundImageLayout = ImageLayout.Stretch;
            pnlViewAdmin.Controls.Add(gridVieMenu);
            pnlViewAdmin.Dock = DockStyle.Fill;
            pnlViewAdmin.Location = new Point(0, 0);
            pnlViewAdmin.Margin = new Padding(4);
            pnlViewAdmin.Name = "pnlViewAdmin";
            pnlViewAdmin.Size = new Size(1152, 704);
            pnlViewAdmin.TabIndex = 0;
            // 
            // gridVieMenu
            // 
            gridVieMenu.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.ColumnHeader;
            gridVieMenu.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
            gridVieMenu.BackgroundColor = Color.MistyRose;
            gridVieMenu.BorderStyle = BorderStyle.None;
            gridVieMenu.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridVieMenu.Dock = DockStyle.Fill;
            gridVieMenu.GridColor = Color.RosyBrown;
            gridVieMenu.Location = new Point(0, 0);
            gridVieMenu.Margin = new Padding(4);
            gridVieMenu.Name = "gridVieMenu";
            gridVieMenu.ReadOnly = true;
            gridVieMenu.RowHeadersWidth = 62;
            gridVieMenu.RowTemplate.Height = 33;
            gridVieMenu.Size = new Size(1152, 704);
            gridVieMenu.TabIndex = 0;
            // 
            // AdminView
            // 
            AutoScaleDimensions = new SizeF(12F, 31F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1152, 704);
            Controls.Add(pnlViewAdmin);
            Font = new Font("Segoe Print", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            ForeColor = Color.SaddleBrown;
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "AdminView";
            Text = "AdminAdd";
            pnlViewAdmin.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)gridVieMenu).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlViewAdmin;
        private DataGridView gridVieMenu;
    }
}