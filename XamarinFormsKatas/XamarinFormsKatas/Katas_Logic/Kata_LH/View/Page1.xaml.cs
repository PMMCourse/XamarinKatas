using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinFormsKatas.Katas_Logic.Kata_LH.ViewModel;

namespace XamarinFormsKatas.Katas_Logic.Kata_LH.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page1 : ContentPage
    {
        Boolean _entrySwitch=false;
        Boolean _labelSwitch = false;
        Boolean _buttonSwitch = false;
        Boolean _activitySwitch = false;
        public Page1(Boolean _entrySwitch, Boolean _labelSwitch, Boolean _buttonSwitch, Boolean _activitySwitch)
        {
            InitializeComponent();
            BindingContext = new SecondViewModel();
            this._entrySwitch = _entrySwitch;
            this._labelSwitch = _labelSwitch;
            this._buttonSwitch = _buttonSwitch;
            this._activitySwitch = _activitySwitch;
            controlState();
        }

        private void controlState()
        {
            Entry entryControl = new Entry();
            entryControl.IsVisible=_entrySwitch;
            Label labelControl = new Label();
            labelControl.IsVisible = _labelSwitch;
            Button buttonControl = new Button();
            buttonControl.IsVisible = _buttonSwitch;
            ActivityIndicator activityControl = new ActivityIndicator();
            activityControl.IsVisible = _activitySwitch;
            activityControl.IsEnabled = true;
            activityControl.IsRunning = true;
            stackControl.Children.Add(entryControl);
            stackControl.Children.Add(labelControl);
            stackControl.Children.Add(buttonControl);
            stackControl.Children.Add(activityControl);
        }
    }
}