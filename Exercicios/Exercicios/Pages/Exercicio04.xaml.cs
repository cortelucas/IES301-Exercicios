using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Exercicios.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Exercicio04 : ContentPage
    {
        public int Numero { get; set; }

        public Exercicio04()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Numero = Convert.ToInt32(NumeroTxt.Text);

            if (Numero == 0)
            {
                DisplayAlert("Resposta", "O numero digitado é zero", "OK");
            }
            else
            {
                if (Numero > 0)
                {
                    DisplayAlert("Resposta", "O número digitado é positivo", "OK");
                }
                else
                {
                    DisplayAlert("Resposta", "O número digitado é negativo", "OK");
                }
            }

            NumeroTxt.Text = "";
        }
    }
}