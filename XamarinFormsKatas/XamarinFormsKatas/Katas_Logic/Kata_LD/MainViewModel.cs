using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using XamarinFormsKatas.Katas_Logic.Kata_LA.ViewModel;

namespace XamarinFormsKatas.Katas_Logic.Kata_LD
{
    public class MainViewModel : BaseViewModel
    {
        private Command _NavigateCommand;

        public ICommand NavigateCommand => _NavigateCommand;
        public INavigation Navigation { get; set; }

        private string _Entry;

        public string Entry
        {
            get => _Entry;
            set
            {
                _Entry = value;
                OnPropertyChanged();
            }
        }

        public MainViewModel(INavigation navigation)
        {
            Navigation = navigation;
            _NavigateCommand = new Command(async() => await Navigate());
            
        }

        public async Task Navigate()
        {
            await Navigation.PushAsync(new Page1(Entry));
        }
    }
}
