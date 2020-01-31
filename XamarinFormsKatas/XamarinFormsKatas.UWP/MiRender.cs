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

[assembly: ExportRenderer(typeof(Entry), typeof(MiRender))]
namespace XamarinFormsKatas.UWP
{
    public class MiRender : EntryRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
        {
            base.OnElementChanged(e);

            try
            {//Si el texto cambia en cualquier momento se lanza el evento
                Control.TextChanged += Control_TextChanged;
            }
            catch (System.ArgumentException)
            {
               new XamarinFormsKatas.MainPage();
            }
            

        }

        private void Control_TextChanged(object sender, Windows.UI.Xaml.Controls.TextChangedEventArgs e)
        {//se comprueba que sea o no nulo el contenido del texto y en funcion a eso se cambia el color del borde
            if (string.IsNullOrWhiteSpace(Control.Text))
            {
                Control.BorderBrush = new SolidColorBrush(Colors.Red);
            }
            else
            {// restauro el color normal de windows
                Control.BorderBrush = new SolidColorBrush(Colors.DodgerBlue);
            }
        }
    }
}
