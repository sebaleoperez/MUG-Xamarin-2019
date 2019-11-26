using System;
using HolaMundo.Views.ListView;
using Xamarin.Forms;

namespace HolaMundo.Selector
{
    public class JugadorSelector : DataTemplateSelector
    {
        public DataTemplate ArqueroTemplate { get; set; }
        public DataTemplate DelanteroTemplate { get; set; }

        protected override DataTemplate OnSelectTemplate(object item, BindableObject container)
        {
            Jugador jugador = (Jugador)item;

            if (jugador.Posicion == "Arquero") return ArqueroTemplate;
            else return DelanteroTemplate;
        }
    }
}
