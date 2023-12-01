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
    public partial class SignOptions : Form
    {
        public SignOptions()
        {
            InitializeComponent();
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
        private void button1_Click(object sender, EventArgs e)
        {
            openChildFormSign(new frmSignIn());
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
            panelChildFormSign.Controls.Add(childFormSign);
            panelChildFormSign.Tag = childFormSign;
            childFormSign.BringToFront();
            childFormSign.Show();
        }

        private void panelChildFormSign_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            openChildFormSign(new signUP2());
        }

        private void SignOptions_Load(object sender, EventArgs e)
        {

        }
    }
}
