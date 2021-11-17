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
    public partial class Exercício02 : ContentPage
    {
        public double Preco { get; set; }
        public double Quilo { get; set; }
        public double Total { get; set; }

        public Exercício02()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Preco = Convert.ToDouble(PrecoTxt.Text);
            Quilo = Convert.ToDouble(QuiloTxt.Text);
            Total = Preco * Quilo;

            DisplayAlert("Resposta", $"O total a ser pago deve ser: R$ {Total}", "OK");

        }
    }
}