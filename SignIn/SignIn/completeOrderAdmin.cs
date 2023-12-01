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
    public partial class completeOrderAdmin : Form
    {
        public completeOrderAdmin()
        {
            InitializeComponent();
            customView();
        }
        private void customView()
        {
            gridVieMenu.DataSource = null;

            gridVieMenu.Columns.Add("custNameOrder", "User Name");
            gridVieMenu.Columns.Add("nameOrderMain", "Main Product");
            gridVieMenu.Columns.Add("orderName", "Sub Product");
            gridVieMenu.Columns.Add("orderPrc", "Price");
            gridVieMenu.Columns.Add("orderAmount", "Amount");
            gridVieMenu.Columns.Add("deliveryDate", "Dilivery Time");


            foreach (var i in cartDL.customOrderList)
            {
                if (i is customOrder j)
                    gridVieMenu.Rows.Add(j.CustNameOrder, j.NameOrderMain, j.OrderName, j.OrderPrc, j.OrderAmount, j.DeliveryDate);
            }
            gridVieMenu.Refresh();
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

        private void gridVieMenu_RowHeaderMouseClick_1(object sender, DataGridViewCellMouseEventArgs e)
        {
            int index = gridVieMenu.SelectedRows[0].Index;
            DateTime dateTime = cartDL.findCustomOrderDilivDate(index);

            if (dateTime == DateTime.Today.Date)  ////// remaining
            {
                lblErrMain.Text = "Order has been fulfilled";
                pnlLblM.Visible = true;
                cartDL.removeOrderfromCustomOrder(index);
            }
            else if (dateTime.Date > DateTime.Today.Date)
            {
                lblErrMain.Text = "The date given by the customer is" + dateTime;
                pnlLblM.Visible = true;
                label1.Text = "Do you really want to fulfill Order Today?";
                panel1.Visible = true;
                checkBoxY.Visible = true;
                checkBoxN.Visible = true;
                if (checkBoxY.Checked)
                {
                    lblErrMain.Text = "Order has been fulfilled";
                    pnlLblM.Visible = true;
                    panel1.Visible = false;
                    checkBoxY.Visible = false;
                    checkBoxN.Visible = false;
                    cartDL.removeOrderfromCustomOrder(index);
                }
                else if (checkBoxN.Checked)
                {
                    lblErrMain.Text = "You have cancled the fulfillment of this order";
                    pnlLblM.Visible = true;
                    panel1.Visible = false;
                    checkBoxY.Visible = false;
                    checkBoxN.Visible = false;
                }
                else if (dateTime < DateTime.Today.Date)
                {
                    lblErrMain.Text = "Can't Fulfill This Order";
                    pnlLblM.Visible = true;
                    label1.Text = "The delivery Date for this Order has Passed";
                    panel1.Visible = true;
                    cartDL.removeOrderfromCustomOrder(index);
                }
            }
            cartDL.storeCustomOrderInFileFromCustomList();
            cartDL.storeCustomOrderInFile();
        }
    }
}
