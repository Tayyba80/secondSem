namespace SignIn
{
    partial class custbillNor
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
            label3 = new Label();
            panel5 = new Panel();
            pnlErrPrc = new Panel();
            lblErrPrc = new Label();
            panel6 = new Panel();
            numprc = new NumericUpDown();
            label2 = new Label();
            pnlLblM = new Panel();
            lblErrMain = new Label();
            btnAddInMenu = new Button();
            label1 = new Label();
            gridVieMenu = new DataGridView();
            panel1.SuspendLayout();
            panel5.SuspendLayout();
            pnlErrPrc.SuspendLayout();
            panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numprc).BeginInit();
            pnlLblM.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gridVieMenu).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.BackgroundImage = Properties.Resources.cake;
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Controls.Add(label3);
            panel1.Controls.Add(panel5);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(pnlLblM);
            panel1.Controls.Add(btnAddInMenu);
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
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(486, 313);
            label3.Name = "label3";
            label3.Size = new Size(67, 31);
            label3.TabIndex = 40;
            label3.Text = "label3";
            // 
            // panel5
            // 
            panel5.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            panel5.BackColor = Color.Transparent;
            panel5.Controls.Add(pnlErrPrc);
            panel5.Controls.Add(panel6);
            panel5.Location = new Point(153, 362);
            panel5.Name = "panel5";
            panel5.Size = new Size(230, 109);
            panel5.TabIndex = 39;
            // 
            // pnlErrPrc
            // 
            pnlErrPrc.BackColor = Color.Transparent;
            pnlErrPrc.Controls.Add(lblErrPrc);
            pnlErrPrc.Dock = DockStyle.Top;
            pnlErrPrc.Location = new Point(0, 68);
            pnlErrPrc.Name = "pnlErrPrc";
            pnlErrPrc.Size = new Size(230, 34);
            pnlErrPrc.TabIndex = 10;
            pnlErrPrc.Visible = false;
            // 
            // lblErrPrc
            // 
            lblErrPrc.AutoSize = true;
            lblErrPrc.FlatStyle = FlatStyle.Flat;
            lblErrPrc.Font = new Font("Segoe Print", 8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lblErrPrc.ForeColor = Color.Crimson;
            lblErrPrc.Location = new Point(3, 6);
            lblErrPrc.Name = "lblErrPrc";
            lblErrPrc.Size = new Size(160, 28);
            lblErrPrc.TabIndex = 10;
            lblErrPrc.Text = "Invalid User Name";
            // 
            // panel6
            // 
            panel6.BackColor = Color.Transparent;
            panel6.Controls.Add(numprc);
            panel6.Dock = DockStyle.Top;
            panel6.Location = new Point(0, 0);
            panel6.Name = "panel6";
            panel6.Size = new Size(230, 68);
            panel6.TabIndex = 8;
            // 
            // numprc
            // 
            numprc.BackColor = Color.PeachPuff;
            numprc.BorderStyle = BorderStyle.None;
            numprc.Font = new Font("Segoe Print", 9F, FontStyle.Bold, GraphicsUnit.Point);
            numprc.ForeColor = Color.SaddleBrown;
            numprc.Location = new Point(21, 25);
            numprc.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            numprc.Name = "numprc";
            numprc.Size = new Size(195, 35);
            numprc.TabIndex = 12;
            numprc.ValueChanged += numprc_ValueChanged;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe Print", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label2.ForeColor = Color.SaddleBrown;
            label2.Location = new Point(62, 326);
            label2.Name = "label2";
            label2.Size = new Size(217, 31);
            label2.TabIndex = 38;
            label2.Text = "Enter Price to pay Bill";
            // 
            // pnlLblM
            // 
            pnlLblM.BackColor = Color.Transparent;
            pnlLblM.Controls.Add(lblErrMain);
            pnlLblM.Location = new Point(12, 268);
            pnlLblM.Name = "pnlLblM";
            pnlLblM.Size = new Size(903, 55);
            pnlLblM.TabIndex = 37;
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
            // btnAddInMenu
            // 
            btnAddInMenu.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnAddInMenu.FlatStyle = FlatStyle.Flat;
            btnAddInMenu.Font = new Font("Segoe Print", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnAddInMenu.ForeColor = Color.SaddleBrown;
            btnAddInMenu.Location = new Point(684, 456);
            btnAddInMenu.Name = "btnAddInMenu";
            btnAddInMenu.Size = new Size(231, 37);
            btnAddInMenu.TabIndex = 36;
            btnAddInMenu.Text = "Pay Bill";
            btnAddInMenu.UseVisualStyleBackColor = true;
            btnAddInMenu.Click += btnAddInMenu_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.FlatStyle = FlatStyle.Flat;
            label1.Location = new Point(62, 36);
            label1.Name = "label1";
            label1.Size = new Size(141, 31);
            label1.TabIndex = 35;
            label1.Text = "Your Order is:";
            // 
            // gridVieMenu
            // 
            gridVieMenu.Anchor = AnchorStyles.Top;
            gridVieMenu.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.ColumnHeader;
            gridVieMenu.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
            gridVieMenu.BackgroundColor = Color.DarkSalmon;
            gridVieMenu.BorderStyle = BorderStyle.None;
            gridVieMenu.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridVieMenu.GridColor = Color.RosyBrown;
            gridVieMenu.Location = new Point(211, 14);
            gridVieMenu.Margin = new Padding(5);
            gridVieMenu.MaximumSize = new Size(700, 500);
            gridVieMenu.Name = "gridVieMenu";
            gridVieMenu.ReadOnly = true;
            gridVieMenu.RowHeadersWidth = 62;
            gridVieMenu.RowTemplate.Height = 33;
            gridVieMenu.Size = new Size(639, 255);
            gridVieMenu.TabIndex = 34;
            gridVieMenu.CellContentClick += gridVieMenu_CellContentClick;
            // 
            // custbillNor
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(938, 512);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "custbillNor";
            Text = "custbillNor";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel5.ResumeLayout(false);
            pnlErrPrc.ResumeLayout(false);
            pnlErrPrc.PerformLayout();
            panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)numprc).EndInit();
            pnlLblM.ResumeLayout(false);
            pnlLblM.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)gridVieMenu).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel pnlLblM;
        private Label lblErrMain;
        private Button btnAddInMenu;
        private Label label1;
        private DataGridView gridVieMenu;
        private Panel panel5;
        private Panel pnlErrPrc;
        private Label lblErrPrc;
        private Panel panel6;
        private NumericUpDown numprc;
        private Label label2;
        private Label label3;
    }
}