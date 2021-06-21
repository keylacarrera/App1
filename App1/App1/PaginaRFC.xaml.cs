using App1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace GeneradorRFC
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PaginaRFC : ContentPage
    {
        public PaginaRFC()
        {
            InitializeComponent();
            btnAtras.Clicked += (sender, e) =>
            {
                Navigation.PushAsync(new MainPage());
            };

        }
        //METODO QUE GENERA EL RFC
        async void GenerarRFC_Clicked(object sender, EventArgs e)
        {
            if (txtNombre.Text != "" && txtPapellido.Text != "" && txtMapellido.Text != "" && txtFecha.Text != "")
            {
                string rfc = "";

                bool respuesta = await DisplayAlert("GENERAR RFC:", "¿TUS DATOS SON CORRECTOS?", "SI, CONTINUAR", "NO, CORREGIR");
                Console.WriteLine("Respuesta" + respuesta);
                if (respuesta == true)
                {
                    //SE CONVIERTEN A MAYUSCULAS LOS DATOS DE LAS CAJAS DE TEXTO
                    txtPapellido.Text = txtPapellido.Text.ToUpper();
                    txtMapellido.Text = txtMapellido.Text.ToUpper();
                    txtNombre.Text = txtNombre.Text.ToUpper();
                    //SE VAN ACUMULANDO LAS CADENAS EN LA VARIABLE STRING DECLARADA RFC
                    rfc += txtPapellido.Text.Substring(0, 1);
                    rfc += txtPapellido.Text.Substring(1, 1);
                    rfc += txtMapellido.Text.Substring(0, 1);
                    rfc += txtNombre.Text.Substring(0, 1);
                    rfc += txtFecha.Text.Substring(8, 2);
                    rfc += txtFecha.Text.Substring(3, 2);
                    rfc += txtFecha.Text.Substring(0, 2);
                }
                //SE MUESTRA EN EL LABEL LA CADENA RFC
                lblMuestraRFC.Text = rfc+"1H0";
            }
            else { lblMuestraRFC.Text = "DEBE LLENAR LOS DATOS SOLICITADOS."; }
        }
        //METODO QUE LIMPIA ENTRADAS
        private void btnLimpiar_Clicked(object sender, EventArgs e)
        {
            txtNombre.Text = "";
            txtMapellido.Text = "";
            txtPapellido.Text = "";
            txtFecha.Text = "";
            lblMuestraRFC.Text = "";
        }
    }
}