using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using Xamarin.Forms;

namespace XamarinFormsKatas.ViewModel
{
    public class BaseViewModel: BindableObject
    {
        public BaseViewModel()
        {
        }

        public void SetChanged<T>(ref T refValue, T value, [CallerMemberName] string propertyName = "")
        {
            if (!value.Equals(refValue))
            {
                refValue = value;
                OnPropertyChanged(propertyName);
            }
        }
    }
}

