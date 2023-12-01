﻿namespace SignIn
{
    partial class PrcUpRmvDisc
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
            btnAdd = new Guna.UI2.WinForms.Guna2CircleButton();
            panel5 = new Panel();
            pnlErrPrcUp = new Panel();
            lblErrPrcUp = new Label();
            panel6 = new Panel();
            numPrcUp = new NumericUpDown();
            label2 = new Label();
            label1 = new Label();
            panel1.SuspendLayout();
            panel5.SuspendLayout();
            pnlErrPrcUp.SuspendLayout();
            panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numPrcUp).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.BackgroundImage = Properties.Resources.frame_food_ingredients_baking_gently_pink_pastel_background_cooking_flat_lay_with_copy_space_top_view_baking_concept;
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Controls.Add(lblstk);
            panel1.Controls.Add(btnAdd);
            panel1.Controls.Add(panel5);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1278, 850);
            panel1.TabIndex = 0;
            // 
            // lblstk
            // 
            lblstk.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            lblstk.AutoSize = true;
            lblstk.Font = new Font("Segoe Print", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lblstk.ForeColor = Color.SaddleBrown;
            lblstk.Image = Properties.Resources.minus;
            lblstk.ImageAlign = ContentAlignment.MiddleLeft;
            lblstk.Location = new Point(669, 671);
            lblstk.Name = "lblstk";
            lblstk.Size = new Size(213, 31);
            lblstk.TabIndex = 44;
            lblstk.Text = "    Discount Removed!";
            lblstk.Visible = false;
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
            btnAdd.Location = new Point(706, 565);
            btnAdd.Name = "btnAdd";
            btnAdd.ShadowDecoration.CustomizableEdges = customizableEdges1;
            btnAdd.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            btnAdd.Size = new Size(135, 87);
            btnAdd.TabIndex = 33;
            btnAdd.Text = "Update";
            btnAdd.Click += btnAdd_Click;
            // 
            // panel5
            // 
            panel5.BackColor = Color.Transparent;
            panel5.Controls.Add(pnlErrPrcUp);
            panel5.Controls.Add(panel6);
            panel5.Location = new Point(304, 348);
            panel5.Name = "panel5";
            panel5.Size = new Size(230, 109);
            panel5.TabIndex = 38;
            // 
            // pnlErrPrcUp
            // 
            pnlErrPrcUp.BackColor = Color.Transparent;
            pnlErrPrcUp.Controls.Add(lblErrPrcUp);
            pnlErrPrcUp.Dock = DockStyle.Top;
            pnlErrPrcUp.Location = new Point(0, 68);
            pnlErrPrcUp.Name = "pnlErrPrcUp";
            pnlErrPrcUp.Size = new Size(230, 34);
            pnlErrPrcUp.TabIndex = 10;
            pnlErrPrcUp.Visible = false;
            // 
            // lblErrPrcUp
            // 
            lblErrPrcUp.AutoSize = true;
            lblErrPrcUp.FlatStyle = FlatStyle.Flat;
            lblErrPrcUp.Font = new Font("Segoe Print", 8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lblErrPrcUp.ForeColor = Color.Crimson;
            lblErrPrcUp.Location = new Point(3, 6);
            lblErrPrcUp.Name = "lblErrPrcUp";
            lblErrPrcUp.Size = new Size(160, 28);
            lblErrPrcUp.TabIndex = 10;
            lblErrPrcUp.Text = "Invalid User Name";
            // 
            // panel6
            // 
            panel6.BackColor = Color.Transparent;
            panel6.Controls.Add(numPrcUp);
            panel6.Dock = DockStyle.Top;
            panel6.Location = new Point(0, 0);
            panel6.Name = "panel6";
            panel6.Size = new Size(230, 68);
            panel6.TabIndex = 8;
            // 
            // numPrcUp
            // 
            numPrcUp.BackColor = Color.MistyRose;
            numPrcUp.BorderStyle = BorderStyle.None;
            numPrcUp.Font = new Font("Segoe Print", 9F, FontStyle.Bold, GraphicsUnit.Point);
            numPrcUp.ForeColor = Color.SaddleBrown;
            numPrcUp.Location = new Point(21, 25);
            numPrcUp.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            numPrcUp.Name = "numPrcUp";
            numPrcUp.Size = new Size(195, 35);
            numPrcUp.TabIndex = 12;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe Print", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.SaddleBrown;
            label2.Location = new Point(222, 300);
            label2.Name = "label2";
            label2.Size = new Size(163, 31);
            label2.TabIndex = 31;
            label2.Text = "Enter New Price";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe Print", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.SaddleBrown;
            label1.Location = new Point(222, 194);
            label1.Name = "label1";
            label1.Size = new Size(690, 38);
            label1.TabIndex = 30;
            label1.Text = "Please Update the Price of Product After Removing Discount";
            // 
            // PrcUpRmvDisc
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1278, 850);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "PrcUpRmvDisc";
            Text = "PrcUpRmvDisc";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel5.ResumeLayout(false);
            pnlErrPrcUp.ResumeLayout(false);
            pnlErrPrcUp.PerformLayout();
            panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)numPrcUp).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label label2;
        private Panel panel5;
        private Panel pnlErrPrcUp;
        private Label lblErrPrcUp;
        private Panel panel6;
        private NumericUpDown numPrcUp;
        private Guna.UI2.WinForms.Guna2CircleButton btnAdd;
        private Label lblstk;
    }
}