using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp2
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 f2 = new Form2();
            f2.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form4 f4 = new Form4();
            f4.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 f2 = new Form2();
            f2.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form5 f5 = new Form5();
            f5.ShowDialog();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form5 f5 = new Form5();
            f5.ShowDialog();
        }

        private void label8_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form5 f5 = new Form5();
            f5.ShowDialog();
        }

        private void label9_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form5 f5 = new Form5();
            f5.ShowDialog();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Form4 f4 = new Form4();
            f4.ShowDialog();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Form5 f5 = new Form5();
            f5.ShowDialog();
        }

        private void label7_Click_1(object sender, EventArgs e)
        {
          
        }

        private void label8_Click_1(object sender, EventArgs e)
        {
            
        }

        private void label9_Click_1(object sender, EventArgs e)
        {
           
        }

        private void label11_Click_1(object sender, EventArgs e)
        {
           
        }

        private void label10_Click(object sender, EventArgs e)
        {
          
        }

        private void label6_Click(object sender, EventArgs e)
        {
           
        }

        private void pictureBox4_Click_1(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            listBox2.Items.Add(label6.Text);
            listBox1.Items.Add(label7.Text);
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {
            listBox2.Items.Add(label10.Text);
            listBox1.Items.Add(label8.Text);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            listBox2.Items.Add(label11.Text);
            listBox1.Items.Add(label9.Text);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            listBox2.Items.Remove(label11.Text);
            listBox1.Items.Remove(label9.Text);
            listBox2.Items.Remove(label10.Text);
            listBox1.Items.Remove(label8.Text);
            listBox2.Items.Remove(label6.Text);
            listBox1.Items.Remove(label7.Text);

        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 f3 = new Form3();
            f3.ShowDialog();
        }

        private void Form3_Load_1(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            decimal TOTAL = 0;
            for (int i = 0; i < listBox2.Items.Count; i++)
            {
                TOTAL += Convert.ToDecimal(listBox2.Items[i]);
            }
            label25.Text = "$" + TOTAL;
            txtfees.Text = "$" + TOTAL;


        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox3_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

     

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {

        }

        private void btnreset_Click(object sender, EventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {
            
        }

        private void label22_Click(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void label21_Click(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtresult_TextChanged(object sender, EventArgs e)
        {

        }

        private void label23_Click(object sender, EventArgs e)
        {

        }

        private void label25_Click(object sender, EventArgs e)
        {

        }

        private void label27_Click(object sender, EventArgs e)
        {

        }

        private void txtbatch_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtfees_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtnumber_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtfather_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtname_TextChanged(object sender, EventArgs e)
        {

        }

        private void label24_Click(object sender, EventArgs e)
        {

        }

        private void label26_Click(object sender, EventArgs e)
        {

        }

        private void label28_Click(object sender, EventArgs e)
        {

        }

        private void label29_Click(object sender, EventArgs e)
        {

        }

        private void label30_Click(object sender, EventArgs e)
        {

        }

        private void btngenerate_Click(object sender, EventArgs e)
        {

        }

        private void btngenerate_Click_1(object sender, EventArgs e)
        {
            txtresult.Clear();
            txtresult.Text += "*****************************************************\n ";
            txtresult.Text += "*********************INVOICE DETAIL******************\n ";
            txtresult.Text += "*****************************************************\n ";
            txtresult.Text += "Date: " + DateTime.Now + "\n\n";


            txtresult.Text += "NAME: " + txtname.Text + "\n\n";
            txtresult.Text += "FATHER NAME: " + txtfather.Text + "\n\n";
            txtresult.Text += "ADDRESS: " + txtbatch.Text + "\n\n";
            txtresult.Text += "MOBILE NUMBER: " + txtnumber.Text + "\n\n";
            txtresult.Text += "TOTAL AMOUNT: " + txtfees.Text + "\n\n";



            txtresult.Text += "\n                                              Signature";
        }

        private void btnreset_Click_1(object sender, EventArgs e)
        {

            txtname.Text = "";
            txtfather.Text = "";
            txtbatch.Text = "";
            txtnumber.Text = "";
            txtfees.Text = "";
            txtresult.Text = "";
           
    }
    }
}
