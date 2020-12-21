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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Szachy2
{
	enum Figura
	{
		Pion,
		Kon,
		Wieza,
		Laufer,
		Krolowa,
		Krol
	};

	/// <summary>
	/// Interaction logic for Field.xaml
	/// </summary>
	public partial class Field : Button
	{
		SolidColorBrush light = new SolidColorBrush(Colors.Moccasin);
		SolidColorBrush dark = new SolidColorBrush(Colors.Brown);
		SolidColorBrush selected = new SolidColorBrush(Colors.Blue);
		SolidColorBrush highlighted = new SolidColorBrush(Colors.Green);

		Figura figura;
		public Field()
		{
			InitializeComponent();
			this.figura = Figura.Pion;
			this.MouseEnter += mouse_enter;
			//this.Mouse
		}

		private void mouse_enter(object sender, EventArgs e)
		{
			//(sender as Field).Background = light;
		}
	}
}
