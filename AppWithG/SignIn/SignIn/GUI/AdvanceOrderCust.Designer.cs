﻿namespace SignIn
{
    partial class AdvanceOrderCust
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
            panel3 = new Panel();
            btnAdd = new Guna.UI2.WinForms.Guna2CircleButton();
            pnlCommonErr = new Panel();
            lblCommonErr = new Label();
            panel5 = new Panel();
            pnlErrPrc = new Panel();
            lblErrPrc = new Label();
            panel6 = new Panel();
            numprc = new NumericUpDown();
            panel2 = new Panel();
            pnlErrSub = new Panel();
            lblErrSub = new Label();
            panel4 = new Panel();
            comboxsub = new ComboBox();
            label2 = new Label();
            lblSub = new Label();
            pnl1Main = new Panel();
            pnlLblM = new Panel();
            lblErrMain = new Label();
            pnle = new Panel();
            comBoxM = new ComboBox();
            lblMName = new Label();
            lblD = new Label();
            dateTimePicker1 = new DateTimePicker();
            panel1.SuspendLayout();
            pnlCommonErr.SuspendLayout();
            panel5.SuspendLayout();
            pnlErrPrc.SuspendLayout();
            panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numprc).BeginInit();
            panel2.SuspendLayout();
            pnlErrSub.SuspendLayout();
            panel4.SuspendLayout();
            pnl1Main.SuspendLayout();
            pnlLblM.SuspendLayout();
            pnle.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackgroundImage = Properties.Resources.custBack;
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(btnAdd);
            panel1.Controls.Add(pnlCommonErr);
            panel1.Controls.Add(panel5);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(lblSub);
            panel1.Controls.Add(pnl1Main);
            panel1.Controls.Add(lblMName);
            panel1.Controls.Add(lblD);
            panel1.Controls.Add(dateTimePicker1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1278, 793);
            panel1.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Left;
            panel3.BackColor = Color.Gainsboro;
            panel3.BackgroundImage = Properties.Resources.forBill;
            panel3.BackgroundImageLayout = ImageLayout.Stretch;
            panel3.Location = new Point(2, 178);
            panel3.Name = "panel3";
            panel3.Size = new Size(307, 310);
            panel3.TabIndex = 44;
            // 
            // btnAdd
            // 
            btnAdd.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnAdd.BackColor = Color.Transparent;
            btnAdd.DisabledState.BorderColor = Color.DarkGray;
            btnAdd.DisabledState.CustomBorderColor = Color.DarkGray;
            btnAdd.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnAdd.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnAdd.FillColor = Color.PeachPuff;
            btnAdd.Font = new Font("Segoe Print", 11F, FontStyle.Bold, GraphicsUnit.Point);
            btnAdd.ForeColor = Color.SaddleBrown;
            btnAdd.Location = new Point(1067, 501);
            btnAdd.Name = "btnAdd";
            btnAdd.ShadowDecoration.CustomizableEdges = customizableEdges1;
            btnAdd.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            btnAdd.Size = new Size(135, 87);
            btnAdd.TabIndex = 43;
            btnAdd.Text = "Add";
            btnAdd.Click += btnAdd_Click;
            // 
            // pnlCommonErr
            // 
            pnlCommonErr.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            pnlCommonErr.BackColor = Color.Transparent;
            pnlCommonErr.Controls.Add(lblCommonErr);
            pnlCommonErr.Location = new Point(932, 609);
            pnlCommonErr.Name = "pnlCommonErr";
            pnlCommonErr.Size = new Size(343, 40);
            pnlCommonErr.TabIndex = 38;
            pnlCommonErr.Visible = false;
            // 
            // lblCommonErr
            // 
            lblCommonErr.AutoSize = true;
            lblCommonErr.FlatStyle = FlatStyle.Flat;
            lblCommonErr.Font = new Font("Segoe Print", 8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lblCommonErr.ForeColor = Color.Crimson;
            lblCommonErr.Location = new Point(3, 0);
            lblCommonErr.Name = "lblCommonErr";
            lblCommonErr.Size = new Size(160, 28);
            lblCommonErr.TabIndex = 10;
            lblCommonErr.Text = "Invalid User Name";
            // 
            // panel5
            // 
            panel5.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            panel5.BackColor = Color.Transparent;
            panel5.Controls.Add(pnlErrPrc);
            panel5.Controls.Add(panel6);
            panel5.Location = new Point(1023, 232);
            panel5.Name = "panel5";
            panel5.Size = new Size(230, 109);
            panel5.TabIndex = 36;
            // 
            // pnlErrPrc
            // 
            pnlErrPrc.BackColor = Color.Transparent;
            pnlErrPrc.Controls.Add(lblErrPrc);
            pnlErrPrc.Dock = DockStyle.Top;
            pnlErrPrc.Location = new Point(0, 68);
            pnlErrPrc.Name = "pnlErrPrc";
            pnlErrPrc.Size = new Size(230, 34);
            pnlErrPrc.TabIndex = 10;
            pnlErrPrc.Visible = false;
            // 
            // lblErrPrc
            // 
            lblErrPrc.AutoSize = true;
            lblErrPrc.FlatStyle = FlatStyle.Flat;
            lblErrPrc.Font = new Font("Segoe Print", 8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lblErrPrc.ForeColor = Color.Crimson;
            lblErrPrc.Location = new Point(3, 6);
            lblErrPrc.Name = "lblErrPrc";
            lblErrPrc.Size = new Size(160, 28);
            lblErrPrc.TabIndex = 10;
            lblErrPrc.Text = "Invalid User Name";
            // 
            // panel6
            // 
            panel6.BackColor = Color.Transparent;
            panel6.Controls.Add(numprc);
            panel6.Dock = DockStyle.Top;
            panel6.Location = new Point(0, 0);
            panel6.Name = "panel6";
            panel6.Size = new Size(230, 68);
            panel6.TabIndex = 8;
            // 
            // numprc
            // 
            numprc.BackColor = Color.PeachPuff;
            numprc.BorderStyle = BorderStyle.None;
            numprc.Font = new Font("Segoe Print", 9F, FontStyle.Bold, GraphicsUnit.Point);
            numprc.ForeColor = Color.SaddleBrown;
            numprc.Location = new Point(21, 25);
            numprc.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            numprc.Name = "numprc";
            numprc.Size = new Size(195, 35);
            numprc.TabIndex = 12;
            numprc.ValueChanged += numprc_ValueChanged_1;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Transparent;
            panel2.Controls.Add(pnlErrSub);
            panel2.Controls.Add(panel4);
            panel2.Location = new Point(524, 426);
            panel2.Name = "panel2";
            panel2.Size = new Size(230, 109);
            panel2.TabIndex = 33;
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
            panel4.Controls.Add(comboxsub);
            panel4.Dock = DockStyle.Top;
            panel4.Location = new Point(0, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(230, 68);
            panel4.TabIndex = 8;
            // 
            // comboxsub
            // 
            comboxsub.BackColor = Color.PeachPuff;
            comboxsub.FlatStyle = FlatStyle.Flat;
            comboxsub.Font = new Font("Segoe Print", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            comboxsub.ForeColor = Color.SaddleBrown;
            comboxsub.FormattingEnabled = true;
            comboxsub.Location = new Point(18, 3);
            comboxsub.Name = "comboxsub";
            comboxsub.Size = new Size(195, 39);
            comboxsub.TabIndex = 27;
            comboxsub.SelectedIndexChanged += comboxsub_SelectedIndexChanged_1;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe Print", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label2.ForeColor = Color.SaddleBrown;
            label2.Location = new Point(967, 178);
            label2.Name = "label2";
            label2.Size = new Size(144, 31);
            label2.TabIndex = 34;
            label2.Text = "Enter Amount";
            // 
            // lblSub
            // 
            lblSub.AutoSize = true;
            lblSub.BackColor = Color.Transparent;
            lblSub.Font = new Font("Segoe Print", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lblSub.ForeColor = Color.SaddleBrown;
            lblSub.Location = new Point(402, 362);
            lblSub.Name = "lblSub";
            lblSub.Size = new Size(218, 31);
            lblSub.TabIndex = 35;
            lblSub.Text = "Select the Sub Product";
            // 
            // pnl1Main
            // 
            pnl1Main.BackColor = Color.Transparent;
            pnl1Main.Controls.Add(pnlLblM);
            pnl1Main.Controls.Add(pnle);
            pnl1Main.Location = new Point(524, 231);
            pnl1Main.Name = "pnl1Main";
            pnl1Main.Size = new Size(230, 109);
            pnl1Main.TabIndex = 32;
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
            lblErrMain.Font = new Font("Segoe Print", 8F, FontStyle.Bold, GraphicsUnit.Point);
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
            pnle.Controls.Add(comBoxM);
            pnle.Dock = DockStyle.Top;
            pnle.Location = new Point(0, 0);
            pnle.Name = "pnle";
            pnle.Size = new Size(230, 68);
            pnle.TabIndex = 8;
            // 
            // comBoxM
            // 
            comBoxM.BackColor = Color.PeachPuff;
            comBoxM.FlatStyle = FlatStyle.Flat;
            comBoxM.Font = new Font("Segoe Print", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            comBoxM.ForeColor = Color.SaddleBrown;
            comBoxM.FormattingEnabled = true;
            comBoxM.Location = new Point(18, 3);
            comBoxM.Name = "comBoxM";
            comBoxM.Size = new Size(195, 39);
            comBoxM.TabIndex = 27;
            comBoxM.SelectedIndexChanged += comBoxM_SelectedIndexChanged_1;
            // 
            // lblMName
            // 
            lblMName.AutoSize = true;
            lblMName.BackColor = Color.Transparent;
            lblMName.Font = new Font("Segoe Print", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lblMName.ForeColor = Color.SaddleBrown;
            lblMName.Location = new Point(402, 178);
            lblMName.Name = "lblMName";
            lblMName.Size = new Size(231, 31);
            lblMName.TabIndex = 31;
            lblMName.Text = "Select the Main Product";
            // 
            // lblD
            // 
            lblD.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblD.AutoSize = true;
            lblD.BackColor = Color.Transparent;
            lblD.FlatStyle = FlatStyle.Flat;
            lblD.Font = new Font("Segoe Print", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblD.ForeColor = Color.SaddleBrown;
            lblD.Location = new Point(967, 362);
            lblD.Name = "lblD";
            lblD.Size = new Size(114, 31);
            lblD.TabIndex = 2;
            lblD.Text = "Select Date";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            dateTimePicker1.CalendarForeColor = Color.SaddleBrown;
            dateTimePicker1.CalendarMonthBackground = Color.Transparent;
            dateTimePicker1.CalendarTitleBackColor = Color.Transparent;
            dateTimePicker1.CalendarTitleForeColor = Color.SaddleBrown;
            dateTimePicker1.CalendarTrailingForeColor = Color.SaddleBrown;
            dateTimePicker1.CustomFormat = "yyyyMMMMdd  hh:mm:ss";
            dateTimePicker1.Font = new Font("Segoe Print", 9F, FontStyle.Bold, GraphicsUnit.Point);
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.Location = new Point(924, 426);
            dateTimePicker1.MinDate = new DateTime(2023, 7, 30, 0, 0, 0, 0);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.ShowUpDown = true;
            dateTimePicker1.Size = new Size(338, 39);
            dateTimePicker1.TabIndex = 0;
            dateTimePicker1.Value = new DateTime(2023, 7, 30, 0, 0, 0, 0);
            // 
            // AdvanceOrderCust
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1278, 793);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AdvanceOrderCust";
            Text = "AdvanceOrderCust";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            pnlCommonErr.ResumeLayout(false);
            pnlCommonErr.PerformLayout();
            panel5.ResumeLayout(false);
            pnlErrPrc.ResumeLayout(false);
            pnlErrPrc.PerformLayout();
            panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)numprc).EndInit();
            panel2.ResumeLayout(false);
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
        private DateTimePicker dateTimePicker1;
        private Label lblD;
        private Panel panel2;
        private Panel pnlErrSub;
        private Label lblErrSub;
        private Panel panel4;
        private ComboBox comboxsub;
        private Label label2;
        private Label lblSub;
        private Panel pnl1Main;
        private Panel pnlLblM;
        private Label lblErrMain;
        private Panel pnle;
        private ComboBox comBoxM;
        private Label lblMName;
        private Panel panel5;
        private Panel pnlErrPrc;
        private Label lblErrPrc;
        private Panel panel6;
        private NumericUpDown numprc;
        private Panel pnlCommonErr;
        private Label lblCommonErr;
        private Guna.UI2.WinForms.Guna2CircleButton btnAdd;
        private Panel panel3;
    }
}