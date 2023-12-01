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
    public partial class discRemove : Form
    {
        public discRemove()
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
        private Form activeForm = null;

        private void openChildFormSign(Form childFormSign)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            activeForm = childFormSign;
            childFormSign.TopLevel = false;
            childFormSign.FormBorderStyle = FormBorderStyle.None;
            childFormSign.Dock = DockStyle.Fill;
            panel1.Controls.Add(childFormSign);
            panel1.Tag = childFormSign;
            childFormSign.BringToFront();
            childFormSign.Show();
        }
        private void addInDropDownOfComboBoxMain()
        {
            foreach (var i in discountDL.discountList)
            {
                comboBoxMainRD.Items.Add(i.MainItem);
            }

        }
        private void addInDropDownOfComboBoxSub()
        {
            string mainName = comboBoxMainRD.Text;
            if (mainName != null)
            {
                foreach (var i in discountDL.discountList)
                {
                    if (i.MainItem == mainName)
                    {
                        comboBoxSubRD.Items.Add(i.DiscN);
                    }
                }
            }
        }
        private void comboBoxMainRD_SelectedIndexChanged(object sender, EventArgs e)
        {
            addInDropDownOfComboBoxSub();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string mainName = comboBoxMainRD.Text;

            string subName = comboBoxSubRD.Text;
            if (mainName != null)
            {
                if (subName != null)
                {
                    comboBoxMainRD.Text = null;
                    comboBoxSubRD.Text = null;
                    openChildFormSign(new PrcUpRmvDisc(mainName, subName));
                    comboBoxSubRD.Items.Clear();
                }
                else
                {
                    lblErrSubRD.Text = "Please select the SubProduct";
                    pnlErrSubRD.Visible = true;
                }
            }
            else
            {
                lblErrMainRD.Text = "Please Select Main Product";
                pnlErrSubRD.Visible = true;
            }
        }
    }
}
