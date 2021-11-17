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
    public partial class Exercício03 : ContentPage
    {
        public int Numero { get; set; }

        public Exercício03()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Numero = Convert.ToInt32(NumeroTxt.Text);

            if (Numero == 10)
            {
                DisplayAlert("Resposta", "O numero digitado é dez", "OK");
            }
            else
            {
                if (Numero > 10)
                {
                    DisplayAlert("Resposta", "O número digitado é maior que dez", "OK");
                }
                else
                {
                    DisplayAlert("Resposta", "O número digitado é menor que dez", "OK");
                }
            }

            NumeroTxt.Text = "";
        }
    }
}