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
    public partial class UpdateStock : Form
    {
        public UpdateStock()
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
            pnlSubStk.Controls.Add(childFormSign);
            pnlSubStk.Tag = childFormSign;
            childFormSign.BringToFront();
            childFormSign.Show();
        }


        private void btnStock_Click(object sender, EventArgs e)
        {
            openChildFormSign(new nrmlStkUpdate());
        }

        private void btnTHstk_Click(object sender, EventArgs e)
        {
            openChildFormSign(new thStkUpdate());
        }
    }
}
