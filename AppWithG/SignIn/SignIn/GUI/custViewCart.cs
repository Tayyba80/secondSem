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
    public partial class custViewCart : Form
    {
        string custNameForFile;
        customerBL cust;
        public custViewCart(ref string custNameForFile, customerBL cust)
        {
            InitializeComponent();
            this.custNameForFile = custNameForFile; this.cust = cust;
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
    }
}
