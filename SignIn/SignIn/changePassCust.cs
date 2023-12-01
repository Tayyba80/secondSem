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
    public partial class changePassCust : Form
    {
        public changePassCust()
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
        private void lblPass_Click(object sender, EventArgs e)
        {

        }

        private void lblErrPass_Click(object sender, EventArgs e)
        {

        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            bool notFound = true;
            bool isValid;
            bool commaFound;
            string prevPass = txtPass.Text;
            string newPass = textBox1.Text;
            int lengthNewPass = newPass.Length;

            isValid = validations.validPasword(lengthNewPass);
            commaFound = validations.ckeckComma(prevPass, newPass);
            bool isUper = validations.isUperCase(newPass, lengthNewPass);
            if (prevPass != null)
            {
                if (newPass != null)
                {
                    if (commaFound == true)
                    {
                        if (isValid == true)
                        {
                            if (isUper == true)
                            {
                                for (int i = 0; i < signDL.userList.Count; i++)
                                {
                                    if (prevPass == signDL.userList[i].getPassword())
                                    {
                                        signDL.userList[i].setPassword(newPass);
                                        lblCommonErr.Text = "Password Updated!";
                                        pnlComErr.Visible = true;
                                        notFound = false;
                                    }
                                   
                                }
                                if(notFound)
                                {
                                    lblErrPass.Text = "Password Does'nt Match";
                                    pnlErrPas.Visible = true;
                                }
                            }
                            else
                            {
                                label1.Text = "Password Must Contain 1 UpperCase Letter";
                                panel2.Visible = true;

                            }
                        }
                        else
                        {
                            label1.Text = "Password Must Have 8 Letters";
                            panel2.Visible = true;

                        }
                    }
                    else
                    {
                        label1.Text = "Comma is not Alowed in any Input";
                        panel2.Visible = true;
                    }
                }
                else
                {
                    label1.Text = "Please Enter New Password";
                    panel2.Visible = true;
                }
            }
            else
            {
                lblErrPass.Text = "Please Enter Previous Password";
                pnlErrPas.Visible = true;
            }

            signDL.storeChangedPasswordInFile();
        }
    }
}
