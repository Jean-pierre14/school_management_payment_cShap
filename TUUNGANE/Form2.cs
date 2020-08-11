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
using System.IO;
namespace TUUNGANE
{
    public partial class Form2 : Form
    {
        int panelWidth;
        bool hidden;
        public Form2()
        {
            InitializeComponent();
            panelWidth = panel1.Width;
            hidden = false;
            
        }
        SqlConnection Cnn = new SqlConnection("Data Source = PETER - KHMZ\\SQLExpress; Initial Catalog = tuungane_db; Integrated Security = True");
        SqlCommand cmd;
        public void DisplayData()
        {
            Cnn.Open();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Select*from eleves_info";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            

            Cnn.Close();

        }
        private void Form2_Load(object sender, EventArgs e)
        {
            timer2.Start();
            timer1.Start();
        }

        private void ClosepictureBox_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MinimizepictureBox_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void RestorepictureBox_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            RestorepictureBox.Visible = false;
            MaxpictureBox.Visible = true;
        }

        private void MaxpictureBox_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            RestorepictureBox.Visible = true;
            MaxpictureBox.Visible = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        { 
           
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            timer1.Start();
            pictureBox1.Visible = false;
            SlideReduce.Visible = true;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            
            pictureBox1.Visible = true;
            SlideReduce.Visible = false;
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            pnlCall(new AccueilForm());
            DigitClock.Hide();
            lblDate.Hide();
            lblDay.Hide();
            lblHrs.Hide();
            lblSecs.Hide();
           
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            pnlCall(new ElevesForm());
            DigitClock.Hide();
            lblDate.Hide();
            lblDay.Hide();
            lblHrs.Hide();
            lblSecs.Hide();
           
        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            pnlCall(new PaymentForm());

            DigitClock.Hide();
            lblDate.Hide();
            lblDay.Hide();
            lblHrs.Hide();
            lblSecs.Hide();
            
        }

        private void bunifuFlatButton4_Click(object sender, EventArgs e)
        {
            pnlCall(new AproposForm());
            DigitClock.Hide();
            lblDate.Hide();
            lblDay.Hide();
            lblHrs.Hide();
            lblSecs.Hide();
           
        }
        private void pnlCall(object call)
        {
            if (this.mainpanel.Controls.Count>0)
            
                this.mainpanel.Controls.RemoveAt(0);
                Form frm = call as Form;
                frm.TopLevel = false;
                frm.Dock = DockStyle.Fill;
                this.mainpanel.Controls.Add(frm);
                this.mainpanel.Tag = frm;
                frm.Show();

            
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            lblHrs.Text = DateTime.Now.ToString("HH:mm");
            lblSecs.Text = DateTime.Now.ToString("ss");
            lblDate.Text = DateTime.Now.ToString("dd MMM yyyy");
            lblDay.Text = DateTime.Now.ToString("dddd");
            lblSecs.Location = new Point(lblHrs.Location.X + lblHrs.Width - 5, lblSecs.Location.Y);


        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblHrs_Click(object sender, EventArgs e)
        {

        }
    }
}
