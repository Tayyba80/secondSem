namespace SignIn
{
    partial class toBuyItems
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
            grdToBuy = new DataGridView();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)grdToBuy).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.BackgroundImage = Properties.Resources.frame_food_ingredients_baking_gently_pink_pastel_background_cooking_flat_lay_with_copy_space_top_view_baking_concept;
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Controls.Add(grdToBuy);
            panel1.Dock = DockStyle.Fill;
            panel1.Font = new Font("Segoe Print", 9F, FontStyle.Bold, GraphicsUnit.Point);
            panel1.ForeColor = Color.SaddleBrown;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(938, 512);
            panel1.TabIndex = 0;
            // 
            // grdToBuy
            // 
            grdToBuy.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            grdToBuy.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.ColumnHeader;
            grdToBuy.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
            grdToBuy.BackgroundColor = Color.MistyRose;
            grdToBuy.BorderStyle = BorderStyle.None;
            grdToBuy.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grdToBuy.GridColor = Color.RosyBrown;
            grdToBuy.Location = new Point(252, 91);
            grdToBuy.Margin = new Padding(4);
            grdToBuy.Name = "grdToBuy";
            grdToBuy.RowHeadersWidth = 62;
            grdToBuy.RowTemplate.Height = 33;
            grdToBuy.Size = new Size(403, 328);
            grdToBuy.TabIndex = 1;
            // 
            // toBuyItems
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(938, 512);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "toBuyItems";
            Text = "toBuyItems";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)grdToBuy).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private DataGridView grdToBuy;
    }
}