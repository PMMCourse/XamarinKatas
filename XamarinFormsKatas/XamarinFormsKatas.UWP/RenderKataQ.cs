using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI;
using Windows.UI.Xaml.Media;
using Xamarin.Forms;
using Xamarin.Forms.Platform.UWP;
using XamarinFormsKatas.UWP;

[assembly: ExportRenderer(typeof(Entry), typeof(RenderKataQ))]
namespace XamarinFormsKatas.UWP
{
    public class RenderKataQ : EntryRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
        {
            base.OnElementChanged(e);

            Control.BorderBrush = new SolidColorBrush(Colors.Transparent);

        }
    }
}
