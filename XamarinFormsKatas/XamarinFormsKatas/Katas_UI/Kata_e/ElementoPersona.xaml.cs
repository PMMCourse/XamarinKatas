using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinFormsKatas.Katas_UI.Kata_e
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ElementoPersona : ContentPage
    {
        Persona person= new Persona();
        public ElementoPersona(Persona person)
        {
            InitializeComponent();
            this.person = person;
            insertOnControllers();
        }

        private void insertOnControllers()
        {
            labelNombre.Text=person.nombre;
        }
    }
}