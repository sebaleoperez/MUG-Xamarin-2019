using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Threading.Tasks;
using System.Windows.Input;
using HolaMundo.Views.ListView;
using Xamarin.Forms;

namespace HolaMundo.ViewModels
{
    public class JugadorViewModel : BaseViewModel
    {
        public ObservableCollection<Jugador> Jugadores { get; set; }
        public string Filtro { get; set; }

        public ICommand FiltrarCommand { get; set; }

        private bool isBusy;
        public bool IsBusy {
            get
            {
                return this.isBusy;
            }
            set
            {
                this.isBusy = value;
                OnPropertyChanged("IsBusy");
            }
        }

        public JugadorViewModel()
        {
            // Cargo datos desde el modelo
            IsBusy = true;
            Jugadores = new ObservableCollection<Jugador>();

            for (int i = 1; i<=3; i++)
            {
                Jugador jugador = new Jugador
                {
                    Nombre = "Lionel Messi " + i,
                    Posicion = "Delantero",
                    Url = "icono1.png"
                };
                Jugadores.Add(jugador);
            }

            FiltrarCommand = new Command(() =>
            {
                ObservableCollection<Jugador> filtrado = new ObservableCollection<Jugador>();

                foreach (Jugador jugador in Jugadores)
                {
                    if (jugador.Nombre.Contains(this.Filtro))
                        filtrado.Add(jugador);
                }

                Jugadores.Clear();
                foreach (Jugador jugador1 in filtrado)
                {
                    Jugadores.Add(jugador1);
                }

                OnPropertyChanged("Jugadores");
                IsBusy = false;
            });

            IsBusy = false;
        }

        public void Guardar()
        {
            // Aca me comunicaria con el modelo para persistir
        }
    }
}
