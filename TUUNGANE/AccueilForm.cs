using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TUUNGANE
{
    public partial class AccueilForm : Form
    {
        public AccueilForm()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblHrs.Text = DateTime.Now.ToString("HH:mm");
            lblSec.Text = DateTime.Now.ToString("ss");
        }

        private void AccueilForm_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void bunifuGradientPanel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
