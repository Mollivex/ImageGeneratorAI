using ImageGeneratorAI.Models;
using Microsoft.Maui.Controls.PlatformConfiguration;
using Microsoft.Extensions.Logging;

namespace ImageGeneratorAI.Views;

public partial class GenerationOptionsView : ContentPage
{
	public List<string> Options { get; set; }
	public List<ArtStyle> Styles { get; set; }
	public GenerationOptionsView()
	{
		InitializeComponent();
		FillOptions();
		BindingContext = this;

		Microsoft.Maui.Handlers.EditorHandler.Mapper.AppendToMapping("MyCustomization", (handler, view) =>
		{
#if ANDROID

			handler.PlatformView.SetBackgroundColor(Android.Graphics.Color.Transparent);

#elif IOS || MACCATALYST

#elif WINDOWS

#endif
		});
	}
	private void FillOptions()
	{
		Options = new List<string>
		{
			"World",
			"Winter",
			"Animals",
			"Forest",
			"Trees",
			"Mountains",
			"City",
			"Nature"
		};

		Styles = new List<ArtStyle>
		{
			new ArtStyle() {Name = "Cartoon", ImageUrl = "cartoon.jpg"},
			new ArtStyle() {Name = "Anime", ImageUrl = "anime.jpg"},
			new ArtStyle() {Name = "Funko", ImageUrl = "funko.jpg"},
			new ArtStyle() {Name = "Nature", ImageUrl = "nature.jpg"},
			new ArtStyle() {Name = "Animals", ImageUrl = "animals.jpg"},
			new ArtStyle() {Name = "Realistic", ImageUrl = "realistic.jpg"},
			new ArtStyle() {Name = "Isometric", ImageUrl = "isometric.jpg"},
			new ArtStyle() {Name = "Minimalism", ImageUrl = "minimalism.jpg"},
			new ArtStyle() {Name = "Water Color", ImageUrl = "watercolor.jpg"},
			new ArtStyle() {Name = "Surrealism", ImageUrl = "surrealism.jpg"},
			new ArtStyle() {Name = "Pop Art", ImageUrl = "popart.jpg"},
            new ArtStyle() {Name = "Story Book", ImageUrl = "storybook.jpg"}
        };
	}

    private void btnGenerate_Clicked(object sender, EventArgs e)
    {
		Shell.Current.GoToAsync(nameof(ImageGeneratorView));
    }
}