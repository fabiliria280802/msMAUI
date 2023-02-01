using System.Collections.ObjectModel;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using msMAUI.Models;

namespace msMAUI.ViewModels
{
    public class ReviewsViewModel
    {
        private ObservableCollection<Review> _reviews;

        public ObservableCollection<Review> Reviews
        {
            get { return _reviews; }
            set { _reviews = value; }
        }

        public async Task GetReviewsAsync()
        {
            var client = new HttpClient();
            var json = await client.GetStringAsync("https://jsonplaceholder.typicode.com/comments");

            var reviews = JsonConvert.DeserializeObject<ObservableCollection<Review>>(json);

            Reviews = reviews;
        }
    }
}



