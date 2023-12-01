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
    public partial class Tofulfill2CheckBox : Form
    {
        int index;
        DateTime datetime;
        public Tofulfill2CheckBox(ref int index, ref DateTime dateTime)
        {
            InitializeComponent();
            this.index = index;
            this.datetime = dateTime;
        }

        private void checkBoxY_CheckedChanged(object sender, EventArgs e)
        {
            panel2.Visible = false;
            checkBoxN.Visible = false;
            checkBoxY.Visible = false;
            lblErrMain.Text = "Order has been fulfilled successfully";
            cartDL.removeOrderfromCustomOrder(index);
            cartDL.storeCustomOrderInFileFromCustomList();
            cartDL.storeCustomOrderInFile();
        }

        private void checkBoxN_CheckedChanged(object sender, EventArgs e)
        {
            panel2.Visible = false;
            checkBoxN.Visible = false;
            checkBoxY.Visible = false;
            lblErrMain.Text = "You cancled the fulfillment of this order";
            cartDL.storeCustomOrderInFileFromCustomList();
            cartDL.storeCustomOrderInFile();
        }

        private void Tofulfill2CheckBox_Load(object sender, EventArgs e)
        {
            lblErrMain.Text = "Delivery date and time of this order is" + " " + datetime.Date;
            label3.Text = "Do you really want to fulfill this order right now?";
        }
    }
}
