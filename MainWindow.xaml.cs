﻿using System;
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

		private void assignFields()
		{
			chessboard[0, 0] = a1;
			chessboard[0, 1] = b1;
			chessboard[0, 2] = c1;
			chessboard[0, 3] = d1;
			chessboard[0, 4] = e1;
			chessboard[0, 5] = f1;
			chessboard[0, 6] = g1;
			chessboard[0, 7] = h1;

			chessboard[1, 0] = a2;
			chessboard[1, 1] = b2;
			chessboard[1, 2] = c2;
			chessboard[1, 3] = d2;
			chessboard[1, 4] = e2;
			chessboard[1, 5] = f2;
			chessboard[1, 6] = g2;
			chessboard[1, 7] = h2;

			chessboard[2, 0] = a3;
			chessboard[2, 1] = b3;
			chessboard[2, 2] = c3;
			chessboard[2, 3] = d3;
			chessboard[2, 4] = e3;
			chessboard[2, 5] = f3;
			chessboard[2, 6] = g3;
			chessboard[2, 7] = h3;

			chessboard[3, 0] = a4;
			chessboard[3, 1] = b4;
			chessboard[3, 2] = c4;
			chessboard[3, 3] = d4;
			chessboard[3, 4] = e4;
			chessboard[3, 5] = f4;
			chessboard[3, 6] = g4;
			chessboard[3, 7] = h4;

			chessboard[4, 0] = a5;
			chessboard[4, 1] = b5;
			chessboard[4, 2] = c5;
			chessboard[4, 3] = d5;
			chessboard[4, 4] = e5;
			chessboard[4, 5] = f5;
			chessboard[4, 6] = g5;
			chessboard[4, 7] = h5;

			chessboard[5, 0] = a6;
			chessboard[5, 1] = b6;
			chessboard[5, 2] = c6;
			chessboard[5, 3] = d6;
			chessboard[5, 4] = e6;
			chessboard[5, 5] = f6;
			chessboard[5, 6] = g6;
			chessboard[5, 7] = h6;

			chessboard[6, 0] = a7;
			chessboard[6, 1] = b7;
			chessboard[6, 2] = c7;
			chessboard[6, 3] = d7;
			chessboard[6, 4] = e7;
			chessboard[6, 5] = f7;
			chessboard[6, 6] = g7;
			chessboard[6, 7] = h7;

			chessboard[7, 0] = a8;
			chessboard[7, 1] = b8;
			chessboard[7, 2] = c8;
			chessboard[7, 3] = d8;
			chessboard[7, 4] = e8;
			chessboard[7, 5] = f8;
			chessboard[7, 6] = g8;
			chessboard[7, 7] = h8;
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
			for (int i = 0; i < 8; i += 2)
				for (int j = 0; j < 8; j += 2)
				{
					chessboard[i, j].Background = light;
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
					if (chessboard[i, j].Background == selected)
					{
						String temp = chessboard[i, j].Content.ToString();
						chessboard[i, j].Content = "";
						return temp;
					}
			return "";
		}

		private void fieldClick(object sender, RoutedEventArgs e)
		{
			if ((sender as Button).Background == highlighted)
			{
				(sender as Button).Content = findSelected(sender);
				clearSelection();
				return;
			}
			clearSelection();
			(sender as Button).Background = selected;
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
							chessboard[i - 1, j].Background = highlighted;
							chessboard[i - 2, j].Background = highlighted;
						}
						if (chessboard[i, j].Content.ToString() == "bWieza")
						{
							chessboard[i - 1, j].Background = highlighted;
							chessboard[i - 2, j].Background = highlighted;
						}
						if (chessboard[i, j].Content.ToString() == "bKon")
						{
							chessboard[i - 1, j].Background = highlighted;
							chessboard[i - 2, j].Background = highlighted;
						}
						if (chessboard[i, j].Content.ToString() == "bLaufer")
						{
							chessboard[i - 1, j].Background = highlighted;
							chessboard[i - 2, j].Background = highlighted;
						}
						if (chessboard[i, j].Content.ToString() == "bKrolowa")
						{
							chessboard[i - 1, j].Background = highlighted;
							chessboard[i - 2, j].Background = highlighted;
						}
						if (chessboard[i, j].Content.ToString() == "bKrol")
						{
							chessboard[i - 1, j].Background = highlighted;
							chessboard[i - 2, j].Background = highlighted;
						}

						// Czarne

						if (chessboard[i, j].Content.ToString() == "cPion")
						{
							chessboard[i + 1, j].Background = highlighted;
							chessboard[i + 2, j].Background = highlighted;
						}
						if (chessboard[i, j].Content.ToString() == "cWieza")
						{
							chessboard[i + 1, j].Background = highlighted;
							chessboard[i + 2, j].Background = highlighted;
						}
						if (chessboard[i, j].Content.ToString() == "cKon")
						{
							chessboard[i + 1, j].Background = highlighted;
							chessboard[i + 2, j].Background = highlighted;
						}
						if (chessboard[i, j].Content.ToString() == "cLaufer")
						{
							chessboard[i + 1, j].Background = highlighted;
							chessboard[i + 2, j].Background = highlighted;
						}
						if (chessboard[i, j].Content.ToString() == "cKrolowa")
						{
							chessboard[i + 1, j].Background = highlighted;
							chessboard[i + 2, j].Background = highlighted;
						}
						if (chessboard[i, j].Content.ToString() == "cKrol")
						{
							chessboard[i + 1, j].Background = highlighted;
							chessboard[i + 2, j].Background = highlighted;
						}
					}
		}
						
	}
}
