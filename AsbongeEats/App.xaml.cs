using AsbongeEats.Views;

namespace AsbongeEats
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new LoginView();
        }
    }
}
