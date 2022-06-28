using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CvMobileApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DemoIronmanPage : ContentPage
    {
        public DemoIronmanPage()
        {
            InitializeComponent();
            this.BindingContext = new ViewModels.DemoIronmanViewModel();
            var vm = BindingContext as ViewModels.DemoIronmanViewModel;
            vm.CarouselView = carouselView;
            vm.FillCarousel();
        }
    }
}