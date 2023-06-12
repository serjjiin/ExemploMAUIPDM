using Microsoft.Maui.Controls;

namespace ExemploMAUIPDM 
{
    public partial class GreetingPage : ContentPage
    {
        // Construtor que recebe o nome do usuário
        public GreetingPage(string nome)
        {
            // Chama o método InitializeComponent para inicializar os elementos de interface do usuário
            InitializeComponent();

            // Define o texto do Label como uma mensagem personalizada com o nome do usuário
            lblSaudacao.Text = $"Olá, {nome}! Bem-vindo(a) ao meu aplicativo feito em MAUI .NET 7!";
        }

        // Metodo para o botao de voltar
        private void Button_Clicked(object sender, EventArgs e)
        {
            Navigation.PopAsync();
        }
    }
}
