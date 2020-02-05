using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;
using XamarinFormsKatas.Katas_Logic.Kata_LA;

namespace XamarinFormsKatas.Katas_Logic.Kata_LC
{
    public class MainViewModel:BaseViewModel
    {
        private Command _CommandButton;
        public ICommand commandButton => _CommandButton;
      
        public MainViewModel()
        {
            _CommandButton = new Command(checkingButton);
        }

        async void checkingButton()
        {
            await Application.Current.MainPage.DisplayAlert("titulo", "message", "Cancelar");

        }
    }
}
