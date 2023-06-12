using Microsoft.Maui.Controls;

namespace ExemploMAUIPDM 
{
    public partial class GreetingPage : ContentPage
    {
        // Construtor que recebe o nome do usuário
        public GreetingPage(string name)
        {
            // Chama o método InitializeComponent para inicializar os elementos de interface do usuário
            InitializeComponent();

            // Define o texto do Label como uma mensagem personalizada com o nome do usuário
            greetingLabel.Text = $"Olá, {name}! Bem-vindo ao meu aplicativo!";
        }
    }
}
