﻿using System;
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
        Button buttonB = new Button();
        Button buttonC = new Button();
        Button buttonD = new Button();
        Button buttonE = new Button();
        Button buttonF = new Button();
        Button buttonG = new Button();
        Button buttonH = new Button();
        Button buttonI = new Button();
        Button buttonJ = new Button();
        Button buttonK = new Button();
        Button buttonL = new Button();
        Button buttonM = new Button();
        Button buttonN = new Button();
        Button buttonO = new Button();
        Button buttonP = new Button();
        Button buttonQ = new Button();
        Button buttonR = new Button();
        Button buttonS = new Button();
        Button buttonT = new Button();
        Button buttonU = new Button();
        Button buttonV = new Button();
        Button buttonW = new Button();
        Button buttonX = new Button();
        Button buttonY = new Button();
        Button buttonZ = new Button();
        public Kata1View ()
		{
			InitializeComponent ();
            buttonB.Clicked += (sender, e) =>
            {
                Navigation.PushAsync(new Katas_UI.Kata_b.KataB());
            };
            buttonC.Clicked += (sender, e) =>
            {
                Navigation.PushAsync(new Katas_UI.Kata_c.KataC());
            };
            buttonD.Clicked += (sender, e) =>
            {
                Navigation.PushAsync(new Katas_UI.Kata_d.KataD());
            };
            buttonE.Clicked += (sender, e) =>
            {
                Navigation.PushAsync(new Katas_UI.Kata_e.KataE());
            };
            buttonF.Clicked += (sender, e) =>
            {
                Navigation.PushAsync(new Katas_UI.Kata_f.KataF());
            };
            buttonG.Clicked += (sender, e) =>
            {
                Navigation.PushAsync(new Katas_UI.Kata_g.KataG());
            };
            buttonH.Clicked += (sender, e) =>
            {
                Navigation.PushAsync(new Katas_UI.Kata_h.KataH());
            };
            buttonI.Clicked += (sender, e) =>
            {
                Navigation.PushAsync(new Katas_UI.Kata_i.KataI());
            };
            buttonJ.Clicked += (sender, e) =>
            {
                Navigation.PushAsync(new Katas_UI.Kata_j.KataJ());
            };
            buttonK.Clicked += (sender, e) =>
            {
                Navigation.PushAsync(new Katas_UI.Kata_k.KataK());
            };
            buttonL.Clicked += (sender, e) =>
            {
                Navigation.PushAsync(new Katas_UI.Kata_l.KataL());
            };
            buttonM.Clicked += (sender, e) =>
            {
                Navigation.PushAsync(new Katas_UI.Kata_m.KataM());
            };
            buttonN.Clicked += (sender, e) =>
            {
                Navigation.PushAsync(new Katas_UI.Kata_n.KataN());
            };
            buttonO.Clicked += (sender, e) =>
            {
                Navigation.PushAsync(new Katas_UI.Kata_o.KataO());
            };
            buttonP.Clicked += (sender, e) =>
            {
                Navigation.PushAsync(new Katas_UI.Kata_p.KataP());
            };
            buttonQ.Clicked += (sender, e) =>
            {
                Navigation.PushAsync(new Katas_UI.Kata_q.KataQ());
            };
            buttonR.Clicked += (sender, e) =>
            {
                Navigation.PushAsync(new Katas_UI.Kata_r.KataR());
            };
            buttonS.Clicked += (sender, e) =>
            {
                Navigation.PushAsync(new Katas_UI.Kata_s.KataS());
            };
            buttonT.Clicked += (sender, e) =>
            {
                Navigation.PushAsync(new Katas_UI.Kata_t.KataT());
            };
            buttonU.Clicked += (sender, e) =>
            {
                Navigation.PushAsync(new Katas_UI.Kata_u.KataU());
            };
            buttonV.Clicked += (sender, e) =>
            {
                Navigation.PushAsync(new Katas_UI.Kata_v.KataV());
            };
            buttonW.Clicked += (sender, e) =>
            {
                Navigation.PushAsync(new Katas_UI.Kata_w.KataW());
            };
            buttonX.Clicked += (sender, e) =>
            {
                Navigation.PushAsync(new Katas_UI.Kata_x.KataX());
            };
            buttonY.Clicked += (sender, e) =>
            {
                Navigation.PushAsync(new Katas_UI.Kata_y.KataY());
            };
            buttonZ.Clicked += (sender, e) =>
            {
                Navigation.PushAsync(new Katas_UI.Kata_z.KataZ());
            };
        }
	}
}