using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;
using XamarinFormsKatas.Katas_Logic.Kata_LA;

namespace XamarinFormsKatas.Katas_Logic.Kata_LC
{
    class MainViewModel : BaseViewModel
    {
        private Command _BtnCommand;
        public ICommand BtnCommand => _BtnCommand;

        public MainViewModel()
        {
            _BtnCommand = new Command(TextButton);
        }

        async void TextButton(object obj)
        {
            await Application.Current.MainPage.DisplayAlert("titulo del mensaje", "Hola, Soy un mensaje", "Cancel");
        }
    }
}
