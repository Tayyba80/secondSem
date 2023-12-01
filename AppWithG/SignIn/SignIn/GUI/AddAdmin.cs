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
    public partial class AddAdmin : Form
    {
        public AddAdmin()
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

        private void btnLogIn_Click(object sender, EventArgs e)
        {

            bool isValid;  // It checks the validation on Password (must have length 8)
            bool isFound;  // It check whether the customer username is unique or not
            bool commaFound; // It check valodation on comma (comma is not allowed)

            string custEnterName = txtuserName.Text;
            string custEnterPas = txtpassword.Text;

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
                                    lblstk.Visible = true;
                                    txtpassword.Text = null;
                                    txtuserName.Text = null;
                                }
                                else
                                {
                                    lblErrPassUpAD.Text = "Password Must Contain 1 UpperCase Letter";
                                    pnlErrPasUpAD.Visible = true;

                                }

                            }
                            else
                            {
                                lblErrPassUpAD.Text = "Password Must Have 8 Letters";
                                pnlErrPasUpAD.Visible = true;

                            }
                        }
                        else
                        {
                            lblnameAD.Text = "UserName Must Contain Atleast 1 UperCase Letter";
                            pnlerrUpNameAD.Visible = true;
                        }
                    }
                    else
                    {
                        lblnameAD.Text = "  UserName must contain atleast 1 Numerical value";
                        pnlerrUpNameAD.Visible = true;


                    }
                }
                else
                {
                    lblUpComnErrAD.Text = "User with this Name or Password already Exist";
                    pnlCommnerrAD.Visible = true;
                }
            }
            else
            {
                lblUpComnErrAD.Text = "Comma is not Alowed in any Input";
                pnlCommnerrAD.Visible = true;
            }
        }

        private void txtuserName_TextChanged(object sender, EventArgs e)
        {
            lblstk.Visible = false;
            pnlerrUpNameAD.Visible = false;
            pnlCommnerrAD.Visible = false;
        }

        private void txtpassword_TextChanged(object sender, EventArgs e)
        {
            lblstk.Visible = false;
            pnlErrPasUpAD.Visible = false;
            pnlCommnerrAD.Visible = false;
        }
    }
}

