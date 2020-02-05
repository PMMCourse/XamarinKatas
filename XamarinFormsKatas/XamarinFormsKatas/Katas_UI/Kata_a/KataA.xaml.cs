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
        }

        public void btKataB_Clicked  (object sender, EventArgs e)
        {
            Navigation.PushAsync(new Katas_UI.Kata_b.KataB());
        }

        private void btKataC_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Katas_UI.Kata_c.KataC());
        }

        private void btKataD_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Katas_UI.Kata_d_e.KataDE());
        }

        private void btKataF_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Katas_UI.Kata_f.KataF());
        }

        private void btKataG_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Katas_UI.Kata_g.KataG());
        }

        private void btKataH_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Katas_UI.Kata_h.KataH());
        }

        private void btKataI_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Katas_UI.Kata_i.KataI());
        }

        private void btKataJ_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Katas_UI.Kata_j.KataJ());
        }

        private void btKataK_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Katas_UI.Kata_k.KataK());
        }

        private void btKataL_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Katas_UI.Kata_l.KataL());
        }

        private void btKataM_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Katas_UI.Kata_m.KataM());
        }

        private void btKataN_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Katas_UI.Kata_n.KataN());
        }

        private void btKataO_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Katas_UI.Kata_o.KataO());
        }

        private void btKataP_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Katas_UI.Kata_p.KataP());
        }

        private void btKataQ_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Katas_UI.Kata_q.KataQ());
        }

        private void btKataR_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Katas_UI.Kata_r.KataR());
        }

        private void btKataS_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Katas_UI.Kata_s.KataS());
        }

        private void btKataT_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Katas_UI.Kata_t.KataT());
        }

        private void btKataU_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Katas_UI.Kata_u.KataU());
        }

        private void btKataV_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Katas_UI.Kata_v.KataV());
        }

        private void btKataW_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Katas_UI.Kata_w.KataW());
        }

        private void btKataX_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Katas_UI.Kata_x.KataX());
        }

        private void btKataY_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Katas_UI.Kata_y.KataY());
        }

        private void btKataZ_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Katas_UI.Kata_z.KataZ());
        }

    }
}