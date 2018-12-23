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
    public partial class Form1 : Form
    {
        public void Form2()
        {
            InitializeComponent();
        }
        public static string id;
        public static int t;
        public static string name;
        public static string cnt;
        public static string add;
        public static string email;
        public static int tot = 0;
        public static int tot1 = 0;
        protected void button1_Click(object sender, EventArgs e)
        {
            id = txtId.Text;
            name = txtName.Text;
            cnt = txtContact.Text;
            add = txtAddress.Text;
            email = txtEmail.Text;
            tot1 = tot;
            
            Form2 f2 = new Form2();
            this.Hide();
            f2.ShowDialog();
            
        }
        public string ss()
        {
            string s = txtId.Text;
            return s;
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
      }

        private void label6_Click(object sender, EventArgs e)
        {
            
        }
        
        private void button2_Click(object sender, EventArgs e)
        {

            try
            {
                myglob.rows = dataGridView1.Rows.Add();
                
                dataGridView1.Rows[myglob.rows].Cells[0].Value = myglob.rows + 1;

                dataGridView1.Rows[myglob.rows].Cells[1].Value = cmbItem.SelectedItem.ToString();
                dataGridView1.Rows[myglob.rows].Cells[2].Value = myglob.uprice;
                dataGridView1.Rows[myglob.rows].Cells[3].Value = myglob.quty;
                dataGridView1.Rows[myglob.rows].Cells[4].Value = myglob.price;
                dataGridView1.AllowUserToAddRows = false;

                 t =0;
                for (int i = 0; i <= dataGridView1.RowCount-1; i++)
                {
                    int z = int.Parse(dataGridView1.Rows[i].Cells[4].Value.ToString());

                    t = t + z;
                    
                }
                lblTotal.Text = t.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Please choose Items");
            }

            
            lblPrice.Text = " ";
            txtquntity.Text = " ";
            cmbItem.Text = " ";
            cmbCategory.Text = " ";
        }
        private void btnOk_Click(object sender, EventArgs e)
        {
            //aa
            if (cmbCategory.SelectedIndex == 0 && cmbItem.SelectedIndex == 0)
            {
                myglob.uprice = 1000;

            }
            else if (cmbCategory.SelectedIndex == 0 && cmbItem.SelectedIndex == 1)
            {
                myglob.uprice = 2000;

            }
            else if (cmbCategory.SelectedIndex == 0 && cmbItem.SelectedIndex == 2)
            {
                myglob.uprice = 3000;
            }
            else if (cmbCategory.SelectedIndex == 0 && cmbItem.SelectedIndex == 3)
            {
                myglob.uprice = 4000;
            }
            if (cmbCategory.SelectedIndex == 1 && cmbItem.SelectedIndex == 0)
            {
                myglob.uprice = 1500;

            }
            else if (cmbCategory.SelectedIndex == 1 && cmbItem.SelectedIndex == 1)
            {
                myglob.uprice = 2500;

            }
            else if (cmbCategory.SelectedIndex == 1 && cmbItem.SelectedIndex == 2)
            {
                myglob.uprice = 3500;
            }
            else if (cmbCategory.SelectedIndex == 1 && cmbItem.SelectedIndex == 3)
            {
                myglob.uprice = 4500;
            }
            if (cmbCategory.SelectedIndex == 2 && cmbItem.SelectedIndex == 0)
            {
                myglob.uprice = 9000;

            }
            else if (cmbCategory.SelectedIndex == 2 && cmbItem.SelectedIndex == 1)
            {
                myglob.uprice = 5000;

            }
            else if (cmbCategory.SelectedIndex == 2 && cmbItem.SelectedIndex == 2)
            {
                myglob.uprice = 4550;
            }
            else if (cmbCategory.SelectedIndex == 2 && cmbItem.SelectedIndex == 3)
            {
                myglob.uprice = 6400;
            }
            if (cmbCategory.SelectedIndex == 3 && cmbItem.SelectedIndex == 0)
            {
                myglob.uprice = 7900;

            }
            else if (cmbCategory.SelectedIndex == 3 && cmbItem.SelectedIndex == 1)
            {
                myglob.uprice = 2100;

            }
            else if (cmbCategory.SelectedIndex == 3 && cmbItem.SelectedIndex == 2)
            {
                myglob.uprice = 3400;
            }
            else if (cmbCategory.SelectedIndex == 3 && cmbItem.SelectedIndex == 3)
            {
                myglob.uprice = 4600;
            }
            try
            {
                myglob.quty = int.Parse(txtquntity.Text);
                myglob.price= myglob.uprice * myglob.quty;
                lblPrice.Text = myglob.price.ToString();

               
                
            }
            catch (Exception)
            {
                MessageBox.Show("Please Enter the quantity");
            }
          
          
        }
        

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public void cmbCategory_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*Processors
Monitors
Ram
Motherboard
Graphics Card
Storage
Casing*/
            if(cmbCategory.SelectedIndex == 0)
            {
                cmbItem.Items.Clear();
                cmbItem.Text = " ";
                cmbItem.Items.Add("AMD Ryzen™ 3 2200G");
                cmbItem.Items.Add("AMD Ryzen™ 5 2600");
                cmbItem.Items.Add("Intel® Core™ I3-7100");
                cmbItem.Items.Add("Intel® Core™ I7-8700");
                
            }
           else if (cmbCategory.SelectedIndex == 1)
            {
                cmbItem.Items.Clear();
                cmbItem.Text = " ";
                cmbItem.Items.Add("AOC E2228SWN 18.5″");
                cmbItem.Items.Add("ASUS 19″ VB198TL LED");
                cmbItem.Items.Add("ASUS 22″ VZ229H");
                cmbItem.Items.Add("Dell 18.5″ Monitor");

            }
            else if (cmbCategory.SelectedIndex == 2)
            {
                cmbItem.Items.Clear();
                cmbItem.Text = " ";
                cmbItem.Items.Add("G.Skill Aegis DDR4 8GIS");
                cmbItem.Items.Add("G.Skill Trident Z RGB DDR4 16GTZR (8GBx2)");
                cmbItem.Items.Add("G.Skill TridentX DDR3 16GTX (8GBx2)");
                cmbItem.Items.Add("Ripjaws DDR4 SO-DIMM 8GB 8GRS");

            }
            else if (cmbCategory.SelectedIndex == 3)
            {
                cmbItem.Items.Clear();
                cmbItem.Text = " ";
                cmbItem.Items.Add("Asus Motherboard H110M");
                cmbItem.Items.Add("Asus Motherboard H310M");
                cmbItem.Items.Add("Asus Motherboard TUF B350M-PLUS GAMING");
                cmbItem.Items.Add("Gigabyte Motherboard GA-B250M-D3H");

            }
        }

        private void btnGo_Click(object sender, EventArgs e)
        {

            lblTotal.Visible = true;
            lbltot.Visible = true;
            dataGridView1.Visible = true;
            // DataGridView dataGrid = new DataGridView();

          
                
            
            
           // for (int i = 0; i < rowCount; i++)
           // {
           //     myglob.total = myglob.price + myglob.total;
           // }
           
            
           
            
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
           
            int a = dataGridView1.CurrentCell.RowIndex;
            dataGridView1.Rows.RemoveAt(a);

            t = 0;
            for (int i = 0; i <= dataGridView1.RowCount - 1; i++)
            {
                int z = int.Parse(dataGridView1.Rows[i].Cells[4].Value.ToString());

                t = t + z;

            }
            lblTotal.Text = t.ToString();
        }//

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }

    public  static class myglob
    {
       
        
        public static int quty=0;
        
        public static int total = 0;
        public static int rows = 0;
        public static decimal price = 0;
        public static int uprice = 0;
        
    }
    
}
