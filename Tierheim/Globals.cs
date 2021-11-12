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
	}
}
