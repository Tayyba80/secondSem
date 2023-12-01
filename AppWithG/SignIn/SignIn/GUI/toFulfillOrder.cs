using SignIn.BL;
using SignIn.DL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SignIn
{
    public partial class toFulfillOrder : Form
    {
        public toFulfillOrder()
        {
            InitializeComponent();
            customView();
        }
        int index;
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
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000;
                return cp;
            }
        }

        private void gridVieMenu_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            index = gridVieMenu.SelectedRows[0].Index;
            DateTime dateTime = cartDL.findCustomOrderDilivDate(index);
            gridVieMenu.Hide();

            if (dateTime == DateTime.Today.Date)  ////// remaining
            {
                label3.Visible = true;
                cartDL.removeOrderfromCustomOrder(index);
            }
            else if (dateTime.Date > DateTime.Today.Date)
            {
                openChildFormSign(new Tofulfill2CheckBox(ref index, ref dateTime));
            }
            else if (dateTime < DateTime.Today.Date)
            {
                label3.Text = "Can't filfill this order,Its delivery date has passed";
                label3.Visible = true;
                cartDL.removeOrderfromCustomOrder(index);
            }
            cartDL.storeCustomOrderInFileFromCustomList();
            cartDL.storeCustomOrderInFile();
        }
    }
}