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
    public partial class Exercicio05 : ContentPage
    {
        public int Nota1 { get; set; }
        public int Nota2 { get; set; }
        public int Nota3 { get; set; }
        public int Nota4 { get; set; }
        public double Media { get; set; }

        public Exercicio05()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Nota1 = Convert.ToInt32(Nota1Txt.Text);
            Nota2 = Convert.ToInt32(Nota2Txt.Text);
            Nota3 = Convert.ToInt32(Nota3Txt.Text);
            Nota4 = Convert.ToInt32(Nota4Txt.Text);

            Media = (Nota1 + Nota2 + Nota3 + Nota4) / 4;

            if (Media >= 7)
            {
                DisplayAlert("Resposta", $"Média {Media} Aprovado!", "OK");
            }
            else
            {
                DisplayAlert("Resposta", $"Média {Media} Reprovado!", "OK");
            }

            Nota1Txt.Text = "";
            Nota2Txt.Text = "";
            Nota3Txt.Text = "";
            Nota4Txt.Text = "";
        }
    }
}