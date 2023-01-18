using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;

namespace msMAUI.Models
{
    [Table("msMaui")]
    public class Movie
    {
        //Esto es adicional para hacer cambios
        /*
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        */
        public string Filename { get; set; }

        //public Image image { get; set; }

        public string title { get; set; }
        public DateTime Date { get; set; }

        //public string time { get; set; }*/

        public string year { get; set; }

        public string director { get; set; }

        public string shortFilm { get; set; }
        public string income { get; set; }

        public string distributor { get; set; }
        public string gender { get; set; }
        public string classification { get; set; }
        public string synopsis { get; set; }
    }
}
