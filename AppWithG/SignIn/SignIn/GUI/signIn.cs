using Guna.UI2.WinForms;
using SignIn.BL;
using SignIn.DL;
using SignIn.GUI;
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
    public partial class frmSignIn : Form
    {
        public frmSignIn()
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
            panel1.Controls.Add(childFormSign);
            panel1.Tag = childFormSign;
            childFormSign.BringToFront();
            childFormSign.Show();
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            customerBL cust = new customerBL();
            string custNameForFile = null;

            string name = txtuserName.Text;
            string password = txtpassword.Text;
            string role = validations.AdminSignIn(name, password, ref custNameForFile);
            if (role == "1")
            {
                AdminMenu2 admin = new AdminMenu2(cust);
                closePreviousForms();
                admin.Show();
            }
            else if (role == "2")
            {
                customerBL cust1 = new customerBL();
                cust = cust1;
                CustomerMenu2 customerMenu = new CustomerMenu2(ref custNameForFile, cust);
                closePreviousForms();
                customerMenu.Show();
            }
            else if (role != "1" && role != "2")
            {

                pnlErrPas.Visible = true;
                return;
            }
        }
        private void txtuserName_TextChanged(object sender, EventArgs e)
        {
            pnlErrPas.Visible = false;
        }
        private void closePreviousForms()
        {
            foreach (Form frm in Miss.miss.activeForms)
            {
                frm.Hide();
            }
        }

        private void txtpassword_TextChanged(object sender, EventArgs e)
        {
            txtpassword.PasswordChar = '.';
            pnlErrPas.Visible = false;
        }
        private void btnopen_Click(object sender, EventArgs e)
        {
            if (txtpassword.PasswordChar == '.')
            {
                btnClose.BringToFront();
                txtpassword.PasswordChar = '\0';
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {

            if (txtpassword.PasswordChar == '\0')
            {
                btnopen.BringToFront();
                txtpassword.PasswordChar = '.';
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            openChildFormSign(new forgotPass());
        }

        private void txtuserName_KeyPress(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar;
            if (c == 32)
            {
                e.Handled = true;
            }
        }

        private void txtpassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar;
            if (c == 32)
            {
                e.Handled = true;
            }
        }
    }
}

