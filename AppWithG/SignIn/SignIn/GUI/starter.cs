using SignIn.DL;
using SignIn.Miss;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SignIn.GUI
{
    public partial class starter : Form
    {
        public starter()
        {
            InitializeComponent();
            productDL.readMenuFromFile();
            cartDL.readCustomOrderFromAdminFile();
            discountDL.readDiscountFromFile();
            rattingDL.readRattingFromFile();
            signDL.readAdminAndUserFromFile();
            cartDL.readCustomOrderFromFile();
            timer1.Start();
        }
        private Form activeForm = null;

        private void openChildFormSign(Form childFormSign)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            activeForm = childFormSign;
            childFormSign.TopLevel = false;
            childFormSign.FormBorderStyle = FormBorderStyle.None;
            childFormSign.Dock = DockStyle.Fill;
            panel1.Controls.Add(childFormSign);
            panel1.Tag = childFormSign;
            childFormSign.BringToFront();
            childFormSign.Show();
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            pbh1.Increment(3);
            pbh2.Increment(3);
            pgv1.Increment(3);
            pbv2.Increment(3);
            if (pbh1.Value >= pbh1.Maximum && pbh2.Value >= pbh2.Maximum && pbv2.Value >= pbv2.Maximum && pgv1.Value >= pgv1.Maximum)
            {
                timer1.Stop();
                miss.activeForms.Add(this);
                openChildFormSign(new SignOptions());
            }
        }

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMax_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Maximized;
            }
            else
            {
                WindowState = FormWindowState.Normal;
            }
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
    }
}
