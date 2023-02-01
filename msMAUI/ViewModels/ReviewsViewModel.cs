using System.Collections.ObjectModel;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using msMAUI.Models;

namespace msMAUI.ViewModels
{
    public class ReviewsViewModel
    {
        // Propiedad privada que contiene una colección de objetos `Review`
        private ObservableCollection<Review> _reviews;

        // Propiedad pública para acceder a la colección de objetos `Review`
        public ObservableCollection<Review> Reviews
        {
            get { return _reviews; }
            set { _reviews = value; }
        }

        // Método asíncrono para obtener la información de los comentarios de la API
        public async Task GetReviewsAsync()
        {
            // Crea una nueva instancia de `HttpClient` para realizar la petición
            var client = new HttpClient();

            // Realiza una llamada GET a la API y obtiene la respuesta en formato JSON
            var json = await client.GetStringAsync("https://jsonplaceholder.typicode.com/comments");

            // Deserializa la respuesta JSON y la almacena en una nueva colección de objetos `Review`
            var reviews = JsonConvert.DeserializeObject<ObservableCollection<Review>>(json);

            // Almacena la nueva colección en la propiedad `Reviews`
            Reviews = reviews;
        }
    }
}



