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
    public partial class CustViewMenu : Form
    {
        public CustViewMenu()
        {
            InitializeComponent();
            customDataBind();
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
        private void customDataBind()
        {
            // custom bind
            gridViewMenuC.DataSource = null;

            gridViewMenuC.Columns.Add("nameofMainItem", "Main Product");
            gridViewMenuC.Columns.Add("pName", "Sub Product");
            gridViewMenuC.Columns.Add("idxCart", "Price");
            gridViewMenuC.Columns.Add("amountCart", "Stock");
            gridViewMenuC.Columns.Add("TsStock", "Threshold Stock");

            foreach (var i in productDL.menuThngPrc)
            {
                gridViewMenuC.Rows.Add(i.NameofMainItem);
                foreach (var j in i.SubProduct)
                {
                    gridViewMenuC.Rows.Add(" ", j.PName, j.IdxCart, j.AmountCart, j.TsStock1);
                }
            }

            gridViewMenuC.Refresh();
        }
    }
}
