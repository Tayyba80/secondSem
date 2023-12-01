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
            gridViewMenuC = new DataGridView();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gridViewMenuC).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackgroundImage = Properties.Resources.cake;
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Controls.Add(gridViewMenuC);
            panel1.Dock = DockStyle.Fill;
            panel1.Font = new Font("Segoe Print", 9F, FontStyle.Bold, GraphicsUnit.Point);
            panel1.ForeColor = Color.SaddleBrown;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(938, 512);
            panel1.TabIndex = 0;
            // 
            // gridViewMenuC
            // 
            gridViewMenuC.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.ColumnHeader;
            gridViewMenuC.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
            gridViewMenuC.BackgroundColor = Color.DarkSalmon;
            gridViewMenuC.BorderStyle = BorderStyle.None;
            gridViewMenuC.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridViewMenuC.Dock = DockStyle.Fill;
            gridViewMenuC.GridColor = Color.DarkSalmon;
            gridViewMenuC.Location = new Point(0, 0);
            gridViewMenuC.Margin = new Padding(4);
            gridViewMenuC.Name = "gridViewMenuC";
            gridViewMenuC.ReadOnly = true;
            gridViewMenuC.RowHeadersWidth = 62;
            gridViewMenuC.RowTemplate.Height = 33;
            gridViewMenuC.Size = new Size(938, 512);
            gridViewMenuC.TabIndex = 1;
            // 
            // CustViewMenu
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(938, 512);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "CustViewMenu";
            Text = "CustViewMenu";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)gridViewMenuC).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private DataGridView gridViewMenuC;
    }
}