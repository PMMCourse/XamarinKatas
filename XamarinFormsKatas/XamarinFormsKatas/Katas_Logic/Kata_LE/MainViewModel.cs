using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;
using XamarinFormsKatas.Katas_Logic.Kata_LA.ViewModel;
using Color = Xamarin.Forms.Color;

namespace XamarinFormsKatas.Katas_Logic.Kata_LE
{
    public class MainViewModel : BaseViewModel
    {
        private Command _ColorCommand;
        public ICommand ColorCommand => _ColorCommand;

      
        private string _EntryColorRed;
        public string EntryColorRed
        {
            get => _EntryColorRed;
            set
            {
                _EntryColorRed = value;
                OnPropertyChanged();
            }
        }
        
        private string _EntryColorGreen;
        public string EntryColorGreen
        {
            get => _EntryColorGreen;
            set
            {
                _EntryColorGreen = value;
                OnPropertyChanged();
            }
        }
      
        private string _EntryColorBlue;
        public string EntryColorBlue
        {
            get => _EntryColorBlue;
            set
            {
                _EntryColorBlue = value;
                OnPropertyChanged();
            }
        }

        private Color _Blend;
        public Color Blend
        {
            get => _Blend;
            set
            {
                _Blend = value;
                OnPropertyChanged();
            }
        }
        public MainViewModel()
        {
            _ColorCommand = new Command(ChangeColor);

            
        }
        void ChangeColor()
        {
            ColorTypeConverter converter = new ColorTypeConverter();
            Color ColorRed = Color.Transparent;
            Color ColorBlue = Color.Transparent;
            Color ColorGreen = Color.Transparent;

            try
            {
                ColorRed = (Color)(converter.ConvertFromInvariantString(EntryColorRed));

            }
            catch (InvalidOperationException)
            {

            }
            try
            {
                ColorGreen = (Color)(converter.ConvertFromInvariantString(EntryColorGreen));

            }
            catch (InvalidOperationException)
            {

            }
            try
            {
                ColorBlue = (Color)(converter.ConvertFromInvariantString(EntryColorBlue));

            }
            catch (InvalidOperationException)
            {

            }

            Blend = ExtensionMethod.Blend(ColorRed, ColorGreen, ColorBlue);
        }
    }
}
