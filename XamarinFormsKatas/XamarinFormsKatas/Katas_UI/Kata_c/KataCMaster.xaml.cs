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
    public partial class KataCMaster : ContentPage
    {
        public ListView ListView;

        public KataCMaster()
        {
            InitializeComponent();

            BindingContext = new KataCMasterViewModel();
            ListView = MenuItemsListView;
        }

        class KataCMasterViewModel : INotifyPropertyChanged
        {
            public ObservableCollection<KataCMasterMenuItem> MenuItems { get; set; }

            public KataCMasterViewModel()
            {
                MenuItems = new ObservableCollection<KataCMasterMenuItem>(new[]
                {
                    new KataCMasterMenuItem { Id = 0, Title = "Opcion 1", TargetType = typeof(Opcion1)},
                    new KataCMasterMenuItem { Id = 1, Title = "Opcion 2", TargetType = typeof(Opcion2) },
                    new KataCMasterMenuItem { Id = 2, Title = "Opcion 3", TargetType = typeof(Opcion3) },
                    new KataCMasterMenuItem { Id = 3, Title = "Opcion 4", TargetType = typeof(Opcion4) },
                    new KataCMasterMenuItem { Id = 4, Title = "Opcion 5", TargetType = typeof(Opcion5) },
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