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
    public partial class AdminView : Form
    {
        public AdminView()
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
            gridVieMenu.DataSource = null;

            gridVieMenu.Columns.Add("nameofMainItem", "Main Product");
            gridVieMenu.Columns.Add("pName", "Sub Product");
            gridVieMenu.Columns.Add("idxCart", "Price");
            gridVieMenu.Columns.Add("amountCart", "Stock");
            gridVieMenu.Columns.Add("TsStock", "Threshold Stock");

            foreach (var i in productDL.menuThngPrc)
            {
                gridVieMenu.Rows.Add(i.NameofMainItem);
                foreach (var j in i.SubProduct)
                {
                    gridVieMenu.Rows.Add(" ", j.PName, j.IdxCart, j.AmountCart, j.TsStock1);
                }
            }

            gridVieMenu.Refresh();
        }


    }
}
