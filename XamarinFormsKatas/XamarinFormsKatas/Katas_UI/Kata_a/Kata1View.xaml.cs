using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinFormsKatas.Katas.Kata1 {
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Kata1View : ContentPage {
        public Kata1View() {
            InitializeComponent();
            Binding();
        }

        void Binding() {
            button_b.Clicked += (sender, e) => {
                Navigation.PushAsync(new Katas_UI.Kata_b.KataB());
            };
            button_c.Clicked += (sender, e) => {
                Navigation.PushAsync(new Katas_UI.Kata_c.KataC_Detail());
            };
            button_d.Clicked += (sender, e) => {
                Navigation.PushAsync(new Katas_UI.Kata_d.KataD());
            };
            button_e.Clicked += (sender, e) => {
                Navigation.PushAsync(new Katas_UI.Kata_e.KataE());
            };
            button_f.Clicked += (sender, e) => {
                Navigation.PushAsync(new Katas_UI.Kata_f.KataF());
            };
            button_g.Clicked += (sender, e) => {
                Navigation.PushAsync(new Katas_UI.Kata_g.KataG());
            };
            button_h.Clicked += (sender, e) => {
                Navigation.PushAsync(new Katas_UI.Kata_h.KataH());
            };
            button_i.Clicked += (sender, e) => {
                Navigation.PushAsync(new Katas_UI.Kata_i.KataI());
            };
            button_j.Clicked += (sender, e) => {
                Navigation.PushAsync(new Katas_UI.Kata_j.KataJ());
            };
            button_k.Clicked += (sender, e) => {
                Navigation.PushAsync(new Katas_UI.Kata_k.KataK());
            };
            button_l.Clicked += (sender, e) => {
                Navigation.PushAsync(new Katas_UI.Kata_l.KataL());
            };
            button_m.Clicked += (sender, e) => {
                Navigation.PushAsync(new Katas_UI.Kata_m.KataM());
            };
            button_n.Clicked += (sender, e) => {
                Navigation.PushAsync(new Katas_UI.Kata_n.KataN());
            };
            button_o.Clicked += (sender, e) => {
                Navigation.PushAsync(new Katas_UI.Kata_o.KataO());
            };
            button_p.Clicked += (sender, e) => {
                Navigation.PushAsync(new Katas_UI.Kata_p.KataP());
            };
            button_q.Clicked += (sender, e) => {
                Navigation.PushAsync(new Katas_UI.Kata_q.KataQ());
            };
            button_r.Clicked += (sender, e) => {
                Navigation.PushAsync(new Katas_UI.Kata_r.KataR());
            };
            button_s.Clicked += (sender, e) => {
                Navigation.PushAsync(new Katas_UI.Kata_s.KataS());
            };
            button_t.Clicked += (sender, e) => {
                Navigation.PushAsync(new Katas_UI.Kata_t.KataT());
            };
            button_u.Clicked += (sender, e) => {
                Navigation.PushAsync(new Katas_UI.Kata_u.KataU());
            };
            button_v.Clicked += (sender, e) => {
                Navigation.PushAsync(new Katas_UI.Kata_v.KataV());
            };
            button_w.Clicked += (sender, e) => {
                Navigation.PushAsync(new Katas_UI.Kata_w.KataW());
            };
            button_x.Clicked += (sender, e) => {
                Navigation.PushAsync(new Katas_UI.Kata_x.KataX());
            };
            button_y.Clicked += (sender, e) => {
                Navigation.PushAsync(new Katas_UI.Kata_y.KataY());
            };
            button_z.Clicked += (sender, e) => {
                Navigation.PushAsync(new Katas_UI.Kata_z.KataZ());
            };
        }
    }
}