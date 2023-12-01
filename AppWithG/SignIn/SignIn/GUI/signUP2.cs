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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace SignIn
{
    public partial class signUP2 : Form
    {
        public signUP2()
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
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            bool isValid;  // It checks the validation on Password (must have length 8)
            bool isFound;  // It check whether the customer username is unique or not
            bool commaFound; // It check valodation on comma (comma is not allowed)

            string custEnterName = txtuserName.Text;
            string custEnterPas = txtpassword.Text;
            string confrmPass = txtConfirm.Text;

            int custNameLength = custEnterName.Length;
            int lengthCustPas = custEnterPas.Length;

            isValid = validations.validPasword(lengthCustPas);
            commaFound = validations.ckeckComma(custEnterName, custEnterPas);
            bool isUper = validations.isUperCase(custEnterName, custNameLength);
            bool isNumeric = validations.isNumeric(custEnterName, custNameLength);
            bool isUperP = validations.isUperCase(custEnterPas, lengthCustPas);
            isFound = validations.uniqueUser(custEnterName);

            if (commaFound == true)
            {
                if (isFound == true)
                {
                    if (custEnterPas == confrmPass)
                    {
                        if (isNumeric == true)
                        {
                            if (isUper == true)
                            {
                                if (isValid == true)
                                {
                                    if (isUperP == true)
                                    {
                                        sign readData = new sign(custEnterName, custEnterPas, "2");
                                        signDL.addUserInList(readData);
                                        signDL.storeAdminAndUserInFile(custEnterName, custEnterPas, "2");

                                    }
                                    else
                                    {
                                        lblErrPassUp.Text = "Password Must Contain 1 UpperCase Letter";
                                        pnlErrPasUp.Visible = true;

                                    }

                                }
                                else
                                {
                                    lblErrPassUp.Text = "Password Must Have 8 Letters";
                                    pnlErrPasUp.Visible = true;

                                }
                            }
                            else
                            {
                                lblnameUp.Text = "UserName Must Contain Atleast 1 UperCase Letter";
                                pnlerrUpName.Visible = true;
                            }
                        }
                        else
                        {
                            lblnameUp.Text = "  UserName must contain atleast 1 Numerical value";
                            pnlerrUpName.Visible = true;


                        }
                    }
                    else
                    {
                        lblConfrm.Text = "Password does not match";
                        pnlErrConfrm.Visible = true;
                    }
                }
                else
                {
                    lblUpComnErr.Text = "User with this Name or Password already Exist";
                    pnlCommnerr.Visible = true;
                }
            }
            else
            {
                lblUpComnErr.Text = "Comma is not Alowed in any Input";
                pnlCommnerr.Visible = true;
            }
        }

        private void txtuserName_TextChanged_1(object sender, EventArgs e)
        {
            pnlerrUpName.Visible = false;
            pnlCommnerr.Visible = false;
        }

        private void txtpassword_TextChanged(object sender, EventArgs e)
        {
            pnlErrPasUp.Visible = false;
            pnlCommnerr.Visible = false;
            txtpassword.PasswordChar = '.';
        }


        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {
            if (txtpassword.PasswordChar == '.')
            {
                btnHide.BringToFront();
                txtpassword.PasswordChar = '\0';
            }
        }

        private void btnHide_Click_1(object sender, EventArgs e)
        {
            if (txtpassword.PasswordChar == '\0')
            {
                guna2ImageButton1.BringToFront();
                txtpassword.PasswordChar = '.';
            }
        }

        private void btnCl_Click(object sender, EventArgs e)
        {
            if (txtConfirm.PasswordChar == '.')
            {
                btnClose.BringToFront();
                txtConfirm.PasswordChar = '\0';
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if (txtConfirm.PasswordChar == '\0')
            {
                btnopen.BringToFront();
                txtConfirm.PasswordChar = '.';
            }
        }

        private void txtConfirm_TextChanged(object sender, EventArgs e)
        {
            pnlCommnerr.Visible = false;
            pnlErrConfrm.Visible = false;
            txtConfirm.PasswordChar = '.';
        }

        private void txtuserName_KeyPress(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar;
            if (c == 32)
            {
                e.Handled = true;
            }
        }

        private void txtpassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar;
            if (c == 32)
            {
                e.Handled = true;
            }
        }

        private void txtConfirm_KeyPress(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar;
            if (c == 32)
            {
                e.Handled = true;
            }
        }
    }
}
