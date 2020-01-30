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

            Binding();
        }

        void Binding()
        {
            btnB.Clicked += (sender, e) =>
            {
                Navigation.PushAsync(new Katas_UI.Kata_b.KataB());
            };
            btnC.Clicked += (sender, e) =>
            {
                Navigation.PushAsync(new Katas_UI.Kata_c.KataC());
            };
            btnD.Clicked += (sender, e) =>
            {
                Navigation.PushAsync(new Katas_UI.Kata_d.KataD());
            };
            btnE.Clicked += (sender, e) =>
            {
                Navigation.PushAsync(new Katas_UI.Kata_e.KataE());
            };
            btnF.Clicked += (sender, e) =>
            {
                Navigation.PushAsync(new Katas_UI.Kata_f.KataF());
            };
            btnG.Clicked += (sender, e) =>
            {
                Navigation.PushAsync(new Katas_UI.Kata_g.KataG());
            };
            btnH.Clicked += (sender, e) =>
            {
                Navigation.PushAsync(new Katas_UI.Kata_h.KataH());
            };
            btnI.Clicked += (sender, e) =>
            {
                Navigation.PushAsync(new Katas_UI.Kata_i.KataI());
            };
            btnJ.Clicked += (sender, e) =>
            {
                Navigation.PushAsync(new Katas_UI.Kata_j.KataJ());
            };
            btnK.Clicked += (sender, e) =>
            {
                Navigation.PushAsync(new Katas_UI.Kata_k.KataK());
            };
            btnL.Clicked += (sender, e) =>
            {
                Navigation.PushAsync(new Katas_UI.Kata_l.KataL());
            };
            btnM.Clicked += (sender, e) =>
            {
                Navigation.PushAsync(new Katas_UI.Kata_m.KataM());
            };
            btnN.Clicked += (sender, e) =>
            {
                Navigation.PushAsync(new Katas_UI.Kata_n.KataN());
            };
            btnO.Clicked += (sender, e) =>
            {
                Navigation.PushAsync(new Katas_UI.Kata_o.KataO());
            };
            btnP.Clicked += (sender, e) =>
            {
                Navigation.PushAsync(new Katas_UI.Kata_p.KataP());
            };
            btnQ.Clicked += (sender, e) =>
            {
                Navigation.PushAsync(new Katas_UI.Kata_q.KataQ());
            };
            btnR.Clicked += (sender, e) =>
            {
                Navigation.PushAsync(new Katas_UI.Kata_r.KataR());
            };
            btnS.Clicked += (sender, e) =>
            {
                Navigation.PushAsync(new Katas_UI.Kata_s.KataS());
            };
            btnT.Clicked += (sender, e) =>
            {
                Navigation.PushAsync(new Katas_UI.Kata_t.KataT());
            };
            btnU.Clicked += (sender, e) =>
            {
                Navigation.PushAsync(new Katas_UI.Kata_u.KataU());
            };
            btnV.Clicked += (sender, e) =>
            {
                Navigation.PushAsync(new Katas_UI.Kata_v.KataV());
            };
            btnW.Clicked += (sender, e) =>
            {
                Navigation.PushAsync(new Katas_UI.Kata_w.KataW());
            };
            btnX.Clicked += (sender, e) =>
            {
                Navigation.PushAsync(new Katas_UI.Kata_x.KataX());
            };
            btnY.Clicked += (sender, e) =>
            {
                Navigation.PushAsync(new Katas_UI.Kata_y.KataY());
            };
            btnZ.Clicked += (sender, e) =>
            {
                Navigation.PushAsync(new Katas_UI.Kata_z.KataZ());
            };

        }

        private void btnB_Clicked(object sender, EventArgs e)
        {

        }
    }
}