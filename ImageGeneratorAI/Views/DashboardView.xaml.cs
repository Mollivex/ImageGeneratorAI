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
		Profiles = new ObservableCollection<Profile>
		{
			new Profile
			{
				Name = "Jack",
				ProfileImage = "profile1.jpg",
				NoPhotos = 25
			},
			                        
			new Profile
            {
                Name = "Henry",
                ProfileImage = "profile2.jpg",
                NoPhotos = 13
            },
			                                   
			new Profile
            {
                Name = "Maddy",
                ProfileImage = "profile3.jpg",
                NoPhotos = 8
            },
        };

		GeneratedImages = new ObservableCollection<GeneratedImage>
		{
			new GeneratedImage
			{
				ImagePath = "dashboard1.jpg",
				MainKeyword = "Castle",
				Keywords = new List<string>
				{
					"Epic, lake, mountain, medieval, trees, grey sky"
				}
			},
                        
			new GeneratedImage
            {
                ImagePath = "dashboard2.jpg",
                MainKeyword = "Mountain",
                Keywords = new List<string>
                {
                    "Landscape, photorealistic, dawn, mountains, blue sky"
                }
            },
		                        
			new GeneratedImage
            {
                ImagePath = "dashboard3.jpg",
                MainKeyword = "Robot",
                Keywords = new List<string>
                {
                    "AI, rototic, human, light, metal, cartoon"
                }
            },

        };
	}
}