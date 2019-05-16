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
    public partial class Page2 : ContentPage
    {

        public Page2()
        {
            InitializeComponent();
        }

        Valores v = new Valores();

        public void cervejas(object sender, EventArgs args)
        {
            if (cerveja.IsToggled)
            {
                qt_pessoas.IsEnabled = true;
            }
            else
            {
                qt_pessoas.IsEnabled = false;
                qt_pessoas.Text = "0";
            }
        }

        public void pessoaCerveja(object sender, EventArgs args)
        {
            if (qt_pessoas.Text == "0")
            {
                qt_pessoas.Text = "";
            }
        }

        public void pessoaCerveja2(object sender, EventArgs args)
        {
            if (qt_pessoas.Text == "")
            {
                qt_pessoas.Text = "0";
            }
        }

        public void entryCrianca2(object sender, EventArgs args)
        {
            if (crianca.Text == "")
            {
                crianca.Text = "0";
            }
        }

        public void entryCrianca(object sender, EventArgs args)
        {
            if(crianca.Text == "0")
            {
                crianca.Text = "";
            }
           
        }

        public void entryMulher(object sender, EventArgs args)
        {
            if (mulher.Text == "0")
            {
                mulher.Text = "";
            }
        }

        public void entryMulher2(object sender, EventArgs args)
        {
            if (mulher.Text == "")
            {
                mulher.Text = "0";
            }
        }

        public void entryHomem(object sender, EventArgs args)
        {
            if (homem.Text == "0")
            {
                homem.Text = "";
            }
        }

        public void entryHomem2(object sender, EventArgs args)
        {
            if (homem.Text == "")
            {
                homem.Text = "0";
            }
        }

        void InfoBois(object sender, EventArgs args)
        {
            DisplayAlert("Preço", "ALCATRA - R$ 35.50/Kg\n\nPICANHA - R$ 55.60/KG\n\nC.FILÉ - R$ 27/KG", "OK");
        }

        void InfoPorcos(object sender, EventArgs args)
        {
            DisplayAlert("Preço", "LINGUIÇA - R$ 13.98/KG\n\nBISTECA - R$ 10.83/KG", "OK");
        }

        void InfoFrango(object sender, EventArgs args)
        {
            DisplayAlert("Preço", "ASA - R$ 13.59/KG\n\nCOXA - R$ 9.50/KG", "OK");
        }

        void ChamarPagina3(object sender, EventArgs args)
        {
            int qt_alimento = 0;
            int qt_boi = 0;
            int qt_frango = 0;
            int qt_porco = 0;

            bool boi = false;
            bool porco = false;
            bool frango = false;

            bool carne_alcatra = false;
            bool carne_picanha = false;
            bool carne_contrafile = false;

            bool carne_linguica = false;
            bool carne_bisteca = false;

            bool carne_asa = false;
            bool carne_coxa = false;

            if (alcatra.IsToggled || picanha.IsToggled || contrafile.IsToggled)
            {
                qt_alimento++;
                boi = true;
                if (alcatra.IsToggled)
                {
                    carne_alcatra = true;
                    qt_boi++;
                }
                if (picanha.IsToggled)
                {
                    carne_picanha = true;
                    qt_boi++;
                }
                if (contrafile.IsToggled)
                {
                    carne_contrafile = true;
                    qt_boi++;
                }
            }

            if (linguica.IsToggled || bisteca.IsToggled)
            {
                porco = true;
                qt_alimento++;
                if (linguica.IsToggled)
                {
                    qt_porco++;
                    carne_linguica = true;
                }
                if (bisteca.IsToggled)
                {
                    qt_porco++;
                    carne_bisteca = true;
                }
                
            }

            if (asa.IsToggled || coxa.IsToggled)
            {
                qt_alimento++;
                frango = true;
                if (asa.IsToggled)
                {
                    qt_frango++;
                    carne_asa = true;
                }
                if (coxa.IsToggled)
                {
                    qt_frango++;
                    carne_coxa = true;
                }
            }

            if (refrigerante.IsToggled || cerveja.IsToggled)
            {
                if (refrigerante.IsToggled)
                {
                    decimal aux = ((((Int32.Parse(homem.Text) + Int32.Parse(mulher.Text) + Int32.Parse(crianca.Text)) - Int32.Parse(qt_pessoas.Text)) * 800) / 1000) / 2;
                    v.qt_garrafas_refrigerante = double.Parse(Math.Ceiling(aux).ToString());
                    v.qt_litros_refrigerante = v.qt_garrafas_refrigerante * 2;

                }

                if (cerveja.IsToggled)
                {
                    v.qt_litros_cerveja = Int32.Parse(qt_pessoas.Text) * 1700;
                    v.qt_latas_cerveja = v.qt_litros_cerveja / 600;
                    v.qt_latas_cerveja = Math.Ceiling(v.qt_latas_cerveja);


                }
            }

            if (homem.Text != "0" || mulher.Text != "0" || crianca.Text != "0")
            {
                double kg_carnes = (Int32.Parse(homem.Text) * 500 + Int32.Parse(mulher.Text) * 400 + Int32.Parse(crianca.Text) * 300) / 1000;
                double kg_cada_tipo = kg_carnes / qt_alimento;
                v.qt_pessoas = Int32.Parse(homem.Text) + Int32.Parse(mulher.Text) + Int32.Parse(crianca.Text);

                if (boi)
                {
                    if (carne_alcatra)
                    {
                        v.qt_alcatra = kg_cada_tipo / qt_boi;
                        v.qt_alcatra += 0.5;
                    }
                    if (carne_picanha)
                    {
                        v.qt_picanha = kg_cada_tipo / qt_boi;
                        v.qt_picanha += 0.5;
                    }
                    if (carne_contrafile)
                    {
                        v.qt_cfile = kg_cada_tipo / qt_boi;
                        v.qt_cfile += 0.5;
                    }
                }

                if (porco)
                {
                    if (carne_linguica)
                    {
                        v.qt_liguica = kg_cada_tipo / qt_porco;
                        v.qt_liguica += 0.5;
                    }
                    if (carne_bisteca)
                    {
                        v.qt_bisteca = kg_cada_tipo / qt_porco;
                        v.qt_bisteca += 0.5;
                    }
                }

                if (frango)
                {
                    if (carne_asa)
                    {
                        v.qt_asa = kg_cada_tipo / qt_frango;
                        v.qt_asa += 0.5;
                    }
                    if (carne_coxa)
                    {
                        v.qt_coxa = kg_cada_tipo / qt_frango;
                        v.qt_coxa += 0.5;
                    }
                }
                v.tot_carvao = kg_carnes * 1.5;
            }

            if (boi == false && frango == false && porco == false)
            {
                DisplayAlert("AVISO!", "Você não pode fazer um churrasco sem nenhuma carne, escolha alguma amigo.", "Entendi!");
            }
            else if (homem.Text == "0" && mulher.Text == "0" && crianca.Text == "0")
            {
                DisplayAlert("AVISO!", "O número de pessoas pro seu churrasco não pode ser 0 amigo.", "Entendi!");
            }
            else if (Int32.Parse(qt_pessoas.Text) > Int32.Parse(homem.Text) + Int32.Parse(mulher.Text) + Int32.Parse(crianca.Text))
            {
                DisplayAlert("AVISO!", "Como existem mais pessoas que bebem do que pessoas presentes na festa?!", "Entendi");
            }
            else
            {
                Navigation.PushAsync(new Page3(v));
            }


        }

        private void Crianca_Focused(object sender, FocusEventArgs e)
        {

        }

        private void Crianca_Unfocused(object sender, FocusEventArgs e)
        {

        }
    }
}