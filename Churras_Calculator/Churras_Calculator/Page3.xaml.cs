using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Churras_Calculator
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Page3 : ContentPage
	{
        Valores v1 = new Valores();

        public Page3 (Valores v)
		{
			InitializeComponent ();

            if (v.qt_alcatra == 0)
            {
                lbl_alcatra.IsEnabled = false;
                lbl_alcatra.Text = "0";
            }
            else
            {
                lbl_alcatra.Text = String.Format("{0:0.00}", v.qt_alcatra);
            }
            //--
            if (v.qt_picanha == 0)
            {
                lbl_picanha.IsEnabled = false;
                lbl_picanha.Text = "0";
            }
            else
            {
                lbl_picanha.Text = String.Format("{0:0.00}", v.qt_picanha);
            }
            //--
            if (v.qt_cfile == 0)
            {
                lbl_cfile.IsEnabled = false;
                lbl_cfile.Text = "0";
            }
            else
            {
                lbl_cfile.Text = String.Format("{0:0.00}", v.qt_cfile);
            }
            //------------------------
            if (v.qt_liguica == 0)
            {
                lbl_linguica.IsEnabled = false;
                lbl_linguica.Text = "0";
            }
            else
            {
                lbl_linguica.Text = String.Format("{0:0.00}", v.qt_liguica);
            }
            //--
            if (v.qt_bisteca == 0)
            {
                lbl_bisteca.IsEnabled = false;
                lbl_bisteca.Text = "0";
            }
            else
            {
                lbl_bisteca.Text = String.Format("{0:0.00}", v.qt_bisteca);
            }
            //------------------------
            if (v.qt_asa == 0)
            {
                lbl_asa.IsEnabled = false;
                lbl_asa.Text = "0";
            }
            else
            {
                lbl_asa.Text = String.Format("{0:0.00}", v.qt_asa);
            }
            //--
            if (v.qt_coxa == 0)
            {
                lbl_coxa.IsEnabled = false;
                lbl_coxa.Text = "0";
            }
            else
            {
                lbl_coxa.Text = String.Format("{0:0.00}", v.qt_coxa);
            }
            //------------------------------------------
            if (v.qt_garrafas_refrigerante == 0)
            {
                lbl_refrigerante.IsEnabled = false;
                lbl_refrigerante.Text = "0";
            }
            else
            {
                lbl_refrigerante.Text = v.qt_garrafas_refrigerante.ToString();
            }
            //--
            if (v.qt_latas_cerveja == 0)
            {
                lbl_cerveja.IsEnabled = false;
                lbl_cerveja.Text = "0";
            }
            else
            {
                lbl_cerveja.Text = String.Format("{0}", v.qt_latas_cerveja);
            }
            //----------------------------------

            lbl_totcarnes.Text = String.Format("{0:0.00}", (double.Parse(lbl_alcatra.Text) + double.Parse(lbl_picanha.Text) + double.Parse(lbl_cfile.Text) + double.Parse(lbl_linguica.Text) + double.Parse(lbl_bisteca.Text) + double.Parse(lbl_asa.Text) + double.Parse(lbl_coxa.Text)).ToString()) + "KG";
            v.qt_litros_cerveja /= 1000;
            lbl_totbebidas.Text = String.Format("{0:0.0}", (v.qt_litros_cerveja + v.qt_litros_refrigerante)) + "L";
            lbl_totcarvao.Text = String.Format("{0:0.00}", v.tot_carvao) + "KG";
            decimal aux = decimal.Parse(v.tot_carvao.ToString()) / 5;
            lbl_carvao.Text = Math.Ceiling(aux).ToString();
            v.tot_carvao /= 5;
            v1 = v;
            //Carne.Text = "";

        }
        void ChamarResultado(object sender, EventArgs args)
        {
            v1.qt_alcatra = double.Parse(lbl_alcatra.Text);
            v1.qt_picanha = double.Parse(lbl_picanha.Text);
            v1.qt_cfile = double.Parse(lbl_cfile.Text);

            v1.qt_liguica = double.Parse(lbl_linguica.Text);
            v1.qt_bisteca = double.Parse(lbl_bisteca.Text);

            v1.qt_asa = double.Parse(lbl_asa.Text);
            v1.qt_coxa = double.Parse(lbl_coxa.Text);

            v1.tot_carvao = double.Parse(lbl_carvao.Text);

            v1.qt_latas_cerveja = double.Parse(lbl_cerveja.Text);
            v1.qt_latas_cerveja = double.Parse(lbl_cerveja.Text);

            v1.fazerCalculos();

            Navigation.PushModalAsync(new PageResultado(v1));
        }
    }
}