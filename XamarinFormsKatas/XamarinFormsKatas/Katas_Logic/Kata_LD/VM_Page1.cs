using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
using XamarinFormsKatas.Katas_Logic.Kata_LA.ViewModel;

namespace XamarinFormsKatas.Katas_Logic.Kata_LD
{
    public class VM_Page1 : BaseViewModel
    {
        private string _Text;

        public string Text
        {
            get => _Text;
            set
            {
                _Text = value;
                OnPropertyChanged();
            }
        }

        public VM_Page1(string t)
        {
            Text = t;
        }
    }
}
