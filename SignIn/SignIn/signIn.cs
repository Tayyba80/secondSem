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
    public partial class frmSignIn : Form
    {
        public frmSignIn()
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

        private void frmSignIn_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            pnlErrPas.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            customerBL cust = new customerBL();
            string custNameForFile = null;
             
            string name = txtUserName.Text;
            string password = txtPass.Text;
            string role = validations.AdminSignIn(name, password, ref custNameForFile);
            if (role == "1")
            {
                this.Hide();
               
                AdminMenu adminMenu = new AdminMenu(cust);
                adminMenu.Show();
            }
            else if (role == "2")
            {
                this.Hide();
                
                customerBL cust1 = new customerBL();
                cust = cust1;
                CustomerMenu customerMenu = new CustomerMenu(ref custNameForFile,cust);
                customerMenu.Show();
            }
            else if (role != "1" && role != "2")
            {

                pnlErrPas.Visible = true;
                return;
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblName_Click(object sender, EventArgs e)
        {

        }

        private void txtPass_TextChanged(object sender, EventArgs e)
        {
            pnlErrPas.Visible = false;
        }

        private void pnlErrPas_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblErrPass_Click(object sender, EventArgs e)
        {

        }
    }
}
