using Microsoft.Maui.Controls;

namespace ExemploMAUIPDM 
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void OnButtonClicked(object sender, EventArgs e)
        {
            // Obtém o texto digitado pelo usuário no Entry
            string nome = nameEntry.Text;

            // Cria uma nova instância da GreetingPage passando o nome do usuário como parâmetro
            var greetingPage = new GreetingPage(nome);

            // Adiciona a GreetingPage na pilha de navegação e mostra ela ao usuário
            await Navigation.PushAsync(greetingPage);

        }
    }
}
