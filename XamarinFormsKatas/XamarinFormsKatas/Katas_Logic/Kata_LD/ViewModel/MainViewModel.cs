using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace XamarinFormsKatas.Katas_Logic.Kata_LD.ViewModel
{
    public class MainViewModel : BindableObject
    {
        private Command _performNavigation;
        public ICommand PerformNavigation => _performNavigation;
        public MainViewModel()
        {
            _performNavigation = new Command(performNavigationPage);
        }

        private void performNavigationPage()
        {
                //Navigation.PushAsync(new Katas_Logic.Kata_LD.View.Page1());
            
        }
    }
}
