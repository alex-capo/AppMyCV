using System.Collections.Generic;
using System.Windows.Input;
using CvMobileApp.Models;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace CvMobileApp.ViewModels
{
    public class CVViewModel
    {
        private List<WorkExperience> workExperience = new List<WorkExperience>();
        private List<Certification> certificationCollection = new List<Certification>();
        private List<Skill> skillsCollection = new List<Skill>();
        public ICommand ClickCommand => new Command<string>((url) => { Launcher.OpenAsync(new System.Uri(url));});

        public CVViewModel()
        {
            //WorkExperience
            workExperience.Add(new WorkExperience("Webcat", "Senior Software Developer", "Webcat,LLC", "Aug 2021 - Present · 11 mos"));
            workExperience.Add(new WorkExperience("Inclusion", "Senior Xamarin Mobile Developer", "Inclusion The Cloud Company · Freelance", "Jul 2019 - Present · 3 yrs"));
            workExperience.Add(new WorkExperience("Ig", "Software Development Engineer", "Intergrupo", "Apr 2016 - Jul 2019 · 3 yrs 4 mos"));


            certificationCollection.Add(new Certification("Certjoin", "Agile Test Driven Development Certified", "CertJoin", "May 2021"));
            certificationCollection.Add(new Certification("Itcertificate", "Scrum Master Certified", "ITCertificate", "Apr 2021"));
            certificationCollection.Add(new Certification("Microsoft", "Xamarin Certified Mobile Developer", "Microsoft", "Jun 2018"));
            certificationCollection.Add(new Certification("Microsoft", "Xamarin Certified Mobile Professional", "Microsoft", "Dec 2017"));


            //Skills
            SkillCollection.Add(new Skill("Xamarin", "Xamarin", 0.9));
            SkillCollection.Add(new Skill("CSharp", "C#", 1));
            SkillCollection.Add(new Skill("Dotnet", ".NET", 0.7));
            SkillCollection.Add(new Skill("Appcenter", "App Center", 0.8));
            SkillCollection.Add(new Skill("Firebase", "Firebase", 0.6));
        }

        public List<WorkExperience> WorkExperience
        {
            get { return workExperience; }
            set { workExperience = value; }
        }

        public List<Certification> CertificationCollection
        {
            get { return certificationCollection; }
            set { certificationCollection = value; }
        }

        public List<Skill> SkillCollection
        {
            get { return skillsCollection; }
            set { skillsCollection = value; }
        }
    }
}
