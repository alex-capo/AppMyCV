namespace CvMobileApp.Models
{
    public class Certification
    {
        private string _picture     = string.Empty;
        private string _title       = string.Empty;
        private string _certifiedBy = string.Empty;
        private string _time        = string.Empty;

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

        public string CertifiedBy
        {
            get { return _certifiedBy; }
            set { _certifiedBy = value; }
        }

        public string Time
        {
            get { return _time; }
            set { _time = value; }
        }

        public Certification(string picture, string title, string certifiedBy, string time)
        {
            Picture = picture;
            Title = title;
            CertifiedBy = certifiedBy;
            Time = time;
        }
    }
}
