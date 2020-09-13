﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace MiCalculadora
{
    public partial class FormCalculadora : Form
    {
        public FormCalculadora()
        {
            InitializeComponent();

            this.Text = "Calculadora de Agustin Gaitan del curso 2°A";


        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();

        }

        private void btnConvertirABinario_Click(object sender, EventArgs e)
        {
            Numero obj = new Numero();

            if (this.lblResultado.Text != "Valor inválido.")
            {
                this.lblResultado.Text = obj.DecimalBinario(double.Parse(this.lblResultado.Text));
            }
            else
            {
                this.lblResultado.Text = "Valor inválido.";
            }
                
            
        }

        private void btnConvertirADecimal_Click(object sender, EventArgs e)
        {
            Numero obj = new Numero();


            if (this.lblResultado.Text != "Valor inválido.")
            {
                this.lblResultado.Text = obj.BinarioDecimal(this.lblResultado.Text);
            } 
            else
            {
                this.lblResultado.Text = "Valor inválido.";
            }
            
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void btnOperar_Click(object sender, EventArgs e)
        {
            string numero1 = txtNumero1.Text;
            string numero2 = txtNumero2.Text;
            string operador = cmbOperador.Text;
            double resultado = 0;

             resultado =  this.Operar(numero1, numero2,operador);

            lblResultado.Text = resultado.ToString();
        }

        private void Limpiar()
        {

            this.txtNumero1.Text = "";
            this.txtNumero2.Text = "";
            this.cmbOperador.Text = "";
            this.lblResultado.Text = "";

        }
        
        private double Operar(string numero1, string numero2, string operador)
        {
            double resultado = 0;

            Numero primerParam = new Numero(numero1);
            Numero segundoParam = new Numero(numero2);

            

            resultado = Calculadora.Operar(primerParam, segundoParam, operador);

            return resultado;
        }

    }
}
