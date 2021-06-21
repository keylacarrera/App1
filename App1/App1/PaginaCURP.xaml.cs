using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App1
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PaginaCURP : ContentPage
    {
        public PaginaCURP()
        {
            InitializeComponent();
            btnAtras.Clicked += (sender, e) =>
            {
                Navigation.PushAsync(new MainPage());
            };
        }

        async void btnCURP_Clicked(object sender, EventArgs e)
        {
            if (txtNombre.Text != "" && txtPapellido.Text != "" && txtMapellido.Text != "" && txtFecha.Text != "" && txtSexo.Text != "" && txtEntFed.Text != "")
            {
                string CURP = "";

                bool respuesta = await DisplayAlert("GENERAR CURP:", "¿TUS DATOS SON CORRECTOS?", "SI, CONTINUAR", "NO, CORREGIR");
                Console.WriteLine("Respuesta" + respuesta);
                if (respuesta == true)
                {
                    //SE CONVIERTEN A MAYUSCULAS LOS DATOS DE LAS CAJAS DE TEXTO
                    txtPapellido.Text = txtPapellido.Text.ToUpper();
                    txtMapellido.Text = txtMapellido.Text.ToUpper();
                    txtNombre.Text = txtNombre.Text.ToUpper();
                    //SE VAN ACUMULANDO LAS CADENAS EN LA VARIABLE STRING DECLARADA RFC
                    CURP += txtPapellido.Text.Substring(0, 1);
                    CURP += txtPapellido.Text.Substring(1, 1);
                    CURP += txtMapellido.Text.Substring(0, 1);
                    CURP += txtNombre.Text.Substring(0, 1);
                    CURP += txtFecha.Text.Substring(8, 2);//AÑO
                    CURP += txtFecha.Text.Substring(3, 2);//MES
                    CURP += txtFecha.Text.Substring(0, 2);//DIA
                    CURP += txtSexo.Text;
                    CURP += txtEntFed.Text;
                    //consonantes
                    CURP += txtPapellido.Text.Substring(2, 1);
                    CURP += txtMapellido.Text.Substring(1, 1);
                    CURP += txtNombre.Text.Substring(2, 1);
                }
                //SE MUESTRA EN EL LABEL LA CADENA RFC
                lblMuestraCURP.Text = CURP + "09";
            }
            else { lblMuestraCURP.Text = "DEBE LLENAR LOS DATOS SOLICITADOS."; }
        }

        private void btnLimpiar_Clicked(object sender, EventArgs e)
        {
            txtNombre.Text = "";
            txtMapellido.Text = "";
            txtPapellido.Text = "";
            txtFecha.Text = "";
            lblMuestraCURP.Text = "";
            txtEntFed.Text = "";
            txtSexo.Text = "";
        }
    }
}