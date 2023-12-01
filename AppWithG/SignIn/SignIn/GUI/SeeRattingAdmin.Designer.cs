namespace SignIn
{
    partial class SeeRattingAdmin
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
            panel2 = new Panel();
            label5 = new Label();
            label4 = new Label();
            label2 = new Label();
            pnlLblM = new Panel();
            lblErrMain = new Label();
            label1 = new Label();
            gridVieMenu = new DataGridView();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            pnlLblM.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gridVieMenu).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.BackgroundImage = Properties.Resources.frame_food_ingredients_baking_gently_pink_pastel_background_cooking_flat_lay_with_copy_space_top_view_baking_concept;
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(pnlLblM);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(gridVieMenu);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1278, 850);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            panel2.BackColor = Color.Transparent;
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(892, 67);
            panel2.Name = "panel2";
            panel2.Size = new Size(298, 233);
            panel2.TabIndex = 41;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe Script", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(85, 75);
            label5.Name = "label5";
            label5.Size = new Size(57, 40);
            label5.TabIndex = 3;
            label5.Text = "till";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe Script", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(20, 127);
            label4.Name = "label4";
            label4.Size = new Size(172, 40);
            label4.TabIndex = 2;
            label4.Text = "you Make it";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe Script", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(42, 22);
            label2.Name = "label2";
            label2.Size = new Size(110, 40);
            label2.TabIndex = 0;
            label2.Text = "Bake it";
            // 
            // pnlLblM
            // 
            pnlLblM.BackColor = Color.Transparent;
            pnlLblM.Controls.Add(lblErrMain);
            pnlLblM.Location = new Point(13, 591);
            pnlLblM.Name = "pnlLblM";
            pnlLblM.Size = new Size(903, 55);
            pnlLblM.TabIndex = 40;
            pnlLblM.Visible = false;
            // 
            // lblErrMain
            // 
            lblErrMain.AutoSize = true;
            lblErrMain.FlatStyle = FlatStyle.Flat;
            lblErrMain.Font = new Font("Segoe Print", 14F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lblErrMain.ForeColor = Color.Crimson;
            lblErrMain.Location = new Point(144, 6);
            lblErrMain.Name = "lblErrMain";
            lblErrMain.Size = new Size(282, 50);
            lblErrMain.TabIndex = 10;
            lblErrMain.Text = "Invalid User Name";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.FlatStyle = FlatStyle.Flat;
            label1.Font = new Font("Segoe Print", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.SaddleBrown;
            label1.Location = new Point(253, 251);
            label1.Name = "label1";
            label1.Size = new Size(89, 31);
            label1.TabIndex = 39;
            label1.Text = "Rattings";
            // 
            // gridVieMenu
            // 
            gridVieMenu.AllowUserToAddRows = false;
            gridVieMenu.Anchor = AnchorStyles.Top;
            gridVieMenu.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.ColumnHeader;
            gridVieMenu.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
            gridVieMenu.BackgroundColor = Color.MistyRose;
            gridVieMenu.BorderStyle = BorderStyle.None;
            gridVieMenu.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridVieMenu.GridColor = Color.RosyBrown;
            gridVieMenu.Location = new Point(292, 308);
            gridVieMenu.Margin = new Padding(5);
            gridVieMenu.MaximumSize = new Size(700, 500);
            gridVieMenu.Name = "gridVieMenu";
            gridVieMenu.ReadOnly = true;
            gridVieMenu.RowHeadersWidth = 62;
            gridVieMenu.RowTemplate.Height = 33;
            gridVieMenu.Size = new Size(464, 255);
            gridVieMenu.TabIndex = 38;
            // 
            // SeeRattingAdmin
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1278, 850);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "SeeRattingAdmin";
            Text = "SeeRattingAdmin";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            pnlLblM.ResumeLayout(false);
            pnlLblM.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)gridVieMenu).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel pnlLblM;
        private Label lblErrMain;
        private Label label1;
        private DataGridView gridVieMenu;
        private Panel panel2;
        private Label label5;
        private Label label4;
        private Label label2;
    }
}