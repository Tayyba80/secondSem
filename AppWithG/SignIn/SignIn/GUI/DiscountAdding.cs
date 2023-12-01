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
using System.Xml.Linq;

namespace SignIn
{
    public partial class DiscountAdding : Form
    {
        public DiscountAdding()
        {
            InitializeComponent();
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
            foreach (var i in productDL.menuThngPrc)
            {
                comBoxMAD.Items.Add(i.NameofMainItem);
            }

        }
        private void addInDropDownOfComboBoxSub()
        {
            string mainName = comBoxMAD.Text;
            if (mainName != null)
            {
                foreach (var i in productDL.menuThngPrc)
                {
                    if (i.NameofMainItem == mainName)
                    {
                        foreach (var j in i.SubProduct)
                        {
                            comboxsubAD.Items.Add(j.PName);
                        }
                    }
                }
            }
        }

        private void comBoxMAD_SelectedIndexChanged(object sender, EventArgs e)
        {
            pnlLblMAD.Visible = false;
            lblstk.Visible = false;
            addInDropDownOfComboBoxSub();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string mainName = comBoxMAD.Text;
            string subName = comboxsubAD.Text;
            if (mainName != null)
            {
                if (subName != null)
                {
                    decimal price = numpercAd.Value;
                    int price2 = (int)price;
                    if (price2 > 0)
                    {
                        if (price2 > 70)
                        {
                            lblErrPrcAD.Text = "Can't Add more than 70%";
                            pnlErrPrcAD.Visible = true;
                        }
                        else
                        {
                            productDL.AddDiscount(subName, price2, mainName);
                            discountBL discountCls = new discountBL(mainName, subName, price2);
                            discountDL.AddDiscountInDisList(discountCls);
                            comBoxMAD.Text = null;
                            comboxsubAD.Text = null;
                            numpercAd.Value = 0;
                            lblstk.Visible = true;
                            comboxsubAD.Items.Clear();
                        }
                    }
                    else
                    {
                        lblErrPrcAD.Text = "Please Enter Discount";
                        pnlErrPrcAD.Visible = true;
                    }
                }
                else
                {
                    lblErrSubAD.Text = "Please select the SubProduct";
                    pnlErrSubAD.Visible = true;
                }
            }
            else
            {
                lblErrMainAD.Text = "Please Select Main Product";
                pnlLblMAD.Visible = true;
            }
        }

        private void comboxsubAD_SelectedIndexChanged(object sender, EventArgs e)
        {
            pnlErrSubAD.Visible = false;
        }

        private void numpercAd_ValueChanged(object sender, EventArgs e)
        {
            pnlErrPrcAD.Visible = false;
        }
    }
}
