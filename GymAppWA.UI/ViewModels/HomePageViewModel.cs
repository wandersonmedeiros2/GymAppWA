using Model.Common.Mvvm;
using Model.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymAppWA.UI.ViewModels
{
    public class HomePageViewModel : BindableBase
    {
        private StudentModel _selectedStudent;
        public StudentModel SelectedStudent
        {
            get { return _selectedStudent; }
            set { SetProperty(ref _selectedStudent, value); }
        }

        private ObservableCollection<StudentModel> _sudents;
        public ObservableCollection<StudentModel> Students
        {
            get { return _sudents; }
            set { SetProperty(ref _sudents, value); }
        }

        public HomePageViewModel()
        {
            var students = new List<StudentModel>()
            {
                new StudentModel(){ Name = "Wanderson", Image="", DateStarted= DateTime.Now},
                new StudentModel(){ Name = "Matheus", Image="", DateStarted= DateTime.Now},
                new StudentModel(){ Name = "Kayo", Image="", DateStarted= DateTime.Now},
                new StudentModel(){ Name = "Hercules", Image="", DateStarted= DateTime.Now},
                new StudentModel(){ Name = "Isabel", Image="", DateStarted= DateTime.Now},
                new StudentModel(){ Name = "Alana", Image="", DateStarted= DateTime.Now},
                new StudentModel(){ Name = "Alexia", Image="", DateStarted= DateTime.Now}
            };

            Students = new ObservableCollection<StudentModel>(students);
        }

    }
}
