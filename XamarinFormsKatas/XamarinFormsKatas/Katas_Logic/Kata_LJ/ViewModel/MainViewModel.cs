using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;
using XamarinFormsKatas.Katas_Logic.Kata_LJ.ViewModel.Base;

namespace XamarinFormsKatas.Katas_Logic.Kata_LJ.ViewModel
{
    public class MainViewModel : BindableObject
    {
        private string username;
        private string password;
        private Command Command;

        public MainViewModel()
        {
            Command = new Command(PerformCommand);
        }

        private void PerformCommand(object obj)
        {
            if (String.IsNullOrEmpty(username))
            {

            }
            if (String.IsNullOrEmpty(password))
            {

            }
        }

        public ICommand comandito => Command;

        public void SetChanged<T>(ref T refValue, T value, [CallerMemberName] string propertyName = "")
        {
            if (!value.Equals(refValue))
            {
                refValue = value;
                OnPropertyChanged(propertyName);
            }
        }
        public string Username{
            get => username;
            set => SetChanged(ref username, value);
        }
        public string Password
        {
            get => password;
            set => SetChanged(ref password, value);
        }

    }
}
