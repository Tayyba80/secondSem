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
using System.Xml.Linq;

namespace SignIn
{
    public partial class PrcUpRmvDisc : Form
    {
        public PrcUpRmvDisc(string main, string sub)
        {
            InitializeComponent();
            this.subName = sub;
            this.mainName = main;
        }
        string mainName;
        string subName;
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000;
                return cp;
            }
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            decimal price = numPrcUp.Value;
            int price2 = (int)price;
            discountDL.removeDiscount(mainName, subName);
            discountDL.UpdatePriceAftrRemovingDiscount(mainName, subName, price2);
            numPrcUp.Value = 0;
            lblstk.Visible = true;
        }
    }
}
