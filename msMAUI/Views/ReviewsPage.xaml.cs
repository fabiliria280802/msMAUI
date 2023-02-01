using System.Threading.Tasks;
using msMAUI.ViewModels;
using msMAUI.Models;

namespace msMAUI.Views
{
    public partial class ReviewsPage : ContentPage
    {
        private ReviewsViewModel _reviewsViewModel;

        public ReviewsPage()
        {
            InitializeComponent();

            _reviewsViewModel = new ReviewsViewModel();
        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();
            await LoadReviews();
        }

        private async Task LoadReviews()
        {
            await _reviewsViewModel.GetReviewsAsync();
            reviewsListView.ItemsSource = _reviewsViewModel.Reviews;
        }
    }
}
