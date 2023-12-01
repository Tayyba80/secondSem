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
    public partial class CustomerMenu : Form
    {
        private string custNameForFile;
        customerBL cust;
        public CustomerMenu(ref string custNameForFile, customerBL cust)
        {
            this.custNameForFile = custNameForFile;
            this.cust = cust;
            cartDL.readCustomerOrderFromFile(ref custNameForFile, cust);
           // cartDL.readCustomOrderFromFile();
            InitializeComponent();
            subMenuPanelDesign();

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
        private void subMenuPanelDesign()
        {
            pnlMenu.Visible = false;
            pnlDisc.Visible = false;
            pnlFdBck.Visible = false;
            pnlOrder.Visible = false;
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
            pnlSubAdmin.Controls.Add(childFormSign);
            pnlSubAdmin.Tag = childFormSign;
            childFormSign.BringToFront();
            childFormSign.Show();
        }
        private void HideSubMenuPanels()
        {
            if (pnlMenu.Visible == true)
            {
                pnlMenu.Visible = false;
            }
            if (pnlFdBck.Visible == true)
            {
                pnlFdBck.Visible = false;
            }
            if (pnlDisc.Visible == true)
            {
                pnlDisc.Visible = false;
            }
            if (pnlOrder.Visible == true)
            {
                pnlOrder.Visible = false;
            }
        }
        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                HideSubMenuPanels();
                subMenu.Visible = true;
            }
            else
            {
                subMenu.Visible = false;
            }
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            showSubMenu(pnlMenu);
        }

        private void btnviewMenu_Click(object sender, EventArgs e)
        {
            //code
            openChildFormSign(new CustViewMenu());
            HideSubMenuPanels();
        }

        private void btnadd_Click(object sender, EventArgs e)//addInCart
        {
            //code
            openChildFormSign(new custAddCart(ref custNameForFile, cust));
            HideSubMenuPanels();
        }

        private void btnUpdatePrc_Click(object sender, EventArgs e)//removeFromCart
        {
            //code
            openChildFormSign(new custCartDel(ref custNameForFile, cust));
            HideSubMenuPanels();
        }

        private void btnUpdateStk_Click(object sender, EventArgs e)//ViewCart
        {
            //code
            openChildFormSign(new custViewCart(ref custNameForFile, cust));
            HideSubMenuPanels();
        }

        private void btnDisc_Click(object sender, EventArgs e)
        {
            showSubMenu(pnlDisc);
        }

        private void btnDiscAdd_Click(object sender, EventArgs e)//see discounted Products
        {
            //code
            openChildFormSign(new discShow());
            HideSubMenuPanels();
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            showSubMenu(pnlOrder);
        }

        private void btnViwOrdr_Click(object sender, EventArgs e)//place oredr
        {
            //code
            openChildFormSign(new placeOrderN(cust));
            HideSubMenuPanels();
        }

        private void btnFlfilOrdr_Click(object sender, EventArgs e)//payBill
        {
            //code
            openChildFormSign(new custbillNor(cust));
            HideSubMenuPanels();
        }

        private void btnfeedBack_Click(object sender, EventArgs e)
        {
            showSubMenu(pnlFdBck);
        }

        private void btnfedBck_Click(object sender, EventArgs e)//add rattings
        {
            //code
            openChildFormSign(new rattingCust());
            HideSubMenuPanels();
        }

        private void btnRecom_Click(object sender, EventArgs e)//see recommendations
        {
            //code
            openChildFormSign(new recomCust());
            HideSubMenuPanels();
        }

        private void btnSave_Click(object sender, EventArgs e)//advance order
        {
            openChildFormSign(new AdvanceOrderCust(ref custNameForFile,cust));
        }

        private void btnAdAdmin_Click(object sender, EventArgs e)//login pass change
        {
            openChildFormSign(new changePassCust());
        }

        private void btnExit_Click(object sender, EventArgs e)
        {

        }
    }
}
