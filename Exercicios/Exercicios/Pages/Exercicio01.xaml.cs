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
    public partial class Exercicio01 : ContentPage
    {
        public double Valor { get; set; }
        public double Preco { get; set; }
        public double Troco { get; set; }

        public Exercicio01()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Valor = Convert.ToDouble(ValorTxt.Text);
            Preco = Convert.ToDouble(PrecoTxt.Text);

            if (Valor >= Preco)
            {
                Troco = Valor - Preco;
                DisplayAlert("Mensagem", $"O troco é R$ {Troco}", "OK");
            } else
            {
                DisplayAlert("Resposta", "O valor pago precisa ser maior que o preço", "OK");
            }
        }
    }
}