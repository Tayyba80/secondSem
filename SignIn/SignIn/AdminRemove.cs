using Microsoft.VisualBasic.ApplicationServices;
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
    public partial class AdminRemove : Form
    {
        public AdminRemove()
        {
            InitializeComponent();
            addInDropDownOfComboBoxMain();

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
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void grdShowMenu_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            string mainName = comboBoxMain.Text;

            string subName = comboBoxSub.Text;
            if (mainName != null)
            {
                if (subName != null)
                {
                    productDL.removeSubItem(mainName, subName);
                    comboBoxMain.Text = null;
                    comboBoxSub.Text = null;
                }
                else
                {
                    lblErrSub.Text = "Please select the SubProduct";
                    pnlErrSub.Visible = true;
                }
            }
            else
            {
                lblErrMain.Text = "Please Select Main Product";
                pnlLblM.Visible = true;
            }
        }

        private void txtSubName_TextChanged(object sender, EventArgs e)
        {
            pnlErrSub.Visible = false;
        }

        private void txtMainName_TextChanged(object sender, EventArgs e)
        {
            pnlLblM.Visible = false;
        }

        private void comboBoxMain_SelectedIndexChanged(object sender, EventArgs e)
        {
            //comboBoxSub = null; // chepi
            addInDropDownOfComboBoxSub();
        }
        private void addInDropDownOfComboBoxMain()
        {
            foreach (var i in productDL.menuThngPrc)
            {
                comboBoxMain.Items.Add(i.NameofMainItem);
            }

        }
        private void addInDropDownOfComboBoxSub()
        {
            string mainName = comboBoxMain.Text;
            if (mainName != null)
            {
                foreach (var i in productDL.menuThngPrc)
                {
                    if (i.NameofMainItem == mainName)
                    {
                        foreach (var j in i.SubProduct)
                        {
                            comboBoxSub.Items.Add(j.PName);
                        }
                    }
                }
            }
        }
    }
}

