namespace SignIn
{
    partial class placeOrderN
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
            pnlLblM = new Panel();
            lblErrMain = new Label();
            btnAddInMenu = new Button();
            label1 = new Label();
            gridVieMenu = new DataGridView();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            panel1.SuspendLayout();
            pnlLblM.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gridVieMenu).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.BackgroundImage = Properties.Resources.cake;
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
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
            panel1.TabIndex = 3;
            // 
            // pnlLblM
            // 
            pnlLblM.BackColor = Color.Transparent;
            pnlLblM.Controls.Add(lblErrMain);
            pnlLblM.Location = new Point(170, 262);
            pnlLblM.Name = "pnlLblM";
            pnlLblM.Size = new Size(595, 45);
            pnlLblM.TabIndex = 33;
            pnlLblM.Visible = false;
            // 
            // lblErrMain
            // 
            lblErrMain.AutoSize = true;
            lblErrMain.FlatStyle = FlatStyle.Flat;
            lblErrMain.Font = new Font("Segoe Print", 11F, FontStyle.Bold, GraphicsUnit.Point);
            lblErrMain.ForeColor = Color.Crimson;
            lblErrMain.Location = new Point(58, 7);
            lblErrMain.Name = "lblErrMain";
            lblErrMain.Size = new Size(221, 38);
            lblErrMain.TabIndex = 10;
            lblErrMain.Text = "Invalid User Name";
            // 
            // btnAddInMenu
            // 
            btnAddInMenu.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnAddInMenu.FlatStyle = FlatStyle.Flat;
            btnAddInMenu.Font = new Font("Segoe Print", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnAddInMenu.ForeColor = Color.SaddleBrown;
            btnAddInMenu.Location = new Point(586, 402);
            btnAddInMenu.Name = "btnAddInMenu";
            btnAddInMenu.Size = new Size(231, 34);
            btnAddInMenu.TabIndex = 32;
            btnAddInMenu.Text = "Click To Order";
            btnAddInMenu.UseVisualStyleBackColor = true;
            btnAddInMenu.Click += btnAddInMenu_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.FlatStyle = FlatStyle.Flat;
            label1.Location = new Point(75, 58);
            label1.Name = "label1";
            label1.Size = new Size(141, 31);
            label1.TabIndex = 3;
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
            gridVieMenu.Location = new Point(241, 24);
            gridVieMenu.Margin = new Padding(5);
            gridVieMenu.MaximumSize = new Size(700, 500);
            gridVieMenu.Name = "gridVieMenu";
            gridVieMenu.ReadOnly = true;
            gridVieMenu.RowHeadersWidth = 62;
            gridVieMenu.RowTemplate.Height = 33;
            gridVieMenu.Size = new Size(468, 219);
            gridVieMenu.TabIndex = 2;
            // 
            // placeOrderN
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(938, 512);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "placeOrderN";
            Text = "placeOrderN";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            pnlLblM.ResumeLayout(false);
            pnlLblM.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)gridVieMenu).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnAddInMenu;
        private Label label1;
        private DataGridView gridVieMenu;
        private Panel pnlLblM;
        private Label lblErrMain;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}