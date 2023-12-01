using SignIn.BL;
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
    public partial class rattingCust : Form
    {
        public rattingCust()
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
        int ratting;

        private void addInDropDownOfComboBoxMain()
        {
            foreach (var i in productDL.menuThngPrc)
            {
                comboBox1.Items.Add(i.NameofMainItem);
            }

        }
        private void addInDropDownOfComboBoxSub()
        {
            string mainName = comboBox1.Text;
            if (mainName != null)
            {
                foreach (var i in productDL.menuThngPrc)
                {
                    if (i.NameofMainItem == mainName)
                    {
                        foreach (var j in i.SubProduct)
                        {
                            comboxsub.Items.Add(j.PName);
                        }
                    }
                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.yellowStarrat;
            pictureBox5.Image = Properties.Resources.blackstar;
            pictureBox2.Image = Properties.Resources.blackstar;
            pictureBox3.Image = Properties.Resources.blackstar;
            pictureBox4.Image = Properties.Resources.blackstar;
            ratting = 1;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.yellowStarrat;
            pictureBox2.Image = Properties.Resources.yellowStarrat;
            pictureBox3.Image = Properties.Resources.blackstar;
            pictureBox4.Image = Properties.Resources.blackstar;
            pictureBox5.Image = Properties.Resources.blackstar;
            ratting = 2;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.yellowStarrat;
            pictureBox2.Image = Properties.Resources.yellowStarrat;
            pictureBox3.Image = Properties.Resources.yellowStarrat;
            pictureBox4.Image = Properties.Resources.blackstar;
            pictureBox5.Image = Properties.Resources.blackstar;
            ratting = 3;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.yellowStarrat;
            pictureBox2.Image = Properties.Resources.yellowStarrat;
            pictureBox3.Image = Properties.Resources.yellowStarrat;
            pictureBox4.Image = Properties.Resources.yellowStarrat;
            pictureBox5.Image = Properties.Resources.blackstar;
            ratting = 4;
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.yellowStarrat;
            pictureBox2.Image = Properties.Resources.yellowStarrat;
            pictureBox3.Image = Properties.Resources.yellowStarrat;
            pictureBox4.Image = Properties.Resources.yellowStarrat;
            pictureBox5.Image = Properties.Resources.yellowStarrat;

            ratting = 5;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            addInDropDownOfComboBoxSub();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            int rattingAvg;
            bool isItemPresent = false;
            bool isRatting = false;
            string mainName = comboBox1.Text;
            string subName = comboxsub.Text;
            if (mainName != null)
            {
                if (subName != null && subName != "")
                {
                    if (ratting > 0)
                    {
                        for (int j = 0; j < rattingDL.ratting.Count; j++)
                        {
                            if (rattingDL.ratting.Count != 0)
                            {
                                if (subName == rattingDL.ratting[j].Name)
                                {

                                    rattingAvg = rattingDL.ratting[j].Ratting + ratting;
                                    rattingDL.ratting[j].Ratting = rattingAvg / 2;
                                    rattingDL.storeRattingInFile();
                                    isItemPresent = true;
                                    isRatting = true;
                                    comboBox1.Text = null;
                                    comboxsub.Text = null;
                                    lblCe.Text = "Thanks for your Remarks";
                                    pnlCE.Visible = true;
                                    comboxsub.Items.Clear();
                                    break;
                                }
                                else
                                {
                                    isItemPresent = false;
                                }
                            }
                        }
                        if (!isItemPresent)
                        {
                            rattingBL obj1 = new rattingBL(mainName, subName, ratting);
                            rattingDL.addRating(obj1);
                            comboBox1.Text = null;
                            comboxsub.Text = null;
                            // function
                            lblCe.Text = "Thanks for your Remarks";
                            pnlCE.Visible = true;
                            isRatting = true;
                            comboxsub.Items.Clear();
                            rattingDL.storeRattingInFile();
                        }

                    }
                    else
                    {
                        lblCe.Text = "Please Enter Ratting";
                        pnlCE.Visible = true;
                    }
                }
                else
                {
                    lblErrSub.Text = "Please select the SubProduct";
                    pnlErrSub.Visible = true;
                }
            }
            else
            {
                lblEm.Text = "Please Select Main Product";
                pnlMB.Visible = true;
            }
        }
    }
}
