﻿using System;

using Avalonia;

namespace CrashRepro
{
	class Program
	{
		[STAThread]
		public static void Main(string[] args)
		{
			var app = BuildAvaloniaApp();

			app.StartWithClassicDesktopLifetime(args);
		}

		public static AppBuilder BuildAvaloniaApp()
		{
			return AppBuilder.Configure<App>()
				.UsePlatformDetect()
				.WithInterFont()
				.LogToTrace();
		}
	}
}
