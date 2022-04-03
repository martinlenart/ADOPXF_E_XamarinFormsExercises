using System.Web;
using Xamarin.Forms;

namespace XamarinFormsExercises.Views.Navigation
{
    public partial class WebViewExercisePage : ContentPage
    {
        public WebViewExercisePage()
        {
            InitializeComponent();
         }
        public WebViewExercisePage(string Url)
        {
            InitializeComponent();
        }
        protected override void OnAppearing()
        {
            base.OnAppearing();
        }
    }
}
