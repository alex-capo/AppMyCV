﻿using CvMobileApp.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using Xamarin.Forms;
using System.Linq;

namespace CvMobileApp.ViewModels
{
    public class DemoIronmanViewModel
    {
        public List<ImageCarousel> ImagesCarousel { get; set; }

        public CarouselView CarouselView { get; set; }

        public DemoIronmanViewModel()
        {
            //FillCarousel();
        }

        public void FillCarousel()
        {
            var listImage = new List<ImageCarousel>()
            {
                new ImageCarousel { Path="Ironman8" },
                new ImageCarousel { Path="Ironman3" },
                new ImageCarousel { Path="Ironman4" },
                new ImageCarousel { Path="Ironman5" },
                new ImageCarousel { Path="Ironman6" },
                new ImageCarousel { Path="Ironman7" },
                new ImageCarousel { Path="Ironman9" },
                new ImageCarousel { Path="Ironman10" }
            };

            CarouselView.ItemsSource = listImage;

            Device.StartTimer(TimeSpan.FromSeconds(3), (Func<bool>)(() => 
            {
                CarouselView.Position = (CarouselView.Position + 1) % listImage.Count;
                return true;
            }));
        }
    }
}