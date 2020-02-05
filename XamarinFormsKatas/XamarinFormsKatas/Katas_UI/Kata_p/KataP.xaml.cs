using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinFormsKatas.Katas_UI.Kata_p
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class KataP : ContentPage
	{
		public KataP ()
		{
			InitializeComponent ();
            actividad.Clicked += async (sender, e) =>
            {
                ActivityIndicator actividadIndicador = new ActivityIndicator();
                sl1.Children.Add(actividadIndicador);
                actividadIndicador.IsRunning = true;
                await pararPrograma(4500, () => actividadIndicador.IsRunning = false);
            };
		}

        private async Task pararPrograma(int milisegundos, Action actionParaExecutar )
        {
            await Task.Delay(milisegundos);
            actionParaExecutar();
        }
    }
}