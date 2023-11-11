using ImageGeneratorAI.Views;

namespace ImageGeneratorAI
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(DashboardView), typeof(DashboardView));
            Routing.RegisterRoute(nameof(GenerationOptionsView), typeof(GenerationOptionsView));
            Routing.RegisterRoute(nameof(ImageGeneratorView), typeof(ImageGeneratorView));
        }
    }
}