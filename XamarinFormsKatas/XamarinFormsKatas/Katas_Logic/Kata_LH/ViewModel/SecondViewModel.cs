using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace XamarinFormsKatas.Katas_Logic.Kata_LH.ViewModel
{
    public class SecondViewModel : BindableObject
    {
        public SecondViewModel(Boolean _entrySwitch, Boolean _labelSwitch, Boolean _buttonSwitch, Boolean _activitySwitch)
        {
            this._entrySwitch = _entrySwitch;
            this._labelSwitch = _labelSwitch;
            this._buttonSwitch = _buttonSwitch;
            this._activitySwitch = _activitySwitch;
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
