using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace Tierheim
{
	public class Globals
	{
		public static RoutedCommand CatDogSelectCmd = new RoutedCommand();


		public static void ShowInfo(string text)
		{
			MessageBox.Show(text,"Dein Tierheim",MessageBoxButton.OK,
				MessageBoxImage.Information);
		}
	}
}
