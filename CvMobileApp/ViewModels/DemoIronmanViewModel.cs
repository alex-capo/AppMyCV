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

        public ValidatableObject<string> Email { get; set; } = new ValidatableObject<string>();

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

            Device.StartTimer(TimeSpan.FromSeconds(4), (Func<bool>)(() => 
            {
                CarouselView.Position = (CarouselView.Position + 1) % listImage.Count;
                return true;
            }));
        }

        public void AddValidationRules()
        {
            //Email Validation Rules
            Email.Validations.Add(new IsNotNullOrEmptyRule<string> { ValidationMessage = "Your email is required" });
            Email.Validations.Add(new IsValidEmailRule<string> { ValidationMessage = "Please use a valid email address" });
        }

        bool AreFieldsValid()
        {
            Email.Value = Email.Value?.Trim();
            return Email.Validate();
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
