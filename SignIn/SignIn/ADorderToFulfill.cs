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
    public partial class ADorderToFulfill : Form
    {
        public ADorderToFulfill()
        {
            InitializeComponent();
            customView();
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
    }
}
