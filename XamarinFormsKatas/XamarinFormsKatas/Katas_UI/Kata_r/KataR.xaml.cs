using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinFormsKatas.Katas_UI.Kata_r
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class KataR : ContentPage
	{
        List<Persona> listaPersona = new List<Persona>();
		public KataR ()
		{
			InitializeComponent ();
            Proveedor provee = new Proveedor("paco","patatas");
            Cliente client = new Cliente("dani","20063078V");
            listaPersona.Add(provee);
            listaPersona.Add(client);
            listaPersonas.ItemsSource =listaPersona;
		}
	}
}