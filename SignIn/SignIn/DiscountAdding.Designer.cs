namespace SignIn
{
    partial class DiscountAdding
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
            btnAddDisc = new Button();
            panel5 = new Panel();
            pnlErrPrcAD = new Panel();
            lblErrPrcAD = new Label();
            panel6 = new Panel();
            numpercAd = new NumericUpDown();
            label2 = new Label();
            panel2 = new Panel();
            pnlErrSubAD = new Panel();
            lblErrSubAD = new Label();
            panel4 = new Panel();
            comboxsubAD = new ComboBox();
            lblSub = new Label();
            pnl1Main = new Panel();
            pnlLblMAD = new Panel();
            lblErrMainAD = new Label();
            pnle = new Panel();
            comBoxMAD = new ComboBox();
            lblMName = new Label();
            panel1.SuspendLayout();
            panel5.SuspendLayout();
            pnlErrPrcAD.SuspendLayout();
            panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numpercAd).BeginInit();
            panel2.SuspendLayout();
            pnlErrSubAD.SuspendLayout();
            panel4.SuspendLayout();
            pnl1Main.SuspendLayout();
            pnlLblMAD.SuspendLayout();
            pnle.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.BackgroundImage = Properties.Resources.frame_food_ingredients_baking_gently_pink_pastel_background_cooking_flat_lay_with_copy_space_top_view_baking_concept;
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Controls.Add(btnAddDisc);
            panel1.Controls.Add(panel5);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(lblSub);
            panel1.Controls.Add(pnl1Main);
            panel1.Controls.Add(lblMName);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(938, 512);
            panel1.TabIndex = 0;
            // 
            // btnAddDisc
            // 
            btnAddDisc.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnAddDisc.FlatStyle = FlatStyle.Flat;
            btnAddDisc.Font = new Font("Segoe Print", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnAddDisc.ForeColor = Color.SaddleBrown;
            btnAddDisc.Location = new Point(631, 417);
            btnAddDisc.Name = "btnAddDisc";
            btnAddDisc.Size = new Size(231, 34);
            btnAddDisc.TabIndex = 38;
            btnAddDisc.Text = "Click To Add Discount";
            btnAddDisc.UseVisualStyleBackColor = true;
            btnAddDisc.Click += btnAddDisc_Click;
            // 
            // panel5
            // 
            panel5.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            panel5.BackColor = Color.Transparent;
            panel5.Controls.Add(pnlErrPrcAD);
            panel5.Controls.Add(panel6);
            panel5.Location = new Point(628, 115);
            panel5.Name = "panel5";
            panel5.Size = new Size(230, 109);
            panel5.TabIndex = 37;
            // 
            // pnlErrPrcAD
            // 
            pnlErrPrcAD.BackColor = Color.Transparent;
            pnlErrPrcAD.Controls.Add(lblErrPrcAD);
            pnlErrPrcAD.Dock = DockStyle.Top;
            pnlErrPrcAD.Location = new Point(0, 68);
            pnlErrPrcAD.Name = "pnlErrPrcAD";
            pnlErrPrcAD.Size = new Size(230, 34);
            pnlErrPrcAD.TabIndex = 10;
            pnlErrPrcAD.Visible = false;
            // 
            // lblErrPrcAD
            // 
            lblErrPrcAD.AutoSize = true;
            lblErrPrcAD.FlatStyle = FlatStyle.Flat;
            lblErrPrcAD.Font = new Font("Segoe Print", 8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lblErrPrcAD.ForeColor = Color.Crimson;
            lblErrPrcAD.Location = new Point(3, 6);
            lblErrPrcAD.Name = "lblErrPrcAD";
            lblErrPrcAD.Size = new Size(160, 28);
            lblErrPrcAD.TabIndex = 10;
            lblErrPrcAD.Text = "Invalid User Name";
            // 
            // panel6
            // 
            panel6.BackColor = Color.Transparent;
            panel6.Controls.Add(numpercAd);
            panel6.Dock = DockStyle.Top;
            panel6.Location = new Point(0, 0);
            panel6.Name = "panel6";
            panel6.Size = new Size(230, 68);
            panel6.TabIndex = 8;
            // 
            // numpercAd
            // 
            numpercAd.BackColor = Color.MistyRose;
            numpercAd.BorderStyle = BorderStyle.None;
            numpercAd.Font = new Font("Segoe Print", 9F, FontStyle.Bold, GraphicsUnit.Point);
            numpercAd.ForeColor = Color.SaddleBrown;
            numpercAd.Location = new Point(21, 25);
            numpercAd.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            numpercAd.Name = "numpercAd";
            numpercAd.Size = new Size(195, 35);
            numpercAd.TabIndex = 12;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe Print", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label2.ForeColor = Color.SaddleBrown;
            label2.Location = new Point(528, 62);
            label2.Name = "label2";
            label2.Size = new Size(301, 31);
            label2.TabIndex = 36;
            label2.Text = "Enter the percentage of Discont";
            // 
            // panel2
            // 
            panel2.BackColor = Color.Transparent;
            panel2.Controls.Add(pnlErrSubAD);
            panel2.Controls.Add(panel4);
            panel2.Location = new Point(198, 342);
            panel2.Name = "panel2";
            panel2.Size = new Size(230, 109);
            panel2.TabIndex = 34;
            // 
            // pnlErrSubAD
            // 
            pnlErrSubAD.BackColor = Color.Transparent;
            pnlErrSubAD.Controls.Add(lblErrSubAD);
            pnlErrSubAD.Dock = DockStyle.Top;
            pnlErrSubAD.Location = new Point(0, 68);
            pnlErrSubAD.Name = "pnlErrSubAD";
            pnlErrSubAD.Size = new Size(230, 34);
            pnlErrSubAD.TabIndex = 10;
            pnlErrSubAD.Visible = false;
            // 
            // lblErrSubAD
            // 
            lblErrSubAD.AutoSize = true;
            lblErrSubAD.FlatStyle = FlatStyle.Flat;
            lblErrSubAD.Font = new Font("Segoe Print", 8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lblErrSubAD.ForeColor = Color.Crimson;
            lblErrSubAD.Location = new Point(3, 6);
            lblErrSubAD.Name = "lblErrSubAD";
            lblErrSubAD.Size = new Size(160, 28);
            lblErrSubAD.TabIndex = 10;
            lblErrSubAD.Text = "Invalid User Name";
            // 
            // panel4
            // 
            panel4.BackColor = Color.Transparent;
            panel4.Controls.Add(comboxsubAD);
            panel4.Dock = DockStyle.Top;
            panel4.Location = new Point(0, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(230, 68);
            panel4.TabIndex = 8;
            // 
            // comboxsubAD
            // 
            comboxsubAD.BackColor = Color.MistyRose;
            comboxsubAD.FlatStyle = FlatStyle.Flat;
            comboxsubAD.Font = new Font("Segoe Print", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            comboxsubAD.ForeColor = Color.SaddleBrown;
            comboxsubAD.FormattingEnabled = true;
            comboxsubAD.Location = new Point(18, 3);
            comboxsubAD.Name = "comboxsubAD";
            comboxsubAD.Size = new Size(195, 39);
            comboxsubAD.TabIndex = 27;
            // 
            // lblSub
            // 
            lblSub.AutoSize = true;
            lblSub.BackColor = Color.Transparent;
            lblSub.Font = new Font("Segoe Print", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lblSub.ForeColor = Color.SaddleBrown;
            lblSub.Location = new Point(76, 279);
            lblSub.Name = "lblSub";
            lblSub.Size = new Size(218, 31);
            lblSub.TabIndex = 35;
            lblSub.Text = "Select the Sub Product";
            // 
            // pnl1Main
            // 
            pnl1Main.BackColor = Color.Transparent;
            pnl1Main.Controls.Add(pnlLblMAD);
            pnl1Main.Controls.Add(pnle);
            pnl1Main.Location = new Point(198, 115);
            pnl1Main.Name = "pnl1Main";
            pnl1Main.Size = new Size(230, 109);
            pnl1Main.TabIndex = 33;
            // 
            // pnlLblMAD
            // 
            pnlLblMAD.BackColor = Color.Transparent;
            pnlLblMAD.Controls.Add(lblErrMainAD);
            pnlLblMAD.Dock = DockStyle.Top;
            pnlLblMAD.Location = new Point(0, 68);
            pnlLblMAD.Name = "pnlLblMAD";
            pnlLblMAD.Size = new Size(230, 34);
            pnlLblMAD.TabIndex = 10;
            pnlLblMAD.Visible = false;
            // 
            // lblErrMainAD
            // 
            lblErrMainAD.AutoSize = true;
            lblErrMainAD.FlatStyle = FlatStyle.Flat;
            lblErrMainAD.Font = new Font("Segoe Print", 8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lblErrMainAD.ForeColor = Color.Crimson;
            lblErrMainAD.Location = new Point(3, 6);
            lblErrMainAD.Name = "lblErrMainAD";
            lblErrMainAD.Size = new Size(160, 28);
            lblErrMainAD.TabIndex = 10;
            lblErrMainAD.Text = "Invalid User Name";
            // 
            // pnle
            // 
            pnle.BackColor = Color.Transparent;
            pnle.Controls.Add(comBoxMAD);
            pnle.Dock = DockStyle.Top;
            pnle.Location = new Point(0, 0);
            pnle.Name = "pnle";
            pnle.Size = new Size(230, 68);
            pnle.TabIndex = 8;
            // 
            // comBoxMAD
            // 
            comBoxMAD.BackColor = Color.MistyRose;
            comBoxMAD.FlatStyle = FlatStyle.Flat;
            comBoxMAD.Font = new Font("Segoe Print", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            comBoxMAD.ForeColor = Color.SaddleBrown;
            comBoxMAD.FormattingEnabled = true;
            comBoxMAD.Location = new Point(18, 3);
            comBoxMAD.Name = "comBoxMAD";
            comBoxMAD.Size = new Size(195, 39);
            comBoxMAD.TabIndex = 27;
            comBoxMAD.SelectedIndexChanged += comBoxMAD_SelectedIndexChanged;
            // 
            // lblMName
            // 
            lblMName.AutoSize = true;
            lblMName.Font = new Font("Segoe Print", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lblMName.ForeColor = Color.SaddleBrown;
            lblMName.Location = new Point(76, 62);
            lblMName.Name = "lblMName";
            lblMName.Size = new Size(231, 31);
            lblMName.TabIndex = 32;
            lblMName.Text = "Select the Main Product";
            // 
            // DiscountAdding
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(938, 512);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "DiscountAdding";
            Text = "DiscountAdding";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel5.ResumeLayout(false);
            pnlErrPrcAD.ResumeLayout(false);
            pnlErrPrcAD.PerformLayout();
            panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)numpercAd).EndInit();
            panel2.ResumeLayout(false);
            pnlErrSubAD.ResumeLayout(false);
            pnlErrSubAD.PerformLayout();
            panel4.ResumeLayout(false);
            pnl1Main.ResumeLayout(false);
            pnlLblMAD.ResumeLayout(false);
            pnlLblMAD.PerformLayout();
            pnle.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnAddDisc;
        private Panel panel5;
        private Panel pnlErrPrcAD;
        private Label lblErrPrcAD;
        private Panel panel6;
        private NumericUpDown numpercAd;
        private Label label2;
        private Panel panel2;
        private Panel pnlErrSubAD;
        private Label lblErrSubAD;
        private Panel panel4;
        private ComboBox comboxsubAD;
        private Label lblSub;
        private Panel pnl1Main;
        private Panel pnlLblMAD;
        private Label lblErrMainAD;
        private Panel pnle;
        private ComboBox comBoxMAD;
        private Label lblMName;
    }
}