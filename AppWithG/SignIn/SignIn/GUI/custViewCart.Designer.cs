namespace SignIn
{
    partial class custViewCart
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
            gridVieMenu = new DataGridView();
            panel1 = new Panel();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)gridVieMenu).BeginInit();
            SuspendLayout();
            // 
            // gridVieMenu
            // 
            gridVieMenu.AllowUserToAddRows = false;
            gridVieMenu.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            gridVieMenu.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.ColumnHeader;
            gridVieMenu.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
            gridVieMenu.BackgroundColor = Color.Bisque;
            gridVieMenu.BorderStyle = BorderStyle.None;
            gridVieMenu.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridVieMenu.GridColor = Color.RosyBrown;
            gridVieMenu.Location = new Point(226, 317);
            gridVieMenu.Margin = new Padding(5);
            gridVieMenu.Name = "gridVieMenu";
            gridVieMenu.ReadOnly = true;
            gridVieMenu.RowHeadersWidth = 62;
            gridVieMenu.RowTemplate.Height = 33;
            gridVieMenu.Size = new Size(673, 304);
            gridVieMenu.TabIndex = 1;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            panel1.BackgroundImage = Properties.Resources.desert;
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Location = new Point(828, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(300, 292);
            panel1.TabIndex = 2;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe Print", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.SaddleBrown;
            label1.Location = new Point(161, 261);
            label1.Name = "label1";
            label1.Size = new Size(114, 35);
            label1.TabIndex = 30;
            label1.Text = "Your Cart";
            // 
            // custViewCart
            // 
            AutoScaleDimensions = new SizeF(12F, 31F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.custBack;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1126, 635);
            Controls.Add(label1);
            Controls.Add(panel1);
            Controls.Add(gridVieMenu);
            DoubleBuffered = true;
            Font = new Font("Segoe Print", 9F, FontStyle.Bold, GraphicsUnit.Point);
            ForeColor = Color.SaddleBrown;
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "custViewCart";
            Text = "custViewCart";
            ((System.ComponentModel.ISupportInitialize)gridVieMenu).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView gridVieMenu;
        private Panel panel1;
        private Label label1;
    }
}