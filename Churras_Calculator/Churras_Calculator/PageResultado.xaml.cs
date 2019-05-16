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
	public partial class PageResultado : ContentPage
	{
        public PageResultado (Valores v)
		{
			InitializeComponent ();

            lbl_kg_alcatra.Text = String.Format("{0:0.00}", v.qt_alcatra) + "KG";
            lbl_pr_alcatra.Text = "R$" + String.Format("{0:0.00}", v.preco_alcatra);

            lbl_kg_picanha.Text = String.Format("{0:0.00}", v.qt_picanha) + "KG";
            lbl_pr_picanha.Text = "R$" + String.Format("{0:0.00}", v.preco_picanha);

            lbl_kg_cfile.Text = String.Format("{0:0.00}", v.qt_cfile) + "KG";
            lbl_pr_cfile.Text = "R$" + String.Format("{0:0.00}", v.preco_cfile);

            //--

            lbl_kg_linguica.Text = String.Format("{0:0.00}", v.qt_liguica) + "KG";
            lbl_pr_linguica.Text = "R$" + String.Format("{0:0.00}", v.preco_liguica);

            lbl_kg_bisteca.Text = String.Format("{0:0.00}", v.qt_bisteca) + "KG";
            lbl_pr_bisteca.Text = "R$" + String.Format("{0:0.00}", v.preco_bisteca);

            //-- 

            lbl_kg_asa.Text = v.qt_asa.ToString() + "KG";
            lbl_pr_asa.Text = "R$" + String.Format("{0:0.00}", v.preco_asa);

            lbl_kg_coxa.Text = String.Format("{0:0.00}", v.qt_coxa) + "KG";
            lbl_pr_coxa.Text = "R$" + String.Format("{0:0.00}", v.preco_coxa);

            //--

            lbl_pr_carvao.Text = "R$" + String.Format("{0:0.00}", v.preco_carvao);
            lbl_kg_carvao.Text = v.tot_carvao.ToString() + " SACOS";

            //--

            lbl_kg_refrigerante.Text = String.Format("{0:0}", v.qt_garrafas_refrigerante) + " GARRAFAS";
            lbl_pr_refrigerante.Text = "R$" + String.Format("{0:0.00}", v.preco_garrafas_refrigerante);

            lbl_kg_cerveja.Text = String.Format("{0:0}", v.qt_latas_cerveja) + " LATAS";
            lbl_pr_cerveja.Text = "R$" + String.Format("{0:0.00}", v.preco_latas_cerveja);

            lbl_preco_total.Text = "R$" + String.Format("{0:0.00}", v.preco_tudo);
            lbl_preco_pessoa.Text = "R$" + String.Format("{0:0.00}", v.preco_pessoa);

            var sboi = v.preco_alcatra + v.preco_picanha + v.preco_cfile;
            var sporco = v.preco_bisteca + v.preco_liguica;
            var sfrango = v.preco_asa + v.preco_coxa;
            var sbebs = v.preco_garrafas_refrigerante + v.preco_latas_cerveja;

            Carne.Text = "R$" + String.Format("{0:0.00}", sboi);
            Porco.Text = "R$" + String.Format("{0:0.00}", sporco);
            Frango.Text = "R$" + String.Format("{0:0.00}", sfrango);
            Bebidas.Text = "R$" + String.Format("{0:0.00}", sbebs);
        }

        private void FecharResultado(object sender, EventArgs args)
        {
            Navigation.PopModalAsync();
        }
	}
}