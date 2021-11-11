using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using static Tierheim.Globals;

namespace Tierheim
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		public MainWindow()
		{
			InitializeComponent();
			this.Width = 800;
			this.Height = 400;
			if (Debugger.IsAttached)
				this.Left = 2000;

		}

		private void CommandBinding_Executed(object sender, ExecutedRoutedEventArgs e)
		{
			if ("Hunde".Equals(e.Parameter))
			{
				// throw new Exception("Test Exception!");
				ShowInfo("Hunde sind leider momentan nicht vorrätig!");
				return;
			}
		}
	}
}
