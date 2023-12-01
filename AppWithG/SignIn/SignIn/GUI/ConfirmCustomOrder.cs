using SignIn.BL;
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
    public partial class ConfirmCustomOrder : Form
    {
        string custNameForFile; customerBL cust;
        public ConfirmCustomOrder(ref string custNameForFile, customerBL cust)
        {
            InitializeComponent();
            this.custNameForFile = custNameForFile;
            this.cust = cust;
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

        private void btnAddInMenu_Click(object sender, EventArgs e)
        {
            openChildFormSign(new BillCustom(ref custNameForFile, cust));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            btnAddInMenu.Visible = false;
            button1.Visible = false;
            label2.Visible = false;
            lblErrMain.Text = "You Cancled Your Order!";
            pnlLblM.Visible = true;
        }
    }
}
