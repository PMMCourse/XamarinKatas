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
            buttonB.Clicked += (sender, e) => {
                Navigation.PushAsync(new Katas_UI.Kata_b.KataB());
            };
            buttonC.Clicked += (sender, e) => {
                Navigation.PushAsync(new Katas_UI.Kata_c.MasterDetailPageKataC());
            };
            buttonD.Clicked += (sender, e) => {
                Navigation.PushAsync(new Katas_UI.Kata_d.KataD());
            };
            buttonE.Clicked += (sender, e) => {
                Navigation.PushAsync(new Katas_UI.Kata_e.KataE());
            };
            buttonF.Clicked += (sender, e) => {
                Navigation.PushAsync(new Katas_UI.Kata_f.KataF());
            };
            buttonG.Clicked += (sender, e) => {
                Navigation.PushAsync(new Katas_UI.Kata_g.KataG());
            };
            buttonH.Clicked += (sender, e) => {
                Navigation.PushAsync(new Katas_UI.Kata_h.KataH());
            };
            buttonI.Clicked += (sender, e) => {
                Navigation.PushAsync(new Katas_UI.Kata_i.KataI());
            };
            buttonJ.Clicked += (sender, e) => {
                Navigation.PushAsync(new Katas_UI.Kata_j.KataJ());
            };
            buttonK.Clicked += (sender, e) => {
                Navigation.PushAsync(new Katas_UI.Kata_k.KataK());
            };
            buttonL.Clicked += (sender, e) => {
                Navigation.PushAsync(new Katas_UI.Kata_l.KataL());
            };
            buttonM.Clicked += (sender, e) => {
                Navigation.PushAsync(new Katas_UI.Kata_m.KataM());
            };
            buttonN.Clicked += (sender, e) => {
                Navigation.PushAsync(new Katas_UI.Kata_n.KataNTabbed());
            };
            buttonO.Clicked += (sender, e) => {
                Navigation.PushAsync(new Katas_UI.Kata_o.KataO());
            };
            buttonP.Clicked += (sender, e) => {
                Navigation.PushAsync(new Katas_UI.Kata_p.KataP());
            };
            buttonQ.Clicked += (sender, e) => {
                Navigation.PushAsync(new Katas_UI.Kata_q.KataQ());
            };
            buttonR.Clicked += (sender, e) => {
                Navigation.PushAsync(new Katas_UI.Kata_r.KataR());
            };
            buttonS.Clicked += (sender, e) => {
                Navigation.PushAsync(new Katas_UI.Kata_s.KataS());
            };
            buttonT.Clicked += (sender, e) => {
                Navigation.PushAsync(new Katas_UI.Kata_t.KataT());
            };
            buttonU.Clicked += (sender, e) => {
                Navigation.PushAsync(new Katas_UI.Kata_u.KataU());
            };
            buttonV.Clicked += (sender, e) => {
                Navigation.PushAsync(new Katas_UI.Kata_v.KataV());
            };
            buttonW.Clicked += (sender, e) => {
                Navigation.PushAsync(new Katas_UI.Kata_w.KataW());
            };
            buttonX.Clicked += (sender, e) => {
                Navigation.PushAsync(new Katas_UI.Kata_x.KataX());
            };
            buttonY.Clicked += (sender, e) => {
                Navigation.PushAsync(new Katas_UI.Kata_y.KataY());
            };
            buttonZ.Clicked += (sender, e) => {
                Navigation.PushAsync(new Katas_UI.Kata_z.KataZ());
            };
            buttonLB.Clicked += (sender, e) => {
                Navigation.PushAsync(new Katas_Logic.Kata_LB.KataLB());
            };
            buttonLC.Clicked += (sender, e) => {
                Navigation.PushAsync(new Katas_Logic.Kata_LC.KataLC());
            };
            buttonLF.Clicked += (sender, e) => {
                Navigation.PushAsync(new Katas_Logic.Kata_LF.KataLF());
            };
        }
	}
}