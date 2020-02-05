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
    public partial class vistaPersona : ContentView
    {
        Persona p = new Persona();
        public vistaPersona(Persona p)
        {
            InitializeComponent();
            this.p = p;
            insertarControl();
        }
        public void insertarControl()
        {
            nombre.Text = p.nombre;
        }
    }
}