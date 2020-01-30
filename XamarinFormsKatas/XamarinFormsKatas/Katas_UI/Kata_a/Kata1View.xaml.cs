using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinFormsKatas.Katas.Kata1
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Kata1View : ContentPage
	{
		public Kata1View ()
		{
			InitializeComponent ();
            Binding();
        }
        void Binding()
        {
            btn1.Clicked += (sender, e) =>
            {
                Navigation.PushAsync(new Katas_UI.Kata_b.KataB());
            };
            btn2.Clicked += (sender, e) =>
            {
                Navigation.PushAsync(new Katas_UI.Kata_c.MasterDetailPage1());
            };
            btn3.Clicked += (sender, e) =>
            {
                Navigation.PushAsync(new Katas_UI.Kata_d.KataD());
            };
            btn4.Clicked += (sender, e) =>
            {
                Navigation.PushAsync(new Katas_UI.Kata_g.KataG());
            };
            btn5.Clicked += (sender, e) =>
            {
                Navigation.PushAsync(new Katas_UI.Kata_h.KataH());
            };
            btn6.Clicked += (sender, e) =>
            {
                Navigation.PushAsync(new Katas_UI.Kata_i.KataI());
            };
            btn7.Clicked += (sender, e) =>
            {
                Navigation.PushAsync(new Katas_UI.Kata_j.KataJ());
            };
            btn8.Clicked += (sender, e) =>
            {
                Navigation.PushAsync(new Katas_UI.Kata_k.KataK());
            };
            btn9.Clicked += (sender, e) =>
            {
                Navigation.PushAsync(new Katas_UI.Kata_l.KataL());
            };
            btn10.Clicked += (sender, e) =>
            {
                Navigation.PushAsync(new Katas_UI.Kata_m.KataM());
            };
            btn11.Clicked += (sender, e) =>
            {
                Navigation.PushAsync(new Katas_UI.Kata_n.TabbedPage1());
            };
            btn12.Clicked += (sender, e) =>
            {
                Navigation.PushAsync(new Katas_UI.Kata_o.KataO());
            };
            btn13.Clicked += (sender, e) =>
            {
                Navigation.PushAsync(new Katas_UI.Kata_p.KataP());
            };
            btn14.Clicked += (sender, e) =>
            {
                Navigation.PushAsync(new Katas_UI.Kata_q.KataQ());
            };
            btn15.Clicked += (sender, e) =>
            {
                Navigation.PushAsync(new Katas_UI.Kata_r.KataR());
            };
            btn16.Clicked += (sender, e) =>
            {
                Navigation.PushAsync(new Katas_UI.Kata_s.KataS());
            };
            btn17.Clicked += (sender, e) =>
            {
                Navigation.PushAsync(new Katas_UI.Kata_t.KataT());
            };
            btn18.Clicked += (sender, e) =>
            {
                Navigation.PushAsync(new Katas_UI.Kata_u.KataU());
            };

        }
    }
}