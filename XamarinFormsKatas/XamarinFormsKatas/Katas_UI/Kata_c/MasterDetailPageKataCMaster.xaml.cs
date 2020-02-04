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
    public partial class MasterDetailPageKataCMaster : ContentPage
    {
        public ListView ListView;

        public MasterDetailPageKataCMaster()
        {
            InitializeComponent();

            BindingContext = new MasterDetailPageKataCMasterViewModel();
            ListView = MenuItemsListView;
        }

        class MasterDetailPageKataCMasterViewModel : INotifyPropertyChanged
        {
            public ObservableCollection<MasterDetailPageKataCMasterMenuItem> MenuItems { get; set; }

            public MasterDetailPageKataCMasterViewModel()
            {
                MenuItems = new ObservableCollection<MasterDetailPageKataCMasterMenuItem>(new[]
                {
                    new MasterDetailPageKataCMasterMenuItem { Id = 0, Title = "Elemento 1", TargetType= typeof(Elemento1) },
                    new MasterDetailPageKataCMasterMenuItem { Id = 1, Title = "Elemento 2", TargetType= typeof(Elemento2) },
                    new MasterDetailPageKataCMasterMenuItem { Id = 2, Title = "Elemento 3", TargetType= typeof(Elemento3) },
                });
            }

            #region INotifyPropertyChanged Implementation
            public event PropertyChangedEventHandler PropertyChanged;
            void OnPropertyChanged([CallerMemberName] string propertyName = "")
            {
                if (PropertyChanged == null)
                    return;

                PropertyChanged.Invoke(this, new PropertyChangedEventArgs(propertyName));
            }
            #endregion
        }
    }
}