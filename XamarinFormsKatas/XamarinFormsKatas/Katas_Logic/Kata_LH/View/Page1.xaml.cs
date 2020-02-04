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
        public Page1(Boolean _entrySwitch, Boolean _labelSwitch, Boolean _buttonSwitch, Boolean _activitySwitch)
        {
            InitializeComponent();
            BindingContext = new SecondViewModel(_entrySwitch, _labelSwitch, _buttonSwitch, _activitySwitch);
        }
    }
}