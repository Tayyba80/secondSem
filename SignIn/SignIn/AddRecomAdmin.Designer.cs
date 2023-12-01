namespace SignIn
{
    partial class AddRecomAdmin
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
            label1 = new Label();
            pnlLblM = new Panel();
            lblErrMain = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            pnlLblM.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackgroundImage = Properties.Resources.frame_food_ingredients_baking_gently_pink_pastel_background_cooking_flat_lay_with_copy_space_top_view_baking_concept;
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(pnlLblM);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(938, 512);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Transparent;
            panel2.Controls.Add(label1);
            panel2.Location = new Point(3, 288);
            panel2.Name = "panel2";
            panel2.Size = new Size(932, 55);
            panel2.TabIndex = 41;
            panel2.Visible = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.FlatStyle = FlatStyle.Flat;
            label1.Font = new Font("Segoe Print", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.ForeColor = Color.Crimson;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(182, 31);
            label1.TabIndex = 10;
            label1.Text = "Invalid User Name";
            // 
            // pnlLblM
            // 
            pnlLblM.BackColor = Color.Transparent;
            pnlLblM.Controls.Add(lblErrMain);
            pnlLblM.Location = new Point(3, 169);
            pnlLblM.Name = "pnlLblM";
            pnlLblM.Size = new Size(932, 55);
            pnlLblM.TabIndex = 40;
            pnlLblM.Visible = false;
            // 
            // lblErrMain
            // 
            lblErrMain.AutoSize = true;
            lblErrMain.FlatStyle = FlatStyle.Flat;
            lblErrMain.Font = new Font("Segoe Print", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lblErrMain.ForeColor = Color.Brown;
            lblErrMain.Location = new Point(0, 0);
            lblErrMain.Name = "lblErrMain";
            lblErrMain.Size = new Size(182, 31);
            lblErrMain.TabIndex = 10;
            lblErrMain.Text = "Invalid User Name";
            // 
            // AddRecomAdmin
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(938, 512);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AddRecomAdmin";
            Text = "AddRecomAdmin";
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            pnlLblM.ResumeLayout(false);
            pnlLblM.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label label1;
        private Panel pnlLblM;
        private Label lblErrMain;
    }
}