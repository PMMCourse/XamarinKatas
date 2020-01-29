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
		}
        public void InsertarPersonas()
        {
            List<Persona> Personas = new List<Persona>();
            Persona p1 = new Persona(25, "Juan");
            Persona p2 = new Persona(18, "Maria");
            Personas.Add(p1);
            Personas.Add(p2);
            listaPersona.ItemsSource = Personas;
        }
	}
}