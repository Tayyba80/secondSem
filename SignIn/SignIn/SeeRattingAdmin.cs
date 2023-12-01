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
    public partial class SeeRattingAdmin : Form
    {
        public SeeRattingAdmin()
        {
            InitializeComponent();
            customeView();
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
        private void customeView()
        {
            if (rattingDL.ratting.Count == 0)
            {
                lblErrMain.Text = "No FeedBacks Added!";
                pnlLblM.Visible = false;
            }
            else
            {
                gridVieMenu.DataSource = null;

                gridVieMenu.Columns.Add("mainItem", "Main Product");
                gridVieMenu.Columns.Add("name", "Sub Product");
                gridVieMenu.Columns.Add("ratting", "Price");
                foreach (var i in rattingDL.ratting)
                {
                    gridVieMenu.Rows.Add(i.MainItem,i.Name,i.Ratting);
                }
                gridVieMenu.Refresh();

            }
        }
    }
}
