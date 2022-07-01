using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Input;
using CvMobileApp.Helpers.Validations;
using CvMobileApp.Helpers.Validations.Rules;
using CvMobileApp.Models;
using Xamarin.Forms;

namespace CvMobileApp.ViewModels
{
    public class DemoIronmanViewModel : INotifyPropertyChanged
    {
        public List<ImageCarousel> ImagesCarousel { get; set; }

        public ValidatablePair<string> Email { get; set; } = new ValidatablePair<string>();

        public CarouselView CarouselView { get; set; }

        public ICommand SignInCommand => new Command(async () =>
        {
            if (AreFieldsValid())
            {
                await App.Current.MainPage.DisplayAlert("Welcome", "", "Ok");
            }
        });

        public DemoIronmanViewModel()
        {
            AddValidationRules();
        }

        public void FillCarousel()
        {
            var listImage = new List<ImageCarousel>()
            {
                new ImageCarousel { Path="Ironman8.jpg" },
                new ImageCarousel { Path="Ironman3.jpg" },
                new ImageCarousel { Path="Ironman4.jpg" },
                new ImageCarousel { Path="Ironman5.jpg" },
                new ImageCarousel { Path="Ironman6.jpg" },
                new ImageCarousel { Path="Ironman7.png" },
                new ImageCarousel { Path="Ironman9.jpg" },
                new ImageCarousel { Path="Ironman10.jpg" }
            };

            CarouselView.ItemsSource = listImage;

            Device.StartTimer(TimeSpan.FromSeconds(3), (Func<bool>)(() => 
            {
                CarouselView.Position = (CarouselView.Position + 1) % listImage.Count;
                return true;
            }));
        }

        public void AddValidationRules()
        {
            //Email Validation Rules
            Email.Item1.Validations.Add(new IsNotNullOrEmptyRule<string> { ValidationMessage = "Email Required" });
            Email.Item1.Validations.Add(new IsValidEmailRule<string> { ValidationMessage = "Invalid Email" });
        }

        bool AreFieldsValid() => Email.Validate();

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
