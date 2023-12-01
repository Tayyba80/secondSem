using SignIn.BL;
using SignIn.DL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SignIn
{
    public partial class custbillNor : Form
    {
        customerBL cust;
        int totalPrice;
        public custbillNor(customerBL cust)
        {
            InitializeComponent();
            this.cust = cust;
            if (cust.IsOrderPlaced == true)
            {
                pnlLblM.Visible = false;
                customView();
                calc();
                label3.Visible = true;
                label3.Text = "YourBill Is:" + totalPrice;
            }
            else
            {
                gridVieMenu.Hide();
                label1.Visible = false;
                label2.Visible = false;
                panel5.Visible = false;
                btnAddInMenu.Visible = false;
                lblErrMain.Text = "Please place your order First";
                pnlLblM.Visible = true;
            }
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
        private void calc()
        {
            foreach (var i in customerDL.bill)
            {
                totalPrice = totalPrice + i.OrderAmount;
            }
        }
        private void customView()
        {
            customerDL.billProcess(cust);

            foreach (var i in customerDL.bill)
            {
                customerDL.bill = customerDL.bill.OrderByDescending(j => i.OrderAmount).ToList();
            }
            gridVieMenu.DataSource = null;

            gridVieMenu.Columns.Add("nameOrderMain", "Main Product");
            gridVieMenu.Columns.Add("orderName", "Sub Product");
            gridVieMenu.Columns.Add("orderPrc", "Price");
            gridVieMenu.Columns.Add("orderAmount", "Total Amount");

            foreach (var i in customerDL.bill)
            {
                gridVieMenu.Rows.Add(i.NameOrderMain, i.OrderName, i.OrderPrc, i.OrderAmount);
            }
            gridVieMenu.Refresh();
        }
        private void btnAddInMenu_Click(object sender, EventArgs e)
        {

            decimal cash = numprc.Value;
            int price2 = (int)cash;
            int change = 0;

            if (cust.IsOrderPlaced == true)
            {

                if (totalPrice < 1)
                {
                    gridVieMenu.Hide();
                    label1.Visible = false;
                    lblErrMain.Text = "Please place your order First";
                    pnlLblM.Visible = true;
                }
                else
                {
                    if (totalPrice > price2)
                    {
                        lblErrPrc.Text = "Enter more Cash";
                        pnlErrPrc.Visible = true;
                    }
                    else if (totalPrice < price2)
                    {
                        change = price2 - totalPrice;
                        lblErrPrc.ForeColor = Color.SaddleBrown;
                        lblErrPrc.Text = "Your Change:" + change.ToString();
                        productDL.removeStock(cust);
                        pnlErrPrc.Visible = true;
                        cust.IsOrderPlaced = false;
                    }
                    else if (totalPrice == price2)
                    {
                        gridVieMenu.Hide();
                        label1.Visible = false;
                        pnlErrPrc.Visible = false;
                        label2.Visible = false;
                        panel5.Visible = false;
                        btnAddInMenu.Visible = false;
                        label3.Visible = false;
                        lblErrMain.ForeColor = Color.SaddleBrown;

                        lblErrMain.Text = "Thank you for Choosing this bakery";
                        productDL.removeStock(cust);
                        pnlLblM.Visible = true;
                        cust.IsOrderPlaced = false;

                    }

                }
            }
            productDL.storeMenuInFile();
            cartDL.storeNormalCustomerOrderInFile();
            cartDL.storeRemainingNormalCustOrderInFile();

        }

        private void numprc_ValueChanged(object sender, EventArgs e)
        {
            pnlErrPrc.Visible = false;
        }

        private void gridVieMenu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
