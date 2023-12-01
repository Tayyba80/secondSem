namespace SignIn
{
    partial class thStkUpdate
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            panel1 = new Panel();
            lblstk = new Label();
            btnUpdAte = new Guna.UI2.WinForms.Guna2CircleButton();
            panel2 = new Panel();
            pnlErrSubTS = new Panel();
            lblErrSubTS = new Label();
            panel4 = new Panel();
            comboxsubTStk = new ComboBox();
            panel5 = new Panel();
            pnlErrPrcTS = new Panel();
            lblErrPrcTS = new Label();
            panel6 = new Panel();
            numprcTStk = new NumericUpDown();
            label2 = new Label();
            lblSub = new Label();
            pnl1Main = new Panel();
            pnlLblMTS = new Panel();
            lblErrMainTS = new Label();
            pnle = new Panel();
            comBoxMTStk = new ComboBox();
            lblMName = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            pnlErrSubTS.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            pnlErrPrcTS.SuspendLayout();
            panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numprcTStk).BeginInit();
            pnl1Main.SuspendLayout();
            pnlLblMTS.SuspendLayout();
            pnle.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.BackgroundImage = Properties.Resources.frame_food_ingredients_baking_gently_pink_pastel_background_cooking_flat_lay_with_copy_space_top_view_baking_concept;
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Controls.Add(lblstk);
            panel1.Controls.Add(btnUpdAte);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(panel5);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(lblSub);
            panel1.Controls.Add(pnl1Main);
            panel1.Controls.Add(lblMName);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1278, 850);
            panel1.TabIndex = 0;
            // 
            // lblstk
            // 
            lblstk.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblstk.AutoSize = true;
            lblstk.Font = new Font("Segoe Print", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lblstk.ForeColor = Color.SaddleBrown;
            lblstk.Image = Properties.Resources.updata;
            lblstk.ImageAlign = ContentAlignment.MiddleLeft;
            lblstk.Location = new Point(733, 559);
            lblstk.Name = "lblstk";
            lblstk.Size = new Size(227, 31);
            lblstk.TabIndex = 43;
            lblstk.Text = "     TH-Stock Updated!";
            lblstk.Visible = false;
            // 
            // btnUpdAte
            // 
            btnUpdAte.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnUpdAte.BackColor = Color.Transparent;
            btnUpdAte.DisabledState.BorderColor = Color.DarkGray;
            btnUpdAte.DisabledState.CustomBorderColor = Color.DarkGray;
            btnUpdAte.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnUpdAte.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnUpdAte.FillColor = Color.RosyBrown;
            btnUpdAte.Font = new Font("Segoe Print", 11F, FontStyle.Bold, GraphicsUnit.Point);
            btnUpdAte.ForeColor = Color.MistyRose;
            btnUpdAte.Location = new Point(786, 465);
            btnUpdAte.Name = "btnUpdAte";
            btnUpdAte.ShadowDecoration.CustomizableEdges = customizableEdges1;
            btnUpdAte.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            btnUpdAte.Size = new Size(135, 87);
            btnUpdAte.TabIndex = 42;
            btnUpdAte.Text = "Update";
            btnUpdAte.Click += btnUpdAte_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Transparent;
            panel2.Controls.Add(pnlErrSubTS);
            panel2.Controls.Add(panel4);
            panel2.Location = new Point(208, 450);
            panel2.Name = "panel2";
            panel2.Size = new Size(230, 109);
            panel2.TabIndex = 37;
            // 
            // pnlErrSubTS
            // 
            pnlErrSubTS.BackColor = Color.Transparent;
            pnlErrSubTS.Controls.Add(lblErrSubTS);
            pnlErrSubTS.Dock = DockStyle.Top;
            pnlErrSubTS.Location = new Point(0, 68);
            pnlErrSubTS.Name = "pnlErrSubTS";
            pnlErrSubTS.Size = new Size(230, 34);
            pnlErrSubTS.TabIndex = 10;
            pnlErrSubTS.Visible = false;
            // 
            // lblErrSubTS
            // 
            lblErrSubTS.AutoSize = true;
            lblErrSubTS.FlatStyle = FlatStyle.Flat;
            lblErrSubTS.Font = new Font("Segoe Print", 8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lblErrSubTS.ForeColor = Color.Crimson;
            lblErrSubTS.Location = new Point(3, 6);
            lblErrSubTS.Name = "lblErrSubTS";
            lblErrSubTS.Size = new Size(160, 28);
            lblErrSubTS.TabIndex = 10;
            lblErrSubTS.Text = "Invalid User Name";
            // 
            // panel4
            // 
            panel4.BackColor = Color.Transparent;
            panel4.Controls.Add(comboxsubTStk);
            panel4.Dock = DockStyle.Top;
            panel4.Location = new Point(0, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(230, 68);
            panel4.TabIndex = 8;
            // 
            // comboxsubTStk
            // 
            comboxsubTStk.BackColor = Color.MistyRose;
            comboxsubTStk.FlatStyle = FlatStyle.Flat;
            comboxsubTStk.Font = new Font("Segoe Print", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            comboxsubTStk.ForeColor = Color.SaddleBrown;
            comboxsubTStk.FormattingEnabled = true;
            comboxsubTStk.Location = new Point(18, 3);
            comboxsubTStk.Name = "comboxsubTStk";
            comboxsubTStk.Size = new Size(195, 39);
            comboxsubTStk.TabIndex = 27;
            comboxsubTStk.SelectedIndexChanged += comboxsubTStk_SelectedIndexChanged;
            // 
            // panel5
            // 
            panel5.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            panel5.BackColor = Color.Transparent;
            panel5.Controls.Add(pnlErrPrcTS);
            panel5.Controls.Add(panel6);
            panel5.Location = new Point(705, 260);
            panel5.Name = "panel5";
            panel5.Size = new Size(230, 109);
            panel5.TabIndex = 40;
            // 
            // pnlErrPrcTS
            // 
            pnlErrPrcTS.BackColor = Color.Transparent;
            pnlErrPrcTS.Controls.Add(lblErrPrcTS);
            pnlErrPrcTS.Dock = DockStyle.Top;
            pnlErrPrcTS.Location = new Point(0, 68);
            pnlErrPrcTS.Name = "pnlErrPrcTS";
            pnlErrPrcTS.Size = new Size(230, 34);
            pnlErrPrcTS.TabIndex = 10;
            pnlErrPrcTS.Visible = false;
            // 
            // lblErrPrcTS
            // 
            lblErrPrcTS.AutoSize = true;
            lblErrPrcTS.FlatStyle = FlatStyle.Flat;
            lblErrPrcTS.Font = new Font("Segoe Print", 8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lblErrPrcTS.ForeColor = Color.Crimson;
            lblErrPrcTS.Location = new Point(3, 6);
            lblErrPrcTS.Name = "lblErrPrcTS";
            lblErrPrcTS.Size = new Size(160, 28);
            lblErrPrcTS.TabIndex = 10;
            lblErrPrcTS.Text = "Invalid User Name";
            // 
            // panel6
            // 
            panel6.BackColor = Color.Transparent;
            panel6.Controls.Add(numprcTStk);
            panel6.Dock = DockStyle.Top;
            panel6.Location = new Point(0, 0);
            panel6.Name = "panel6";
            panel6.Size = new Size(230, 68);
            panel6.TabIndex = 8;
            // 
            // numprcTStk
            // 
            numprcTStk.BackColor = Color.MistyRose;
            numprcTStk.BorderStyle = BorderStyle.None;
            numprcTStk.Font = new Font("Segoe Print", 9F, FontStyle.Bold, GraphicsUnit.Point);
            numprcTStk.ForeColor = Color.SaddleBrown;
            numprcTStk.Location = new Point(21, 25);
            numprcTStk.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            numprcTStk.Name = "numprcTStk";
            numprcTStk.Size = new Size(195, 35);
            numprcTStk.TabIndex = 12;
            numprcTStk.ValueChanged += numprcTStk_ValueChanged;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe Print", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label2.ForeColor = Color.SaddleBrown;
            label2.Location = new Point(618, 212);
            label2.Name = "label2";
            label2.Size = new Size(160, 31);
            label2.TabIndex = 39;
            label2.Text = "Enter new Price";
            // 
            // lblSub
            // 
            lblSub.AutoSize = true;
            lblSub.BackColor = Color.Transparent;
            lblSub.Font = new Font("Segoe Print", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lblSub.ForeColor = Color.SaddleBrown;
            lblSub.Location = new Point(68, 390);
            lblSub.Name = "lblSub";
            lblSub.Size = new Size(218, 31);
            lblSub.TabIndex = 38;
            lblSub.Text = "Select the Sub Product";
            // 
            // pnl1Main
            // 
            pnl1Main.BackColor = Color.Transparent;
            pnl1Main.Controls.Add(pnlLblMTS);
            pnl1Main.Controls.Add(pnle);
            pnl1Main.Location = new Point(208, 262);
            pnl1Main.Name = "pnl1Main";
            pnl1Main.Size = new Size(230, 109);
            pnl1Main.TabIndex = 36;
            // 
            // pnlLblMTS
            // 
            pnlLblMTS.BackColor = Color.Transparent;
            pnlLblMTS.Controls.Add(lblErrMainTS);
            pnlLblMTS.Dock = DockStyle.Top;
            pnlLblMTS.Location = new Point(0, 68);
            pnlLblMTS.Name = "pnlLblMTS";
            pnlLblMTS.Size = new Size(230, 34);
            pnlLblMTS.TabIndex = 10;
            pnlLblMTS.Visible = false;
            // 
            // lblErrMainTS
            // 
            lblErrMainTS.AutoSize = true;
            lblErrMainTS.FlatStyle = FlatStyle.Flat;
            lblErrMainTS.Font = new Font("Segoe Print", 8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lblErrMainTS.ForeColor = Color.Crimson;
            lblErrMainTS.Location = new Point(3, 6);
            lblErrMainTS.Name = "lblErrMainTS";
            lblErrMainTS.Size = new Size(160, 28);
            lblErrMainTS.TabIndex = 10;
            lblErrMainTS.Text = "Invalid User Name";
            // 
            // pnle
            // 
            pnle.BackColor = Color.Transparent;
            pnle.Controls.Add(comBoxMTStk);
            pnle.Dock = DockStyle.Top;
            pnle.Location = new Point(0, 0);
            pnle.Name = "pnle";
            pnle.Size = new Size(230, 68);
            pnle.TabIndex = 8;
            // 
            // comBoxMTStk
            // 
            comBoxMTStk.BackColor = Color.MistyRose;
            comBoxMTStk.FlatStyle = FlatStyle.Flat;
            comBoxMTStk.Font = new Font("Segoe Print", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            comBoxMTStk.ForeColor = Color.SaddleBrown;
            comBoxMTStk.FormattingEnabled = true;
            comBoxMTStk.Location = new Point(18, 3);
            comBoxMTStk.Name = "comBoxMTStk";
            comBoxMTStk.Size = new Size(195, 39);
            comBoxMTStk.TabIndex = 27;
            comBoxMTStk.SelectedIndexChanged += comBoxMTStk_SelectedIndexChanged;
            // 
            // lblMName
            // 
            lblMName.AutoSize = true;
            lblMName.Font = new Font("Segoe Print", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lblMName.ForeColor = Color.SaddleBrown;
            lblMName.Location = new Point(68, 201);
            lblMName.Name = "lblMName";
            lblMName.Size = new Size(231, 31);
            lblMName.TabIndex = 35;
            lblMName.Text = "Select the Main Product";
            // 
            // thStkUpdate
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1278, 850);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "thStkUpdate";
            Text = "thStkUpdate";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            pnlErrSubTS.ResumeLayout(false);
            pnlErrSubTS.PerformLayout();
            panel4.ResumeLayout(false);
            panel5.ResumeLayout(false);
            pnlErrPrcTS.ResumeLayout(false);
            pnlErrPrcTS.PerformLayout();
            panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)numprcTStk).EndInit();
            pnl1Main.ResumeLayout(false);
            pnlLblMTS.ResumeLayout(false);
            pnlLblMTS.PerformLayout();
            pnle.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel pnlErrSubTS;
        private Label lblErrSubTS;
        private Panel panel4;
        private ComboBox comboxsubTStk;
        private Panel panel5;
        private Panel pnlErrPrcTS;
        private Label lblErrPrcTS;
        private Panel panel6;
        private NumericUpDown numprcTStk;
        private Label label2;
        private Label lblSub;
        private Panel pnl1Main;
        private Panel pnlLblMTS;
        private Label lblErrMainTS;
        private Panel pnle;
        private ComboBox comBoxMTStk;
        private Label lblMName;
        private Guna.UI2.WinForms.Guna2CircleButton btnUpdAte;
        private Label lblstk;
    }
}