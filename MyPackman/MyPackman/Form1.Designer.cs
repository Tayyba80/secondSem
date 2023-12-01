namespace MyPackman
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            gameLoop = new System.Windows.Forms.Timer(components);
            lblLives = new Label();
            lblScore = new Label();
            SuspendLayout();
            // 
            // gameLoop
            // 
            gameLoop.Enabled = true;
            gameLoop.Interval = 200;
            gameLoop.Tick += gameLoop_Tick_1;
            // 
            // lblLives
            // 
            lblLives.AutoSize = true;
            lblLives.BackColor = Color.Transparent;
            lblLives.Font = new Font("Segoe Print", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblLives.ForeColor = Color.AntiqueWhite;
            lblLives.Location = new Point(1365, 69);
            lblLives.Name = "lblLives";
            lblLives.Size = new Size(67, 31);
            lblLives.TabIndex = 0;
            lblLives.Text = "label1";
            // 
            // lblScore
            // 
            lblScore.AutoSize = true;
            lblScore.BackColor = Color.Transparent;
            lblScore.Font = new Font("Segoe Print", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblScore.ForeColor = Color.AntiqueWhite;
            lblScore.Location = new Point(1365, 136);
            lblScore.Name = "lblScore";
            lblScore.Size = new Size(67, 31);
            lblScore.TabIndex = 1;
            lblScore.Text = "label2";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(1538, 1050);
            Controls.Add(lblScore);
            Controls.Add(lblLives);
            DoubleBuffered = true;
            ForeColor = Color.Black;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load_1;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Timer gameLoop;
        private Label lblLives;
        private Label lblScore;
    }
}