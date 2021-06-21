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
    public partial class PaginaImp : ContentPage
    {
        public PaginaImp()
        {
            InitializeComponent();
            //AL OPRIMIR EL BOTO ATRAS NOS DIRIGIMOS A LA PAGINA PRINCIPAL
            btnAtras.Clicked += (sender, e) =>
            {
              // Navigation.PushAsync(new MainPage());
            };

        }
        //METODO PARA CALCULAR EL IMPUESTO MENSUAL
        private void ImpuestoMensual_Clicked(object sender, EventArgs e)
        {
            double impuestoMen;
            double couta_fija;
            double exc_lim_inf;

            if (txtSueldo.Text != "")
            {
                double utilidad = Convert.ToDouble(txtSueldo.Text) - Convert.ToDouble(txtGasto.Text);
                //RANGOS EN LOS QUE SE COMPARA LA UTILIDAD
                if (utilidad >= 0.01 && utilidad <= 496.07)
                {
                    //VALORES DEFINIDOS POR LA TABLA DEL SAT
                    couta_fija = 0;
                    exc_lim_inf = 1.92;
                    impuestoMen = (utilidad - 0.01) * (exc_lim_inf / 100) + couta_fija;
                    //SE MUESTRA EN EL LABEL CANTIDAD EL IMPUESTO
                    //lblCantidad.Text = lblCantidad.Text + Convert.ToString(impuestoMen);
                    lblCantidad.Text = Convert.ToString(impuestoMen);

                }
                if (utilidad >= 496.08 && utilidad <= 4210.41)
                {
                    couta_fija = 9.52;
                    exc_lim_inf = 6.4;
                    impuestoMen = (utilidad - 496.08) * (exc_lim_inf / 100) + couta_fija;
                    //lblCantidad.Text = lblCantidad.Text + Convert.ToString(impuestoMen);
                    lblCantidad.Text = Convert.ToString(impuestoMen);
                }
                if (utilidad >= 4210.42 && utilidad <= 7399.42)
                {
                    couta_fija = 247.23;
                    exc_lim_inf = 10.88;
                    impuestoMen = (utilidad - 4210.42) * (exc_lim_inf / 100) + couta_fija;
                    //lblCantidad.Text = lblCantidad.Text + Convert.ToString(impuestoMen);
                    lblCantidad.Text = Convert.ToString(impuestoMen);

                }
                if (utilidad >= 7399.43 && utilidad <= 8601.5)
                {
                    couta_fija = 594.24;
                    exc_lim_inf = 16;
                    impuestoMen = (utilidad - 7399.43) * (exc_lim_inf / 100) + couta_fija;
                    //lblCantidad.Text = lblCantidad.Text + Convert.ToString(impuestoMen);
                    lblCantidad.Text = Convert.ToString(impuestoMen);
                }
                if (utilidad >= 8601.51 && utilidad <= 10298.35)
                {
                    couta_fija = 786.55;
                    exc_lim_inf = 17.92;
                    impuestoMen = (utilidad - 8601.51) * (exc_lim_inf / 100) + couta_fija;
                    // lblCantidad.Text = lblCantidad.Text + Convert.ToString(impuestoMen);
                    lblCantidad.Text = Convert.ToString(impuestoMen);
                }
                if (utilidad >= 10298.36 && utilidad <= 20770.29)
                {
                    couta_fija = 1090.62;
                    exc_lim_inf = 21.36;
                    impuestoMen = (utilidad - 10298.36) * (exc_lim_inf / 100) + couta_fija;
                    //lblCantidad.Text = lblCantidad.Text + Convert.ToString(impuestoMen);
                    lblCantidad.Text = Convert.ToString(impuestoMen);
                }
                if (utilidad >= 20770.3 && utilidad <= 32736.83)
                {
                    couta_fija = 3327.42;
                    exc_lim_inf = 23.52;
                    impuestoMen = (utilidad - 20770.3) * (exc_lim_inf / 100) + couta_fija;
                    // lblCantidad.Text = lblCantidad.Text + Convert.ToString(impuestoMen);
                    lblCantidad.Text = Convert.ToString(impuestoMen);
                }
                if (utilidad >= 32736.84)
                {
                    couta_fija = 6141.95;
                    exc_lim_inf = 30;
                    impuestoMen = (utilidad - 32736.84) * (exc_lim_inf / 100) + couta_fija;
                    //lblCantidad.Text = lblCantidad.Text + Convert.ToString(impuestoMen);
                    lblCantidad.Text = Convert.ToString(impuestoMen);
                }
            }
            else { lblCantidad.Text = "DEBE INGRESAR UN SUELDO."; }
            
        }
        //METODO QUE LIMPIA ENTRADAS
        private void btnLimpiar_Clicked(object sender, EventArgs e)
        {
            txtSueldo.Text = "";
            txtGasto.Text = "";
            lblCantidad.Text = "";
        }

        private async void btnAtras_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MainPage());
        }
    }
}