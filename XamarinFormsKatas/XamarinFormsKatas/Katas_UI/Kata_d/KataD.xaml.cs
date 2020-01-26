using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinFormsKatas.Katas_UI.Kata_d
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class KataD : ContentPage
	{
		public KataD ()
		{
			InitializeComponent ();
            insertOnList();
		}

        private void insertOnList()
        {
            Persona paco = new Persona("Paco",35);
            Persona dani = new Persona("Dani", 21);
            List<Persona> listaPersona = new List<Persona>();
            listaPersona.Add(paco);
            listaPersona.Add(dani);
            lista.ItemsSource = listaPersona;
        }
    }
}