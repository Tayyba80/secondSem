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
    public partial class thStkUpdate : Form
    {
        public thStkUpdate()
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
                comBoxMTStk.Items.Add(i.NameofMainItem);
            }

        }
        private void addInDropDownOfComboBoxSub()
        {
            string mainName = comBoxMTStk.Text;
            if (mainName != null)
            {
                foreach (var i in productDL.menuThngPrc)
                {
                    if (i.NameofMainItem == mainName)
                    {
                        foreach (var j in i.SubProduct)
                        {
                            comboxsubTStk.Items.Add(j.PName);
                        }
                    }
                }
            }
        }

        private void comBoxMTStk_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblstk.Visible = false;
            pnlLblMTS.Visible = false;
            addInDropDownOfComboBoxSub();
        }
        private void btnUpdAte_Click(object sender, EventArgs e)
        {
            string mainName = comBoxMTStk.Text;
            string subName = comboxsubTStk.Text;
            if (mainName != null)
            {
                if (subName != null)
                {
                    decimal price = numprcTStk.Value;
                    int price2 = (int)price;
                    if (price2 > 0)
                    {
                        productDL.updateThresholdStock(mainName, subName, price2);
                        comBoxMTStk.Text = null;
                        comboxsubTStk.Text = null;
                        numprcTStk.Value = 0;
                        lblstk.Visible = true;
                        comboxsubTStk.Items.Clear();
                    }
                    else
                    {
                        lblErrPrcTS.Text = "Please Enter Th_Stock";
                        pnlErrPrcTS.Visible = true;
                    }
                }
                else
                {
                    lblErrSubTS.Text = "Please select the SubProduct";
                    pnlErrSubTS.Visible = true;
                }
            }
            else
            {
                lblErrMainTS.Text = "Please Select Main Product";
                pnlLblMTS.Visible = true;
            }
        }

        private void comboxsubTStk_SelectedIndexChanged(object sender, EventArgs e)
        {
            pnlErrSubTS.Visible = false;
        }

        private void numprcTStk_ValueChanged(object sender, EventArgs e)
        {
            pnlErrPrcTS.Visible = false;
        }
    }
}
