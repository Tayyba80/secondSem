using Microsoft.VisualBasic.Devices;
using SignIn.BL;
using SignIn.DL;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SignIn
{
    public partial class AdminAdd : Form
    {
        public AdminAdd()
        {
            InitializeComponent();
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

        private void txtMainItem_TextChanged(object sender, EventArgs e)
        {
            pnlErrMainName.Visible = false;
        }

        private void btnAddInMenu_Click(object sender, EventArgs e)
        {
            bool found, FoundSub;
            List<product> subMenuList = new List<product>();

            string mainName = txtMainItem.Text;

            string adminNewItems = validations.lowerCaseConvertor(mainName);// this funtion convert the added new item by the admin in lower case
            found = validations.itemAlreadyPresentInMenu(adminNewItems);/*this function check new item added by the admin 
                                                               is new or already present in the menu*/
            if (found == false)
            {
                string subName = txtSubName.Text;

                string subMenus = validations.lowerCaseConvertor(subName);// this funtion convert the added new item by the admin in lower case

                FoundSub = validations.itemAlreadyPresentInSubMenu(adminNewItems, subMenus);
                if (FoundSub == false)
                {
                    decimal price = numPrc.Value;
                    int price2 = (int)price;
                    decimal stock = numStk.Value;
                    int stock2 = (int)stock;
                    decimal thStock = numTsTk.Value;
                    int thStock2 = (int)thStock;
                    if (price > 0)
                    {
                        if (stock > 0)
                        {
                            if (thStock2 > 0)
                            {
                                product menu = new product(subMenus, price2, stock2, thStock2);
                                subMenuList.Add(menu);
                                productDL.addProductInList(adminNewItems, subMenuList);
                            }
                            else
                            {
                                lblErrTStk.Text = "Please enter TH-Stock";
                                pnlErrTstk.Visible = true;
                            }
                        }
                        else
                        {
                            lblErrStk.Text = "Please enter stock";
                            pnlErrStk.Visible = true;

                        }
                    }
                    else
                    {
                        lblErrPrc.Text = "Plese enter price";
                        panel6.Visible = true;
                    }

                }
                else
                {
                    lblErrSub.Text = "Item Already Present";
                    pnlLblS.Visible = true;
                }
            }
            else
            {
                foreach (var k in productDL.menuThngPrc)
                {
                    if (k.NameofMainItem == adminNewItems)
                    {
                        string subName = txtSubName.Text;
                        string subMenus = validations.lowerCaseConvertor(subName);// this funtion convert the added new item by the admin in lower case                       
                        FoundSub = validations.itemAlreadyPresentInSubMenu(adminNewItems, subMenus);
                        if (FoundSub == false)
                        {
                            decimal price = numPrc.Value;

                            int price2 = (int)price;
                            decimal stock = numStk.Value;
                            int stock2 = (int)stock;
                            decimal thStock = numTsTk.Value;
                            int thStock2 = (int)thStock;
                            if (price > 0)
                            {
                                if (stock > 0)
                                {
                                    if (thStock2 > 0)
                                    {
                                        product menu = new product(subMenus, price2, stock2, thStock2);
                                        k.SubProduct.Add(menu);
                                    }
                                    else
                                    {
                                        lblErrTStk.Text = "Please enter TH-Stock";
                                        pnlErrTstk.Visible = true;
                                    }
                                }
                                else
                                {
                                    lblErrStk.Text = "Please enter stock";
                                    pnlErrStk.Visible = true;

                                }
                            }
                            else
                            {
                                lblErrPrc.Text = "Plese enter price";
                                panel6.Visible = true;
                            }

                        }
                        else
                        {
                            lblErrSub.Text = "Item Already Present";
                            pnlLblS.Visible = true;
                        }
                    }
                }
            }
        }

        private void txtSubName_TextChanged(object sender, EventArgs e)
        {
            pnlLblS.Visible = false;
        }

        private void txtMainItem_KeyPress(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar;
            if (char.IsLetter(c))
            {
                e.Handled = false;
            }
            else if (c == 8)
            {
                e.Handled = false;
            }
            /* else if (c == 32)
             {
                 e.Handled = false;
             }*/
            else
            {
                e.Handled = true;
            }
        }

        private void txtSubName_KeyPress(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar;
            if (char.IsLetter(c))
            {
                e.Handled = false;
            }
            else if (c == 8)
            {
                e.Handled = false;
            }
            else if (c == 32)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void numPrc_ValueChanged(object sender, EventArgs e)
        {
            panel6.Visible = false;
        }

        private void numStk_ValueChanged(object sender, EventArgs e)
        {
            pnlErrStk.Visible = false;
        }

        private void numTsTk_ValueChanged(object sender, EventArgs e)
        {
            pnlErrTstk.Visible = false;
        }
    }
}
