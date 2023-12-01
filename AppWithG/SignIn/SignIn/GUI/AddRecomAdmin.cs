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
    public partial class AddRecomAdmin : Form
    {
        public AddRecomAdmin()
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
            if (rattingDL.ratting.Count == 0)
            {
                lblErrMain.ForeColor = Color.Brown;
                lblErrMain.Text = "Cat't Add Recommendation";
                pnlLblM.Visible = true;
                label1.ForeColor = Color.Brown;
                label1.Text = "Zero Reviews from the Customers";
                panel1.Visible = true;

            }
            else
            {
                rattingDL.ratting = rattingDL.ratting.OrderByDescending(i => i.Ratting).ToList();
                lblErrMain.ForeColor = Color.Brown;
                lblErrMain.Text = "Famous Product is '" + rattingDL.ratting[0].MainItem + "' whose Sub-Product '" + rattingDL.ratting[0].Name + "' is on highest ratting of '" + rattingDL.ratting[0].Ratting + "' Stars";
                pnlLblM.Visible = true;

            }
        }
    }
}
