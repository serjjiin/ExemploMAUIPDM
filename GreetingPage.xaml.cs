using Microsoft.Maui.Controls;

namespace ExemploMAUIPDM 
{
    public partial class GreetingPage : ContentPage
    {
        // Construtor que recebe o nome do usu�rio
        public GreetingPage(string name)
        {
            // Chama o m�todo InitializeComponent para inicializar os elementos de interface do usu�rio
            InitializeComponent();

            // Define o texto do Label como uma mensagem personalizada com o nome do usu�rio
            greetingLabel.Text = $"Ol�, {name}! Bem-vindo ao meu aplicativo!";
        }
    }
}
