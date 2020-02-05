using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinFormsKatas.Katas_UI.Kata_c
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MasterDetailKC : MasterDetailPage
    {
        public MasterDetailKC()
        {
            InitializeComponent();
            MasterDetailPageMaster = new MasterDetailPageMaster();
            MasterDetailPageDetail = new NavigationPage(new MasterDetailPageDetail());

            App.MasterDetail = this;
        }

    }
}