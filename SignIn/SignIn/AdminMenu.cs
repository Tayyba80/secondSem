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
    public partial class AdminMenu : Form
    {
        customerBL cust;
        public AdminMenu(customerBL cust)
        {
            InitializeComponent();
            subMenuPanelDesign();
            this.cust = cust;
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
            pnlSubAdmin.Controls.Add(childFormSign);
            pnlSubAdmin.Tag = childFormSign;
            childFormSign.BringToFront();
            childFormSign.Show();
        }

        private void AdminMenu_Load(object sender, EventArgs e)
        {

        }
        private void subMenuPanelDesign()
        {
            pnlMenu.Visible = false;
            pnlDisc.Visible = false;
            pnlFdBck.Visible = false;
            pnlOrder.Visible = false;
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
            openChildFormSign(new AdminView());
            HideSubMenuPanels();


        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            // my code
            openChildFormSign(new AdminAdd());
            HideSubMenuPanels();
        }

        private void btnUpdatePrc_Click(object sender, EventArgs e)
        {
            // my code
            openChildFormSign(new UpdatePrice());
            HideSubMenuPanels();
        }

        private void btnUpdateStk_Click(object sender, EventArgs e)
        {
            // my code
            openChildFormSign(new UpdateStock());
            HideSubMenuPanels();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            // my code
            openChildFormSign(new AdminRemove());
            HideSubMenuPanels();
        }

        private void btnToOrder_Click(object sender, EventArgs e)
        {
            // my code
            openChildFormSign(new toBuyItems());
            HideSubMenuPanels();
        }

        private void btnDisc_Click(object sender, EventArgs e)
        {
            showSubMenu(pnlDisc);
        }

        private void btnDiscAdd_Click(object sender, EventArgs e)
        {
            // my code
            openChildFormSign(new DiscountAdding());
            HideSubMenuPanels();
        }

        private void btnDiscRem_Click(object sender, EventArgs e)
        {
            // my code
            openChildFormSign(new discRemove());
            HideSubMenuPanels();
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            showSubMenu(pnlOrder);
        }

        private void btnViwOrdr_Click(object sender, EventArgs e)
        {
            // my code
            openChildFormSign(new ADorderToFulfill());
            HideSubMenuPanels();
        }

        private void btnFlfilOrdr_Click(object sender, EventArgs e)
        {
            // my code
            openChildFormSign(new completeOrderAdmin());
            HideSubMenuPanels();
        }

        private void btnfeedBack_Click(object sender, EventArgs e)
        {
            showSubMenu(pnlFdBck);
        }

        private void btnfedBck_Click(object sender, EventArgs e)
        {
            // my code
            openChildFormSign(new SeeRattingAdmin());
            HideSubMenuPanels();
        }

        private void btnRecom_Click(object sender, EventArgs e)
        {
            // my code
            openChildFormSign(new AddRecomAdmin());
            HideSubMenuPanels();
        }

        private void btnAdAdmin_Click(object sender, EventArgs e)
        {
            openChildFormSign(new AddAdmin());
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            productDL.storeMenuInFile();
            discountDL.storeDiscountInFile();
            openChildFormSign(new Save());
        }
    }
}
