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
    public partial class ElevesForm : Form

    {
        public string connectionString = "Data Source=PETER-KHMZ\\SQLEXPRESS;Initial Catalog=New_tuungane;Integrated Security=True";
        SqlConnection Cnn = new SqlConnection("Data Source=PETER-KHMZ\\SQLEXPRESS;Initial Catalog=New_tuungane;Integrated Security=True");
        SqlCommand cmd;
        MemoryStream img = new MemoryStream();
        string imgLocation = "";

        public ElevesForm()
        {
            InitializeComponent();
            String ID = IDtxt.Text.ToString();
            String Nom = Nomtxt.Text.ToString();
            String PostNOm = Posttxt.Text.ToString();
            String PreNom = Pretxt.Text.ToString();
            String LieuDeNaissance = Lieutxt.Text.ToString();
            String NomDuPere = NomPeretxt.Text.ToString();
            String NomDeLaMer = NomMeretxt.Text.ToString();
            String Tutel = NomTuteltxt.Text.ToString();
            String Telephone = Teltxt.Text.ToString();
            String Email = Mailtxt.Text.ToString();

            String gender = String.Empty;
            if (sexRadioM.Checked )
            {
                gender = "Male";
            }
            else if(sexRadioF .Checked)
            {
                gender = "Female";
            }
        }
        public void display()
        {
            Cnn.Open();
            SqlCommand cmd = Cnn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select *from eleves";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            Cnn.Close();

        }
        // String imgLocation = "";
        // SqlConnection Cnn = new SqlConnection();
        // SqlCommand cmd;
        public void show()// this is for displaying the data
        {
            SqlConnection Cnn = new SqlConnection(connectionString);
            Cnn.Open();
            SqlCommand cmd = Cnn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from eleves";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            Cnn.Close();
        }
        //  DBConnection dbcon = IDbConnection();
        private void textBox11_TextChanged(object sender, EventArgs e)
        {
            Recherchetxt.Text = " ";
        }

        private void textBox11_MouseClick(object sender, MouseEventArgs e)
        {
            Recherchetxt.Text = "";
        }

        private void textBox1_MouseClick(object sender, MouseEventArgs e)
        {
            Nomtxt.Text = "";
        }

        private void textBox8_MouseClick(object sender, MouseEventArgs e)
        {
            Posttxt.Text = "";
        }

        private void textBox7_DoubleClick(object sender, EventArgs e)
        {
            Pretxt.Text = "";
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_MouseClick(object sender, MouseEventArgs e)
        {
            Lieutxt.Text = "";
        }
        public void DisplayData()
        {
            SqlConnection Cnn = new SqlConnection();
            SqlCommand cmd = Cnn.CreateCommand();
            Cnn.Open();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Select*from eleves";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;

            Cnn.Close();

        }

        private void textBox5_MouseClick(object sender, MouseEventArgs e)
        {
            NomPeretxt.Text = "";
        }

        private void textBox2_MouseClick(object sender, MouseEventArgs e)
        {
            NomMeretxt.Text = "";
        }

        private void textBox3_MouseClick(object sender, MouseEventArgs e)
        {
            NomTuteltxt.Text = "";
        }

        private void textBox6_MouseClick(object sender, MouseEventArgs e)
        {
            Teltxt.Text = "";
        }

        private void textBox9_MouseClick(object sender, MouseEventArgs e)
        {
            Mailtxt.Text = "";
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

       

        private void textBox8_DoubleClick(object sender, EventArgs e)
        {
            Posttxt.Text = " ";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Png files(*.png)|*.png|Jpg files(*.jpg)|*.jpg|ICO files(*.ico)|*.ico|All files(*.*)|*.*";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                imgLocation = dialog.FileName.ToString();
                pictureBox9.ImageLocation = imgLocation;
            }
        }
       
       
        private void textBox5_Click(object sender, EventArgs e)
        {
            NomPeretxt.Text = "";
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            Nomtxt.Text = "";
        }

        private void textBox8_Click(object sender, EventArgs e)
        {
            Posttxt.Text = "";
        }

        private void textBox7_Click(object sender, EventArgs e)
        {
            Pretxt.Text = "";
        }

        private void textBox4_Click(object sender, EventArgs e)
        {
            Lieutxt.Text = "";
        }

        private void textBox2_Click(object sender, EventArgs e)
        {
            NomMeretxt.Text = "";
        }

        private void textBox3_Click(object sender, EventArgs e)
        {
            NomTuteltxt.Text = "";
        }

        private void textBox6_Click(object sender, EventArgs e)
        {
            Teltxt.Text = "";
        }


        private void textBox9_Click(object sender, EventArgs e)
        {
            Mailtxt.Text = "";
        }

        private void textBox11_Click(object sender, EventArgs e)
        {
            Recherchetxt.Text = "";
        }

        private void textBox10_Click(object sender, EventArgs e)
        {
            IDtxt.Text = "";
        }

        String gender;
        private void button1_Click(object sender, EventArgs e)
        {
            String Class = ComboClass.SelectedItem.ToString();
 
            Cnn = new SqlConnection("Data Source=PETER-KHMZ\\SQLEXPRESS;Initial Catalog=New_tuungane;Integrated Security=True");
            string SqlQuery = "insert into eleves(Id,Nom,PostNom,Prenom,Sex,Date_de_Naissance,class,Lieu_de_Naissance,Nom_du_pere,Nom_de_la_mere,Tutel,Telephone,Mail,Photos)  values('" + IDtxt.Text.ToString()+ "','" + Nomtxt.Text.ToString () + "','"+Posttxt .Text.ToString () +"','"+Pretxt.Text.ToString () +"','"+gender+"','"+DateNtxt.Text.ToString ()+"','"+Class+"','"+Lieutxt.Text.ToString () +"','"+NomPeretxt .Text.ToString ()+"','"+NomMeretxt .Text.ToString () +"','"+NomTuteltxt.Text.ToString ()+"','"+Teltxt .Text .ToString ()+"','"+Mailtxt .Text .ToString ()+ "',@image)";
           // MemoryStream img = new MemoryStream();
            pictureBox9.Image.Save(img, pictureBox9.Image.RawFormat);
            Cnn.Open();
            cmd = new SqlCommand(SqlQuery, Cnn);
            cmd.CommandText = SqlQuery;
            cmd.Parameters.AddWithValue("@image",SqlDbType .Image).Value = img .ToArray ();

            int n =
            cmd.ExecuteNonQuery();


            //show();
            IDtxt.Text       = "";
            Nomtxt.Text      = "";
            Posttxt.Text     = "";
            Pretxt.Text      = "";
            Lieutxt.Text     = "";
            NomPeretxt.Text  = "";
            NomMeretxt.Text  = "";
            NomTuteltxt.Text = "";
            Teltxt.Text      = "";
            Mailtxt.Text     = "";
            ///  cmd.Parameters.Add(new SqlParameter("@photos", photos));
           
            MessageBox.Show(n.ToString()+"Enregistrer avec Succes", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Cnn.Dispose();
            Cnn.Close();
            
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            IDtxt.Text       = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            Nomtxt.Text      = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            Posttxt.Text     = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            Pretxt.Text      = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            Lieutxt.Text     = dataGridView1.SelectedRows[0].Cells[7].Value.ToString();
            NomPeretxt.Text  = dataGridView1.SelectedRows[0].Cells[8].Value.ToString();
            NomMeretxt.Text  = dataGridView1.SelectedRows[0].Cells[9].Value.ToString();
            NomTuteltxt.Text = dataGridView1.SelectedRows[0].Cells[10].Value.ToString();
            Teltxt.Text      = dataGridView1.SelectedRows[0].Cells[11].Value.ToString();
            Mailtxt.Text     = dataGridView1.SelectedRows[0].Cells[12].Value.ToString();
            ComboClass.Text  = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();
            DateNtxt .Text   = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
        }

        private void Supprimerbtn_Click(object sender, EventArgs e)
        {
            SqlConnection Cnn = new SqlConnection(connectionString);
            Cnn.Open();
            SqlCommand cmd = Cnn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "delete from eleves where Nom ='" + Nomtxt.Text + "'";
            cmd.ExecuteNonQuery();
            IDtxt.Text = "";
            Nomtxt.Text = "";
            Posttxt.Text = "";
            Pretxt.Text = "";
            Lieutxt.Text = "";
            NomPeretxt.Text = "";
            NomMeretxt.Text = "";
            NomTuteltxt.Text = "";
            Teltxt.Text = "";
            Mailtxt.Text = "";
            DateNtxt.Text = ""; 
            MessageBox.Show("Data removed successfully");
            show();
            Cnn.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            String Class = ComboClass.SelectedItem.ToString();
            SqlConnection Cnn = new SqlConnection(connectionString);
            Cnn.Open();
            SqlCommand cmd = Cnn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = " UPDATE  eleves SET (Id,Nom,PostNom,Prenom,Sex,Date_de_Naissance,class,Lieu_de_Naissance,Nom_du_pere,Nom_de_la_mere,Tutel,Telephone,Mail,Photos)  values('" + IDtxt.Text.ToString() + "','" + Nomtxt.Text.ToString() + "','" + Posttxt.Text.ToString() + "','" + Pretxt.Text.ToString() + "','" + gender + "','" + DateNtxt.Text.ToString() + "','" + Class + "','" + Lieutxt.Text.ToString() + "','" + NomPeretxt.Text.ToString() + "','" + NomMeretxt.Text.ToString() + "','" + NomTuteltxt.Text.ToString() + "','" + Teltxt.Text.ToString() + "','" + Mailtxt.Text.ToString() + "',@image) where Id=('"+IDtxt  .Text+"')";
            cmd.ExecuteNonQuery();
            IDtxt.Text = "";
            Nomtxt.Text = "";
            Posttxt.Text = "";
            Pretxt.Text = "";
            Lieutxt.Text = "";
            NomPeretxt.Text = "";
            NomMeretxt.Text = "";
            NomTuteltxt.Text = "";
            Teltxt.Text = "";
            Mailtxt.Text = "";
            MessageBox.Show("Data Updated successfully");
            show();
            
            Cnn.Close();
        }

        private void Recherchebtn_Click(object sender, EventArgs e)
        {
            /* SqlConnection Cnn = new SqlConnection(connectionString);
             Cnn.Open();
             SqlCommand cmd = Cnn.CreateCommand();
             cmd.CommandType = CommandType.Text;
             cmd.CommandText = "select * from student_info where name='" + Nomtxt.Text + "'";
             if (Nomtxt.Text == "")
             {
                 MessageBox.Show("The field is empty", "", MessageBoxButtons.OK, MessageBoxIcon.Stop);
             }
             cmd.ExecuteNonQuery();
             DataTable dt = new DataTable();
             SqlDataAdapter da = new SqlDataAdapter(cmd);
             da.Fill(dt);
             dataGridView1.DataSource = dt;
             Cnn.Close();*/
            Cnn = new SqlConnection("Data Source=PETER-KHMZ\\SQLEXPRESS;Initial Catalog=New_tuungane;Integrated Security=True");
            string SqlQuery = "select * from eleves where Id='"+ Recherchetxt .Text + "'";
            Cnn.Open();
            cmd = new SqlCommand(SqlQuery ,Cnn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            IDtxt.Text       = "";
            Nomtxt.Text      = "";
            Posttxt.Text     = "";
            Pretxt.Text      = "";
            Lieutxt.Text     = "";
            NomPeretxt.Text  = "";
            NomMeretxt.Text  = "";
            NomTuteltxt.Text = "";
            Teltxt.Text      = "";
            Mailtxt.Text     = "";

            IDtxt.Text         =  dataGridView1.CurrentRow.Cells[0].Value.ToString();
            Nomtxt.Text        =  dataGridView1.CurrentRow.Cells[1].Value.ToString();
            Posttxt.Text       =  dataGridView1.CurrentRow.Cells[2].Value.ToString();
            Pretxt.Text        =  dataGridView1.CurrentRow.Cells[3].Value.ToString();
            Lieutxt.Text       =  dataGridView1.CurrentRow.Cells[7].Value.ToString();
            NomPeretxt.Text    =  dataGridView1.CurrentRow.Cells[8].Value.ToString();
            NomMeretxt.Text    =  dataGridView1.CurrentRow.Cells[9].Value.ToString();
            NomTuteltxt.Text   = dataGridView1.CurrentRow.Cells[10].Value.ToString();
            Teltxt.Text        = dataGridView1.CurrentRow.Cells[11].Value.ToString();
            Mailtxt.Text       = dataGridView1.CurrentRow.Cells[12].Value.ToString();
            DateNtxt.Text      =   dataGridView1.CurrentRow.Cells[5].Value.ToString();
           

            Byte[] img = (Byte[])dataGridView1.CurrentRow.Cells[13].Value;
            MemoryStream ms = new MemoryStream(img);
            pictureBox9.Image = Image.FromStream(ms);
        }

        private void Afficherbtn_Click(object sender, EventArgs e)
        {
            show();
        }

        private void Pretxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void sexRadioM_CheckedChanged(object sender, EventArgs e)
        {
            gender = "Male";
        }

        private void sexRadioF_CheckedChanged(object sender, EventArgs e)
        {
            gender = "Female";
        }

        private void ElevesForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'new_tuunganeDataSet.eleves' table. You can move, or remove it, as needed.
           // this.elevesTableAdapter.Fill(this.new_tuunganeDataSet.eleves);

        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            Byte[] img = (Byte[])dataGridView1.CurrentRow.Cells[13].Value;
            MemoryStream ms = new MemoryStream(img);
            pictureBox9.Image = Image.FromStream(ms);
            
            IDtxt.Text       = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            Nomtxt.Text      = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            Posttxt.Text     = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            Pretxt.Text      = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            Lieutxt.Text     = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            NomPeretxt.Text  = dataGridView1.CurrentRow.Cells[8].Value.ToString();
            NomMeretxt.Text  = dataGridView1.CurrentRow.Cells[9].Value.ToString();
            NomTuteltxt.Text = dataGridView1.CurrentRow.Cells[10].Value.ToString();
            Teltxt.Text      = dataGridView1.CurrentRow.Cells[11].Value.ToString();
            Mailtxt.Text     = dataGridView1.CurrentRow.Cells[12].Value.ToString();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //printDialog1.Document = printDocument1;
            //if (printDialog1.ShowDialog() == DialogResult.OK)
            //{
           
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.PrintPreviewControl.Zoom = 1;
            printPreviewDialog1.ShowDialog();
            printDocument1.Print();
            //}
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Bitmap bt = new Bitmap(this.dataGridView1 .Width ,this .Height );
            dataGridView1.DrawToBitmap(bt,new Rectangle (0,0,this .dataGridView1.Width ,this .dataGridView1 .Height ));
            e.Graphics.DrawImage(bt,10,10);
        }

        private void IDtxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void Nomtxt_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
