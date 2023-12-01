namespace SignIn
{
    partial class toFulfillOrder
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
            label3 = new Label();
            pnlLblM = new Panel();
            lblErrMain = new Label();
            label2 = new Label();
            gridVieMenu = new DataGridView();
            label1 = new Label();
            checkBoxY = new CheckBox();
            checkBoxN = new CheckBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            pnlLblM.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gridVieMenu).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkSalmon;
            panel1.BackgroundImage = Properties.Resources.frame_food_ingredients_baking_gently_pink_pastel_background_cooking_flat_lay_with_copy_space_top_view_baking_concept;
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Controls.Add(checkBoxN);
            panel1.Controls.Add(checkBoxY);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(pnlLblM);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(gridVieMenu);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Fill;
            panel1.Font = new Font("Segoe Print", 9F, FontStyle.Bold, GraphicsUnit.Point);
            panel1.ForeColor = Color.SaddleBrown;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(938, 512);
            panel1.TabIndex = 1;
            panel1.Visible = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Transparent;
            panel2.Controls.Add(label3);
            panel2.Location = new Point(32, 387);
            panel2.Name = "panel2";
            panel2.Size = new Size(903, 41);
            panel2.TabIndex = 41;
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
            pnlLblM.Location = new Point(32, 346);
            pnlLblM.Name = "pnlLblM";
            pnlLblM.Size = new Size(903, 41);
            pnlLblM.TabIndex = 40;
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
            label2.Location = new Point(336, 312);
            label2.Name = "label2";
            label2.Size = new Size(294, 31);
            label2.TabIndex = 39;
            label2.Text = "Select the Row To fulfill Order ";
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
            gridVieMenu.Location = new Point(124, 23);
            gridVieMenu.Margin = new Padding(5);
            gridVieMenu.MinimumSize = new Size(800, 200);
            gridVieMenu.Name = "gridVieMenu";
            gridVieMenu.ReadOnly = true;
            gridVieMenu.RowHeadersWidth = 62;
            gridVieMenu.RowTemplate.Height = 33;
            gridVieMenu.Size = new Size(800, 284);
            gridVieMenu.TabIndex = 37;
            gridVieMenu.RowHeaderMouseClick += gridVieMenu_RowHeaderMouseClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.FlatStyle = FlatStyle.Flat;
            label1.Location = new Point(27, 23);
            label1.Name = "label1";
            label1.Size = new Size(75, 31);
            label1.TabIndex = 36;
            label1.Text = "Orders\r\n";
            // 
            // checkBoxY
            // 
            checkBoxY.AutoSize = true;
            checkBoxY.BackColor = Color.Transparent;
            checkBoxY.Location = new Point(223, 446);
            checkBoxY.Name = "checkBoxY";
            checkBoxY.Size = new Size(69, 35);
            checkBoxY.TabIndex = 11;
            checkBoxY.Text = "Yes";
            checkBoxY.UseVisualStyleBackColor = false;
            // 
            // checkBoxN
            // 
            checkBoxN.AutoSize = true;
            checkBoxN.BackColor = Color.Transparent;
            checkBoxN.Location = new Point(477, 446);
            checkBoxN.Name = "checkBoxN";
            checkBoxN.Size = new Size(65, 35);
            checkBoxN.TabIndex = 42;
            checkBoxN.Text = "No";
            checkBoxN.UseVisualStyleBackColor = false;
            // 
            // toFulfillOrder
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(938, 512);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "toFulfillOrder";
            Text = "toFulfillOrder";
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
        private Label label1;
        private DataGridView gridVieMenu;
        private Label label2;
        private Panel pnlLblM;
        private Label lblErrMain;
        private Panel panel2;
        private Label label3;
        private CheckBox checkBoxN;
        private CheckBox checkBoxY;
    }
}