using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace XamarinFormsKatas.Katas_Logic.Kata_LC
{
    public class MainViewModel : BindableObject
    {
        private Command _performMessage;
        public ICommand PerformMessage => _performMessage;
        public MainViewModel()
        {
            _performMessage = new Command(performMessageAlert);
        }

        private void performMessageAlert()
        {
            Application.Current.MainPage.DisplayAlert("Alerta viewmodel", "Hola chema", "Ok");
        }
    }
}
