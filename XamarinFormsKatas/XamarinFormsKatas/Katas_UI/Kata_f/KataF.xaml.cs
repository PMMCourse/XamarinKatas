﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Internals;
using Xamarin.Forms.Xaml;

namespace XamarinFormsKatas.Katas_UI.Kata_f
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class KataF : ContentPage
	{
        public KataF ()
		{
			InitializeComponent ();
            BindingContext = new MainViewModel();
		}
    }
}