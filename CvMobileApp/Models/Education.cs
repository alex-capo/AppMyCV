using System;
namespace CvMobileApp.Models
{
    public class Education
    {
       private string _picture     = string.Empty;
       private string _title       = string.Empty;
       private string _description = string.Empty;
       private string _years       = string.Empty;

       public string Picture
        {
            get { return _picture;  }
            set { _picture = value; }
        }

        public string Title
        {
            get { return _title;  }
            set { _title = value; }
        }

        public string Description
        {
            get { return _description; }
            set { _description = value; }
        }

        public string Years
        {
            get { return _years; }
            set { _years = value; }
        }

        public Education(string picture, string title, string description, string years)
        {
            Picture = picture;
            Title = title;
            Description = description;
            Years = years;
        }

    }
}
