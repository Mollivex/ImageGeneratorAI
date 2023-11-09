using ImageGeneratorAI.Models;
using System.Collections.ObjectModel;

namespace ImageGeneratorAI.Views;

public partial class DashboardView : ContentPage
{
	public ObservableCollection<Profile> Profiles { get; set; }
	public ObservableCollection<GeneratedImage> GeneratedImages { get; set; }

	public DashboardView()
	{
		InitializeComponent();
			LoadData();
			BindingContext = this;
	}

	private void LoadData()
	{
		throw new NotImplementedException();
	}
}