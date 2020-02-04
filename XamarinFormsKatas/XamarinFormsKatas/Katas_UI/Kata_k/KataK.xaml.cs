using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinFormsKatas.Katas_UI.Kata_k
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class KataK : ContentPage
	{
        ObservableCollection<string> RefreshList = new ObservableCollection<string>();

        public KataK ()
		{
			InitializeComponent ();
            ListaRefresh.RefreshCommand = new Command(() =>
            {
                ListaRefresh.IsRefreshing = true;
                ListaRefresh.ItemsSource = RefreshList;
                ListaRefresh.IsRefreshing = false;
            });

            BtnRefresh.Clicked += (sender, e) =>
            {
                if (EntryRefresh.Text != null && EntryRefresh.Text != "")
                {
                    RefreshList.Add(EntryRefresh.Text);
                }
            };
        }
	}
}