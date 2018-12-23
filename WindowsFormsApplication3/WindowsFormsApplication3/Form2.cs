using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication3
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            txtPin.PasswordChar='*';
        }



        private void Form2_Load(object sender, EventArgs e)
        {
            txtId.Text = Form1.id;
            txtName.Text = Form1.name;
            txtContact.Text = Form1.cnt;
            txtAddress.Text = Form1.add;
            txtEmail.Text = Form1.email;
            lblTotal.Text = Form1.t.ToString();
        }
    


        private void btnCancel_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            this.Hide();
            f1.ShowDialog();
           

        }

        private void txtPin_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            if(cmbCard.SelectedIndex==0 && txtPin.Text == "pass")
            {
                MessageBox.Show("Payment and the Order is Successfull");
            }
            else
            {
                MessageBox.Show("Please check the password");
            }
        }
    }
}
