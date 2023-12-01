namespace SignIn
{
    partial class completeOrderAdmin
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
            checkBoxN = new CheckBox();
            checkBoxY = new CheckBox();
            panel2 = new Panel();
            label3 = new Label();
            pnlLblM = new Panel();
            lblErrMain = new Label();
            label2 = new Label();
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
            panel1.BackgroundImage = Properties.Resources.frame_food_ingredients_baking_gently_pink_pastel_background_cooking_flat_lay_with_copy_space_top_view_baking_concept;
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Controls.Add(checkBoxN);
            panel1.Controls.Add(checkBoxY);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(pnlLblM);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(gridVieMenu);
            panel1.Dock = DockStyle.Fill;
            panel1.Font = new Font("Segoe Print", 9F, FontStyle.Bold, GraphicsUnit.Point);
            panel1.ForeColor = Color.SaddleBrown;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(938, 512);
            panel1.TabIndex = 0;
            // 
            // checkBoxN
            // 
            checkBoxN.AutoSize = true;
            checkBoxN.BackColor = Color.Transparent;
            checkBoxN.Location = new Point(477, 469);
            checkBoxN.Name = "checkBoxN";
            checkBoxN.Size = new Size(65, 35);
            checkBoxN.TabIndex = 47;
            checkBoxN.Text = "No";
            checkBoxN.UseVisualStyleBackColor = false;
            checkBoxN.Visible = false;
            // 
            // checkBoxY
            // 
            checkBoxY.AutoSize = true;
            checkBoxY.BackColor = Color.Transparent;
            checkBoxY.Location = new Point(223, 469);
            checkBoxY.Name = "checkBoxY";
            checkBoxY.Size = new Size(69, 35);
            checkBoxY.TabIndex = 43;
            checkBoxY.Text = "Yes";
            checkBoxY.UseVisualStyleBackColor = false;
            checkBoxY.Visible = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Transparent;
            panel2.Controls.Add(label3);
            panel2.Location = new Point(32, 410);
            panel2.Name = "panel2";
            panel2.Size = new Size(903, 41);
            panel2.TabIndex = 46;
            panel2.Visible = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.FlatStyle = FlatStyle.Flat;
            label3.Font = new Font("Segoe Print", 11F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label3.ForeColor = Color.LightCoral;
            label3.Location = new Point(36, 0);
            label3.Name = "label3";
            label3.Size = new Size(221, 38);
            label3.TabIndex = 10;
            label3.Text = "Invalid User Name";
            // 
            // pnlLblM
            // 
            pnlLblM.BackColor = Color.Transparent;
            pnlLblM.Controls.Add(lblErrMain);
            pnlLblM.Location = new Point(32, 369);
            pnlLblM.Name = "pnlLblM";
            pnlLblM.Size = new Size(903, 41);
            pnlLblM.TabIndex = 45;
            pnlLblM.Visible = false;
            // 
            // lblErrMain
            // 
            lblErrMain.AutoSize = true;
            lblErrMain.FlatStyle = FlatStyle.Flat;
            lblErrMain.Font = new Font("Segoe Print", 11F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lblErrMain.ForeColor = Color.LightCoral;
            lblErrMain.Location = new Point(36, 0);
            lblErrMain.Name = "lblErrMain";
            lblErrMain.Size = new Size(221, 38);
            lblErrMain.TabIndex = 10;
            lblErrMain.Text = "Invalid User Name";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe Print", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label2.ForeColor = Color.SaddleBrown;
            label2.Location = new Point(326, 317);
            label2.Name = "label2";
            label2.Size = new Size(294, 31);
            label2.TabIndex = 40;
            label2.Text = "Select the Row To fulfill Order ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.FlatStyle = FlatStyle.Flat;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(75, 31);
            label1.TabIndex = 39;
            label1.Text = "Orders\r\n";
            // 
            // gridVieMenu
            // 
            gridVieMenu.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            gridVieMenu.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.ColumnHeader;
            gridVieMenu.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
            gridVieMenu.BackgroundColor = Color.MistyRose;
            gridVieMenu.BorderStyle = BorderStyle.None;
            gridVieMenu.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridVieMenu.GridColor = Color.RosyBrown;
            gridVieMenu.Location = new Point(124, 28);
            gridVieMenu.Margin = new Padding(5);
            gridVieMenu.MinimumSize = new Size(800, 100);
            gridVieMenu.Name = "gridVieMenu";
            gridVieMenu.ReadOnly = true;
            gridVieMenu.RowHeadersWidth = 62;
            gridVieMenu.RowTemplate.Height = 33;
            gridVieMenu.Size = new Size(800, 284);
            gridVieMenu.TabIndex = 38;
            gridVieMenu.RowHeaderMouseClick += gridVieMenu_RowHeaderMouseClick_1;
            // 
            // completeOrderAdmin
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(938, 512);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "completeOrderAdmin";
            Text = "completeOrderAdmin";
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
        private DataGridView gridVieMenu;
        private Label label1;
        private Label label2;
        private CheckBox checkBoxN;
        private CheckBox checkBoxY;
        private Panel panel2;
        private Label label3;
        private Panel pnlLblM;
        private Label lblErrMain;
    }
}