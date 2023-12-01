namespace SignIn
{
    partial class Tofulfill2CheckBox
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
            checkBoxN = new CheckBox();
            lblErrMain = new Label();
            pnlLblM = new Panel();
            label3 = new Label();
            panel2 = new Panel();
            checkBoxY = new CheckBox();
            pnlLblM.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // checkBoxN
            // 
            checkBoxN.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            checkBoxN.AutoSize = true;
            checkBoxN.BackColor = Color.Transparent;
            checkBoxN.FlatStyle = FlatStyle.Flat;
            checkBoxN.Font = new Font("Segoe Print", 9F, FontStyle.Bold, GraphicsUnit.Point);
            checkBoxN.ForeColor = Color.LightCoral;
            checkBoxN.Location = new Point(371, 519);
            checkBoxN.Name = "checkBoxN";
            checkBoxN.Size = new Size(60, 35);
            checkBoxN.TabIndex = 50;
            checkBoxN.Text = "No";
            checkBoxN.UseVisualStyleBackColor = false;
            checkBoxN.CheckedChanged += checkBoxN_CheckedChanged;
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
            // pnlLblM
            // 
            pnlLblM.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnlLblM.BackColor = Color.Transparent;
            pnlLblM.Controls.Add(lblErrMain);
            pnlLblM.Location = new Point(78, 298);
            pnlLblM.Name = "pnlLblM";
            pnlLblM.Size = new Size(1197, 55);
            pnlLblM.TabIndex = 47;
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
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel2.BackColor = Color.Transparent;
            panel2.Controls.Add(label3);
            panel2.Location = new Point(77, 380);
            panel2.Name = "panel2";
            panel2.Size = new Size(1197, 46);
            panel2.TabIndex = 48;
            // 
            // checkBoxY
            // 
            checkBoxY.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            checkBoxY.AutoSize = true;
            checkBoxY.BackColor = Color.Transparent;
            checkBoxY.FlatStyle = FlatStyle.Flat;
            checkBoxY.Font = new Font("Segoe Print", 9F, FontStyle.Regular, GraphicsUnit.Point);
            checkBoxY.ForeColor = Color.LightCoral;
            checkBoxY.Location = new Point(370, 468);
            checkBoxY.Name = "checkBoxY";
            checkBoxY.Size = new Size(64, 35);
            checkBoxY.TabIndex = 49;
            checkBoxY.Text = "Yes";
            checkBoxY.UseVisualStyleBackColor = false;
            checkBoxY.CheckedChanged += checkBoxY_CheckedChanged;
            // 
            // Tofulfill2CheckBox
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.frame_food_ingredients_baking_gently_pink_pastel_background_cooking_flat_lay_with_copy_space_top_view_baking_concept;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1278, 850);
            Controls.Add(checkBoxN);
            Controls.Add(checkBoxY);
            Controls.Add(panel2);
            Controls.Add(pnlLblM);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Name = "Tofulfill2CheckBox";
            Text = "Tofulfill2CheckBox";
            Load += Tofulfill2CheckBox_Load;
            pnlLblM.ResumeLayout(false);
            pnlLblM.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckBox checkBoxN;
        private Label lblErrMain;
        private Panel pnlLblM;
        private Label label3;
        private Panel panel2;
        private CheckBox checkBoxY;
    }
}