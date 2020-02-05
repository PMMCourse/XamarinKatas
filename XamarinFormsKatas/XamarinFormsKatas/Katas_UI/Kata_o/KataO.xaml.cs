﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinFormsKatas.Katas_UI.Kata_o
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class KataO : ContentPage
	{
		public KataO()
		{
			InitializeComponent();

			this.Disappearing += KataO_Disappearing;
		}

		private void KataO_Disappearing(object sender, EventArgs e)
		{
			Device.BeginInvokeOnMainThread(async () =>
			{
				var decision = await DisplayAlert("¿ESTA SEGURO?", "¿DESEA SALIR DE MI APP?", "si", "no");
				if (decision == true)
				{
					Process.GetCurrentProcess().CloseMainWindow();
				}
			});
		}
	}
}