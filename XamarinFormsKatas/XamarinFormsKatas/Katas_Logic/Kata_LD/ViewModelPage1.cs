using System;
using System.Collections.Generic;
using System.Text;
using XamarinFormsKatas.Katas_Logic.Kata_LA.ViewModel;

namespace XamarinFormsKatas.Katas_Logic.Kata_LD {
    public class ViewModelPage1 : BaseViewModel {
        private string _Text;

        public string Text {
            get => _Text;
            set {
                _Text = value;
                OnPropertyChanged();
            }
        }

        public ViewModelPage1(string str) {
            Text = str;
        }
    }
}
