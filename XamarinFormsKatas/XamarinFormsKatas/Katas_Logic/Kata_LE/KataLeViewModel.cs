using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace XamarinFormsKatas.Katas_Logic.Kata_LE
{
    public class KataLeViewModel : BindableObject
    {
        private byte? _red;
        private byte? _green;
        private byte? _blue;

        public byte? Red
        {
            get => _red;
            set
            {
                _red = value;
                OnPropertyChanged();
            }
        }

        public byte? Green

        {
            get => _green;
            set
            {
                _green = value;
                OnPropertyChanged();
            }
        }

        public byte? Blue
        {
            get => _blue;
            set
            {
                _blue = value;
                OnPropertyChanged();
            }
        }

        private Color _resultColor;

        public Color ResultColor
        {
            get => _resultColor;
            set
            {
                _resultColor = value;
                OnPropertyChanged();
            }
        }

        public KataLeViewModel()
        {
            _blendColorsCommand = new Command(PerformBlendColors);
        }

        private Command _blendColorsCommand;

        public ICommand BlendColorsCommand => _blendColorsCommand;

        private void PerformBlendColors(object obj)
        {
            if (_red.HasValue && _green.HasValue && _blue.HasValue)
            {
                ResultColor = Color.FromRgb(_red.Value, _green.Value, _blue.Value);
            }

        }



    }
}

