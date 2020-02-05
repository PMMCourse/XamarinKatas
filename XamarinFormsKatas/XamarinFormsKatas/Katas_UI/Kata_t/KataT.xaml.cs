using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinFormsKatas.Katas_UI.Kata_t
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class KataT : ContentPage
	{
		public KataT()
		{
			InitializeComponent();

			Deportista d = new Deportista("100", "Emmanuel", "Programation", 10);
			dep.Text = d.Deporte;
			pun.Text = d.Puntuacion;
			nom.Text = d.Nombre;
			eda.Text = d.Edad.ToString();
		}
	}
}