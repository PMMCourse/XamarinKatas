using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using Xamarin.Forms;

namespace XamarinFormsKatas.Katas_UI.Kata_r.ViewModel
{
    public abstract class BaseViewModel : BindableObject
    {
        public void SetChanged<T>(ref T refValue, T value, [CallerMemberName] string propertyName = "")
        {
            if (!value.Equals(refValue))
            {
                refValue = value;
                OnPropertyChanged(propertyName);
            }
        }

        public virtual void OnAppearing()
        { }

        public virtual void OnDisappearing()
        { }
    }
}
