namespace CvMobileApp.Models
{
    public class WorkExperience
    {
       private string _picture     = string.Empty;
       private string _position    = string.Empty;
       private string _company     = string.Empty;
       private string _time        = string.Empty;

       public string Picture
        {
            get { return _picture;  }
            set { _picture = value; }
        }

        public string Position
        {
            get { return _position;  }
            set { _position = value; }
        }

        public string Company
        {
            get { return _company; }
            set { _company = value; }
        }

        public string Time
        {
            get { return _time; }
            set { _time = value; }
        }

        public WorkExperience(string picture, string position, string company, string time)
        {
            Picture = picture;
            Position = position;
            Company = company;
            Time = time;
        }

    }
}
