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
		public IList<Persona> p { get; private set; }
		public KataD ()
		{
			InitializeComponent();
			p = new List<Persona>();
			p.Add(new Persona("Emmanuel","20"));
			p.Add(new Persona("pepe", "23"));
			p.Add(new Persona("Manuel", "10"));
			p.Add(new Persona("Emma", "2"));
			p.Add(new Persona("Emmilly", "40"));

			BindingContext = this;
		}
	}
}