using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dapper;
using System.Configuration;
using System.Data.SqlClient;

namespace TUUNGANE
{
    public partial class PrintForm : Form
    {
        public string connectionString = "Data Source=PETER-KHMZ\\SQLEXPRESS;Initial Catalog=New_tuungane;Integrated Security=True";
        SqlConnection Cnn = new SqlConnection("Data Source=PETER-KHMZ\\SQLEXPRESS;Initial Catalog=New_tuungane;Integrated Security=True");
        SqlCommand cmd;
        public PrintForm()
        {
            InitializeComponent();
        }

        private void BtnLoad_Click(object sender, EventArgs e)
        {
            using (IDbConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings["Cnn"].ConnectionString))
            {
                if (db.State == ConnectionState.Closed)
                    db.Open();
                string query = "select o.Id,c.Nom,c.PostNom,c.Prenom,c.Sex,o.Date_de_Naissance,c.Class,c.Lieu_de_Naissance ,c.Nom_du_pere,c.Nom_de_la_mere , c.Tutel,c.Telephone ,c.Mail,c.Photos "+
                "from eleves o inner join eleves c on o.Nom = c.Nom" + $"where o.Date_de_Naissance between '{ dtDebut .Value}' and '{ dtFin .Value }' ";
                studentsBindingSource1.DataSource = db.Query<Students>(query, CommandType.Text);
            }
        }
    }
}
