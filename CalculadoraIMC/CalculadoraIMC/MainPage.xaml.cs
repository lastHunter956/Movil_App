using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace CalculadoraIMC
{
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(Peso.Text) && !string.IsNullOrEmpty(Altura.Text))
            {
                var altura = double.Parse(Altura.Text);
                var peso = double.Parse(Peso.Text);

                var imc = peso / (altura * altura);
                IMC.Text = imc.ToString();

                string resultado = "";
                if (imc < 18.5)
                {
                    resultado = "Estas bajo de paso, procura comer mas";
                }
                else if (imc >= 18.5 && imc <= 24.9)
                {
                    resultado = "Estas en tu peso ideal";
                }
                else if (imc >= 25 && imc <= 29.9)
                {
                    resultado = "Estas con sobrepeso";
                }
                else if (imc >= 30 && imc <= 34.9)
                {
                    resultado = "Estas con obesidad grado 1";
                }
                else if (imc >= 35 && imc <= 39.9)
                {
                    resultado = "Estas con obesidad grado 2";
                }
                else if (imc >= 40)
                {
                    resultado = "Estas con obesidad grado 3";
                }
                else if (imc < 0)
                {
                    resultado = "Ingresa un valor valido";
                }
                else resultado = "";
                DisplayAlert("Resultado", resultado, "OK");
            }
            else
            {
                DisplayAlert("Error", "Ingresa un valor valido", "OK");//cuando no dijita
            }
        }
        
        }
}
