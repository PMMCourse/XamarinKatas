using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using XamarinFormsKatas.Katas_Logic.Kata_LH.View;

namespace XamarinFormsKatas.Katas_Logic.Kata_LH.ViewModel
{
    public class MainViewModel : BindableObject
    {
        private Command _navigationCommandButton;

        public ICommand NavigationCommandButton => _navigationCommandButton;
        public INavigation Navigation { get; set; }

        public MainViewModel(INavigation navigation)
        {
            Navigation = navigation;
            _navigationCommandButton = new Command(async () => await Navigate());
        }
        public async Task Navigate()
        {
            await Navigation.PushAsync(new Page1(_entrySwitch,_labelSwitch,_buttonSwitch,_activitySwitch));
        }

        private Boolean _entrySwitch = false;

        public Boolean EntrySwitch
        {
            get => _entrySwitch;
            set
            {
                OnPropertyChanged();
                _entrySwitch = value;
            }
        }
        private Boolean _labelSwitch = false;

        public Boolean LabelSwitch
        {
            get => _labelSwitch;
            set
            {
                OnPropertyChanged();
                _labelSwitch = value;
            }
        }
        private Boolean _buttonSwitch = false;

        public Boolean ButtonSwitch
        {
            get => _buttonSwitch;
            set
            {
                OnPropertyChanged();
                _buttonSwitch = value;
            }
        }
        private Boolean _activitySwitch = false;

        public Boolean ActivitySwitch
        {
            get => _activitySwitch;
            set
            {
                OnPropertyChanged();
                _activitySwitch = value;
            }
        }
    }
}
