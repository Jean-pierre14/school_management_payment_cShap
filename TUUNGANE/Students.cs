using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TUUNGANE
{
    public class Students
    {
        public int Id { get; set; }
        public string Nom { get; set; }
        public string PostNom { get; set; }
        public string Prenom { get; set; }
        public string Sex { get; set; }
        public DateTime  Date_de_Naissance { get; set; }
        public string Class { set; get; }
        public string Lieu_de_Naissance { set; get; }
        public string Nom_du_pere { set; get; }
        public string Nom_de_la_mere { set; get; }
        public string Tutel { set; get; }
        public string Telephone { set; get; }
        public string mail { set; get; }
        public Byte  Photos { set; get; }
    }
}
