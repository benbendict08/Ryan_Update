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
    
    public partial class Add_personnel : Form
    {
        MySqlConnection conn;
        MySqlCommand cn;
        global frmconn = new global();
        public Add_personnel()
        {
            InitializeComponent();
            conn = new MySqlConnection(frmconn.dbconnect());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            conn.Open();

            if (string.IsNullOrEmpty(textBox1.Text) || string.IsNullOrEmpty(textBox2.Text) || string.IsNullOrEmpty(textBox3.Text) || string.IsNullOrEmpty(textBox4.Text) || string.IsNullOrEmpty(textBox5.Text))
            {
                MessageBox.Show("please inpute required data");
            }
            else
            {
                cn = new MySqlCommand("INSERT INTO personnel (fname,mname,lname,con_num,address,AID) VALUES('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "','" + global.a_name + "')", conn);
                cn.ExecuteNonQuery();
                MessageBox.Show("Successful");
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
                textBox5.Text = "";
            }
            conn.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
