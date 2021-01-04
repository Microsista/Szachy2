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
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		SolidColorBrush light = new SolidColorBrush(Colors.Moccasin);
		SolidColorBrush dark = new SolidColorBrush(Colors.Brown);
		SolidColorBrush selected = new SolidColorBrush(Colors.Blue);
		SolidColorBrush highlighted = new SolidColorBrush(Colors.Green);
		SolidColorBrush white = new SolidColorBrush(Colors.White);

		//ImageBrush bPion = new ImageBrush(new BitmapImage(new Uri("../../ikony/bPionek.png", UriKind.Relative)));
		//ImageBrush bWieza = new ImageBrush(new BitmapImage(new Uri("../../ikony/bWieza.png", UriKind.Relative)));
		//ImageBrush bKon = new ImageBrush(new BitmapImage(new Uri("../../ikony/bKon.png", UriKind.Relative)));
		//ImageBrush bLaufer = new ImageBrush(new BitmapImage(new Uri("../../ikony/bLaufer.png", UriKind.Relative)));
		//ImageBrush bKrolowa = new ImageBrush(new BitmapImage(new Uri("../../ikony/bKrolowa.png", UriKind.Relative)));
		//ImageBrush bKrol = new ImageBrush(new BitmapImage(new Uri("../../ikony/bKrol.png", UriKind.Relative)));
		//ImageBrush cPion = new ImageBrush(new BitmapImage(new Uri("../../ikony/cPionek.png", UriKind.Relative)));
		//ImageBrush cWieza = new ImageBrush(new BitmapImage(new Uri("../../ikony/cWieza.png", UriKind.Relative)));
		//ImageBrush cKon = new ImageBrush(new BitmapImage(new Uri("../../ikony/cKon.png", UriKind.Relative)));
		//ImageBrush cLaufer = new ImageBrush(new BitmapImage(new Uri("../../ikony/cLaufer.png", UriKind.Relative)));
		//ImageBrush cKrolowa = new ImageBrush(new BitmapImage(new Uri("../../ikony/cKrolowa.png", UriKind.Relative)));
		//ImageBrush cKrol = new ImageBrush(new BitmapImage(new Uri("../../ikony/cKrol.png", UriKind.Relative)));

		ImageBrush bPionJ = new ImageBrush(new BitmapImage(new Uri("../../ikony/bPionekJ.png", UriKind.Relative)));
		ImageBrush bWiezaJ = new ImageBrush(new BitmapImage(new Uri("../../ikony/bWiezaJ.png", UriKind.Relative)));
		ImageBrush bKonJ = new ImageBrush(new BitmapImage(new Uri("../../ikony/bKonJ.png", UriKind.Relative)));
		ImageBrush bLauferJ = new ImageBrush(new BitmapImage(new Uri("../../ikony/bLauferJ.png", UriKind.Relative)));
		ImageBrush bKrolowaJ = new ImageBrush(new BitmapImage(new Uri("../../ikony/bKrolowaJ.png", UriKind.Relative)));
		ImageBrush bKrolJ = new ImageBrush(new BitmapImage(new Uri("../../ikony/bKrolJ.png", UriKind.Relative)));
		ImageBrush cPionJ = new ImageBrush(new BitmapImage(new Uri("../../ikony/cPionekJ.png", UriKind.Relative)));
		ImageBrush cWiezaJ = new ImageBrush(new BitmapImage(new Uri("../../ikony/cWiezaJ.png", UriKind.Relative)));
		ImageBrush cKonJ = new ImageBrush(new BitmapImage(new Uri("../../ikony/cKonJ.png", UriKind.Relative)));
		ImageBrush cLauferJ = new ImageBrush(new BitmapImage(new Uri("../../ikony/cLauferJ.png", UriKind.Relative)));
		ImageBrush cKrolowaJ = new ImageBrush(new BitmapImage(new Uri("../../ikony/cKrolowaJ.png", UriKind.Relative)));
		ImageBrush cKrolJ = new ImageBrush(new BitmapImage(new Uri("../../ikony/cKrolJ.png", UriKind.Relative)));

		ImageBrush bPionC = new ImageBrush(new BitmapImage(new Uri("../../ikony/bPionekC.png", UriKind.Relative)));
		ImageBrush bWiezaC = new ImageBrush(new BitmapImage(new Uri("../../ikony/bWiezaC.png", UriKind.Relative)));
		ImageBrush bKonC = new ImageBrush(new BitmapImage(new Uri("../../ikony/bKonC.png", UriKind.Relative)));
		ImageBrush bLauferC = new ImageBrush(new BitmapImage(new Uri("../../ikony/bLauferC.png", UriKind.Relative)));
		ImageBrush bKrolowaC = new ImageBrush(new BitmapImage(new Uri("../../ikony/bKrolowaC.png", UriKind.Relative)));
		ImageBrush bKrolC = new ImageBrush(new BitmapImage(new Uri("../../ikony/bKrolC.png", UriKind.Relative)));
		ImageBrush cPionC = new ImageBrush(new BitmapImage(new Uri("../../ikony/cPionekC.png", UriKind.Relative)));
		ImageBrush cWiezaC = new ImageBrush(new BitmapImage(new Uri("../../ikony/cWiezaC.png", UriKind.Relative)));
		ImageBrush cKonC = new ImageBrush(new BitmapImage(new Uri("../../ikony/cKonC.png", UriKind.Relative)));
		ImageBrush cLauferC = new ImageBrush(new BitmapImage(new Uri("../../ikony/cLauferC.png", UriKind.Relative)));
		ImageBrush cKrolowaC = new ImageBrush(new BitmapImage(new Uri("../../ikony/cKrolowaC.png", UriKind.Relative)));
		ImageBrush cKrolC = new ImageBrush(new BitmapImage(new Uri("../../ikony/cKrolC.png", UriKind.Relative)));

		Image img = new Image();
		StackPanel stackPnl = new StackPanel();



		Button[,] chessboard = new Button[8, 8];
		Button[,] fchessboard = new Button[8, 8];

		private void assignFields()
		{
			chessboard[0, 7] = a1;
			chessboard[1, 7] = b1;
			chessboard[2, 7] = c1;
			chessboard[3, 7] = d1;
			chessboard[4, 7] = e1;
			chessboard[5, 7] = f1;
			chessboard[6, 7] = g1;
			chessboard[7, 7] = h1;

			chessboard[0, 6] = a2;
			chessboard[1, 6] = b2;
			chessboard[2, 6] = c2;
			chessboard[3, 6] = d2;
			chessboard[4, 6] = e2;
			chessboard[5, 6] = f2;
			chessboard[6, 6] = g2;
			chessboard[7, 6] = h2;

			chessboard[0, 5] = a3;
			chessboard[1, 5] = b3;
			chessboard[2, 5] = c3;
			chessboard[3, 5] = d3;
			chessboard[4, 5] = e3;
			chessboard[5, 5] = f3;
			chessboard[6, 5] = g3;
			chessboard[7, 5] = h3;

			chessboard[0, 4] = a4;
			chessboard[1, 4] = b4;
			chessboard[2, 4] = c4;
			chessboard[3, 4] = d4;
			chessboard[4, 4] = e4;
			chessboard[5, 4] = f4;
			chessboard[6, 4] = g4;
			chessboard[7, 4] = h4;

			chessboard[0, 3] = a5;
			chessboard[1, 3] = b5;
			chessboard[2, 3] = c5;
			chessboard[3, 3] = d5;
			chessboard[4, 3] = e5;
			chessboard[5, 3] = f5;
			chessboard[6, 3] = g5;
			chessboard[7, 3] = h5;

			chessboard[0, 2] = a6;
			chessboard[1, 2] = b6;
			chessboard[2, 2] = c6;
			chessboard[3, 2] = d6;
			chessboard[4, 2] = e6;
			chessboard[5, 2] = f6;
			chessboard[6, 2] = g6;
			chessboard[7, 2] = h6;

			chessboard[0, 1] = a7;
			chessboard[1, 1] = b7;
			chessboard[2, 1] = c7;
			chessboard[3, 1] = d7;
			chessboard[4, 1] = e7;
			chessboard[5, 1] = f7;
			chessboard[6, 1] = g7;
			chessboard[7, 1] = h7;

			chessboard[0, 0] = a8;
			chessboard[1, 0] = b8;
			chessboard[2, 0] = c8;
			chessboard[3, 0] = d8;
			chessboard[4, 0] = e8;
			chessboard[5, 0] = f8;
			chessboard[6, 0] = g8;
			chessboard[7, 0] = h8;



			fchessboard[0, 7] = fa1;
			fchessboard[1, 7] = fb1;
			fchessboard[2, 7] = fc1;
			fchessboard[3, 7] = fd1;
			fchessboard[4, 7] = fe1;
			fchessboard[5, 7] = ff1;
			fchessboard[6, 7] = fg1;
			fchessboard[7, 7] = fh1;

			fchessboard[0, 6] = fa2;
			fchessboard[1, 6] = fb2;
			fchessboard[2, 6] = fc2;
			fchessboard[3, 6] = fd2;
			fchessboard[4, 6] = fe2;
			fchessboard[5, 6] = ff2;
			fchessboard[6, 6] = fg2;
			fchessboard[7, 6] = fh2;

			fchessboard[0, 5] = fa3;
			fchessboard[1, 5] = fb3;
			fchessboard[2, 5] = fc3;
			fchessboard[3, 5] = fd3;
			fchessboard[4, 5] = fe3;
			fchessboard[5, 5] = ff3;
			fchessboard[6, 5] = fg3;
			fchessboard[7, 5] = fh3;

			fchessboard[0, 4] = fa4;
			fchessboard[1, 4] = fb4;
			fchessboard[2, 4] = fc4;
			fchessboard[3, 4] = fd4;
			fchessboard[4, 4] = fe4;
			fchessboard[5, 4] = ff4;
			fchessboard[6, 4] = fg4;
			fchessboard[7, 4] = fh4;

			fchessboard[0, 3] = fa5;
			fchessboard[1, 3] = fb5;
			fchessboard[2, 3] = fc5;
			fchessboard[3, 3] = fd5;
			fchessboard[4, 3] = fe5;
			fchessboard[5, 3] = ff5;
			fchessboard[6, 3] = fg5;
			fchessboard[7, 3] = fh5;

			fchessboard[0, 2] = fa6;
			fchessboard[1, 2] = fb6;
			fchessboard[2, 2] = fc6;
			fchessboard[3, 2] = fd6;
			fchessboard[4, 2] = fe6;
			fchessboard[5, 2] = ff6;
			fchessboard[6, 2] = fg6;
			fchessboard[7, 2] = fh6;

			fchessboard[0, 1] = fa7;
			fchessboard[1, 1] = fb7;
			fchessboard[2, 1] = fc7;
			fchessboard[3, 1] = fd7;
			fchessboard[4, 1] = fe7;
			fchessboard[5, 1] = ff7;
			fchessboard[6, 1] = fg7;
			fchessboard[7, 1] = fh7;

			fchessboard[0, 0] = fa8;
			fchessboard[1, 0] = fb8;
			fchessboard[2, 0] = fc8;
			fchessboard[3, 0] = fd8;
			fchessboard[4, 0] = fe8;
			fchessboard[5, 0] = ff8;
			fchessboard[6, 0] = fg8;
			fchessboard[7, 0] = fh8;
		}

		private void loadImages()
		{
			img.Source = new BitmapImage(new Uri("../../ikony/bPionek.png", UriKind.Relative));
			
			stackPnl.Orientation = Orientation.Horizontal;
			stackPnl.Margin = new Thickness(10);
			stackPnl.Children.Add(img);
		}

		public MainWindow()
		{
			InitializeComponent();
			assignFields();
			loadImages();
			clearSelection();
		}

		private void clearSelection()
		{
			for (int i = 0; i < 8; i++)
				for (int j = 0; j < 8; j++) {
					fchessboard[i, j].BorderBrush = white;
				}

			for (int i = 0; i < 8; i += 2)
				for (int j = 0; j < 8; j += 2)
				{
					chessboard[i, j].Background = light;
					chessboard[i, j].Tag = "";
					// Biale

					if (chessboard[i, j].Content.ToString() == "bPion")
					{
						chessboard[i, j].Background = bPionJ;

					}
					if (chessboard[i, j].Content.ToString() == "bWieza")
					{
						chessboard[i, j].Background = bWiezaJ;
					}
					if (chessboard[i, j].Content.ToString() == "bKon")
					{
						chessboard[i, j].Background = bKonJ;
					}
					if (chessboard[i, j].Content.ToString() == "bLaufer")
					{
						chessboard[i, j].Background = bLauferJ;
					}
					if (chessboard[i, j].Content.ToString() == "bKrolowa")
					{
						chessboard[i, j].Background = bKrolowaJ;
					}
					if (chessboard[i, j].Content.ToString() == "bKrol")
					{
						chessboard[i, j].Background = bKrolJ;
					}

					// Czarne

					if (chessboard[i, j].Content.ToString() == "cPion")
					{
						chessboard[i, j].Background = cPionJ;
					}
					if (chessboard[i, j].Content.ToString() == "cWieza")
					{
						chessboard[i, j].Background = cWiezaJ;
					}
					if (chessboard[i, j].Content.ToString() == "cKon")
					{
						chessboard[i, j].Background = cKonJ;
					}
					if (chessboard[i, j].Content.ToString() == "cLaufer")
					{
						chessboard[i, j].Background = cLauferJ;
					}
					if (chessboard[i, j].Content.ToString() == "cKrolowa")
					{
						chessboard[i, j].Background = cKrolowaJ;
					}
					if (chessboard[i, j].Content.ToString() == "cKrol")
					{
						chessboard[i, j].Background = cKrolJ;
					}
				}
					

			for (int i = 1; i < 8; i += 2)
				for (int j = 1; j < 8; j += 2)
				{
					chessboard[i, j].Background = light;
					chessboard[i, j].Tag = "";
					// Biale

					if (chessboard[i, j].Content.ToString() == "bPion")
					{
						chessboard[i, j].Background = bPionJ;
					}
					if (chessboard[i, j].Content.ToString() == "bWieza")
					{
						chessboard[i, j].Background = bWiezaJ;
					}
					if (chessboard[i, j].Content.ToString() == "bKon")
					{
						chessboard[i, j].Background = bKonJ;
					}
					if (chessboard[i, j].Content.ToString() == "bLaufer")
					{
						chessboard[i, j].Background = bLauferJ;
					}
					if (chessboard[i, j].Content.ToString() == "bKrolowa")
					{
						chessboard[i, j].Background = bKrolowaJ;
					}
					if (chessboard[i, j].Content.ToString() == "bKrol")
					{
						chessboard[i, j].Background = bKrolJ;
					}

					// Czarne

					if (chessboard[i, j].Content.ToString() == "cPion")
					{
						chessboard[i, j].Background = cPionJ;
					}
					if (chessboard[i, j].Content.ToString() == "cWieza")
					{
						chessboard[i, j].Background = cWiezaJ;
					}
					if (chessboard[i, j].Content.ToString() == "cKon")
					{
						chessboard[i, j].Background = cKonJ;
					}
					if (chessboard[i, j].Content.ToString() == "cLaufer")
					{
						chessboard[i, j].Background = cLauferJ;
					}
					if (chessboard[i, j].Content.ToString() == "cKrolowa")
					{
						chessboard[i, j].Background = cKrolowaJ;
					}
					if (chessboard[i, j].Content.ToString() == "cKrol")
					{
						chessboard[i, j].Background = cKrolJ;
					}
				}
					

			for (int i = 1; i < 8; i += 2)
				for (int j = 0; j < 8; j += 2)
				{
					chessboard[i, j].Background = dark;
					chessboard[i, j].Tag = "";
					//Biale

					if (chessboard[i, j].Content.ToString() == "bPion")
					{
						chessboard[i, j].Background = bPionC;
					}
					if (chessboard[i, j].Content.ToString() == "bWieza")
					{
						chessboard[i, j].Background = bWiezaC;
					}
					if (chessboard[i, j].Content.ToString() == "bKon")
					{
						chessboard[i, j].Background = bKonC;
					}
					if (chessboard[i, j].Content.ToString() == "bLaufer")
					{
						chessboard[i, j].Background = bLauferC;
					}
					if (chessboard[i, j].Content.ToString() == "bKrolowa")
					{
						chessboard[i, j].Background = bKrolowaC;
					}
					if (chessboard[i, j].Content.ToString() == "bKrol")
					{
						chessboard[i, j].Background = bKrolC;
					}

					// Czarne

					if (chessboard[i, j].Content.ToString() == "cPion")
					{
						chessboard[i, j].Background = cPionC;
					}
					if (chessboard[i, j].Content.ToString() == "cWieza")
					{
						chessboard[i, j].Background = cWiezaC;
					}
					if (chessboard[i, j].Content.ToString() == "cKon")
					{
						chessboard[i, j].Background = cKonC;
					}
					if (chessboard[i, j].Content.ToString() == "cLaufer")
					{
						chessboard[i, j].Background = cLauferC;
					}
					if (chessboard[i, j].Content.ToString() == "cKrolowa")
					{
						chessboard[i, j].Background = cKrolowaC;
					}
					if (chessboard[i, j].Content.ToString() == "cKrol")
					{
						chessboard[i, j].Background = cKrolC;
					}


				}


			for (int i = 0; i < 8; i += 2)
				for (int j = 1; j < 8; j += 2)
				{
					chessboard[i, j].Background = dark;
					chessboard[i, j].Tag = "";

					//Biale

					if (chessboard[i, j].Content.ToString() == "bPion")
					{
						chessboard[i, j].Background = bPionC;
					}
					if (chessboard[i, j].Content.ToString() == "bWieza")
					{
						chessboard[i, j].Background = bWiezaC;
					}
					if (chessboard[i, j].Content.ToString() == "bKon")
					{
						chessboard[i, j].Background = bKonC;
					}
					if (chessboard[i, j].Content.ToString() == "bLaufer")
					{
						chessboard[i, j].Background = bLauferC;
					}
					if (chessboard[i, j].Content.ToString() == "bKrolowa")
					{
						chessboard[i, j].Background = bKrolowaC;
					}
					if (chessboard[i, j].Content.ToString() == "bKrol")
					{
						chessboard[i, j].Background = bKrolC;
					}

					// Czarne

					if (chessboard[i, j].Content.ToString() == "cPion")
					{
						chessboard[i, j].Background = cPionC;
					}
					if (chessboard[i, j].Content.ToString() == "cWieza")
					{
						chessboard[i, j].Background = cWiezaC;
					}
					if (chessboard[i, j].Content.ToString() == "cKon")
					{
						chessboard[i, j].Background = cKonC;
					}
					if (chessboard[i, j].Content.ToString() == "cLaufer")
					{
						chessboard[i, j].Background = cLauferC;
					}
					if (chessboard[i, j].Content.ToString() == "cKrolowa")
					{
						chessboard[i, j].Background = cKrolowaC;
					}
					if (chessboard[i, j].Content.ToString() == "cKrol")
					{
						chessboard[i, j].Background = cKrolC;
					}
				}
					

			//for (int i = 0; i < 8; i++)
			//	for (int j = 0; j < 8; j++)
			//	{
			//		// Biale

			//		if (chessboard[i, j].Content.ToString() == "bPion")
			//		{
			//			chessboard[i, j].Background = bPion;
			//		}
			//		if (chessboard[i, j].Content.ToString() == "bWieza")
			//		{
			//			chessboard[i, j].Background = bWieza;
			//		}
			//		if (chessboard[i, j].Content.ToString() == "bKon")
			//		{
			//			chessboard[i, j].Background = bKon;
			//		}
			//		if (chessboard[i, j].Content.ToString() == "bLaufer")
			//		{
			//			chessboard[i, j].Background = bLaufer;
			//		}
			//		if (chessboard[i, j].Content.ToString() == "bKrolowa")
			//		{
			//			chessboard[i, j].Background = bKrolowa;
			//		}
			//		if (chessboard[i, j].Content.ToString() == "bKrol")
			//		{
			//			chessboard[i, j].Background = bKrol;
			//		}

			//		// Czarne

			//		if (chessboard[i, j].Content.ToString() == "cPion")
			//		{
			//			chessboard[i, j].Background = cPion;
			//		}
			//		if (chessboard[i, j].Content.ToString() == "cWieza")
			//		{
			//			chessboard[i, j].Background = cWieza;
			//		}
			//		if (chessboard[i, j].Content.ToString() == "cKon")
			//		{
			//			chessboard[i, j].Background = cKon;
			//		}
			//		if (chessboard[i, j].Content.ToString() == "cLaufer")
			//		{
			//			chessboard[i, j].Background = cLaufer;
			//		}
			//		if (chessboard[i, j].Content.ToString() == "cKrolowa")
			//		{
			//			chessboard[i, j].Background = cKrolowa;
			//		}
			//		if (chessboard[i, j].Content.ToString() == "cKrol")
			//		{
			//			chessboard[i, j].Background = cKrol;
			//		}
			//	}
		}

		private String findSelected(object sender)
		{
			for (int i = 0; i < 8; i++)
				for (int j = 0; j < 8; j++)
					if (chessboard[i, j].Tag == "selected")
					{
						String temp = chessboard[i, j].Content.ToString();
						chessboard[i, j].Content = "";
						return temp;
					}
			return "";
		}

		private void fieldClick(object sender, RoutedEventArgs e)
		{

			for (int i = 0; i < 8; i++)
				for (int j = 0; j < 8; j++)
					if (chessboard[i, j].Name == (sender as Button).Name)
					{
						Console.Write("Koordynaty X = " + i + ", Koordynaty Y = " + j + "\n");

					}

			if ((sender as Button).Tag == "highlighted")
			{
				(sender as Button).Content = findSelected(sender);
				clearSelection();
				return;
			}
			clearSelection();
			(sender as Button).Tag = "selected";

			highlight(sender);
		}

		private void highlight(object sender)
		{
			for (int i = 0; i < 8; i++)
				for (int j = 0; j < 8; j++)
					if (chessboard[i, j] == (sender as Button))
					{
						// Biale

						if (chessboard[i, j].Content.ToString() == "bPion")
						{
							if (i >=0 && i <= 7 && j +1>= 0 && j +1<= 7)
							{
								fchessboard[i, j + 1].BorderThickness = new Thickness(2);
								fchessboard[i, j + 1].BorderBrush = highlighted;
								chessboard[i, j + 1].Tag = "highlighted";
							}

							if (i>= 0 && i<= 7 && j +2>= 0 && j +2<= 7)
							{
								fchessboard[i, j +2].BorderThickness = new Thickness(2);
								fchessboard[i, j+2].BorderBrush = highlighted;
								chessboard[i, j+2].Tag = "highlighted";
							}

								
						}

						if (chessboard[i, j].Content.ToString() == "bWieza" || chessboard[i, j].Content.ToString() == "cWieza")
						{
							if (i - 1 >= 0 && i - 1 <= 7 && j >= 0 && j <= 7)
							{
								fchessboard[i - 1, j].BorderThickness = new Thickness(2);
								fchessboard[i - 1, j].BorderBrush = highlighted;
								chessboard[i - 1, j].Tag = "highlighted";
							}


							if (i + 1 >= 0 && i + 1 <= 7 && j >= 0 && j <= 7)
							{
								fchessboard[i + 1, j].BorderThickness = new Thickness(2);
								fchessboard[i + 1, j].BorderBrush = highlighted;
								chessboard[i + 1, j].Tag = "highlighted";
							}



							if (j - 1 >= 0 && j - 1 <= 7)
							{
								fchessboard[i, j - 1].BorderThickness = new Thickness(2);
								fchessboard[i, j - 1].BorderBrush = highlighted;
								chessboard[i, j - 1].Tag = "highlighted";
							}


							if (j + 1 >= 0 && j + 1 <= 7)
							{
								fchessboard[i, j + 1].BorderThickness = new Thickness(2);
								fchessboard[i, j + 1].BorderBrush = highlighted;
								chessboard[i, j + 1].Tag = "highlighted";
							}


							if (i - 2 >= 0 && i - 2 <= 7 && j >= 0 && j <= 7)
							{
								fchessboard[i - 2, j].BorderThickness = new Thickness(2);
								fchessboard[i - 2, j].BorderBrush = highlighted;
								chessboard[i - 2, j].Tag = "highlighted";
							}


							if (i + 2 >= 0 && i + 2 <= 7 && j >= 0 && j <= 7)
							{
								fchessboard[i + 2, j].BorderThickness = new Thickness(2);
								fchessboard[i + 2, j].BorderBrush = highlighted;
								chessboard[i + 2, j].Tag = "highlighted";
							}



							if (j - 2 >= 0 && j - 2 <= 7)
							{
								fchessboard[i, j - 2].BorderThickness = new Thickness(2);
								fchessboard[i, j - 2].BorderBrush = highlighted;
								chessboard[i, j - 2].Tag = "highlighted";
							}


							if (j + 2 >= 0 && j + 2 <= 7)
							{
								fchessboard[i, j + 2].BorderThickness = new Thickness(2);
								fchessboard[i, j + 2].BorderBrush = highlighted;
								chessboard[i, j + 2].Tag = "highlighted";
							}


							if (i - 3 >= 0 && i - 3 <= 7 && j >= 0 && j <= 7)
							{
								fchessboard[i - 3, j].BorderThickness = new Thickness(2);
								fchessboard[i - 3, j].BorderBrush = highlighted;
								chessboard[i - 3, j].Tag = "highlighted";
							}


							if (i + 3 >= 0 && i + 3 <= 7 && j >= 0 && j <= 7)
							{
								fchessboard[i + 3, j].BorderThickness = new Thickness(2);
								fchessboard[i + 3, j].BorderBrush = highlighted;
								chessboard[i + 3, j].Tag = "highlighted";
							}



							if (j - 3 >= 0 && j - 3 <= 7)
							{
								fchessboard[i, j - 3].BorderThickness = new Thickness(2);
								fchessboard[i, j - 3].BorderBrush = highlighted;
								chessboard[i, j - 3].Tag = "highlighted";
							}


							if (j + 3 >= 0 && j + 3 <= 7)
							{
								fchessboard[i, j + 3].BorderThickness = new Thickness(2);
								fchessboard[i, j + 3].BorderBrush = highlighted;
								chessboard[i, j + 3].Tag = "highlighted";
							}


							if (i - 4 >= 0 && i - 4 <= 7 && j >= 0 && j <= 7)
							{
								fchessboard[i - 4, j].BorderThickness = new Thickness(2);
								fchessboard[i - 4, j].BorderBrush = highlighted;
								chessboard[i - 4, j].Tag = "highlighted";
							}


							if (i + 4 >= 0 && i + 4 <= 7 && j >= 0 && j <= 7)
							{
								fchessboard[i + 4, j].BorderThickness = new Thickness(2);
								fchessboard[i + 4, j].BorderBrush = highlighted;
								chessboard[i + 4, j].Tag = "highlighted";
							}



							if (j - 4 >= 0 && j - 4 <= 7)
							{
								fchessboard[i, j - 4].BorderThickness = new Thickness(2);
								fchessboard[i, j - 4].BorderBrush = highlighted;
								chessboard[i, j - 4].Tag = "highlighted";
							}


							if (j + 4 >= 0 && j + 4 <= 7)
							{
								fchessboard[i, j + 4].BorderThickness = new Thickness(2);
								fchessboard[i, j + 4].BorderBrush = highlighted;
								chessboard[i, j + 4].Tag = "highlighted";
							}


							if (i - 5 >= 0 && i - 5 <= 7 && j >= 0 && j <= 7)
							{
								fchessboard[i - 5, j].BorderThickness = new Thickness(2);
								fchessboard[i - 5, j].BorderBrush = highlighted;
								chessboard[i - 5, j].Tag = "highlighted";
							}


							if (i + 5 >= 0 && i + 5 <= 7 && j >= 0 && j <= 7)
							{
								fchessboard[i + 5, j].BorderThickness = new Thickness(2);
								fchessboard[i + 5, j].BorderBrush = highlighted;
								chessboard[i + 5, j].Tag = "highlighted";
							}



							if (j - 5 >= 0 && j - 5 <= 7)
							{
								fchessboard[i, j - 5].BorderThickness = new Thickness(2);
								fchessboard[i, j - 5].BorderBrush = highlighted;
								chessboard[i, j - 5].Tag = "highlighted";
							}


							if (j + 5 >= 0 && j + 5 <= 7)
							{
								fchessboard[i, j + 5].BorderThickness = new Thickness(2);
								fchessboard[i, j + 5].BorderBrush = highlighted;
								chessboard[i, j + 5].Tag = "highlighted";
							}


							if (i - 6 >= 0 && i - 6 <= 7 && j >= 0 && j <= 7)
							{
								fchessboard[i - 6, j].BorderThickness = new Thickness(2);
								fchessboard[i - 6, j].BorderBrush = highlighted;
								chessboard[i - 6, j].Tag = "highlighted";
							}


							if (i + 6 >= 0 && i + 6 <= 7 && j >= 0 && j <= 7)
							{
								fchessboard[i + 6, j].BorderThickness = new Thickness(2);
								fchessboard[i + 6, j].BorderBrush = highlighted;
								chessboard[i + 6, j].Tag = "highlighted";
							}



							if (j - 6 >= 0 && j - 6 <= 7)
							{
								fchessboard[i, j - 6].BorderThickness = new Thickness(2);
								fchessboard[i, j - 6].BorderBrush = highlighted;
								chessboard[i, j - 6].Tag = "highlighted";
							}


							if (j + 6 >= 0 && j + 6 <= 7)
							{
								fchessboard[i, j + 6].BorderThickness = new Thickness(2);
								fchessboard[i, j + 6].BorderBrush = highlighted;
								chessboard[i, j + 6].Tag = "highlighted";
							}


							if (i - 7 >= 0 && i - 7 <= 7 && j >= 0 && j <= 7)
							{
								fchessboard[i - 7, j].BorderThickness = new Thickness(2);
								fchessboard[i - 7, j].BorderBrush = highlighted;
								chessboard[i - 7, j].Tag = "highlighted";
							}


							if (i + 7 >= 0 && i + 7 <= 7 && j >= 0 && j <= 7)
							{
								fchessboard[i + 7, j].BorderThickness = new Thickness(2);
								fchessboard[i + 7, j].BorderBrush = highlighted;
								chessboard[i + 7, j].Tag = "highlighted";
							}



							if (j - 7 >= 0 && j - 7 <= 7)
							{
								fchessboard[i, j - 7].BorderThickness = new Thickness(2);
								fchessboard[i, j - 7].BorderBrush = highlighted;
								chessboard[i, j - 7].Tag = "highlighted";
							}


							if (j + 7 >= 0 && j + 7 <= 7)
							{
								fchessboard[i, j + 7].BorderThickness = new Thickness(2);
								fchessboard[i, j + 7].BorderBrush = highlighted;
								chessboard[i, j + 7].Tag = "highlighted";
							}


						}

						if (chessboard[i, j].Content.ToString() == "bKon" || chessboard[i, j].Content.ToString() == "cKon")
						{
							if (i - 2 >= 0 && i - 2 <= 7  && j + 1 >= 0 && j + 1 <= 7)
							{
								fchessboard[i-2, j+1].BorderThickness = new Thickness(2);
								fchessboard[i-2, j+1].BorderBrush = highlighted;
								chessboard[i-2, j+1].Tag = "highlighted";
							}

							if (i - 2 >= 0 && i - 2 <= 7 && j - 1 >= 0 && j - 1 <= 7)
							{
								fchessboard[i-2, j-1].BorderThickness = new Thickness(2);
								fchessboard[i-2, j-1].BorderBrush = highlighted;
								chessboard[i-2, j-1].Tag = "highlighted";
							}

							if (i + 2 >= 0 && i + 2 <= 7 && j + 1 >= 0 && j + 1 <= 7)
							{
								fchessboard[i+2, j+1].BorderThickness = new Thickness(2);
								fchessboard[i+2, j+1].BorderBrush = highlighted;
								chessboard[i+2, j+1].Tag = "highlighted";
							}

							if (i + 2 >= 0 && i + 2 <= 7 && j - 1 >= 0 && j - 1 <= 7)
							{
								fchessboard[i+2, j-1].BorderThickness = new Thickness(2);
								fchessboard[i+2, j-1].BorderBrush = highlighted;
								chessboard[i+2, j-1].Tag = "highlighted";
							}

							if (i + 1 >= 0 && i + 1 <= 7 && j - 2 >= 0 && j - 2 <= 7)
							{
								fchessboard[i+1, j-2].BorderThickness = new Thickness(2);
								fchessboard[i+1, j-2].BorderBrush = highlighted;
								chessboard[i+1, j-2].Tag = "highlighted";
							}

							if (i - 1 >= 0 && i - 1 <= 7 && j - 2 >= 0 && j - 2 <= 7)
							{
								fchessboard[i-1, j-2].BorderThickness = new Thickness(2);
								fchessboard[i-1, j-2].BorderBrush = highlighted;
								chessboard[i-1, j-2].Tag = "highlighted";
							}

							if (i + 1 >= 0 && i + 1 <= 7 && j + 2 >= 0 && j + 2 <= 7)
							{
								fchessboard[i+1, j+2].BorderThickness = new Thickness(2);
								fchessboard[i+1, j+2].BorderBrush = highlighted;
								chessboard[i+1, j+2].Tag = "highlighted";
							}

							if (i - 1 >= 0 && i - 1 <= 7 && j + 2 >= 0 && j + 2 <= 7)
							{
								fchessboard[i-1, j+2].BorderThickness = new Thickness(2);
								fchessboard[i-1, j+2].BorderBrush = highlighted;
								chessboard[i-1, j+2].Tag = "highlighted";
							}

						}

						if (chessboard[i, j].Content.ToString() == "bLaufer" || chessboard[i, j].Content.ToString() == "cLaufer")
						{
							if (i - 1 >= 0 && i - 1 <= 7 && j - 1 >= 0 && j - 1 <= 7)
							{
								fchessboard[i-1, j-1].BorderThickness = new Thickness(2);
								fchessboard[i-1, j-1].BorderBrush = highlighted;
								chessboard[i-1, j-1].Tag = "highlighted";
							}
							if (i - 2 >= 0 && i - 2 <= 7 && j - 2 >= 0 && j - 2 <= 7)
							{
								fchessboard[i - 2, j - 2].BorderThickness = new Thickness(2);
								fchessboard[i - 2, j - 2].BorderBrush = highlighted;
								chessboard[i - 2, j - 2].Tag = "highlighted";
							}
							if (i - 3 >= 0 && i - 3 <= 7 && j - 3 >= 0 && j - 3 <= 7)
							{
								fchessboard[i - 3, j - 3].BorderThickness = new Thickness(2);
								fchessboard[i - 3, j - 3].BorderBrush = highlighted;
								chessboard[i - 3, j - 3].Tag = "highlighted";
							}
							if (i - 4 >= 0 && i - 4 <= 7 && j - 4 >= 0 && j - 4 <= 7)
							{
								fchessboard[i - 4, j - 4].BorderThickness = new Thickness(2);
								fchessboard[i - 4, j - 4].BorderBrush = highlighted;
								chessboard[i - 4, j - 4].Tag = "highlighted";
							}
							if (i - 5 >= 0 && i - 5 <= 7 && j - 5 >= 0 && j - 5 <= 7)
							{
								fchessboard[i - 5, j - 5].BorderThickness = new Thickness(2);
								fchessboard[i - 5, j - 5].BorderBrush = highlighted;
								chessboard[i - 5, j - 5].Tag = "highlighted";
							}
							if (i - 6 >= 0 && i - 6 <= 7 && j - 6 >= 0 && j - 6 <= 7)
							{
								fchessboard[i - 6, j - 6].BorderThickness = new Thickness(2);
								fchessboard[i - 6, j - 6].BorderBrush = highlighted;
								chessboard[i - 6, j - 6].Tag = "highlighted";
							}
							if (i - 7 >= 0 && i - 7 <= 7 && j - 7 >= 0 && j - 7 <= 7)
							{
								fchessboard[i - 7, j - 7].BorderThickness = new Thickness(2);
								fchessboard[i - 7, j - 7].BorderBrush = highlighted;
								chessboard[i - 7, j - 7].Tag = "highlighted";
							}





							if (i + 1 >= 0 && i + 1 <= 7 && j + 1 >= 0 && j + 1 <= 7)
							{
								fchessboard[i+1, j+1].BorderThickness = new Thickness(2);
								fchessboard[i+1, j+1].BorderBrush = highlighted;
								chessboard[i+1, j+1].Tag = "highlighted";
							}
							if (i + 2 >= 0 && i + 2 <= 7 && j + 2 >= 0 && j + 2 <= 7)
							{
								fchessboard[i + 2, j + 2].BorderThickness = new Thickness(2);
								fchessboard[i + 2, j + 2].BorderBrush = highlighted;
								chessboard[i + 2, j + 2].Tag = "highlighted";
							}
							if (i + 3 >= 0 && i + 3 <= 7 && j + 3 >= 0 && j + 3 <= 7)
							{
								fchessboard[i + 3, j + 3].BorderThickness = new Thickness(2);
								fchessboard[i + 3, j + 3].BorderBrush = highlighted;
								chessboard[i + 3, j + 3].Tag = "highlighted";
							}
							if (i + 4 >= 0 && i + 4 <= 7 && j + 4 >= 0 && j + 4 <= 7)
							{
								fchessboard[i + 4, j + 4].BorderThickness = new Thickness(2);
								fchessboard[i + 4, j + 4].BorderBrush = highlighted;
								chessboard[i + 4, j + 4].Tag = "highlighted";
							}
							if (i + 5 >= 0 && i + 5 <= 7 && j + 5 >= 0 && j + 5 <= 7)
							{
								fchessboard[i + 5, j + 5].BorderThickness = new Thickness(2);
								fchessboard[i + 5, j + 5].BorderBrush = highlighted;
								chessboard[i + 5, j + 5].Tag = "highlighted";
							}
							if (i + 6 >= 0 && i + 6 <= 7 && j + 6 >= 0 && j + 6 <= 7)
							{
								fchessboard[i + 6, j + 6].BorderThickness = new Thickness(2);
								fchessboard[i + 6, j + 6].BorderBrush = highlighted;
								chessboard[i + 6, j + 6].Tag = "highlighted";
							}
							if (i + 7 >= 0 && i + 7 <= 7 && j + 7 >= 0 && j + 7 <= 7)
							{
								fchessboard[i + 7, j + 7].BorderThickness = new Thickness(2);
								fchessboard[i + 7, j + 7].BorderBrush = highlighted;
								chessboard[i + 7, j + 7].Tag = "highlighted";
							}





							if (i + 1 >= 0 && i + 1 <= 7 && j - 1 >= 0 && j - 1 <= 7)
							{
								fchessboard[i+1, j-1].BorderThickness = new Thickness(2);
								fchessboard[i+1, j-1].BorderBrush = highlighted;
								chessboard[i+1, j-1].Tag = "highlighted";
							}
							if (i + 2 >= 0 && i + 2 <= 7 && j - 2 >= 0 && j - 2 <= 7)
							{
								fchessboard[i + 2, j - 2].BorderThickness = new Thickness(2);
								fchessboard[i + 2, j - 2].BorderBrush = highlighted;
								chessboard[i + 2, j - 2].Tag = "highlighted";
							}
							if (i + 3 >= 0 && i + 3 <= 7 && j - 3 >= 0 && j - 3 <= 7)
							{
								fchessboard[i + 3, j - 3].BorderThickness = new Thickness(2);
								fchessboard[i + 3, j - 3].BorderBrush = highlighted;
								chessboard[i + 3, j - 3].Tag = "highlighted";
							}
							if (i + 4 >= 0 && i + 4 <= 7 && j - 4 >= 0 && j - 4 <= 7)
							{
								fchessboard[i + 4, j - 4].BorderThickness = new Thickness(2);
								fchessboard[i + 4, j - 4].BorderBrush = highlighted;
								chessboard[i + 4, j - 4].Tag = "highlighted";
							}
							if (i + 5 >= 0 && i + 5 <= 7 && j - 5 >= 0 && j - 5 <= 7)
							{
								fchessboard[i + 5, j - 5].BorderThickness = new Thickness(2);
								fchessboard[i + 5, j - 5].BorderBrush = highlighted;
								chessboard[i + 5, j - 5].Tag = "highlighted";
							}
							if (i + 6 >= 0 && i + 6 <= 7 && j - 6 >= 0 && j - 6 <= 7)
							{
								fchessboard[i + 6, j - 6].BorderThickness = new Thickness(2);
								fchessboard[i + 6, j - 6].BorderBrush = highlighted;
								chessboard[i + 6, j - 6].Tag = "highlighted";
							}
							if (i + 7 >= 0 && i + 7 <= 7 && j - 7 >= 0 && j - 7 <= 7)
							{
								fchessboard[i + 7, j - 7].BorderThickness = new Thickness(2);
								fchessboard[i + 7, j - 7].BorderBrush = highlighted;
								chessboard[i + 7, j - 7].Tag = "highlighted";
							}





							if (i - 1 >= 0 && i - 1 <= 7 && j + 1 >= 0 && j + 1 <= 7)
							{
								fchessboard[i-1, j+1].BorderThickness = new Thickness(2);
								fchessboard[i-1, j+1].BorderBrush = highlighted;
								chessboard[i-1, j+1].Tag = "highlighted";
							}
							if (i - 2 >= 0 && i - 2 <= 7 && j + 2 >= 0 && j + 2 <= 7)
							{
								fchessboard[i - 2, j + 2].BorderThickness = new Thickness(2);
								fchessboard[i - 2, j + 2].BorderBrush = highlighted;
								chessboard[i - 2, j + 2].Tag = "highlighted";
							}
							if (i - 3 >= 0 && i - 3 <= 7 && j + 3 >= 0 && j + 3 <= 7)
							{
								fchessboard[i - 3, j + 3].BorderThickness = new Thickness(2);
								fchessboard[i - 3, j + 3].BorderBrush = highlighted;
								chessboard[i - 3, j + 3].Tag = "highlighted";
							}
							if (i - 4 >= 0 && i - 4 <= 7 && j + 4 >= 0 && j + 4 <= 7)
							{
								fchessboard[i - 4, j + 4].BorderThickness = new Thickness(2);
								fchessboard[i - 4, j + 4].BorderBrush = highlighted;
								chessboard[i - 4, j + 4].Tag = "highlighted";
							}
							if (i - 5 >= 0 && i - 5 <= 7 && j + 5 >= 0 && j + 5 <= 7)
							{
								fchessboard[i - 5, j + 5].BorderThickness = new Thickness(2);
								fchessboard[i - 5, j + 5].BorderBrush = highlighted;
								chessboard[i - 5, j + 5].Tag = "highlighted";
							}
							if (i - 6 >= 0 && i - 6 <= 7 && j + 6 >= 0 && j + 6 <= 7)
							{
								fchessboard[i - 6, j + 6].BorderThickness = new Thickness(2);
								fchessboard[i - 6, j + 6].BorderBrush = highlighted;
								chessboard[i - 6, j + 6].Tag = "highlighted";
							}
							if (i - 7 >= 0 && i - 7 <= 7 && j + 7 >= 0 && j + 7 <= 7)
							{
								fchessboard[i - 7, j + 7].BorderThickness = new Thickness(2);
								fchessboard[i - 7, j + 7].BorderBrush = highlighted;
								chessboard[i - 7, j + 7].Tag = "highlighted";
							}






						}

						if (chessboard[i, j].Content.ToString() == "bKrolowa" || chessboard[i, j].Content.ToString() == "cKrolowa")
						{
							if (i - 1 >= 0 && i - 1 <= 7 && j - 1 >= 0 && j - 1 <= 7)
							{
								fchessboard[i - 1, j - 1].BorderThickness = new Thickness(2);
								fchessboard[i - 1, j - 1].BorderBrush = highlighted;
								chessboard[i - 1, j - 1].Tag = "highlighted";
							}
							if (i - 2 >= 0 && i - 2 <= 7 && j - 2 >= 0 && j - 2 <= 7)
							{
								fchessboard[i - 2, j - 2].BorderThickness = new Thickness(2);
								fchessboard[i - 2, j - 2].BorderBrush = highlighted;
								chessboard[i - 2, j - 2].Tag = "highlighted";
							}
							if (i - 3 >= 0 && i - 3 <= 7 && j - 3 >= 0 && j - 3 <= 7)
							{
								fchessboard[i - 3, j - 3].BorderThickness = new Thickness(2);
								fchessboard[i - 3, j - 3].BorderBrush = highlighted;
								chessboard[i - 3, j - 3].Tag = "highlighted";
							}
							if (i - 4 >= 0 && i - 4 <= 7 && j - 4 >= 0 && j - 4 <= 7)
							{
								fchessboard[i - 4, j - 4].BorderThickness = new Thickness(2);
								fchessboard[i - 4, j - 4].BorderBrush = highlighted;
								chessboard[i - 4, j - 4].Tag = "highlighted";
							}
							if (i - 5 >= 0 && i - 5 <= 7 && j - 5 >= 0 && j - 5 <= 7)
							{
								fchessboard[i - 5, j - 5].BorderThickness = new Thickness(2);
								fchessboard[i - 5, j - 5].BorderBrush = highlighted;
								chessboard[i - 5, j - 5].Tag = "highlighted";
							}
							if (i - 6 >= 0 && i - 6 <= 7 && j - 6 >= 0 && j - 6 <= 7)
							{
								fchessboard[i - 6, j - 6].BorderThickness = new Thickness(2);
								fchessboard[i - 6, j - 6].BorderBrush = highlighted;
								chessboard[i - 6, j - 6].Tag = "highlighted";
							}
							if (i - 7 >= 0 && i - 7 <= 7 && j - 7 >= 0 && j - 7 <= 7)
							{
								fchessboard[i - 7, j - 7].BorderThickness = new Thickness(2);
								fchessboard[i - 7, j - 7].BorderBrush = highlighted;
								chessboard[i - 7, j - 7].Tag = "highlighted";
							}





							if (i + 1 >= 0 && i + 1 <= 7 && j + 1 >= 0 && j + 1 <= 7)
							{
								fchessboard[i + 1, j + 1].BorderThickness = new Thickness(2);
								fchessboard[i + 1, j + 1].BorderBrush = highlighted;
								chessboard[i + 1, j + 1].Tag = "highlighted";
							}
							if (i + 2 >= 0 && i + 2 <= 7 && j + 2 >= 0 && j + 2 <= 7)
							{
								fchessboard[i + 2, j + 2].BorderThickness = new Thickness(2);
								fchessboard[i + 2, j + 2].BorderBrush = highlighted;
								chessboard[i + 2, j + 2].Tag = "highlighted";
							}
							if (i + 3 >= 0 && i + 3 <= 7 && j + 3 >= 0 && j + 3 <= 7)
							{
								fchessboard[i + 3, j + 3].BorderThickness = new Thickness(2);
								fchessboard[i + 3, j + 3].BorderBrush = highlighted;
								chessboard[i + 3, j + 3].Tag = "highlighted";
							}
							if (i + 4 >= 0 && i + 4 <= 7 && j + 4 >= 0 && j + 4 <= 7)
							{
								fchessboard[i + 4, j + 4].BorderThickness = new Thickness(2);
								fchessboard[i + 4, j + 4].BorderBrush = highlighted;
								chessboard[i + 4, j + 4].Tag = "highlighted";
							}
							if (i + 5 >= 0 && i + 5 <= 7 && j + 5 >= 0 && j + 5 <= 7)
							{
								fchessboard[i + 5, j + 5].BorderThickness = new Thickness(2);
								fchessboard[i + 5, j + 5].BorderBrush = highlighted;
								chessboard[i + 5, j + 5].Tag = "highlighted";
							}
							if (i + 6 >= 0 && i + 6 <= 7 && j + 6 >= 0 && j + 6 <= 7)
							{
								fchessboard[i + 6, j + 6].BorderThickness = new Thickness(2);
								fchessboard[i + 6, j + 6].BorderBrush = highlighted;
								chessboard[i + 6, j + 6].Tag = "highlighted";
							}
							if (i + 7 >= 0 && i + 7 <= 7 && j + 7 >= 0 && j + 7 <= 7)
							{
								fchessboard[i + 7, j + 7].BorderThickness = new Thickness(2);
								fchessboard[i + 7, j + 7].BorderBrush = highlighted;
								chessboard[i + 7, j + 7].Tag = "highlighted";
							}





							if (i + 1 >= 0 && i + 1 <= 7 && j - 1 >= 0 && j - 1 <= 7)
							{
								fchessboard[i + 1, j - 1].BorderThickness = new Thickness(2);
								fchessboard[i + 1, j - 1].BorderBrush = highlighted;
								chessboard[i + 1, j - 1].Tag = "highlighted";
							}
							if (i + 2 >= 0 && i + 2 <= 7 && j - 2 >= 0 && j - 2 <= 7)
							{
								fchessboard[i + 2, j - 2].BorderThickness = new Thickness(2);
								fchessboard[i + 2, j - 2].BorderBrush = highlighted;
								chessboard[i + 2, j - 2].Tag = "highlighted";
							}
							if (i + 3 >= 0 && i + 3 <= 7 && j - 3 >= 0 && j - 3 <= 7)
							{
								fchessboard[i + 3, j - 3].BorderThickness = new Thickness(2);
								fchessboard[i + 3, j - 3].BorderBrush = highlighted;
								chessboard[i + 3, j - 3].Tag = "highlighted";
							}
							if (i + 4 >= 0 && i + 4 <= 7 && j - 4 >= 0 && j - 4 <= 7)
							{
								fchessboard[i + 4, j - 4].BorderThickness = new Thickness(2);
								fchessboard[i + 4, j - 4].BorderBrush = highlighted;
								chessboard[i + 4, j - 4].Tag = "highlighted";
							}
							if (i + 5 >= 0 && i + 5 <= 7 && j - 5 >= 0 && j - 5 <= 7)
							{
								fchessboard[i + 5, j - 5].BorderThickness = new Thickness(2);
								fchessboard[i + 5, j - 5].BorderBrush = highlighted;
								chessboard[i + 5, j - 5].Tag = "highlighted";
							}
							if (i + 6 >= 0 && i + 6 <= 7 && j - 6 >= 0 && j - 6 <= 7)
							{
								fchessboard[i + 6, j - 6].BorderThickness = new Thickness(2);
								fchessboard[i + 6, j - 6].BorderBrush = highlighted;
								chessboard[i + 6, j - 6].Tag = "highlighted";
							}
							if (i + 7 >= 0 && i + 7 <= 7 && j - 7 >= 0 && j - 7 <= 7)
							{
								fchessboard[i + 7, j - 7].BorderThickness = new Thickness(2);
								fchessboard[i + 7, j - 7].BorderBrush = highlighted;
								chessboard[i + 7, j - 7].Tag = "highlighted";
							}





							if (i - 1 >= 0 && i - 1 <= 7 && j + 1 >= 0 && j + 1 <= 7)
							{
								fchessboard[i - 1, j + 1].BorderThickness = new Thickness(2);
								fchessboard[i - 1, j + 1].BorderBrush = highlighted;
								chessboard[i - 1, j + 1].Tag = "highlighted";
							}
							if (i - 2 >= 0 && i - 2 <= 7 && j + 2 >= 0 && j + 2 <= 7)
							{
								fchessboard[i - 2, j + 2].BorderThickness = new Thickness(2);
								fchessboard[i - 2, j + 2].BorderBrush = highlighted;
								chessboard[i - 2, j + 2].Tag = "highlighted";
							}
							if (i - 3 >= 0 && i - 3 <= 7 && j + 3 >= 0 && j + 3 <= 7)
							{
								fchessboard[i - 3, j + 3].BorderThickness = new Thickness(2);
								fchessboard[i - 3, j + 3].BorderBrush = highlighted;
								chessboard[i - 3, j + 3].Tag = "highlighted";
							}
							if (i - 4 >= 0 && i - 4 <= 7 && j + 4 >= 0 && j + 4 <= 7)
							{
								fchessboard[i - 4, j + 4].BorderThickness = new Thickness(2);
								fchessboard[i - 4, j + 4].BorderBrush = highlighted;
								chessboard[i - 4, j + 4].Tag = "highlighted";
							}
							if (i - 5 >= 0 && i - 5 <= 7 && j + 5 >= 0 && j + 5 <= 7)
							{
								fchessboard[i - 5, j + 5].BorderThickness = new Thickness(2);
								fchessboard[i - 5, j + 5].BorderBrush = highlighted;
								chessboard[i - 5, j + 5].Tag = "highlighted";
							}
							if (i - 6 >= 0 && i - 6 <= 7 && j + 6 >= 0 && j + 6 <= 7)
							{
								fchessboard[i - 6, j + 6].BorderThickness = new Thickness(2);
								fchessboard[i - 6, j + 6].BorderBrush = highlighted;
								chessboard[i - 6, j + 6].Tag = "highlighted";
							}
							if (i - 7 >= 0 && i - 7 <= 7 && j + 7 >= 0 && j + 7 <= 7)
							{
								fchessboard[i - 7, j + 7].BorderThickness = new Thickness(2);
								fchessboard[i - 7, j + 7].BorderBrush = highlighted;
								chessboard[i - 7, j + 7].Tag = "highlighted";
							}

							if (i - 1 >= 0 && i - 1 <= 7 && j >= 0 && j <= 7)
							{
								fchessboard[i - 1, j].BorderThickness = new Thickness(2);
								fchessboard[i - 1, j].BorderBrush = highlighted;
								chessboard[i - 1, j].Tag = "highlighted";
							}


							if (i + 1 >= 0 && i + 1 <= 7 && j >= 0 && j <= 7)
							{
								fchessboard[i + 1, j].BorderThickness = new Thickness(2);
								fchessboard[i + 1, j].BorderBrush = highlighted;
								chessboard[i + 1, j].Tag = "highlighted";
							}



							if (j - 1 >= 0 && j - 1 <= 7)
							{
								fchessboard[i, j - 1].BorderThickness = new Thickness(2);
								fchessboard[i, j - 1].BorderBrush = highlighted;
								chessboard[i, j - 1].Tag = "highlighted";
							}


							if (j + 1 >= 0 && j + 1 <= 7)
							{
								fchessboard[i, j + 1].BorderThickness = new Thickness(2);
								fchessboard[i, j + 1].BorderBrush = highlighted;
								chessboard[i, j + 1].Tag = "highlighted";
							}


							if (i - 2 >= 0 && i - 2 <= 7 && j >= 0 && j <= 7)
							{
								fchessboard[i - 2, j].BorderThickness = new Thickness(2);
								fchessboard[i - 2, j].BorderBrush = highlighted;
								chessboard[i - 2, j].Tag = "highlighted";
							}


							if (i + 2 >= 0 && i + 2 <= 7 && j >= 0 && j <= 7)
							{
								fchessboard[i + 2, j].BorderThickness = new Thickness(2);
								fchessboard[i + 2, j].BorderBrush = highlighted;
								chessboard[i + 2, j].Tag = "highlighted";
							}



							if (j - 2 >= 0 && j - 2 <= 7)
							{
								fchessboard[i, j - 2].BorderThickness = new Thickness(2);
								fchessboard[i, j - 2].BorderBrush = highlighted;
								chessboard[i, j - 2].Tag = "highlighted";
							}


							if (j + 2 >= 0 && j + 2 <= 7)
							{
								fchessboard[i, j + 2].BorderThickness = new Thickness(2);
								fchessboard[i, j + 2].BorderBrush = highlighted;
								chessboard[i, j + 2].Tag = "highlighted";
							}


							if (i - 3 >= 0 && i - 3 <= 7 && j >= 0 && j <= 7)
							{
								fchessboard[i - 3, j].BorderThickness = new Thickness(2);
								fchessboard[i - 3, j].BorderBrush = highlighted;
								chessboard[i - 3, j].Tag = "highlighted";
							}


							if (i + 3 >= 0 && i + 3 <= 7 && j >= 0 && j <= 7)
							{
								fchessboard[i + 3, j].BorderThickness = new Thickness(2);
								fchessboard[i + 3, j].BorderBrush = highlighted;
								chessboard[i + 3, j].Tag = "highlighted";
							}



							if (j - 3 >= 0 && j - 3 <= 7)
							{
								fchessboard[i, j - 3].BorderThickness = new Thickness(2);
								fchessboard[i, j - 3].BorderBrush = highlighted;
								chessboard[i, j - 3].Tag = "highlighted";
							}


							if (j + 3 >= 0 && j + 3 <= 7)
							{
								fchessboard[i, j + 3].BorderThickness = new Thickness(2);
								fchessboard[i, j + 3].BorderBrush = highlighted;
								chessboard[i, j + 3].Tag = "highlighted";
							}


							if (i - 4 >= 0 && i - 4 <= 7 && j >= 0 && j <= 7)
							{
								fchessboard[i - 4, j].BorderThickness = new Thickness(2);
								fchessboard[i - 4, j].BorderBrush = highlighted;
								chessboard[i - 4, j].Tag = "highlighted";
							}


							if (i + 4 >= 0 && i + 4 <= 7 && j >= 0 && j <= 7)
							{
								fchessboard[i + 4, j].BorderThickness = new Thickness(2);
								fchessboard[i + 4, j].BorderBrush = highlighted;
								chessboard[i + 4, j].Tag = "highlighted";
							}



							if (j - 4 >= 0 && j - 4 <= 7)
							{
								fchessboard[i, j - 4].BorderThickness = new Thickness(2);
								fchessboard[i, j - 4].BorderBrush = highlighted;
								chessboard[i, j - 4].Tag = "highlighted";
							}


							if (j + 4 >= 0 && j + 4 <= 7)
							{
								fchessboard[i, j + 4].BorderThickness = new Thickness(2);
								fchessboard[i, j + 4].BorderBrush = highlighted;
								chessboard[i, j + 4].Tag = "highlighted";
							}


							if (i - 5 >= 0 && i - 5 <= 7 && j >= 0 && j <= 7)
							{
								fchessboard[i - 5, j].BorderThickness = new Thickness(2);
								fchessboard[i - 5, j].BorderBrush = highlighted;
								chessboard[i - 5, j].Tag = "highlighted";
							}


							if (i + 5 >= 0 && i + 5 <= 7 && j >= 0 && j <= 7)
							{
								fchessboard[i + 5, j].BorderThickness = new Thickness(2);
								fchessboard[i + 5, j].BorderBrush = highlighted;
								chessboard[i + 5, j].Tag = "highlighted";
							}



							if (j - 5 >= 0 && j - 5 <= 7)
							{
								fchessboard[i, j - 5].BorderThickness = new Thickness(2);
								fchessboard[i, j - 5].BorderBrush = highlighted;
								chessboard[i, j - 5].Tag = "highlighted";
							}


							if (j + 5 >= 0 && j + 5 <= 7)
							{
								fchessboard[i, j + 5].BorderThickness = new Thickness(2);
								fchessboard[i, j + 5].BorderBrush = highlighted;
								chessboard[i, j + 5].Tag = "highlighted";
							}


							if (i - 6 >= 0 && i - 6 <= 7 && j >= 0 && j <= 7)
							{
								fchessboard[i - 6, j].BorderThickness = new Thickness(2);
								fchessboard[i - 6, j].BorderBrush = highlighted;
								chessboard[i - 6, j].Tag = "highlighted";
							}


							if (i + 6 >= 0 && i + 6 <= 7 && j >= 0 && j <= 7)
							{
								fchessboard[i + 6, j].BorderThickness = new Thickness(2);
								fchessboard[i + 6, j].BorderBrush = highlighted;
								chessboard[i + 6, j].Tag = "highlighted";
							}



							if (j - 6 >= 0 && j - 6 <= 7)
							{
								fchessboard[i, j - 6].BorderThickness = new Thickness(2);
								fchessboard[i, j - 6].BorderBrush = highlighted;
								chessboard[i, j - 6].Tag = "highlighted";
							}


							if (j + 6 >= 0 && j + 6 <= 7)
							{
								fchessboard[i, j + 6].BorderThickness = new Thickness(2);
								fchessboard[i, j + 6].BorderBrush = highlighted;
								chessboard[i, j + 6].Tag = "highlighted";
							}


							if (i - 7 >= 0 && i - 7 <= 7 && j >= 0 && j <= 7)
							{
								fchessboard[i - 7, j].BorderThickness = new Thickness(2);
								fchessboard[i - 7, j].BorderBrush = highlighted;
								chessboard[i - 7, j].Tag = "highlighted";
							}


							if (i + 7 >= 0 && i + 7 <= 7 && j >= 0 && j <= 7)
							{
								fchessboard[i + 7, j].BorderThickness = new Thickness(2);
								fchessboard[i + 7, j].BorderBrush = highlighted;
								chessboard[i + 7, j].Tag = "highlighted";
							}



							if (j - 7 >= 0 && j - 7 <= 7)
							{
								fchessboard[i, j - 7].BorderThickness = new Thickness(2);
								fchessboard[i, j - 7].BorderBrush = highlighted;
								chessboard[i, j - 7].Tag = "highlighted";
							}


							if (j + 7 >= 0 && j + 7 <= 7)
							{
								fchessboard[i, j + 7].BorderThickness = new Thickness(2);
								fchessboard[i, j + 7].BorderBrush = highlighted;
								chessboard[i, j + 7].Tag = "highlighted";
							}
						}

						if (chessboard[i, j].Content.ToString() == "bKrol" || chessboard[i, j].Content.ToString() == "cKrol")
						{
							if (i - 1 >= 0 && i - 1 <= 7 && j >= 0 && j <= 7)
							{
								fchessboard[i - 1, j].BorderThickness = new Thickness(2);
								fchessboard[i - 1, j].BorderBrush = highlighted;
								chessboard[i - 1, j].Tag = "highlighted";
							}
							

							if (i + 1 >= 0 && i + 1 <= 7 && j >= 0 && j <= 7)
							{
								fchessboard[i + 1, j].BorderThickness = new Thickness(2);
								fchessboard[i + 1, j].BorderBrush = highlighted;
								chessboard[i + 1, j].Tag = "highlighted";
							}



							if (j - 1 >= 0 && j - 1 <= 7)
							{
								fchessboard[i, j -1].BorderThickness = new Thickness(2);
								fchessboard[i, j -1].BorderBrush = highlighted;
								chessboard[i , j-1].Tag = "highlighted";
							}


							if (j + 1 >= 0 && j + 1 <= 7)
							{
								fchessboard[i , j+1].BorderThickness = new Thickness(2);
								fchessboard[i, j+1].BorderBrush = highlighted;
								chessboard[i , j+1].Tag = "highlighted";
							}




							if (i - 1 >= 0 && i - 1 <= 7 && j - 1 >= 0 && j - 1 <= 7)
							{
								fchessboard[i-1, j-1].BorderThickness = new Thickness(2);
								fchessboard[i-1, j-1].BorderBrush = highlighted;
								chessboard[i-1, j-1].Tag = "highlighted";
							}





							if (i + 1 >= 0 && i + 1 <= 7 && j + 1 >= 0 && j + 1 <= 7)
							{
								fchessboard[i+1, j+1].BorderThickness = new Thickness(2);
								fchessboard[i+1, j+1].BorderBrush = highlighted;
								chessboard[i+1, j+1].Tag = "highlighted";
							}





							if (i + 1 >= 0 && i + 1 <= 7 && j - 1 >= 0 && j - 1 <= 7)
							{
								fchessboard[i+1, j-1].BorderThickness = new Thickness(2);
								fchessboard[i+1, j-1].BorderBrush = highlighted;
								chessboard[i+1, j-1].Tag = "highlighted";
							}





							if (i - 1 >= 0 && i - 1 <= 7 && j + 1 >= 0 && j + 1 <= 7)
							{
								fchessboard[i-1, j+1].BorderThickness = new Thickness(2);
								fchessboard[i-1, j+1].BorderBrush = highlighted;
								chessboard[i-1, j+1].Tag = "highlighted";
							}



						}

						// Czarne

						if (chessboard[i, j].Content.ToString() == "cPion")
						{
							if (i >= 0 && i <= 7 && j -1>= 0 && j -1<= 7)
							{
								fchessboard[i, j-1].BorderThickness = new Thickness(2);
								fchessboard[i, j-1].BorderBrush = highlighted;
								chessboard[i, j-1].Tag = "highlighted";
							}
								


							if (i >= 0 && i <= 7 && j -2>= 0 && j -2<= 7)
							{
								fchessboard[i, j-2].BorderThickness = new Thickness(2);
								fchessboard[i, j-2].BorderBrush = highlighted;
								chessboard[i, j-2].Tag = "highlighted";
							}
								
						}
						//if (chessboard[i, j].Content.ToString() == "cWieza")
						//{
						//	chessboard[i + 1, j].Background = highlighted;
						//	chessboard[i + 2, j].Background = highlighted;
						//}
						//if (chessboard[i, j].Content.ToString() == "cKon")
						//{
						//	chessboard[i + 1, j].Background = highlighted;
						//	chessboard[i + 2, j].Background = highlighted;
						//}
						//if (chessboard[i, j].Content.ToString() == "cLaufer")
						//{
						//	chessboard[i + 1, j].Background = highlighted;
						//	chessboard[i + 2, j].Background = highlighted;
						//}
						//if (chessboard[i, j].Content.ToString() == "cKrolowa")
						//{
						//	chessboard[i + 1, j].Background = highlighted;
						//	chessboard[i + 2, j].Background = highlighted;
						//}
						//if (chessboard[i, j].Content.ToString() == "cKrol")
						//{
						//	chessboard[i + 1, j].Background = highlighted;
						//	chessboard[i + 2, j].Background = highlighted;
						//}
					}
		}

		private void startButton_Click(object sender, RoutedEventArgs e)
		{
			startButton.Visibility = Visibility.Hidden;
			startBackground.Visibility = Visibility.Hidden;
		}
	}
}
