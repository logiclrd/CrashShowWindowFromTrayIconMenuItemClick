using System.Windows.Input;

using Avalonia;
using Avalonia.Controls.ApplicationLifetimes;
using Avalonia.Markup.Xaml;

using ReactiveUI;

namespace CrashRepro
{
	public partial class App : Application
	{
		public override void Initialize()
		{
			AvaloniaXamlLoader.Load(this);
		}

		public App()
		{
			ShowWindowCommand = ReactiveCommand.Create(ShowWindow);

			DataContext = this;
		}

		public override void OnFrameworkInitializationCompleted()
		{
			if (ApplicationLifetime is IClassicDesktopStyleApplicationLifetime desktop)
				desktop.ShutdownMode = Avalonia.Controls.ShutdownMode.OnExplicitShutdown;

			base.OnFrameworkInitializationCompleted();
		}

		public ICommand ShowWindowCommand { get; }

		public MainWindow? MainWindow { get; set; }

		void ShowWindow()
		{
			MainWindow ??= new MainWindow();
			MainWindow.Show();
		}
	}
}

