using SQLite;

namespace msMAUI.Models
{
    [Table("Movie")]
    public class Movie
    {
        //Esto es adicional para hacer cambios
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        //public string Filename { get; set; }

        //public Image image { get; set; }
        [MaxLength(250), Unique]
        public string title { get; set; }
        //public DateTime Date { get; set; }
        //public string time { get; set; }
        public int year { get; set; }
        public string director { get; set; }
        public bool shortFilm { get; set; }
        public double income { get; set; }
        public string distributor { get; set; }
        public string gender { get; set; }
        public string classification { get; set; }
        public string synopsis { get; set; }
        public string portadaPath { get; set; }
    }
}
