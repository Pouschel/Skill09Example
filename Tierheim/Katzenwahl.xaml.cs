using System;
using System.Collections.Generic;
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
using System.Windows.Shapes;

namespace Tierheim
{
	/// <summary>
	/// Interaction logic for Katzenwahl.xaml
	/// </summary>
	public partial class Katzenwahl : Window
	{
		public Katzenwahl()
		{
			InitializeComponent();
		}

		private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
		{
			var cat = cbCatSel.SelectedItem as Cat;
			if (cat is null) return;
			DataContext = cat;
		}
	}
}
