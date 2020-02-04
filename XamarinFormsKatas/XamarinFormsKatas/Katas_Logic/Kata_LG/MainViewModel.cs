using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
using Xamarin.Forms.Maps;
using XamarinFormsKatas.Katas_Logic.Kata_LA.ViewModel;

namespace XamarinFormsKatas.Katas_Logic.Kata_LG
{
    public class MainViewModel : BaseViewModel
    {
        private Map _Map;
        public Map Map
        {
            get => _Map;
            set
            {
                _Map = value;
                OnPropertyChanged();
            }
        }
        public MainViewModel()
        {
            _Map = new Map(MapSpan.FromCenterAndRadius(new Position(37.393355, -5.983900), Distance.FromMiles(1)))
            {
                VerticalOptions = LayoutOptions.FillAndExpand
            };

            var pin1 = new Pin
            {
                Type = PinType.Place,
                Position = new Position(37.371861, -5.999654),
                Label = "Fesac"
            };
            var pin2 = new Pin
            {
                Type = PinType.Place,
                Position = new Position(37.384217, -5.993467),
                Label = "Taco Bell"

            };
            _Map.Pins.Add(pin1);
            _Map.Pins.Add(pin2);
        }
    }
}
