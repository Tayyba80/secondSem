using SignIn.BL;
using SignIn.DL;

namespace SignIn
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            productDL.readMenuFromFile();
            cartDL.readCustomOrderFromAdminFile();
            discountDL.readDiscountFromFile();
            rattingDL.readRattingFromFile();
            signDL.readAdminAndUserFromFile();
            cartDL.readCustomOrderFromFile();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            SignOptions f2 = new SignOptions();
            f2.ShowDialog();

        }


    }
}