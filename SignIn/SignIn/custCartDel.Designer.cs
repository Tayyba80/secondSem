namespace SignIn
{
    partial class custCartDel
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
            btnAddInMenu = new Button();
            label2 = new Label();
            label1 = new Label();
            PnlS = new Panel();
            pnlErrSub = new Panel();
            lblErrSub = new Label();
            panel4 = new Panel();
            comboBoxSub = new ComboBox();
            pnl1Main = new Panel();
            pnlLblM = new Panel();
            lblErrMain = new Label();
            pnle = new Panel();
            comboBoxMain = new ComboBox();
            panel2.SuspendLayout();
            PnlS.SuspendLayout();
            pnlErrSub.SuspendLayout();
            panel4.SuspendLayout();
            pnl1Main.SuspendLayout();
            pnlLblM.SuspendLayout();
            pnle.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(938, 512);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackgroundImage = Properties.Resources.cake;
            panel2.BackgroundImageLayout = ImageLayout.Stretch;
            panel2.Controls.Add(btnAddInMenu);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(PnlS);
            panel2.Controls.Add(pnl1Main);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(938, 512);
            panel2.TabIndex = 1;
            // 
            // btnAddInMenu
            // 
            btnAddInMenu.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnAddInMenu.BackColor = Color.Transparent;
            btnAddInMenu.FlatStyle = FlatStyle.Flat;
            btnAddInMenu.Font = new Font("Segoe Print", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnAddInMenu.ForeColor = Color.SaddleBrown;
            btnAddInMenu.Location = new Point(736, 417);
            btnAddInMenu.Name = "btnAddInMenu";
            btnAddInMenu.Size = new Size(151, 34);
            btnAddInMenu.TabIndex = 32;
            btnAddInMenu.Text = "Remove";
            btnAddInMenu.UseVisualStyleBackColor = false;
            btnAddInMenu.Click += btnAddInMenu_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe Print", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.SaddleBrown;
            label2.Location = new Point(70, 272);
            label2.Name = "label2";
            label2.Size = new Size(218, 31);
            label2.TabIndex = 29;
            label2.Text = "Select the Sub Product";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe Print", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.SaddleBrown;
            label1.Location = new Point(88, 63);
            label1.Name = "label1";
            label1.Size = new Size(231, 31);
            label1.TabIndex = 28;
            label1.Text = "Select the Main Product";
            // 
            // PnlS
            // 
            PnlS.BackColor = Color.Transparent;
            PnlS.Controls.Add(pnlErrSub);
            PnlS.Controls.Add(panel4);
            PnlS.Font = new Font("Segoe Print", 9F, FontStyle.Bold, GraphicsUnit.Point);
            PnlS.ForeColor = Color.SaddleBrown;
            PnlS.Location = new Point(234, 342);
            PnlS.Name = "PnlS";
            PnlS.Size = new Size(230, 109);
            PnlS.TabIndex = 27;
            // 
            // pnlErrSub
            // 
            pnlErrSub.BackColor = Color.Transparent;
            pnlErrSub.Controls.Add(lblErrSub);
            pnlErrSub.Dock = DockStyle.Top;
            pnlErrSub.Location = new Point(0, 68);
            pnlErrSub.Name = "pnlErrSub";
            pnlErrSub.Size = new Size(230, 34);
            pnlErrSub.TabIndex = 10;
            pnlErrSub.Visible = false;
            // 
            // lblErrSub
            // 
            lblErrSub.AutoSize = true;
            lblErrSub.FlatStyle = FlatStyle.Flat;
            lblErrSub.Font = new Font("Segoe Print", 8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lblErrSub.ForeColor = Color.Crimson;
            lblErrSub.Location = new Point(3, 6);
            lblErrSub.Name = "lblErrSub";
            lblErrSub.Size = new Size(160, 28);
            lblErrSub.TabIndex = 10;
            lblErrSub.Text = "Invalid User Name";
            // 
            // panel4
            // 
            panel4.BackColor = Color.Transparent;
            panel4.Controls.Add(comboBoxSub);
            panel4.Dock = DockStyle.Top;
            panel4.Location = new Point(0, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(230, 68);
            panel4.TabIndex = 8;
            // 
            // comboBoxSub
            // 
            comboBoxSub.BackColor = Color.PeachPuff;
            comboBoxSub.FlatStyle = FlatStyle.Flat;
            comboBoxSub.ForeColor = Color.SaddleBrown;
            comboBoxSub.FormattingEnabled = true;
            comboBoxSub.Location = new Point(15, 3);
            comboBoxSub.Name = "comboBoxSub";
            comboBoxSub.Size = new Size(195, 39);
            comboBoxSub.TabIndex = 28;
            comboBoxSub.SelectedIndexChanged += comboBoxSub_SelectedIndexChanged;
            // 
            // pnl1Main
            // 
            pnl1Main.BackColor = Color.Transparent;
            pnl1Main.Controls.Add(pnlLblM);
            pnl1Main.Controls.Add(pnle);
            pnl1Main.Font = new Font("Segoe Print", 9F, FontStyle.Bold, GraphicsUnit.Point);
            pnl1Main.ForeColor = Color.SaddleBrown;
            pnl1Main.Location = new Point(231, 123);
            pnl1Main.Name = "pnl1Main";
            pnl1Main.Size = new Size(230, 109);
            pnl1Main.TabIndex = 26;
            // 
            // pnlLblM
            // 
            pnlLblM.BackColor = Color.Transparent;
            pnlLblM.Controls.Add(lblErrMain);
            pnlLblM.Dock = DockStyle.Top;
            pnlLblM.Location = new Point(0, 68);
            pnlLblM.Name = "pnlLblM";
            pnlLblM.Size = new Size(230, 34);
            pnlLblM.TabIndex = 10;
            pnlLblM.Visible = false;
            // 
            // lblErrMain
            // 
            lblErrMain.AutoSize = true;
            lblErrMain.FlatStyle = FlatStyle.Flat;
            lblErrMain.Font = new Font("Segoe Print", 8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lblErrMain.ForeColor = Color.Crimson;
            lblErrMain.Location = new Point(3, 6);
            lblErrMain.Name = "lblErrMain";
            lblErrMain.Size = new Size(160, 28);
            lblErrMain.TabIndex = 10;
            lblErrMain.Text = "Invalid User Name";
            // 
            // pnle
            // 
            pnle.BackColor = Color.Transparent;
            pnle.Controls.Add(comboBoxMain);
            pnle.Dock = DockStyle.Top;
            pnle.Location = new Point(0, 0);
            pnle.Name = "pnle";
            pnle.Size = new Size(230, 68);
            pnle.TabIndex = 8;
            // 
            // comboBoxMain
            // 
            comboBoxMain.BackColor = Color.PeachPuff;
            comboBoxMain.FlatStyle = FlatStyle.Flat;
            comboBoxMain.ForeColor = Color.SaddleBrown;
            comboBoxMain.FormattingEnabled = true;
            comboBoxMain.Location = new Point(18, 3);
            comboBoxMain.Name = "comboBoxMain";
            comboBoxMain.Size = new Size(195, 39);
            comboBoxMain.TabIndex = 27;
            comboBoxMain.SelectedIndexChanged += comboBoxMain_SelectedIndexChanged;
            // 
            // custCartDel
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(938, 512);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "custCartDel";
            Text = "custCartDel";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            PnlS.ResumeLayout(false);
            pnlErrSub.ResumeLayout(false);
            pnlErrSub.PerformLayout();
            panel4.ResumeLayout(false);
            pnl1Main.ResumeLayout(false);
            pnlLblM.ResumeLayout(false);
            pnlLblM.PerformLayout();
            pnle.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label label2;
        private Label label1;
        private Panel PnlS;
        private Panel pnlErrSub;
        private Label lblErrSub;
        private Panel panel4;
        private ComboBox comboBoxSub;
        private Panel pnl1Main;
        private Panel pnlLblM;
        private Label lblErrMain;
        private Panel pnle;
        private ComboBox comboBoxMain;
        private Button btnAddInMenu;
    }
}