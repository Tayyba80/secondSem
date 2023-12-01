namespace SignIn
{
    partial class discRemove
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            panel1 = new Panel();
            btnAdd = new Guna.UI2.WinForms.Guna2CircleButton();
            label2 = new Label();
            label1 = new Label();
            PnlS = new Panel();
            pnlErrSubRD = new Panel();
            lblErrSubRD = new Label();
            panel4 = new Panel();
            comboBoxSubRD = new ComboBox();
            pnl1Main = new Panel();
            pnlLblMRD = new Panel();
            lblErrMainRD = new Label();
            pnle = new Panel();
            comboBoxMainRD = new ComboBox();
            panel1.SuspendLayout();
            PnlS.SuspendLayout();
            pnlErrSubRD.SuspendLayout();
            panel4.SuspendLayout();
            pnl1Main.SuspendLayout();
            pnlLblMRD.SuspendLayout();
            pnle.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.BackgroundImage = Properties.Resources.frame_food_ingredients_baking_gently_pink_pastel_background_cooking_flat_lay_with_copy_space_top_view_baking_concept;
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Controls.Add(btnAdd);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(PnlS);
            panel1.Controls.Add(pnl1Main);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1278, 850);
            panel1.TabIndex = 0;
            // 
            // btnAdd
            // 
            btnAdd.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnAdd.BackColor = Color.Transparent;
            btnAdd.DisabledState.BorderColor = Color.DarkGray;
            btnAdd.DisabledState.CustomBorderColor = Color.DarkGray;
            btnAdd.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnAdd.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnAdd.FillColor = Color.RosyBrown;
            btnAdd.Font = new Font("Segoe Print", 11F, FontStyle.Bold, GraphicsUnit.Point);
            btnAdd.ForeColor = Color.MistyRose;
            btnAdd.Location = new Point(766, 609);
            btnAdd.Name = "btnAdd";
            btnAdd.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btnAdd.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            btnAdd.Size = new Size(135, 87);
            btnAdd.TabIndex = 33;
            btnAdd.Text = "Remove";
            btnAdd.Click += btnAdd_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe Print", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.SaddleBrown;
            label2.Location = new Point(289, 358);
            label2.Name = "label2";
            label2.Size = new Size(218, 31);
            label2.TabIndex = 30;
            label2.Text = "Select the Sub Product";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe Print", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.SaddleBrown;
            label1.Location = new Point(289, 168);
            label1.Name = "label1";
            label1.Size = new Size(231, 31);
            label1.TabIndex = 29;
            label1.Text = "Select the Main Product";
            // 
            // PnlS
            // 
            PnlS.BackColor = Color.Transparent;
            PnlS.Controls.Add(pnlErrSubRD);
            PnlS.Controls.Add(panel4);
            PnlS.Location = new Point(453, 439);
            PnlS.Name = "PnlS";
            PnlS.Size = new Size(230, 109);
            PnlS.TabIndex = 28;
            // 
            // pnlErrSubRD
            // 
            pnlErrSubRD.BackColor = Color.Transparent;
            pnlErrSubRD.Controls.Add(lblErrSubRD);
            pnlErrSubRD.Dock = DockStyle.Top;
            pnlErrSubRD.Location = new Point(0, 68);
            pnlErrSubRD.Name = "pnlErrSubRD";
            pnlErrSubRD.Size = new Size(230, 34);
            pnlErrSubRD.TabIndex = 10;
            pnlErrSubRD.Visible = false;
            // 
            // lblErrSubRD
            // 
            lblErrSubRD.AutoSize = true;
            lblErrSubRD.FlatStyle = FlatStyle.Flat;
            lblErrSubRD.Font = new Font("Segoe Print", 8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lblErrSubRD.ForeColor = Color.Crimson;
            lblErrSubRD.Location = new Point(3, 6);
            lblErrSubRD.Name = "lblErrSubRD";
            lblErrSubRD.Size = new Size(160, 28);
            lblErrSubRD.TabIndex = 10;
            lblErrSubRD.Text = "Invalid User Name";
            // 
            // panel4
            // 
            panel4.BackColor = Color.Transparent;
            panel4.Controls.Add(comboBoxSubRD);
            panel4.Dock = DockStyle.Top;
            panel4.Location = new Point(0, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(230, 68);
            panel4.TabIndex = 8;
            // 
            // comboBoxSubRD
            // 
            comboBoxSubRD.BackColor = Color.MistyRose;
            comboBoxSubRD.FlatStyle = FlatStyle.Flat;
            comboBoxSubRD.Font = new Font("Segoe Print", 9F, FontStyle.Bold, GraphicsUnit.Point);
            comboBoxSubRD.ForeColor = Color.SaddleBrown;
            comboBoxSubRD.FormattingEnabled = true;
            comboBoxSubRD.Location = new Point(15, 3);
            comboBoxSubRD.Name = "comboBoxSubRD";
            comboBoxSubRD.Size = new Size(195, 39);
            comboBoxSubRD.TabIndex = 28;
            // 
            // pnl1Main
            // 
            pnl1Main.BackColor = Color.Transparent;
            pnl1Main.Controls.Add(pnlLblMRD);
            pnl1Main.Controls.Add(pnle);
            pnl1Main.Location = new Point(450, 221);
            pnl1Main.Name = "pnl1Main";
            pnl1Main.Size = new Size(230, 109);
            pnl1Main.TabIndex = 27;
            // 
            // pnlLblMRD
            // 
            pnlLblMRD.BackColor = Color.Transparent;
            pnlLblMRD.Controls.Add(lblErrMainRD);
            pnlLblMRD.Dock = DockStyle.Top;
            pnlLblMRD.Location = new Point(0, 68);
            pnlLblMRD.Name = "pnlLblMRD";
            pnlLblMRD.Size = new Size(230, 34);
            pnlLblMRD.TabIndex = 10;
            pnlLblMRD.Visible = false;
            // 
            // lblErrMainRD
            // 
            lblErrMainRD.AutoSize = true;
            lblErrMainRD.BackColor = Color.Transparent;
            lblErrMainRD.FlatStyle = FlatStyle.Flat;
            lblErrMainRD.Font = new Font("Segoe Print", 8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lblErrMainRD.ForeColor = Color.Crimson;
            lblErrMainRD.Location = new Point(3, 6);
            lblErrMainRD.Name = "lblErrMainRD";
            lblErrMainRD.Size = new Size(160, 28);
            lblErrMainRD.TabIndex = 10;
            lblErrMainRD.Text = "Invalid User Name";
            // 
            // pnle
            // 
            pnle.BackColor = Color.Transparent;
            pnle.Controls.Add(comboBoxMainRD);
            pnle.Dock = DockStyle.Top;
            pnle.Location = new Point(0, 0);
            pnle.Name = "pnle";
            pnle.Size = new Size(230, 68);
            pnle.TabIndex = 8;
            // 
            // comboBoxMainRD
            // 
            comboBoxMainRD.BackColor = Color.MistyRose;
            comboBoxMainRD.FlatStyle = FlatStyle.Flat;
            comboBoxMainRD.Font = new Font("Segoe Print", 9F, FontStyle.Bold, GraphicsUnit.Point);
            comboBoxMainRD.ForeColor = Color.SaddleBrown;
            comboBoxMainRD.FormattingEnabled = true;
            comboBoxMainRD.Location = new Point(18, 3);
            comboBoxMainRD.Name = "comboBoxMainRD";
            comboBoxMainRD.Size = new Size(195, 39);
            comboBoxMainRD.TabIndex = 27;
            comboBoxMainRD.SelectedIndexChanged += comboBoxMainRD_SelectedIndexChanged;
            // 
            // discRemove
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1278, 850);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "discRemove";
            Text = "discRemove";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            PnlS.ResumeLayout(false);
            pnlErrSubRD.ResumeLayout(false);
            pnlErrSubRD.PerformLayout();
            panel4.ResumeLayout(false);
            pnl1Main.ResumeLayout(false);
            pnlLblMRD.ResumeLayout(false);
            pnlLblMRD.PerformLayout();
            pnle.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label2;
        private Label label1;
        private Panel PnlS;
        private Panel pnlErrSubRD;
        private Label lblErrSubRD;
        private Panel panel4;
        private ComboBox comboBoxSubRD;
        private Panel pnl1Main;
        private Panel pnlLblMRD;
        private Label lblErrMainRD;
        private Panel pnle;
        private ComboBox comboBoxMainRD;
        private Guna.UI2.WinForms.Guna2CircleButton btnAdd;
    }
}