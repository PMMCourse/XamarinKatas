using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinFormsKatas.Katas_UI.Kata_c
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MasterDetailPageMaster : ContentPage
    {
        public ListView ListView;
        public MasterDetailPageMaster()
        {
            InitializeComponent();
            BindingContext = new MasterDetailPage1MasterViewModel();
            ListView = OptionsListView;
        }

        class MasterDetailPage1MasterViewModel : INotifyPropertyChanged
        {
            public ObservableCollection<MasterDetailKataItem> Options { get; set; }

            public MasterDetailPage1MasterViewModel()
            {
                Options = new ObservableCollection<MasterDetailKataItem>(new[]
                {
                    new MasterDetailKataItem { Id = 0, Title = "Vista 1", TargetType = typeof(View1)},
                    new MasterDetailKataItem { Id = 1, Title = "Vista 2", TargetType = typeof(View2)},
                    new MasterDetailKataItem { Id = 2, Title = "Vista 3", TargetType = typeof(View3)},
                });
            }

            INotifyPropertyChanged Implementation;
            public event PropertyChangedEventHandler PropertyChanged;
            void OnPropertyChanged([CallerMemberName] string propertyName = "")
            {
                if (PropertyChanged == null)
                    return;

                PropertyChanged.Invoke(this, new PropertyChangedEventArgs(propertyName));
            }

        }
    }
}
    