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
    public partial class AdvanceOrderCust : Form
    {
        string custNameForFile;
        customerBL cust;
        public AdvanceOrderCust(ref string custNameForFile, customerBL cust)
        {
            InitializeComponent();
            addInDropDownOfComboBoxMain();
            this.custNameForFile = custNameForFile;
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
            panel1.Controls.Add(childFormSign);
            panel1.Tag = childFormSign;
            childFormSign.BringToFront();
            childFormSign.Show();
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

        private void comBoxM_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            addInDropDownOfComboBoxSub();
            if (pnlLblM.Visible == true) { pnlLblM.Visible = false; }
            if (pnlCommonErr.Visible == true)
                pnlCommonErr.Visible = false;
        }

        private void comboxsub_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (pnlErrSub.Visible == true)
                pnlErrSub.Visible = false;
            if (pnlCommonErr.Visible == true)
                pnlCommonErr.Visible = false;
        }

        private void numprc_ValueChanged_1(object sender, EventArgs e)
        {

            if (pnlErrPrc.Visible == true)
                pnlErrPrc.Visible = false;

            if (pnlCommonErr.Visible == true)
                pnlCommonErr.Visible = false;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            bool isItemPresent = false;
            int stockQ;
            string mainName = comBoxM.Text;
            string subName = comboxsub.Text;
            DateTime date = dateTimePicker1.Value;

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
                            foreach (var j in cust.cart)    //foreach
                            {
                                if (j is customOrder k)
                                {

                                    if (subName == k.OrderName) /// obj make
                                    {
                                        k.OrderAmount = k.OrderAmount + price2;
                                        isItemPresent = true;
                                        comboxsub.Text = null;
                                        comBoxM.Text = null;
                                        numprc.Value = 0;
                                        lblCommonErr.Text = "Order Added Successfully!";
                                        pnlCommonErr.Visible = true;
                                        comboxsub.Items.Clear();
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
                                customOrder cartVal = new customOrder(mainName, subName, cartPrc, price2, date);
                                cust.AddItem(cartVal);
                                comboxsub.Text = null;
                                comBoxM.Text = null;
                                numprc.Value = 0;
                                lblCommonErr.Text = "Order Added Successfully!";
                                pnlCommonErr.Visible = true;
                                comboxsub.Items.Clear();
                            }
                            openChildFormSign(new ConfirmCustomOrder(ref custNameForFile, cust));
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
        }
    }
}
