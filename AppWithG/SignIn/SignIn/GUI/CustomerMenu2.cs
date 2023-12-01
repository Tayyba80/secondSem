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
    public partial class CustomerMenu2 : Form
    {

        private string custNameForFile;
        customerBL cust;
        public CustomerMenu2(ref string custNameForFile, customerBL cust)
        {
            this.custNameForFile = custNameForFile;
            this.cust = cust;
            cartDL.readCustomerOrderFromFile(ref custNameForFile, cust);
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
            pnlMainFd.Visible = false;
            pnlMainOrder.Visible = false;
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
        private void HideSubMenuPanels()
        {
            if (pnlMenu.Visible == true)
            {
                pnlMenu.Visible = false;
            }
            if (pnlMainFd.Visible == true)
            {
                pnlMainFd.Visible = false;
            }
            if (pnlDisc.Visible == true)
            {
                pnlDisc.Visible = false;
            }
            if (pnlMainOrder.Visible == true)
            {
                pnlMainOrder.Visible = false;
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


        private void btnMainMenu_Click(object sender, EventArgs e)
        {
            showSubMenu(pnlMenu);
        }

        private void btnViewItem_Click(object sender, EventArgs e)
        {
            openChildFormSign(new CustViewMenu());
            HideSubMenuPanels();
        }

        private void btnAddMenu_Click(object sender, EventArgs e)
        {
            openChildFormSign(new custAddCart(ref custNameForFile, cust));
            HideSubMenuPanels();
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            openChildFormSign(new custCartDel(ref custNameForFile, cust));
            HideSubMenuPanels();
        }

        private void btnToBuy_Click(object sender, EventArgs e)//view cart
        {
            openChildFormSign(new custViewCart(ref custNameForFile, cust));
            HideSubMenuPanels();
        }

        private void btnMainDis_Click(object sender, EventArgs e)
        {
            showSubMenu(pnlDisc);
        }

        private void btnAddDisc_Click(object sender, EventArgs e)//discProd
        {
            openChildFormSign(new discShow());
            HideSubMenuPanels();
        }

        private void btnFdMain_Click(object sender, EventArgs e) //orderMain
        {
            showSubMenu(pnlMainFd);
        }

        private void btnFdBck_Click(object sender, EventArgs e)//place order
        {
            openChildFormSign(new placeOrderN(cust));
            HideSubMenuPanels();
        }

        private void btnRecom_Click(object sender, EventArgs e) //paybill
        {
            openChildFormSign(new custbillNor(cust));
            HideSubMenuPanels();
        }

        private void btnMainOrder_Click(object sender, EventArgs e)//fdMain
        {
            showSubMenu(pnlMainOrder);
        }

        private void btnToBeFulfl_Click(object sender, EventArgs e)//addFdb
        {
            openChildFormSign(new rattingCust());
            HideSubMenuPanels();
        }

        private void guna2GradientButton2_Click(object sender, EventArgs e)//see recom
        {
            openChildFormSign(new recomCust());
            HideSubMenuPanels();
        }

        private void btnAddAdmin_Click(object sender, EventArgs e)//advance odr
        {
            openChildFormSign(new AdvanceOrderCust(ref custNameForFile, cust));
        }

        private void guna2GradientButton3_Click(object sender, EventArgs e)//chngPass
        {
            openChildFormSign(new changePassCust());
        }

        private void guna2GradientButton4_Click(object sender, EventArgs e)//exit
        {
            this.Close();
        }

        private void guna2ImageButton3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void guna2ImageButton2_Click(object sender, EventArgs e)
        {

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
