using SignIn.BL;
using SignIn.DL;
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
    public partial class custCartDel : Form
    {
        string custNameForFile;
        customerBL cust;
        public custCartDel(ref string custNameForFile, customerBL cust)
        {
            InitializeComponent();
            this.cust = cust;
            this.custNameForFile = custNameForFile;
            addInDropDownOfComboBoxMain();
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
        private void addInDropDownOfComboBoxMain()
        {
            foreach (var i in cust.cart)
            {
                comboBoxMain.Items.Add(i.NameOrderMain);
            }

        }
        private void addInDropDownOfComboBoxSub()
        {
            string mainName = comboBoxMain.Text;
            if (mainName != null)
            {
                foreach (var i in cust.cart)
                {
                    if (i.NameOrderMain == mainName)
                    {
                        comboBoxSub.Items.Add(i.OrderName);
                    }
                }
            }
        }

        private void comboBoxSub_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxMain_SelectedIndexChanged(object sender, EventArgs e)
        {
            addInDropDownOfComboBoxSub();
        }

        private void btnAddInMenu_Click(object sender, EventArgs e)
        {
            string mainName = comboBoxMain.Text;
            string subName = comboBoxSub.Text;
            if (mainName != null)
            {
                if (subName != null && subName != "")
                {
                    cust.removeFromCart(mainName, subName);
                }
                else
                {
                    lblErrSub.Text = "Please select the SubProduct";
                    pnlErrSub.Visible = true;
                }
            }
            else
            {
                lblErrMain.Text = "Please Select Main Product";
                pnlLblM.Visible = true;
            }
            cartDL.storeNormalCustomerOrderInFile(ref custNameForFile, cust);
            cartDL.storeRemainingNormalCustOrderInFile();
        }
    }
}
