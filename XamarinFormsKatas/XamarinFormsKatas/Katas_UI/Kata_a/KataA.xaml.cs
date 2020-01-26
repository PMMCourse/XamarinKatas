using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinFormsKatas.Katas_UI.Kata_a
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class KataA : ContentPage
    {
        public KataA()
        {
            InitializeComponent();
            botonB.Clicked += PantallaB;
            botonC.Clicked += PantallaC;
            botonD.Clicked += PantallaD;
            botonE.Clicked += PantallaE;
            botonF.Clicked += PantallaF;
        }

        private void PantallaF(object sender, EventArgs e)
        {
            ((NavigationPage)this.Parent).PushAsync(new Kata_f.KataF());
        }

        private void PantallaE(object sender, EventArgs e)
        {
            ((NavigationPage)this.Parent).PushAsync(new Kata_e.KataE());
        }

        private void PantallaD(object sender, EventArgs e)
        {
            ((NavigationPage)this.Parent).PushAsync(new Kata_d.KataD());
        }

        private void PantallaC(object sender, EventArgs e)
        {
            ((NavigationPage)this.Parent).PushAsync(new Kata_c.KataC());
        }

        private void PantallaB(object sender, EventArgs e)
        {
            ((NavigationPage)this.Parent).PushAsync(new Kata_b.KataB());
        }
    }
}