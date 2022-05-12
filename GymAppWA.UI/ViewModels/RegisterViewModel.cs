using Prism.Commands;
using Prism.Windows.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Storage;

namespace GymAppWA.UI.ViewModels
{
    public class RegisterViewModel : ViewModelBase
    {
        private string _name;
        public string Name
        {
            get { return _name; }
            set { SetProperty(ref _name, value); }
        }

        private string _age;
        public string Age
        {
            get { return _age; }
            set { SetProperty(ref _age, value); }
        }

        private bool _isMale;
        public bool IsMale
        {
            get { return _isMale; }
            set { 
                    SetProperty(ref _isMale, value);
                    IsFemale = !value;
                }
        }

        private bool _isFemale;
        public bool IsFemale
        {
            get { return _isFemale; }
            set { SetProperty(ref _isFemale, value); }
        }

        private StorageFile _image;
        public StorageFile Image
        {
            get { return _image; }
            set { SetProperty(ref _image, value); }
        }

        public DelegateCommand LoadImageCommand { get; set; }
        public DelegateCommand SaveCommand { get; set; }
        public DelegateCommand ClearCommand { get; set; }
        public DelegateCommand CancelCommand { get; set; }

        public RegisterViewModel()
        {
            LoadImageCommand = new DelegateCommand(ButtonLoadImageClick);
            SaveCommand = new DelegateCommand(ButtonSaveClick);
            ClearCommand = new DelegateCommand(ButtonClearClick);
            CancelCommand = new DelegateCommand(ButtonCancelClick);
        }

        private void ButtonCancelClick()
        {
            throw new NotImplementedException();
        }

        private void ButtonClearClick()
        {
            Name = "";
            Age = "";
            IsMale = true;
            Image = null;
        }

        private void ButtonSaveClick()
        {
            throw new NotImplementedException();
        }

        private void ButtonLoadImageClick()
        {
            throw new NotImplementedException();
        }
    }
}
