using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinFormsKatas.Katas_UI.Kata_h
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class KataH : ContentPage
	{
		public KataH()
		{
			InitializeComponent();
		}
		public void BotonKata_h(object sender, EventArgs args)
		{
			//lo muevo en 50 de los ejes X e Y hacia arriba
			botonDinamico.TranslateTo(botonDinamico.X-50, botonDinamico.Y-50);
			//El boton Gira
			botonDinamico.RotateTo(360* 360);
		}
	}
}