using System;
using System.Collections.Generic;
using System.Text;

namespace Churras_Calculator
{
    public class Valores
    {
        public double qt_picanha = 0;
        public double qt_alcatra = 0;
        public double qt_cfile = 0;

        public double qt_liguica = 0;
        public double qt_bisteca = 0;

        public double qt_asa = 0;
        public double qt_coxa = 0;

        public double qt_latas_cerveja = 0;
        public double qt_garrafas_refrigerante = 0;

        public double qt_litros_cerveja = 0;
        public double qt_litros_refrigerante = 0;

        public double tot_carvao = 0;

        //-------------

        public double preco_picanha = 0;
        public double preco_alcatra = 0;
        public double preco_cfile = 0;

        public double preco_liguica = 0;
        public double preco_bisteca = 0;

        public double preco_asa = 0;
        public double preco_coxa = 0;

        public double preco_latas_cerveja = 0;
        public double preco_garrafas_refrigerante = 0;

        public double preco_carvao = 0;

        //--

        public int qt_pessoas = 0;

        /*
         * CARNES DE BOI PREÇOS *
         * 
         * ALCATRA - 35.50KG
         * PICANHA - 55.60KG
         * C. FILÉ - 27KG
         * 
         * CARNES DE PORCO PREÇOS
         * 
         * LINGUIÇA - 13.98KG
         * BISTECA - 10.83KG
         * 
         * CARNES DE FRANGO PREÇOS
         * 
         * ASA - 13.59KG
         * COXA - 9.50KG
         * 
         * CARVAO PREÇO
         * 
         * CARVÃO 24.90 SACO 5KG
         * 
         * BEBIDAS PREÇO
         * 
         * CERVEJA - 2.20 - LATA
         * REFRIGERANTE - 6.80 GARRAFA 2L
         */


        public double preco_tudo = 0;
        public double preco_pessoa = 0;

        public void fazerCalculos()
        {
            preco_tudo = 0;

            qt_latas_cerveja = Math.Ceiling(qt_latas_cerveja);
            qt_garrafas_refrigerante = Math.Ceiling(qt_garrafas_refrigerante);

            preco_picanha = qt_picanha * 55.60;
            preco_tudo += preco_picanha;

            preco_alcatra = qt_alcatra * 35.50;
            preco_tudo += preco_alcatra;

            preco_cfile = qt_cfile * 27;
            preco_tudo += preco_cfile;

            //----

            preco_liguica = qt_liguica * 14;
            preco_tudo += preco_liguica;

            preco_bisteca = qt_bisteca * 10.85;
            preco_tudo += preco_bisteca;

            //----

            preco_asa = qt_asa * 13.60;
            preco_tudo += preco_asa;

            preco_coxa = qt_coxa * 9.50;
            preco_tudo += preco_coxa;

            //----

            preco_carvao = tot_carvao * 24.90;
            preco_tudo += preco_carvao;

            //---

            qt_latas_cerveja = Math.Ceiling(qt_latas_cerveja);
            preco_latas_cerveja = qt_latas_cerveja * 2.20;
            preco_tudo += preco_latas_cerveja;


            qt_garrafas_refrigerante = Math.Ceiling(qt_garrafas_refrigerante);
            preco_garrafas_refrigerante = qt_garrafas_refrigerante * 6.80;
            preco_tudo += preco_garrafas_refrigerante;

            preco_pessoa = preco_tudo / qt_pessoas;

        }
    }
}
