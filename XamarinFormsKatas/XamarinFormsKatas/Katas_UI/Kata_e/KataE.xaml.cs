using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinFormsKatas.Katas_UI.Kata_d;

namespace XamarinFormsKatas.Katas_UI.Kata_e
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class KataE : ContentPage
	{
        
		public KataE ()
		{
            InitializeComponent();
            insertarPersona();
            listaEjerE.ItemTapped += (sender, e) =>
            {
                var per1 = listaEjerE.SelectedItem;
                Navigation.PushAsync(new Katas_UI.Kata_e.vistaPersona(per1));

            };
		}
        public void insertarPersona()
        {
            List<Persona> personas = new List<Persona>();
            Persona p1 = new Persona(25, "Juan");
            Persona p2 = new Persona(18, "Maria");
            personas.Add(p1);
            personas.Add(p2);
            listaEjerE.ItemsSource = personas;
	}
}