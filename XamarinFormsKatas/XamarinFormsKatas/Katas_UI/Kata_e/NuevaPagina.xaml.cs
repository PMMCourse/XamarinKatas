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
    public partial class NuevaPagina : ContentPage
    {
        public NuevaPagina(Persona persona)
        {
            InitializeComponent(); 
            labelTexto.Text = persona.ToString();
            imagen.Source = persona.Foto;

        }
    }
}