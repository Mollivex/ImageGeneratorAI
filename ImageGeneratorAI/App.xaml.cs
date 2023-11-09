using ImageGeneratorAI.Views;

namespace ImageGeneratorAI
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            //MainPage = new DashboardView();
            //MainPage = new GenerationOptionsView();
            MainPage = new ImageGeneratorView();
        }
    }
}