using System;
namespace CvMobileApp.Models
{
    public class Skills
    {
        private string _picture = string.Empty;
        private string _title = string.Empty;
        private double _percentage = 0;

        public string Picture
        {
            get { return _picture; }
            set { _picture = value; }
        }

        public string Title
        {
            get { return _title; }
            set { _title = value; }
        }

        public double Percentage
        {
            get { return _percentage; }
            set { _percentage = value; }
        }

        public Skills(string picture, string title, double percentage)
        {
            Picture = picture;
            Title = title;
            Percentage = percentage;
        }
    }
}
