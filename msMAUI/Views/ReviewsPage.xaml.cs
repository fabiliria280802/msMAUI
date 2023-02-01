using System.Threading.Tasks;
using msMAUI.ViewModels;
using msMAUI.Models;

namespace msMAUI.Views
{
    public partial class ReviewsPage : ContentPage
    {
        //Declara una variable de tipo `ReviewsViewModel`
        private ReviewsViewModel _reviewsViewModel;

        //Constructor de la clase
        public ReviewsPage()
        {
            InitializeComponent();

            //Instanciamos `_reviewsViewModel`
            _reviewsViewModel = new ReviewsViewModel();
        }

        //El método `OnAppearing` es llamado cada vez que la página es mostrada en la aplicación
        protected override async void OnAppearing()
        {
            base.OnAppearing();
            //Llamamos al método `LoadReviews` para cargar las reseñas
            await LoadReviews();
        }

        //Método para cargar las reseñas
        private async Task LoadReviews()
        {
            //Llamamos al método `GetReviewsAsync` del `_reviewsViewModel`
            await _reviewsViewModel.GetReviewsAsync();
            //Establecemos la propiedad `ItemsSource` del `reviewsListView` a la propiedad `Reviews` del `_reviewsViewModel`
            reviewsListView.ItemsSource = _reviewsViewModel.Reviews;
        }
    }
}

