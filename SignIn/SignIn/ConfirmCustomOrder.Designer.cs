namespace SignIn
{
    partial class ConfirmCustomOrder
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
            button1 = new Button();
            btnAddInMenu = new Button();
            label2 = new Label();
            pnlLblM = new Panel();
            lblErrMain = new Label();
            panel1.SuspendLayout();
            pnlLblM.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackgroundImage = Properties.Resources.cake;
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Controls.Add(pnlLblM);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(btnAddInMenu);
            panel1.Controls.Add(label2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(938, 512);
            panel1.TabIndex = 0;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button1.BackColor = Color.Transparent;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe Print", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            button1.ForeColor = Color.PeachPuff;
            button1.Location = new Point(436, 249);
            button1.Name = "button1";
            button1.Size = new Size(71, 37);
            button1.TabIndex = 41;
            button1.Text = "NO";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // btnAddInMenu
            // 
            btnAddInMenu.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnAddInMenu.BackColor = Color.Transparent;
            btnAddInMenu.FlatStyle = FlatStyle.Flat;
            btnAddInMenu.Font = new Font("Segoe Print", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnAddInMenu.ForeColor = Color.PeachPuff;
            btnAddInMenu.ImageAlign = ContentAlignment.MiddleLeft;
            btnAddInMenu.Location = new Point(436, 188);
            btnAddInMenu.Name = "btnAddInMenu";
            btnAddInMenu.Size = new Size(71, 37);
            btnAddInMenu.TabIndex = 40;
            btnAddInMenu.Text = "YES";
            btnAddInMenu.UseVisualStyleBackColor = false;
            btnAddInMenu.Click += btnAddInMenu_Click;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe Print", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.SaddleBrown;
            label2.Location = new Point(341, 88);
            label2.Name = "label2";
            label2.Size = new Size(243, 57);
            label2.TabIndex = 39;
            label2.Text = "Cofirm Order";
            // 
            // pnlLblM
            // 
            pnlLblM.BackColor = Color.Transparent;
            pnlLblM.Controls.Add(lblErrMain);
            pnlLblM.Location = new Point(32, 292);
            pnlLblM.Name = "pnlLblM";
            pnlLblM.Size = new Size(903, 55);
            pnlLblM.TabIndex = 42;
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
            // ConfirmCustomOrder
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(938, 512);
            Controls.Add(panel1);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Name = "ConfirmCustomOrder";
            Text = "ConfirmCustomOrder";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            pnlLblM.ResumeLayout(false);
            pnlLblM.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label2;
        private Button button1;
        private Button btnAddInMenu;
        private Panel pnlLblM;
        private Label lblErrMain;
    }
}