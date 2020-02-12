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

namespace XamarinFormsKatas.Katas_UI.Kata_c {
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class KataC_DetailMaster : ContentPage {
        public ListView ListView;

        public KataC_DetailMaster() {
            InitializeComponent();

            BindingContext = new KataC_DetailMasterViewModel();
            ListView = MenuItemsListView;
        }

        class KataC_DetailMasterViewModel : INotifyPropertyChanged {
            public ObservableCollection<KataC_DetailMasterMenuItem> MenuItems { get; set; }

            public KataC_DetailMasterViewModel() {
                MenuItems = new ObservableCollection<KataC_DetailMasterMenuItem>(new[] {
                    new KataC_DetailMasterMenuItem { Id = 0, Title = "Page 1", TargetType = typeof(Page1)},
                    new KataC_DetailMasterMenuItem { Id = 1, Title = "Page 2", TargetType = typeof(Page2)},
                    new KataC_DetailMasterMenuItem { Id = 2, Title = "Page 3", TargetType = typeof(Page3)},
                });
            }

            #region INotifyPropertyChanged Implementation
            public event PropertyChangedEventHandler PropertyChanged;
            void OnPropertyChanged([CallerMemberName] string propertyName = "") {
                if (PropertyChanged == null)
                    return;

                PropertyChanged.Invoke(this, new PropertyChangedEventArgs(propertyName));
            }
            #endregion
        }
    }
}