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
    public partial class MastDetaKataCMaster : ContentPage
    {
        public ListView ListView;

        public MastDetaKataCMaster()
        {
            InitializeComponent();

            BindingContext = new MastDetaKataCMasterViewModel();
            ListView = MenuItemsListView;
        }

        class MastDetaKataCMasterViewModel : INotifyPropertyChanged
        {
            public ObservableCollection<MastDetaKataCMasterMenuItem> MenuItems { get; set; }

            public MastDetaKataCMasterViewModel()
            {
                MenuItems = new ObservableCollection<MastDetaKataCMasterMenuItem>(new[]
                {
                    new MastDetaKataCMasterMenuItem { Id = 0, Title = "ELEMENTO 1", TargetType = typeof(Elemento_1)} ,
                    new MastDetaKataCMasterMenuItem { Id = 1, Title = "ELEMENTO 2", TargetType = typeof(Elemento_2)},
                    new MastDetaKataCMasterMenuItem { Id = 2, Title = "ELEMENTO 3", TargetType = typeof(Elemento_3)},
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