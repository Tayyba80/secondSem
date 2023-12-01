namespace SignIn
{
    partial class nrmlStkUpdate
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
            lblStkk = new Label();
            btnUpdAte = new Guna.UI2.WinForms.Guna2CircleButton();
            panel2 = new Panel();
            pnlErrSubS = new Panel();
            lblErrSubS = new Label();
            panel4 = new Panel();
            comboxsubStk = new ComboBox();
            panel5 = new Panel();
            pnlErrPrcS = new Panel();
            lblErrPrcS = new Label();
            panel6 = new Panel();
            numprcStk = new NumericUpDown();
            label2 = new Label();
            lblSub = new Label();
            pnl1Main = new Panel();
            pnlLblMS = new Panel();
            lblErrMainS = new Label();
            pnle = new Panel();
            comBoxMStk = new ComboBox();
            lblMName = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            pnlErrSubS.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            pnlErrPrcS.SuspendLayout();
            panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numprcStk).BeginInit();
            pnl1Main.SuspendLayout();
            pnlLblMS.SuspendLayout();
            pnle.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.BackgroundImage = Properties.Resources.frame_food_ingredients_baking_gently_pink_pastel_background_cooking_flat_lay_with_copy_space_top_view_baking_concept;
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Controls.Add(lblStkk);
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
            // lblStkk
            // 
            lblStkk.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblStkk.AutoSize = true;
            lblStkk.Font = new Font("Segoe Print", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lblStkk.ForeColor = Color.SaddleBrown;
            lblStkk.Image = Properties.Resources.updata;
            lblStkk.ImageAlign = ContentAlignment.MiddleLeft;
            lblStkk.Location = new Point(750, 551);
            lblStkk.Name = "lblStkk";
            lblStkk.Size = new Size(189, 31);
            lblStkk.TabIndex = 44;
            lblStkk.Text = "     Stock Updated!";
            lblStkk.Visible = false;
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
            btnUpdAte.Location = new Point(780, 450);
            btnUpdAte.Name = "btnUpdAte";
            btnUpdAte.ShadowDecoration.CustomizableEdges = customizableEdges1;
            btnUpdAte.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            btnUpdAte.Size = new Size(135, 87);
            btnUpdAte.TabIndex = 43;
            btnUpdAte.Text = "Update";
            btnUpdAte.Click += btnUpdAte_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Transparent;
            panel2.Controls.Add(pnlErrSubS);
            panel2.Controls.Add(panel4);
            panel2.Location = new Point(219, 428);
            panel2.Name = "panel2";
            panel2.Size = new Size(230, 109);
            panel2.TabIndex = 28;
            // 
            // pnlErrSubS
            // 
            pnlErrSubS.BackColor = Color.Transparent;
            pnlErrSubS.Controls.Add(lblErrSubS);
            pnlErrSubS.Dock = DockStyle.Top;
            pnlErrSubS.Location = new Point(0, 68);
            pnlErrSubS.Name = "pnlErrSubS";
            pnlErrSubS.Size = new Size(230, 34);
            pnlErrSubS.TabIndex = 10;
            pnlErrSubS.Visible = false;
            // 
            // lblErrSubS
            // 
            lblErrSubS.AutoSize = true;
            lblErrSubS.FlatStyle = FlatStyle.Flat;
            lblErrSubS.Font = new Font("Segoe Print", 8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lblErrSubS.ForeColor = Color.Crimson;
            lblErrSubS.Location = new Point(3, 6);
            lblErrSubS.Name = "lblErrSubS";
            lblErrSubS.Size = new Size(160, 28);
            lblErrSubS.TabIndex = 10;
            lblErrSubS.Text = "Invalid User Name";
            // 
            // panel4
            // 
            panel4.BackColor = Color.Transparent;
            panel4.Controls.Add(comboxsubStk);
            panel4.Dock = DockStyle.Top;
            panel4.Location = new Point(0, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(230, 68);
            panel4.TabIndex = 8;
            // 
            // comboxsubStk
            // 
            comboxsubStk.BackColor = Color.MistyRose;
            comboxsubStk.FlatStyle = FlatStyle.Flat;
            comboxsubStk.Font = new Font("Segoe Print", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            comboxsubStk.ForeColor = Color.SaddleBrown;
            comboxsubStk.FormattingEnabled = true;
            comboxsubStk.Location = new Point(18, 3);
            comboxsubStk.Name = "comboxsubStk";
            comboxsubStk.Size = new Size(195, 39);
            comboxsubStk.TabIndex = 27;
            comboxsubStk.SelectedIndexChanged += comboxsubStk_SelectedIndexChanged;
            // 
            // panel5
            // 
            panel5.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            panel5.BackColor = Color.Transparent;
            panel5.Controls.Add(pnlErrPrcS);
            panel5.Controls.Add(panel6);
            panel5.Location = new Point(708, 236);
            panel5.Name = "panel5";
            panel5.Size = new Size(230, 109);
            panel5.TabIndex = 33;
            // 
            // pnlErrPrcS
            // 
            pnlErrPrcS.BackColor = Color.Transparent;
            pnlErrPrcS.Controls.Add(lblErrPrcS);
            pnlErrPrcS.Dock = DockStyle.Top;
            pnlErrPrcS.Location = new Point(0, 68);
            pnlErrPrcS.Name = "pnlErrPrcS";
            pnlErrPrcS.Size = new Size(230, 34);
            pnlErrPrcS.TabIndex = 10;
            pnlErrPrcS.Visible = false;
            // 
            // lblErrPrcS
            // 
            lblErrPrcS.AutoSize = true;
            lblErrPrcS.FlatStyle = FlatStyle.Flat;
            lblErrPrcS.Font = new Font("Segoe Print", 8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lblErrPrcS.ForeColor = Color.Crimson;
            lblErrPrcS.Location = new Point(3, 6);
            lblErrPrcS.Name = "lblErrPrcS";
            lblErrPrcS.Size = new Size(160, 28);
            lblErrPrcS.TabIndex = 10;
            lblErrPrcS.Text = "Invalid User Name";
            // 
            // panel6
            // 
            panel6.BackColor = Color.Transparent;
            panel6.Controls.Add(numprcStk);
            panel6.Dock = DockStyle.Top;
            panel6.Location = new Point(0, 0);
            panel6.Name = "panel6";
            panel6.Size = new Size(230, 68);
            panel6.TabIndex = 8;
            // 
            // numprcStk
            // 
            numprcStk.BackColor = Color.MistyRose;
            numprcStk.BorderStyle = BorderStyle.None;
            numprcStk.Font = new Font("Segoe Print", 9F, FontStyle.Bold, GraphicsUnit.Point);
            numprcStk.ForeColor = Color.SaddleBrown;
            numprcStk.Location = new Point(21, 25);
            numprcStk.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            numprcStk.Name = "numprcStk";
            numprcStk.Size = new Size(195, 35);
            numprcStk.TabIndex = 12;
            numprcStk.ValueChanged += numprcStk_ValueChanged;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe Print", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label2.ForeColor = Color.SaddleBrown;
            label2.Location = new Point(577, 179);
            label2.Name = "label2";
            label2.Size = new Size(160, 31);
            label2.TabIndex = 32;
            label2.Text = "Enter new Price";
            // 
            // lblSub
            // 
            lblSub.AutoSize = true;
            lblSub.BackColor = Color.Transparent;
            lblSub.Font = new Font("Segoe Print", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lblSub.ForeColor = Color.SaddleBrown;
            lblSub.Location = new Point(79, 368);
            lblSub.Name = "lblSub";
            lblSub.Size = new Size(218, 31);
            lblSub.TabIndex = 29;
            lblSub.Text = "Select the Sub Product";
            // 
            // pnl1Main
            // 
            pnl1Main.BackColor = Color.Transparent;
            pnl1Main.Controls.Add(pnlLblMS);
            pnl1Main.Controls.Add(pnle);
            pnl1Main.Location = new Point(219, 240);
            pnl1Main.Name = "pnl1Main";
            pnl1Main.Size = new Size(230, 109);
            pnl1Main.TabIndex = 27;
            // 
            // pnlLblMS
            // 
            pnlLblMS.BackColor = Color.Transparent;
            pnlLblMS.Controls.Add(lblErrMainS);
            pnlLblMS.Dock = DockStyle.Top;
            pnlLblMS.Location = new Point(0, 68);
            pnlLblMS.Name = "pnlLblMS";
            pnlLblMS.Size = new Size(230, 34);
            pnlLblMS.TabIndex = 10;
            pnlLblMS.Visible = false;
            // 
            // lblErrMainS
            // 
            lblErrMainS.AutoSize = true;
            lblErrMainS.FlatStyle = FlatStyle.Flat;
            lblErrMainS.Font = new Font("Segoe Print", 8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lblErrMainS.ForeColor = Color.Crimson;
            lblErrMainS.Location = new Point(3, 6);
            lblErrMainS.Name = "lblErrMainS";
            lblErrMainS.Size = new Size(160, 28);
            lblErrMainS.TabIndex = 10;
            lblErrMainS.Text = "Invalid User Name";
            // 
            // pnle
            // 
            pnle.BackColor = Color.Transparent;
            pnle.Controls.Add(comBoxMStk);
            pnle.Dock = DockStyle.Top;
            pnle.Location = new Point(0, 0);
            pnle.Name = "pnle";
            pnle.Size = new Size(230, 68);
            pnle.TabIndex = 8;
            // 
            // comBoxMStk
            // 
            comBoxMStk.BackColor = Color.MistyRose;
            comBoxMStk.FlatStyle = FlatStyle.Flat;
            comBoxMStk.Font = new Font("Segoe Print", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            comBoxMStk.ForeColor = Color.SaddleBrown;
            comBoxMStk.FormattingEnabled = true;
            comBoxMStk.Location = new Point(18, 3);
            comBoxMStk.Name = "comBoxMStk";
            comBoxMStk.Size = new Size(195, 39);
            comBoxMStk.TabIndex = 27;
            comBoxMStk.SelectedIndexChanged += comBoxMStk_SelectedIndexChanged;
            // 
            // lblMName
            // 
            lblMName.AutoSize = true;
            lblMName.Font = new Font("Segoe Print", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lblMName.ForeColor = Color.SaddleBrown;
            lblMName.Location = new Point(79, 179);
            lblMName.Name = "lblMName";
            lblMName.Size = new Size(231, 31);
            lblMName.TabIndex = 26;
            lblMName.Text = "Select the Main Product";
            // 
            // nrmlStkUpdate
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1278, 850);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "nrmlStkUpdate";
            Text = "nrmlStkUpdate";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            pnlErrSubS.ResumeLayout(false);
            pnlErrSubS.PerformLayout();
            panel4.ResumeLayout(false);
            panel5.ResumeLayout(false);
            pnlErrPrcS.ResumeLayout(false);
            pnlErrPrcS.PerformLayout();
            panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)numprcStk).EndInit();
            pnl1Main.ResumeLayout(false);
            pnlLblMS.ResumeLayout(false);
            pnlLblMS.PerformLayout();
            pnle.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label lblMName;
        private Panel pnl1Main;
        private Panel pnlLblMS;
        private Label lblErrMainS;
        private Panel pnle;
        private ComboBox comBoxMStk;
        private Panel panel2;
        private Panel pnlErrSubS;
        private Label lblErrSubS;
        private Panel panel4;
        private ComboBox comboxsubStk;
        private Label lblSub;
        private Panel panel5;
        private Panel pnlErrPrcS;
        private Label lblErrPrcS;
        private Panel panel6;
        private NumericUpDown numprcStk;
        private Label label2;
        private Guna.UI2.WinForms.Guna2CircleButton btnUpdAte;
        private Label lblStkk;
    }
}