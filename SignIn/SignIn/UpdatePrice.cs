using SignIn.DL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SignIn
{
    public partial class UpdatePrice : Form
    {
        public UpdatePrice()
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

        private void comBoxM_SelectedIndexChanged(object sender, EventArgs e)
        {
            addInDropDownOfComboBoxSub();
            if (pnlLblM.Visible == true) { pnlLblM.Visible = false; }
        }

        private void btnAddInMenu_Click(object sender, EventArgs e)
        {
            string mainName = comBoxM.Text;
            string subName = comboxsub.Text;
            if (mainName != null)
            {
                if (subName != null && subName != "")
                {
                    decimal price = numprc.Value;
                    int price2 = (int)price;
                    if (price2 > 0)
                    {
                        productDL.updatePrc(mainName, subName, price2);
                        comBoxM.Text = null;
                        comboxsub.Text = null;
                        numprc.Value = 0;
                    }
                    else
                    {
                        lblErrPrc.Text = "Please Enter price";
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
        }

        private void numprc_ValueChanged(object sender, EventArgs e)
        {
            if (pnlErrPrc.Visible == true)
                pnlErrPrc.Visible = false;
        }

        private void comboxsub_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (pnlErrSub.Visible == true)
                pnlErrSub.Visible = false;
        }
    }

}
