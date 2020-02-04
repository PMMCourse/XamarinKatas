using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinFormsKatas.Katas_UI.Kata_w
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class KataW : ContentPage
	{
		public StackLayout sl = new StackLayout();
		public KataW()
		{
			InitializeComponent();

			BotonNavegar.Clicked += Button_Navegar;
		}

		private void Button_Navegar(object sender, EventArgs e)
		{
			
			if (switchEntry.IsToggled)
				{
				sl.Children.Add(entryVist1);
				}
			
			if (switchLabel.IsToggled)
				{
				sl.Children.Add(labVist1);
				}
				
			if (switchBoton.IsToggled)
				{
				sl.Children.Add(buttVist1);
				}
					
			if (switchAIndicator.IsToggled)
				{
				sl.Children.Add(AIvist1);
				}

			//le paso el stacklayout con los componentes que han sido marcados
			Navigation.PushAsync(new Katas_UI.Kata_w.SegundaVista(sl));
		}
	}
}