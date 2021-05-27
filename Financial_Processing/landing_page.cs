using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;


namespace Financial_Processing
{
    public partial class landing_page : Form
    {
        MySqlConnection conn;
        MySqlCommand cn;
        MySqlDataReader GetReader;
        global frmcon = new global();
        public landing_page()
        {
            InitializeComponent();
            conn = new MySqlConnection(frmcon.dbconnect());
            this.panel10.Controls.Clear();
            Dashboard dashboard_form = new Dashboard()
            {
                Dock = DockStyle.Bottom,
                TopLevel = false

            };
            dashboard_form.FormBorderStyle = FormBorderStyle.None;
            this.panel10.Controls.Add(dashboard_form);
            dashboard_form.Show();
            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
        }
        private void landing_page_Load(object sender, EventArgs e)
        {
            
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr one, int two, int three, int four);
        private void panel9_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(Handle, 0x112, 0xf012, 0);
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            add_admin nf = new add_admin();
            nf.Show();
            
        }

        


        

        
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox3_click(object sender, EventArgs e)
        {

        }

        private void panel8_Paint(object sender, PaintEventArgs e)
        {

        }

        

        

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            this.panel10.Controls.Clear();
            Dashboard dashboard_form = new Dashboard()
            {
                Dock = DockStyle.Bottom,
                TopLevel = false
            };
            dashboard_form.FormBorderStyle = FormBorderStyle.None;
            this.panel10.Controls.Add(dashboard_form);
            dashboard_form.Show();
        }

        private void pictureBox5_MouseHover(object sender, EventArgs e)
        {
            panel1.Size = new Size(135, 736);
            panel10.Size = new Size(1205, 723);
            this.Size = new Size(1270, 736);
            label1.Visible = true;
            label2.Visible = true;
            label3.Visible = true;
            label4.Visible = true;
        }

        private void pictureBox5_MouseLeave(object sender, EventArgs e)
        {
            panel1.Size = new Size(65, 736);
            panel10.Size = new Size(1135, 723);
            this.Size = new Size(1200, 736);
            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
        }
        
        private void pictureBox3_Click_1(object sender, EventArgs e)
        {
            this.panel10.Controls.Clear();

            paymentfrm payment_form = new paymentfrm()
            {
                Dock = DockStyle.Bottom,
                TopLevel = false
            };
            payment_form.FormBorderStyle = FormBorderStyle.None;
            this.panel10.Controls.Add(payment_form);
            payment_form.Show();
        }

        private void pictureBox3_MouseHover(object sender, EventArgs e)
        {
            panel1.Size = new Size(135, 736);
            panel10.Size = new Size(1205, 723);
            this.Size = new Size(1270, 736);
            label1.Visible = true;
            label2.Visible = true;
            label3.Visible = true;
            label4.Visible = true;
        }

        private void pictureBox3_MouseLeave(object sender, EventArgs e)
        {
            panel1.Size = new Size(65, 736);
            panel10.Size = new Size(1135, 723);
            this.Size = new Size(1200, 736);
            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
        }

        

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.panel10.Controls.Clear();
            salary salary_form = new salary()
            {
                Dock = DockStyle.Bottom,
                TopLevel = false
            };
            salary_form.FormBorderStyle = FormBorderStyle.None;
            this.panel10.Controls.Add(salary_form);
            salary_form.Show();
        }

     

        private void pictureBox4_MouseHover(object sender, EventArgs e)
        {
            panel1.Size = new Size(135, 736);
            panel10.Size = new Size(1205, 723);
            this.Size = new Size(1270, 736);
            label1.Visible = true;
            label2.Visible = true;
            label3.Visible = true;
            label4.Visible = true;
        }

        private void pictureBox4_MouseLeave(object sender, EventArgs e)
        {
            panel1.Size = new Size(65, 736);
            panel10.Size = new Size(1135, 723);
            this.Size = new Size(1200, 736);
            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Login nf = new Login();
            nf.Show();
            Visible = false;
        }

        private void pictureBox2_MouseHover(object sender, EventArgs e)
        {
            panel1.Size = new Size(135, 736);
            panel10.Size = new Size(1205, 723);
            this.Size = new Size(1270, 736);
            label1.Visible = true;
            label2.Visible = true;
            label3.Visible = true;
            label4.Visible = true;
        }

        private void pictureBox2_MouseLeave(object sender, EventArgs e)
        {
            panel1.Size = new Size(65, 736);
            panel10.Size = new Size(1135, 723);
            this.Size = new Size(1200, 736);
            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
        }
    }
}
