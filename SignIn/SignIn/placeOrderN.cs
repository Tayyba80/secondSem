using SignIn.BL;
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
    public partial class placeOrderN : Form
    {
        customerBL cust;
        public placeOrderN(customerBL cust)
        {
            InitializeComponent();
            this.cust = cust;
            if (cust.cart.Count != 0)
            {
                pnlLblM.Visible = false;
                customView();
            }
            else
            {
                gridVieMenu.Hide();
                label1.Visible = false;
                lblErrMain.Text = "Your Cart is Empty!Please Buy something First";
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
        private void customView()
        {

            gridVieMenu.DataSource = null;

            gridVieMenu.Columns.Add("nameOrderMain", "Main Product");
            gridVieMenu.Columns.Add("orderName", "Sub Product");
            gridVieMenu.Columns.Add("orderAmount", "Price");
            gridVieMenu.Columns.Add("orderPrc", "Amount");


            foreach (var i in cust.cart)
            {
                gridVieMenu.Rows.Add(i.NameOrderMain, i.OrderName, i.OrderPrc, i.OrderAmount);
            }

            gridVieMenu.Refresh();
        }
        private void btnAddInMenu_Click(object sender, EventArgs e)
        {
            cust.IsOrderPlaced = true;
            gridVieMenu.Hide();
            label1.Visible = false;
            btnAddInMenu.Visible = false;
            lblErrMain.Text = "Your Order has been Placed";
            pnlLblM.Visible = true;
        }
    }
}
