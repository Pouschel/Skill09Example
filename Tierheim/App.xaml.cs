using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using static Tierheim.Globals;

namespace Tierheim
{
	/// <summary>
	/// Interaction logic for App.xaml
	/// </summary>
	public partial class App : Application
	{
		public App()
		{
			if (!Debugger.IsAttached)
			  this.DispatcherUnhandledException += this.App_DispatcherUnhandledException;
		}

		private void App_DispatcherUnhandledException(object sender, System.Windows.Threading.DispatcherUnhandledExceptionEventArgs e)
		{
			ShowInfo(@"Leider ist ein Fehler aufgetreten.
Bitte Anwendung beenden und neu starten!");
			e.Handled = true; // verhindert Absturz!
		}
	}
}
