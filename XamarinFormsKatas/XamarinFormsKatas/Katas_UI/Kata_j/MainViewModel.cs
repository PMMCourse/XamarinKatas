using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace XamarinFormsKatas.Katas_UI.Kata_j
{
    public class MainViewModel: BindableObject
    {
        private Command _loginCommand;
        public ICommand loginCommand => _loginCommand;

        private string _usuario;
        private string _contraseña;
        public MainViewModel() {
            _loginCommand = new Command(PerformLogin);
        }

        private void PerformLogin()
        {
            if (usuario=="" | contraseña=="") {
                
            }
        }

        public string usuario
        {
            get => _usuario;
            set
            {
                OnPropertyChanged();
                _usuario = value;
            }
        }

        public string contraseña
        {
            get => _contraseña;
            set
            {
                OnPropertyChanged();
                _contraseña = value;
            }
        }
    }
}
