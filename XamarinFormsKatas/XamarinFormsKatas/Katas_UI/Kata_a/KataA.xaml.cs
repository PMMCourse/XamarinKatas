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
            botonF.Clicked += PantallaG;
            botonH.Clicked += PantallaH;
            botonI.Clicked += PantallaI;
            botonK.Clicked += PantallaK;
            botonM.Clicked += PantallaM;
            botonN.Clicked += PantallaN;
            botonP.Clicked += PantallaP;
            botonS.Clicked += PantallaS;
        }

        private void PantallaG(object sender, EventArgs e)
        {
            ((NavigationPage)this.Parent).PushAsync(new Kata_g.KataG());
        }

        private void PantallaE(object sender, EventArgs e)
        {
            ((NavigationPage)this.Parent).PushAsync(new Kata_f.KataF());
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

        private void PantallaH(object sender, EventArgs e)
        {
            ((NavigationPage)this.Parent).PushAsync(new Kata_h.AnimarBoton());
        }

        private void PantallaI(object sender, EventArgs e)
        {
            ((NavigationPage)this.Parent).PushAsync(new Kata_i.KataI());
        }

        private void PantallaK(object sender, EventArgs e)
        {
            ((NavigationPage)this.Parent).PushAsync(new Kata_k.KataK());
        }
        private void PantallaM(object sender, EventArgs e)
        {
            ((NavigationPage)this.Parent).PushAsync(new Kata_m.KataM());
        }
        private void PantallaN(object sender, EventArgs e)
        {
            ((NavigationPage)this.Parent).PushAsync(new Kata_n.KataN());
        }
        private void PantallaP(object sender, EventArgs e)
        {
            ((NavigationPage)this.Parent).PushAsync(new Kata_p.KataP());
        }
        private void PantallaS(object sender, EventArgs e)
        {
            ((NavigationPage)this.Parent).PushAsync(new Kata_s.KataS());
        }

    }
}