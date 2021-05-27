using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;

namespace Financial_Processing
{
    public partial class Dashboard : Form
    {
        MySqlConnection conn;
        MySqlCommand cn;
        MySqlDataReader GetReader;
        global frmcon = new global();
        public Dashboard()
        {
            InitializeComponent();
            conn = new MySqlConnection(frmcon.dbconnect());

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            paymentfrm payment_form = new paymentfrm()
            {
                Dock = DockStyle.Bottom,
                TopLevel = false
            };
            payment_form.FormBorderStyle = FormBorderStyle.None;
            this.Controls.Add(payment_form);
            payment_form.Show();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
        private void revenue()
        {
            conn.Open();
            cn = new MySqlCommand("SELECT SUM(amount) as total_payment FROM `payment`", conn);
            GetReader = cn.ExecuteReader();
            while (GetReader.Read())
            {
                string revenue = GetReader["total_payment"].ToString();
                label9.Text = revenue;

            }
            conn.Close();
        }
        private void expense()
        {
            conn.Open();
            cn = new MySqlCommand("SELECT SUM(etotal) as total_expense FROM `event`", conn);
            GetReader = cn.ExecuteReader();
            while (GetReader.Read())
            {
                string expense = GetReader["total_expense"].ToString();
                label3.Text = expense;
            }
            conn.Close();
        }
        private void resident()
        {
            conn.Open();
            cn = new MySqlCommand("SELECT count(lname) as total_resident FROM `resident`", conn);
            GetReader = cn.ExecuteReader();
            while (GetReader.Read())
            {
                string resident = GetReader["total_resident"].ToString();
                label5.Text = resident;
            }
            conn.Close();
        }
        private void net()
        {
            int revenue = int.Parse(label9.Text);
            int expense = int.Parse(label3.Text);
            conn.Open();
            cn = new MySqlCommand("SELECT count(total_sal) as total_sal FROM `salary`", conn);
            GetReader = cn.ExecuteReader();
            while (GetReader.Read())
            {
                int salary = int.Parse(GetReader["total_sal"].ToString());
                int net = revenue-(expense + salary);
                label12.Text = net.ToString();
            }
            conn.Close();
        }
        private void personnel() 
        {
            conn.Open();
            cn = new MySqlCommand("SELECT count(lname) as total_personnel FROM `personnel`", conn);
            GetReader = cn.ExecuteReader();
            while (GetReader.Read())
            {
                string personnel = GetReader["total_personnel"].ToString();
                label14.Text = personnel;

            }
            conn.Close();
        }
        private void tax()
        {
            double net;
            net = double.Parse(label12.Text);
            double tax = net * .1;
            label7.Text = tax.ToString();
        }
        
        private void Dashboard_Load(object sender, EventArgs e)
        {
            revenue();
            expense();
            resident();
            net();
            tax();
            personnel();
            label16.Text = global.a_name + "!";
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            
            this.Controls.Clear();
            expense expense_form = new expense()
            {
                Dock = DockStyle.Fill,
                TopLevel = false
            };
            expense_form.FormBorderStyle = FormBorderStyle.None;
            this.Controls.Add(expense_form);
            expense_form.Show();
            



        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click_1(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        

        private void label3_Click(object sender, EventArgs e)
        {
            
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            Add_resident nf = new Add_resident();
            nf.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void panel11_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel12_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            Add_personnel nf = new Add_personnel();
            nf.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
