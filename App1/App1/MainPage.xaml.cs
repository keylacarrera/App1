using GeneradorRFC;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App1
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            //AL OPRIMIR EL BOTON btnRFC nos dirigimos a la PaginaRFC mediante un Navigation.PushAsync
            btnRFC.Clicked += (sender, e) =>

            {
               /// Navigation.PushModalAsync(new PaginaRFC());
            };
            //ocurre lo mismo para el boton de Impuesto
            btnImp.Clicked += (sender, e) =>
            {
               //// Navigation.PushAsync(new PaginaImp());
            };
        }

        private void Salir_Clicked(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
        }

        private async void btnImp_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new PaginaImp(),false);
        }

        private async void btnRFC_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new PaginaRFC(), false);
        }

        private async void btnCurp_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new PaginaCURP(), false);
        }
    }
}

