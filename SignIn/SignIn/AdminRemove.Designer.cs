namespace SignIn
{
    partial class AdminRemove
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
            panel1.SuspendLayout();
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
            panel1.BackColor = Color.DarkSalmon;
            panel1.BackgroundImage = Properties.Resources.frame_food_ingredients_baking_gently_pink_pastel_background_cooking_flat_lay_with_copy_space_top_view_baking_concept;
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Controls.Add(button1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(PnlS);
            panel1.Controls.Add(pnl1Main);
            panel1.Dock = DockStyle.Fill;
            panel1.Font = new Font("Segoe Print", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            panel1.ForeColor = Color.SaddleBrown;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(960, 568);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Bottom;
            button1.BackColor = Color.Transparent;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(767, 493);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 26;
            button1.Text = "Delete";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Location = new Point(91, 273);
            label2.Name = "label2";
            label2.Size = new Size(218, 31);
            label2.TabIndex = 25;
            label2.Text = "Select the Sub Product";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Location = new Point(109, 64);
            label1.Name = "label1";
            label1.Size = new Size(231, 31);
            label1.TabIndex = 24;
            label1.Text = "Select the Main Product";
            // 
            // PnlS
            // 
            PnlS.BackColor = Color.Transparent;
            PnlS.Controls.Add(pnlErrSub);
            PnlS.Controls.Add(panel4);
            PnlS.Location = new Point(255, 343);
            PnlS.Name = "PnlS";
            PnlS.Size = new Size(230, 109);
            PnlS.TabIndex = 23;
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
            comboBoxSub.BackColor = Color.MistyRose;
            comboBoxSub.FlatStyle = FlatStyle.Flat;
            comboBoxSub.ForeColor = Color.SaddleBrown;
            comboBoxSub.FormattingEnabled = true;
            comboBoxSub.Location = new Point(15, 3);
            comboBoxSub.Name = "comboBoxSub";
            comboBoxSub.Size = new Size(195, 39);
            comboBoxSub.TabIndex = 28;
            // 
            // pnl1Main
            // 
            pnl1Main.BackColor = Color.Transparent;
            pnl1Main.Controls.Add(pnlLblM);
            pnl1Main.Controls.Add(pnle);
            pnl1Main.Location = new Point(252, 124);
            pnl1Main.Name = "pnl1Main";
            pnl1Main.Size = new Size(230, 109);
            pnl1Main.TabIndex = 22;
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
            comboBoxMain.BackColor = Color.MistyRose;
            comboBoxMain.FlatStyle = FlatStyle.Flat;
            comboBoxMain.ForeColor = Color.SaddleBrown;
            comboBoxMain.FormattingEnabled = true;
            comboBoxMain.Location = new Point(18, 3);
            comboBoxMain.Name = "comboBoxMain";
            comboBoxMain.Size = new Size(195, 39);
            comboBoxMain.TabIndex = 27;
            comboBoxMain.SelectedIndexChanged += comboBoxMain_SelectedIndexChanged;
            // 
            // AdminRemove
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MistyRose;
            ClientSize = new Size(960, 568);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AdminRemove";
            Text = "AdminRemove";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
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
        private Panel PnlS;
        private Panel pnlErrSub;
        private Label lblErrSub;
        private Panel panel4;
        private Panel pnl1Main;
        private Panel pnlLblM;
        private Label lblErrMain;
        private Panel pnle;
        private Button button1;
        private Label label2;
        private Label label1;
        private ComboBox comboBoxMain;
        private ComboBox comboBoxSub;
    }
}