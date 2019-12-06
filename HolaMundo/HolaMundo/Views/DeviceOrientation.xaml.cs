using System;
using System.Collections.Generic;
using HolaMundo.Interfaces;
using Xamarin.Forms;

namespace HolaMundo.Views
{
    public partial class DeviceOrientation : ContentPage
    {
        public DeviceOrientation()
        {
            InitializeComponent();

        }

        public void ClickBoton(object sender, EventArgs args)
        {
            IDeviceOrientationService orientationService = DependencyService.Get<IDeviceOrientationService>();
            Interfaces.DeviceOrientation orientation = orientationService.GetOrientation();
            lblOrientacion.Text = orientation.ToString();
        }
    }
}
