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
    public partial class discShow : Form
    {
        public discShow()
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
            if (discountDL.discountList.Count == 0)
            {

                label2.Text = "No Discount Available";
                panel2.Visible = true;
                pictureBox1.Visible = true;
            }
            else
            {
                gridVieMenu.DataSource = null;

                gridVieMenu.Columns.Add("mainItem", "Main Product");
                gridVieMenu.Columns.Add("discN", "Sub Product");
                gridVieMenu.Columns.Add("discPercent", "Percentage");

                foreach (var i in discountDL.discountList)
                {
                    gridVieMenu.Rows.Add(i.MainItem, i.DiscN, i.DiscPercent);
                }

                gridVieMenu.Refresh();
            }
        }
    }
}
