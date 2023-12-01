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
    public partial class toBuyItems : Form
    {
        public toBuyItems()
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
            grdToBuy.DataSource = null;

            grdToBuy.Columns.Add("mainItem", "Main Product");
            grdToBuy.Columns.Add("pName", "Sub Product");


            foreach (var i in productDL.menuThngPrc)
            {

                foreach (var j in i.SubProduct)
                {
                    if (j.AmountCart <= j.TsStock1)
                    {
                        grdToBuy.Rows.Add(i.NameofMainItem, j.PName);
                    }
                }
            }


            grdToBuy.Refresh();
        }
    }
}
