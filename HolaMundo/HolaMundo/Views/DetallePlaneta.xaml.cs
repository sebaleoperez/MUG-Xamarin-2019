using System;
using System.Collections.Generic;
using HolaMundo.Services;
using Xamarin.Forms;

namespace HolaMundo.Views
{
    public partial class DetallePlaneta : ContentPage
    {
        public DetallePlaneta(Planeta planeta)
        {
            InitializeComponent();

            nombrePlaneta.Text = planeta.Name;
            diametroPlaneta.Text = planeta.Diameter;
        }
    }
}
