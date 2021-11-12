using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace Tierheim
{
	public class Globals
	{
		public static RoutedCommand CatDogSelectCmd = new RoutedCommand();

		public static List<Cat> CatList { get; private set; } = CreateCatList();

		public static void ShowInfo(string text) 
			=> MessageBox.Show(text, "Dein Tierheim", MessageBoxButton.OK, MessageBoxImage.Information);
	
		public static List<Cat> CreateCatList()
		{
			var list = new List<Cat>();
			var puschel = new Cat
			{
				Name = "Puschel",
				Age = 6,
				Race = "Maine Coon"
			};
			list.Add(puschel);
			var merle = new Cat
			{
				Name = "Merle",
				Age = 9,
				Race = "Europäisches Kurzhaar"
			};
			list.Add(merle);
			return list;
		}

		public static ImageSource LoadImageRelative(string relName)
		{
			var dir = Path.GetDirectoryName( Assembly.GetEntryAssembly().Location);
			var fn = Path.Combine(dir, relName);
			return new BitmapImage(new Uri(fn));
		}
	}
}
