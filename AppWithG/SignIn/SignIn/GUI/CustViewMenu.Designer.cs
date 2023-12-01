namespace SignIn
{
    partial class CustViewMenu
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
            panel7 = new Panel();
            label3 = new Label();
            label2 = new Label();
            label6 = new Label();
            label9 = new Label();
            label1 = new Label();
            gridViewMenuC = new DataGridView();
            panel1.SuspendLayout();
            panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gridViewMenuC).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackgroundImage = Properties.Resources.custBack;
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Controls.Add(panel7);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(gridViewMenuC);
            panel1.Dock = DockStyle.Fill;
            panel1.Font = new Font("Segoe Print", 9F, FontStyle.Bold, GraphicsUnit.Point);
            panel1.ForeColor = Color.SaddleBrown;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1278, 793);
            panel1.TabIndex = 0;
            // 
            // panel7
            // 
            panel7.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            panel7.BackColor = Color.PeachPuff;
            panel7.Controls.Add(label3);
            panel7.Controls.Add(label2);
            panel7.Controls.Add(label6);
            panel7.Controls.Add(label9);
            panel7.Location = new Point(932, 504);
            panel7.Name = "panel7";
            panel7.Size = new Size(321, 255);
            panel7.TabIndex = 44;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe Script", 14F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label3.ForeColor = Color.DarkRed;
            label3.Location = new Point(135, 183);
            label3.Name = "label3";
            label3.Size = new Size(46, 46);
            label3.TabIndex = 5;
            label3.Text = "it";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe Script", 11F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label2.ForeColor = Color.DarkRed;
            label2.Location = new Point(95, 135);
            label2.Name = "label2";
            label2.Size = new Size(112, 37);
            label2.TabIndex = 4;
            label2.Text = "You take";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe Script", 14F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label6.ForeColor = Color.DarkRed;
            label6.Location = new Point(117, 79);
            label6.Name = "label6";
            label6.Size = new Size(46, 46);
            label6.TabIndex = 3;
            label6.Text = "it";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe Script", 11F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label9.ForeColor = Color.DarkRed;
            label9.Location = new Point(106, 28);
            label9.Name = "label9";
            label9.Size = new Size(112, 37);
            label9.TabIndex = 0;
            label9.Text = "We Bake";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Left;
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe Print", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(62, 83);
            label1.Name = "label1";
            label1.Size = new Size(128, 38);
            label1.TabIndex = 2;
            label1.Text = "Our Menu";
            // 
            // gridViewMenuC
            // 
            gridViewMenuC.AllowUserToAddRows = false;
            gridViewMenuC.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            gridViewMenuC.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.ColumnHeader;
            gridViewMenuC.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
            gridViewMenuC.BackgroundColor = Color.Bisque;
            gridViewMenuC.BorderStyle = BorderStyle.None;
            gridViewMenuC.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridViewMenuC.GridColor = Color.DarkSalmon;
            gridViewMenuC.Location = new Point(116, 134);
            gridViewMenuC.Margin = new Padding(4);
            gridViewMenuC.Name = "gridViewMenuC";
            gridViewMenuC.ReadOnly = true;
            gridViewMenuC.RowHeadersWidth = 62;
            gridViewMenuC.RowTemplate.Height = 33;
            gridViewMenuC.Size = new Size(689, 345);
            gridViewMenuC.TabIndex = 1;
            // 
            // CustViewMenu
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1278, 793);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "CustViewMenu";
            Text = "CustViewMenu";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)gridViewMenuC).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private DataGridView gridViewMenuC;
        private Label label1;
        private Panel panel7;
        private Label label3;
        private Label label2;
        private Label label6;
        private Label label9;
    }
}