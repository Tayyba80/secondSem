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
    public partial class AdminMenu2 : Form
    {
        customerBL cust;
        public AdminMenu2(customerBL cust)
        {
            InitializeComponent();
            this.cust = cust;
            pnlDisc.Visible = false;
            pnlMainFd.Visible = false;
            pnlMainOrder.Visible = false;
            pnlMenu.Visible = false;
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
        private void subMenuPanelDesign()
        {
            pnlMenu.Visible = false;
            pnlDisc.Visible = false;
            pnlMainFd.Visible = false;
            pnlMainOrder.Visible = false;
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


        private void btnMainMenu_Click_1(object sender, EventArgs e)
        {
            showSubMenu(pnlMenu);
        }

        private void btnAddMenu_Click_1(object sender, EventArgs e)
        {
            openChildFormSign(new AdminAdd());
            HideSubMenuPanels();
        }

        private void btnUpdatePrc_Click_1(object sender, EventArgs e)
        {
            openChildFormSign(new UpdatePrice());
            HideSubMenuPanels();
        }

        private void btnUpStk_Click_1(object sender, EventArgs e)
        {
            openChildFormSign(new UpdateStock());
            HideSubMenuPanels();
        }

        private void btndelete_Click_1(object sender, EventArgs e)
        {
            openChildFormSign(new AdminRemove());
            HideSubMenuPanels();
        }

        private void btnToBuy_Click_1(object sender, EventArgs e)
        {
            openChildFormSign(new toBuyItems());
            HideSubMenuPanels();
        }

        private void btnMainDis_Click_1(object sender, EventArgs e)
        {
            showSubMenu(pnlDisc);
        }

        private void btnAddDisc_Click_1(object sender, EventArgs e)
        {
            openChildFormSign(new DiscountAdding());
            HideSubMenuPanels();
        }

        private void guna2GradientButton1_Click_1(object sender, EventArgs e)
        {
            openChildFormSign(new discRemove());
            HideSubMenuPanels();
        }

        private void btnFdMain_Click_1(object sender, EventArgs e)
        {
            showSubMenu(pnlMainFd);
        }

        private void btnFdBck_Click_1(object sender, EventArgs e)
        {
            openChildFormSign(new SeeRattingAdmin());
            HideSubMenuPanels();
        }

        private void btnRecom_Click_1(object sender, EventArgs e)
        {
            openChildFormSign(new AddRecomAdmin());
            HideSubMenuPanels();
        }

        private void btnMainOrder_Click_1(object sender, EventArgs e)
        {
            showSubMenu(pnlMainOrder);
        }

        private void btnToBeFulfl_Click_1(object sender, EventArgs e)
        {
            openChildFormSign(new ADorderToFulfill());
            HideSubMenuPanels();
        }

        private void guna2GradientButton2_Click_1(object sender, EventArgs e)
        {
            openChildFormSign(new toFulfillOrder());
            HideSubMenuPanels();
        }

        private void btnAddAdmin_Click_1(object sender, EventArgs e)
        {
            openChildFormSign(new AddAdmin());
        }

        private void guna2GradientButton3_Click_1(object sender, EventArgs e)
        {
            productDL.storeMenuInFile();
            discountDL.storeDiscountInFile();
            openChildFormSign(new Save());
        }

        private void guna2GradientButton4_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnViewItem_Click(object sender, EventArgs e)
        {
            openChildFormSign(new AdminView());
            HideSubMenuPanels();
        }

        private void guna2ImageButton3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void guna2ImageButton2_Click(object sender, EventArgs e)
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

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
    }
}
