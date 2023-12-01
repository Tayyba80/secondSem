using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SignIn
{
    public partial class Save : Form
    {
        public Save()
        {
            InitializeComponent();
            timer1.Start();

        }
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000;
                return cp;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            circleBar.Increment(3);
            if (circleBar.Value >= circleBar.Maximum)
            {
                timer1.Stop();
                circleBar.Visible = false;
                pictureBox1.Visible = true;
                label1.Visible = true;
            }
        }
    }
}
