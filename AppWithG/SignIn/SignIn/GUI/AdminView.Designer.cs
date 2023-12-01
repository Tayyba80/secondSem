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
            panel1 = new Panel();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            gridVieMenu = new DataGridView();
            pnlViewAdmin.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gridVieMenu).BeginInit();
            SuspendLayout();
            // 
            // pnlViewAdmin
            // 
            pnlViewAdmin.BackColor = Color.Transparent;
            pnlViewAdmin.BackgroundImage = Properties.Resources.frame_food_ingredients_baking_gently_pink_pastel_background_cooking_flat_lay_with_copy_space_top_view_baking_concept;
            pnlViewAdmin.BackgroundImageLayout = ImageLayout.Stretch;
            pnlViewAdmin.Controls.Add(panel1);
            pnlViewAdmin.Controls.Add(label1);
            pnlViewAdmin.Controls.Add(gridVieMenu);
            pnlViewAdmin.Dock = DockStyle.Fill;
            pnlViewAdmin.Location = new Point(0, 0);
            pnlViewAdmin.Margin = new Padding(4);
            pnlViewAdmin.Name = "pnlViewAdmin";
            pnlViewAdmin.Size = new Size(1152, 704);
            pnlViewAdmin.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            panel1.BackColor = Color.LightCoral;
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(831, 440);
            panel1.Name = "panel1";
            panel1.Size = new Size(320, 263);
            panel1.TabIndex = 2;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe Script", 14F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label5.ForeColor = Color.MistyRose;
            label5.Location = new Point(52, 56);
            label5.Name = "label5";
            label5.Size = new Size(110, 46);
            label5.TabIndex = 7;
            label5.Text = "World";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe Script", 14F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label4.ForeColor = Color.MistyRose;
            label4.Location = new Point(67, 143);
            label4.Name = "label4";
            label4.Size = new Size(101, 46);
            label4.TabIndex = 6;
            label4.Text = "Place";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe Script", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label3.ForeColor = Color.MistyRose;
            label3.Location = new Point(92, 104);
            label3.Name = "label3";
            label3.Size = new Size(115, 40);
            label3.TabIndex = 5;
            label3.Text = "a better";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe Script", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label2.ForeColor = Color.MistyRose;
            label2.Location = new Point(92, 8);
            label2.Name = "label2";
            label2.Size = new Size(127, 40);
            label2.TabIndex = 4;
            label2.Text = "Bake the";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Location = new Point(52, 75);
            label1.Name = "label1";
            label1.Size = new Size(138, 31);
            label1.TabIndex = 1;
            label1.Text = "Your makings";
            // 
            // gridVieMenu
            // 
            gridVieMenu.AllowUserToAddRows = false;
            gridVieMenu.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            gridVieMenu.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.ColumnHeader;
            gridVieMenu.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
            gridVieMenu.BackgroundColor = Color.MistyRose;
            gridVieMenu.BorderStyle = BorderStyle.None;
            gridVieMenu.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridVieMenu.GridColor = Color.RosyBrown;
            gridVieMenu.Location = new Point(161, 131);
            gridVieMenu.Margin = new Padding(4);
            gridVieMenu.Name = "gridVieMenu";
            gridVieMenu.ReadOnly = true;
            gridVieMenu.RowHeadersWidth = 62;
            gridVieMenu.RowTemplate.Height = 33;
            gridVieMenu.Size = new Size(643, 345);
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
            pnlViewAdmin.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)gridVieMenu).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlViewAdmin;
        private DataGridView gridVieMenu;
        private Label label1;
        private Panel panel1;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
    }
}