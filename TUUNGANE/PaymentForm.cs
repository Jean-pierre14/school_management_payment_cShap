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

namespace TUUNGANE
{
    public partial class PaymentForm : Form
    {
        SqlConnection Cnn = new SqlConnection("Data Source=PETER-KHMZ\\SQLEXPRESS;Initial Catalog=New_tuungane;Integrated Security=True");
        SqlCommand Cmd;
        public PaymentForm()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //label17.Text = dataGridView1.Text.ToString();
            printDialog1.Document = printDocument1;
            if (printDialog1.ShowDialog() == DialogResult.OK)
            {
                printDocument1.Print();
            }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString(label7.Text, new Font("Centery Gothic", 12, FontStyle.Regular), Brushes.Black, 90, 150);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
