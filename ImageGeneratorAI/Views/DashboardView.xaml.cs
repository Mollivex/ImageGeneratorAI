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
				NoPhotos = 5
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
			new Profile
            {
                Name = "John",
                ProfileImage = "profile4.jpg",
                NoPhotos = 19
            },
            new Profile
            {
                Name = "Kate",
                ProfileImage = "profile5.jpg",
                NoPhotos = 3
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
					"Epic, lake, mountain, medieval, trees, smog, dawn"
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
            new GeneratedImage
            {
                ImagePath = "dashboard4.jpg",
                MainKeyword = "Ocean",
                Keywords = new List<string>
                {
                    "ocean, diving, fishes, rocks, water, nature"
                }
            },
            new GeneratedImage
            {
                ImagePath = "dashboard5.jpg",
                MainKeyword = "Forest",
                Keywords = new List<string>
                {
                    "Trees, dawn, outdoors, landscape, travel, nature"
                }
            },
            new GeneratedImage
            {
                ImagePath = "dashboard6.jpg",
                MainKeyword = "City",
                Keywords = new List<string>
                {
                    "City jungles, roads, skycrapers, Chicago, landscape, buildings"
                }
            },

        };
	}
}