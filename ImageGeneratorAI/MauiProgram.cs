﻿using CommunityToolkit.Maui;
using Microsoft.Extensions.Logging;
using Microsoft.Maui.Controls.PlatformConfiguration;
using PanCardView;
using SkiaSharp.Views.Maui.Controls.Hosting;

namespace ImageGeneratorAI
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .UseCardsView()
                .UseMauiCommunityToolkit()
                .UseSkiaSharp()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                    fonts.AddFont("Exo-Black.ttf", "ExoBlack");
                    fonts.AddFont("Exo-Medium.ttf", "ExoMedium");
                    fonts.AddFont("Exo-Bold.ttf", "ExoBold");
                    fonts.AddFont("Exo-ExtraBold.ttf", "ExoExtraBold");
                });

#if DEBUG
            builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}