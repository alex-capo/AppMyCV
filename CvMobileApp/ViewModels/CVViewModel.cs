using System;
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
        private List<Skills> skillsCollection = new List<Skills>();
        public ICommand ClickCommand => new Command<string>((url) => { Launcher.OpenAsync(new System.Uri(url));});

        public CVViewModel()
        {
            //Education
            workExperience.Add(new WorkExperience("Webcat", "Senior Software Developer", "Webcat,LLC", "Aug 2021 - Present · 11 mos"));
            workExperience.Add(new WorkExperience("Inclusion", "Senior Xamarin Mobile Developer", "Inclusion The Cloud Company · Freelance", "Jul 2019 - Present · 3 yrs"));
            workExperience.Add(new WorkExperience("Ig", "Software Development Engineer", "Intergrupo", "Apr 2016 - Jul 2019 · 3 yrs 4 mos"));

            //Skills
            skillsCollection.Add(new Skills("Xamarin", "Xamarin", 0.9));
            skillsCollection.Add(new Skills("CSharp", "C#", 1));
            skillsCollection.Add(new Skills("Dotnet", ".NET", 0.7));
            skillsCollection.Add(new Skills("Appcenter", "App Center", 0.8));
            skillsCollection.Add(new Skills("Firebase", "Firebase", 0.6));
        }

        public List<WorkExperience> WorkExperience
        {
            get { return workExperience; }
            set { workExperience = value; }
        }

        public List<Skills> SkillsCollection
        {
            get { return skillsCollection; }
            set { skillsCollection = value; }
        }
    }
}
