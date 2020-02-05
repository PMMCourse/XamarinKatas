﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinFormsKatas.Katas_Logic.Kata_LJ;
using XamarinFormsKatas.Katas_UI.Kata_b;
using XamarinFormsKatas.Katas_UI.Kata_c;

using XamarinFormsKatas.Katas_UI.Kata_g;
using XamarinFormsKatas.Katas_UI.Kata_h;
using XamarinFormsKatas.Katas_UI.Kata_i;
using XamarinFormsKatas.Katas_UI.Kata_j;
using XamarinFormsKatas.Katas_UI.Kata_m;
using XamarinFormsKatas.Katas_UI.Kata_r;
using XamarinFormsKatas.Katas_UI.Kata_s;
using XamarinFormsKatas.Katas_UI.Kata_t;
using XamarinFormsKatas.Katas_UI.Kata_v;

namespace XamarinFormsKatas.Katas.Kata1
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Kata1View : ContentPage
	{
		public Kata1View ()
		{
			InitializeComponent ();
            ButB.Clicked += (sender, e) =>
            {
                Navigation.PushAsync(new KataB());
            };
            ButC.Clicked += (sender, e) =>
            {
                Navigation.PushAsync(new MasterDetailPage1());
            };
            
            ButG.Clicked += (sender, e) =>
            {
                Navigation.PushAsync(new KataG());
            };
            ButH.Clicked += (sender, e) =>
            {
                Navigation.PushAsync(new KataH());
            };
            ButI.Clicked += (sender, e) =>
            {
                Navigation.PushAsync(new KataI());
            };
            ButJ.Clicked += (sender, e) =>
            {
                Navigation.PushAsync(new KataJ());
            };
            ButV.Clicked += (sender, e) =>
            {
                Navigation.PushAsync(new KataV());
            };
            ButS.Clicked += (sender, e) =>
            {
                Navigation.PushAsync(new KataS());
            };
            ButM.Clicked += (sender, e) =>
            {
                Navigation.PushAsync(new KataM());
            };
            ButR.Clicked += (sender, e) =>
            {
                Navigation.PushAsync(new KataR());
            };
            ButT.Clicked += (sender, e) =>
            {
                Navigation.PushAsync(new KataT());
            };
            ButLJ.Clicked += (sender, e) =>
            {
                Navigation.PushAsync(new Kata_LJ());
            };
        }
    }
}