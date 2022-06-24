using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace CvMobileApp.Views
{
    public partial class MyPage : ContentPage
    {
        public MyPage()
        {
            InitializeComponent();
            this.BindingContext = new ViewModels.CVViewModel();

        }
    }
}
