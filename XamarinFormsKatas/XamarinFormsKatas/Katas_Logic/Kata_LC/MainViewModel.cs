using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;
using XamarinFormsKatas.Katas_Logic.Kata_LA.ViewModel;
using Xamarin.Forms.Xaml;

namespace XamarinFormsKatas.Katas_Logic.Kata_LC
{
    public class MainViewModel : BaseViewModel
    {
        private Command _ButtonCommand;

        public ICommand ButtonCommand => _ButtonCommand;

        
        public MainViewModel()
        {
            _ButtonCommand = new Command(CheckButtonCommand);
            
        }
        async void CheckButtonCommand()
        {
            await Application.Current.MainPage.DisplayAlert("Title", "Message", "Cancel");
        }
    }
}
