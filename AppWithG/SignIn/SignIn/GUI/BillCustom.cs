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

    public partial class BillCustom : Form
    {
        string custNameForFile;
        customerBL cust;
        int totalPrice = 0;
        public BillCustom(ref string custNameForFile, customerBL cust)
        {
            InitializeComponent();
            this.custNameForFile = custNameForFile;
            this.cust = cust;

            pnlLblM.Visible = false;
            customView();
            calc();
            label3.Visible = true;
            label3.Text = "YourBill Is:" + totalPrice;

        }
        protected override CreateParams CreateParams  // to stop flickring
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
                if (i is customOrder j)
                {
                    totalPrice = totalPrice + j.OrderAmount;
                }
            }
        }
        private void customView()
        {
            customerDL.billProcess(cust);


            customerDL.bill = customerDL.bill.OrderByDescending(j => j.OrderAmount).ToList();

            gridVieMenu.DataSource = null;

            gridVieMenu.Columns.Add("nameOrderMain", "Main Product");
            gridVieMenu.Columns.Add("orderName", "Sub Product");
            gridVieMenu.Columns.Add("orderPrc", "Price");
            gridVieMenu.Columns.Add("orderAmount", "Total Amount");
            gridVieMenu.Columns.Add("date", "Delivery Date");

            foreach (var i in customerDL.bill)
            {
                if (i is customOrder j)
                {
                    gridVieMenu.Rows.Add(j.NameOrderMain, j.OrderName, j.OrderPrc, j.OrderAmount, j.DeliveryDate);
                }
            }
            gridVieMenu.Refresh();
        }
        private void numprc_ValueChanged_1(object sender, EventArgs e)
        {
            pnlErrPrc.Visible = false;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            decimal cash = numprc.Value;
            int price2 = (int)cash;
            int change = 0;


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
                    btnAdd.Visible = false;
                    label3.Visible = false;
                    lblErrMain.Visible = false;
                    pictureBox1.Visible = true;
                    pbC.Visible = true;
                    productDL.removeStock(cust);
                    pnlLblM.Visible = true;
                    cust.IsOrderPlaced = false;

                }

            }
            productDL.storeMenuInFile();
            cartDL.storeCustomOrderInFile(ref custNameForFile, cust);
        }
    }
}
