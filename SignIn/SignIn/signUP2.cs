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

        private void signUP2_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnBackUp_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtUserName_TextChanged(object sender, EventArgs e)
        {
            pnlerrUpName.Visible = false;
            pnlCommnerr.Visible = false;
        }

        private void txtPass_TextChanged(object sender, EventArgs e)
        {
            pnlErrPasUp.Visible = false;
            pnlCommnerr.Visible = false;
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            bool isValid;  // It checks the validation on Password (must have length 8)
            bool isFound;  // It check whether the customer username is unique or not
            bool commaFound; // It check valodation on comma (comma is not allowed)

            string custEnterName = txtUserNameUp.Text;
            string custEnterPas = txtPassUp.Text;

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

        private void lblErrPassUp_Click(object sender, EventArgs e)
        {

        }

        private void lblUpComnErr_Click(object sender, EventArgs e)
        {

        }
    }
}
