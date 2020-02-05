using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;
using XamarinFormsKatas.Katas_Logic.Kata_LA;

namespace XamarinFormsKatas.Katas_Logic.Kata_LE
{
    public class MainViewModel:BaseViewModel
    {
        private Command _colorCommando;
        public ICommand colorCommando => _colorCommando;

        private string _colorRed;
        public string colorRed
        {
            get => _colorRed;
            set
            {
                _colorRed = value;
                OnPropertyChanged();
            }
        }
        private string _colorGreen;
        public string colorGreen
        {
            get => _colorGreen;
            set
            {
                _colorGreen = value;
                OnPropertyChanged();
            }
        }
        private string _colorBlue;
        public string colorBlue
        {
            get => _colorBlue;
            set
            {
                _colorBlue = value;
                OnPropertyChanged();
            }
        }
        private Color _colorMexcla;
        public Color colorMexcla
        {
            get => _colorMexcla;
            set
            {
                _colorMexcla = value;
                OnPropertyChanged();
            }
        }
        public MainViewModel()
        {
            _colorCommando = new Command(CambiarColor);
        }

        public  void CambiarColor(object obj)
        {
            ColorTypeConverter conversion = new ColorTypeConverter();
            Color Red = Color.Transparent;
            Color Blue = Color.Transparent;
            Color Green = Color.Transparent;

            try
            {
                Red = (Color)(conversion.ConvertFromInvariantString(colorRed));
            }
            catch (InvalidOperationException)
            {
                
            }

            try
            {
                Blue = (Color)(conversion.ConvertFromInvariantString(colorBlue));
            }
            catch (InvalidOperationException)
            {

            }

            try
            {
                Green = (Color)(conversion.ConvertFromInvariantString(colorGreen));
            }
            catch (InvalidOperationException)
            {

            }

            colorMexcla = MetodoExtencion.Mexcla(Red, Green, Blue);
        }
    }
}
