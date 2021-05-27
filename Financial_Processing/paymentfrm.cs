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
    public partial class paymentfrm : Form
    {
        MySqlConnection conn;
        MySqlCommand cn;
        MySqlDataReader GetReader;
        global frmcon = new global();
        
        public paymentfrm()
        {
            InitializeComponent();
            conn = new MySqlConnection(frmcon.dbconnect());
            
        }

        public void viewdata()
        {
            
            conn.Open();
            dataGridView1.Rows.Clear();
            cn = new MySqlCommand("SELECT  `PID`,`fname`,`mname`, `lname`, `blk`, `lot`, `street` FROM `payment`", conn);
            GetReader = cn.ExecuteReader();
            while (GetReader.Read())
            {
                
                dataGridView1.Rows.Add(GetReader[0].ToString(),GetReader[1].ToString()+" "+ GetReader[2].ToString() + " " + GetReader[3].ToString(),
                                        GetReader[4].ToString(), GetReader[5].ToString(), GetReader[6].ToString());
            }
            conn.Close();
            GetReader.Close();
        }

        public void viewdata2()
        {

            conn.Open();
            dataGridView2.Rows.Clear();
            cn = new MySqlCommand("SELECT `accnum`,`fname`,`mname`,`lname`,`blk`,`lot`,`street`,`contnum` FROM `resident` ORDER BY `accnum`,`fname`,`mname`,`lname`,`blk`,`lot`,`street`,`contnum`", conn);
            GetReader = cn.ExecuteReader();
            while (GetReader.Read())
            {

                dataGridView2.Rows.Add(GetReader[0].ToString(), GetReader[1].ToString(), GetReader[2].ToString(),GetReader[3].ToString(),
                                        GetReader[4].ToString(), GetReader[5].ToString(), GetReader[6].ToString(), GetReader[7].ToString());
            }
            conn.Close();
            GetReader.Close();
        }

        private void paymentfrm_Load(object sender, EventArgs e)
        {
            viewdata();
            viewdata2();

            searchform.Visible = false;
            pictureBox1.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string date = dateTimePicker1.Value.ToString("MM-dd-yyyy");
            if (string.IsNullOrEmpty(fbox.Text)|| string.IsNullOrEmpty(mbox.Text)|| string.IsNullOrEmpty(lbox.Text)|| string.IsNullOrEmpty(blkbox.Text)|| string.IsNullOrEmpty(lotbox.Text)|| string.IsNullOrEmpty(streetbox.Text)|| string.IsNullOrEmpty(date)|| string.IsNullOrEmpty(amountbox.Text))
            {
                MessageBox.Show("Fill Missing Input");
            }
            else
            {
                conn.Open();
                cn = new MySqlCommand("INSERT INTO payment(fname,mname,lname,blk,lot,street,date,amount,a_name) VALUES ('" + fbox.Text + "','" + mbox.Text + "','" + lbox.Text + "','" + blkbox.Text + "','" + lotbox.Text + "','" + streetbox.Text + "','" + date + "','" + amountbox.Text + "','" + global.a_name + "')", conn);
                cn.ExecuteNonQuery();
                MessageBox.Show("successful");
                conn.Close();
                viewdata();
            }
            
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {
            
        }

        private void label10_Click(object sender, EventArgs e)
        {
            
            
        }
        

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            

        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label10_Click_1(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged_2(object sender, EventArgs e)
        {

        }

        private void panel5_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void label10_Click_2(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged_3(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
        }

        private void panel6_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        

        private void listView2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void panel5_Paint_2(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click_1(object sender, EventArgs e)
        {

        }

        private void searchbtn_Click(object sender, EventArgs e)
        {
            searchform.Visible = true;
            searchform.Size = new Size(667, 360);
            pictureBox1.Visible = true;
            pictureBox1.Location = new Point(650, 91);
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            searchform.Visible = false;
            pictureBox1.Visible = false;

        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                fbox.Text = dataGridView2.SelectedRows[0].Cells[1].Value.ToString();
                mbox.Text = dataGridView2.SelectedRows[0].Cells[2].Value.ToString();
                lbox.Text = dataGridView2.SelectedRows[0].Cells[3].Value.ToString();
                textBox1.Text = dataGridView2.SelectedRows[0].Cells[7].Value.ToString();
                textBox2.Text = dataGridView2.SelectedRows[0].Cells[0].Value.ToString();
                blkbox.Text = dataGridView2.SelectedRows[0].Cells[4].Value.ToString();
                lotbox.Text = dataGridView2.SelectedRows[0].Cells[5].Value.ToString();
                streetbox.Text = dataGridView2.SelectedRows[0].Cells[6].Value.ToString();
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            conn.Open();

            MySqlCommand cmd = new MySqlCommand("SELECT fname, mname, lname, contnum, blk, lot, street from resident WHERE accnum =@accnum", conn); 
            cmd.Parameters.AddWithValue("@accnum", int.Parse(textBox2.Text));
            GetReader = cmd.ExecuteReader();
            while (GetReader.Read())
            {
                fbox.Text = GetReader.GetValue(0).ToString();
                mbox.Text = GetReader.GetValue(1).ToString();
                lbox.Text = GetReader.GetValue(2).ToString();
                textBox1.Text = GetReader.GetValue(3).ToString();
                blkbox.Text = GetReader.GetValue(4).ToString();
                lotbox.Text = GetReader.GetValue(5).ToString();
                streetbox.Text = GetReader.GetValue(6).ToString();
            
            }
            conn.Close();
            GetReader.Close();
     
        }

        private void searchform_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            conn.Open();
            dataGridView3.Rows.Clear();
            cn = new MySqlCommand("SELECT  `accnum`, `fname`, `mname`, `lname` FROM `resident` WHERE accnum = '" + textBox2.Text + "'", conn);
            GetReader = cn.ExecuteReader();
            while (GetReader.Read())
            {

                dataGridView3.Rows.Add(GetReader[0].ToString(), GetReader[1].ToString() + " " + GetReader[2].ToString() + " " + GetReader[3].ToString());

            }
            conn.Close();
            GetReader.Close();
            
        }
    }
}
