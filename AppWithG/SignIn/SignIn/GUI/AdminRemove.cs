using Guna.UI2.WinForms;
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


        private void comboBoxMain_SelectedIndexChanged(object sender, EventArgs e)
        {
            //comboBoxSub = null; // chepi
            pnlLblM.Visible = false;
            lblRem.Visible = true;
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

        private void btnAdd_Click(object sender, EventArgs e)
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
                    lblRem.Visible = true;
                    comboBoxSub.Items.Clear();
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

        private void comboBoxSub_SelectedIndexChanged(object sender, EventArgs e)
        {
            pnlErrSub.Visible = false;
        }
    }
}

