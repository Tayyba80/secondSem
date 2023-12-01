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
    public partial class nrmlStkUpdate : Form
    {
        public nrmlStkUpdate()
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
                comBoxMStk.Items.Add(i.NameofMainItem);
            }

        }
        private void addInDropDownOfComboBoxSub()
        {
            string mainName = comBoxMStk.Text;
            if (mainName != null)
            {
                foreach (var i in productDL.menuThngPrc)
                {
                    if (i.NameofMainItem == mainName)
                    {
                        foreach (var j in i.SubProduct)
                        {
                            comboxsubStk.Items.Add(j.PName);
                        }
                    }
                }
            }
        }
        private void comBoxMStk_SelectedIndexChanged(object sender, EventArgs e)
        {
            addInDropDownOfComboBoxSub();
        }

        private void btnUpdateStk_Click(object sender, EventArgs e)
        {
            string mainName = comBoxMStk.Text;
            string subName = comboxsubStk.Text;
            if (mainName != null)
            {
                if (subName != null)
                {
                    decimal price = numprcStk.Value;
                    int price2 = (int)price;
                    if (price2 > 0)
                    {
                        productDL.updateStock(mainName, subName, price2);
                        comBoxMStk.Text = null;
                        comboxsubStk.Text = null;
                        numprcStk.Value = 0;
                    }
                    else
                    {
                        lblErrPrcS.Text = "Please Enter the Stock";
                        pnlErrPrcS.Visible = true;
                    }
                }
                else
                {
                    lblErrSubS.Text = "Please select the SubProduct";
                    pnlErrSubS.Visible = true;
                }
            }
            else
            {
                lblErrMainS.Text = "Please Select Main Product";
                pnlLblMS.Visible = true;
            }
        }

    }
}
