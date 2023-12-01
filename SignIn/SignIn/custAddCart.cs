using SignIn.BL;
using SignIn.DL;
using System;
using System.Collections;
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
    public partial class custAddCart : Form
    {
        public custAddCart(ref string custNameForFile, customerBL cust)
        {
            InitializeComponent();
            addInDropDownOfComboBoxMain();
            this.custNameForFile = custNameForFile;
            this.cust = cust;
        }
        string custNameForFile;
        customerBL cust;
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000;
                return cp;
            }
        }

        private void comBoxM_SelectedIndexChanged(object sender, EventArgs e)
        {
            addInDropDownOfComboBoxSub();
            if (pnlLblM.Visible == true) { pnlLblM.Visible = false; }
            if (pnlCommonErr.Visible == true)
                pnlCommonErr.Visible = false;
        }
        private void addInDropDownOfComboBoxMain()
        {
            foreach (var i in productDL.menuThngPrc)
            {
                comBoxM.Items.Add(i.NameofMainItem);
            }

        }
        private void addInDropDownOfComboBoxSub()
        {
            string mainName = comBoxM.Text;
            if (mainName != null)
            {
                foreach (var i in productDL.menuThngPrc)
                {
                    if (i.NameofMainItem == mainName)
                    {
                        foreach (var j in i.SubProduct)
                        {
                            comboxsub.Items.Add(j.PName);
                        }
                    }
                }
            }
        }

        private void comboxsub_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (pnlErrSub.Visible == true)
                pnlErrSub.Visible = false;
            if (pnlCommonErr.Visible == true)
                pnlCommonErr.Visible = false;
        }

        private void numprc_ValueChanged(object sender, EventArgs e)
        {
            if (pnlErrPrc.Visible == true)
                pnlErrPrc.Visible = false;

            if (pnlCommonErr.Visible == true)
                pnlCommonErr.Visible = false;
        }

        private void btnAddInMenu_Click(object sender, EventArgs e)
        {
            bool isItemPresent = false;
            int stockQ;
            string mainName = comBoxM.Text;
            string subName = comboxsub.Text;
            if (mainName != null)
            {
                if (subName != null && subName != "")
                {
                    decimal price = numprc.Value;
                    int price2 = (int)price;
                    stockQ = productDL.findSubProStock(mainName, subName);
                    if (price2 > 0)
                    {

                        if (price2 <= stockQ)
                        {
                            for (int j = 0; j < cust.cart.Count; j++)
                            {
                                if (cust.cart.Count != 0)
                                {

                                    if (subName == cust.cart[j].OrderName) /// obj make
                                    {
                                        cust.cart[j].OrderAmount = cust.cart[j].OrderAmount + price2;
                                        cartDL.storeNormalCustomerOrderInFile(ref custNameForFile, cust);// store cust orders in file
                                                                                                         //  adminDL.menuThngPrc[tempa - 1].AmountCart = adminDL.menuThngPrc[tempa - 1].AmountCart - numberOfbuyingItema;
                                        isItemPresent = true;
                                        break;
                                    }
                                    else
                                    {
                                        isItemPresent = false;
                                    }
                                }
                            }
                            if (!isItemPresent)
                            {

                                int cartPrc = productDL.findPrcOfSubPro(mainName, subName);

                                order cartVal = new order(mainName, subName, cartPrc, price2);
                                cust.AddItem(cartVal);
                                cartDL.storeNormalCustomerOrderInFile(ref custNameForFile, cust);
                            }
                        }
                        else
                        {
                            lblCommonErr.Text = "Sorry!This item is out of Stock";
                            pnlCommonErr.Visible = true;

                        }
                    }
                    else
                    {
                        lblErrPrc.Text = "Please Enter the Amount";
                        pnlErrPrc.Visible = true;
                    }

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
            cartDL.storeRemainingNormalCustOrderInFile();
        }
    }
}
