using MyGame.gameLogics;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyGame
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
            closeForms.activeForms.Add(this);
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
        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
           
            openChildFormSign(new Instructions());
        }

        private void guna2GradientButton2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {

           Form1 obj=new Form1();
            closePreviousForms();
            obj.Show();
        }
        private void closePreviousForms()
        {
            foreach (Form frm in closeForms.activeForms)
            {
                frm.Hide();
            }
        }

    }
}
