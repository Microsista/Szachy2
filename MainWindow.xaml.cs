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

		Game game = new Game();

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
			chessboard[7, 0] = a1;
			chessboard[7, 1] = b1;
			chessboard[7, 2] = c1;
			chessboard[7, 3] = d1;
			chessboard[7, 4] = e1;
			chessboard[7, 5] = f1;
			chessboard[7, 6] = g1;
			chessboard[7, 7] = h1;

			chessboard[6, 0] = a2;
			chessboard[6, 1] = b2;
			chessboard[6, 2] = c2;
			chessboard[6, 3] = d2;
			chessboard[6, 4] = e2;
			chessboard[6, 5] = f2;
			chessboard[6, 6] = g2;
			chessboard[6, 7] = h2;

			chessboard[5, 0] = a3;
			chessboard[5, 1] = b3;
			chessboard[5, 2] = c3;
			chessboard[5, 3] = d3;
			chessboard[5, 4] = e3;
			chessboard[5, 5] = f3;
			chessboard[5, 6] = g3;
			chessboard[5, 7] = h3;

			chessboard[4, 0] = a4;
			chessboard[4, 1] = b4;
			chessboard[4, 2] = c4;
			chessboard[4, 3] = d4;
			chessboard[4, 4] = e4;
			chessboard[4, 5] = f4;
			chessboard[4, 6] = g4;
			chessboard[4, 7] = h4;

			chessboard[3, 0] = a5;
			chessboard[3, 1] = b5;
			chessboard[3, 2] = c5;
			chessboard[3, 3] = d5;
			chessboard[3, 4] = e5;
			chessboard[3, 5] = f5;
			chessboard[3, 6] = g5;
			chessboard[3, 7] = h5;

			chessboard[2, 0] = a6;
			chessboard[2, 1] = b6;
			chessboard[2, 2] = c6;
			chessboard[2, 3] = d6;
			chessboard[2, 4] = e6;
			chessboard[2, 5] = f6;
			chessboard[2, 6] = g6;
			chessboard[2, 7] = h6;

			chessboard[1, 0] = a7;
			chessboard[1, 1] = b7;
			chessboard[1, 2] = c7;
			chessboard[1, 3] = d7;
			chessboard[1, 4] = e7;
			chessboard[1, 5] = f7;
			chessboard[1, 6] = g7;
			chessboard[1, 7] = h7;

			chessboard[0, 0] = a8;
			chessboard[0, 1] = b8;
			chessboard[0, 2] = c8;
			chessboard[0, 3] = d8;
			chessboard[0, 4] = e8;
			chessboard[0, 5] = f8;
			chessboard[0, 6] = g8;
			chessboard[0, 7] = h8;


			fchessboard[7, 0] = fa1;
			fchessboard[7, 1] = fb1;
			fchessboard[7, 2] = fc1;
			fchessboard[7, 3] = fd1;
			fchessboard[7, 4] = fe1;
			fchessboard[7, 5] = ff1;
			fchessboard[7, 6] = fg1;
			fchessboard[7, 7] = fh1;

			fchessboard[6, 0] = fa2;
			fchessboard[6, 1] = fb2;
			fchessboard[6, 2] = fc2;
			fchessboard[6, 3] = fd2;
			fchessboard[6, 4] = fe2;
			fchessboard[6, 5] = ff2;
			fchessboard[6, 6] = fg2;
			fchessboard[6, 7] = fh2;

			fchessboard[5, 0] = fa3;
			fchessboard[5, 1] = fb3;
			fchessboard[5, 2] = fc3;
			fchessboard[5, 3] = fd3;
			fchessboard[5, 4] = fe3;
			fchessboard[5, 5] = ff3;
			fchessboard[5, 6] = fg3;
			fchessboard[5, 7] = fh3;

			fchessboard[4, 0] = fa4;
			fchessboard[4, 1] = fb4;
			fchessboard[4, 2] = fc4;
			fchessboard[4, 3] = fd4;
			fchessboard[4, 4] = fe4;
			fchessboard[4, 5] = ff4;
			fchessboard[4, 6] = fg4;
			fchessboard[4, 7] = fh4;

			fchessboard[3, 0] = fa5;
			fchessboard[3, 1] = fb5;
			fchessboard[3, 2] = fc5;
			fchessboard[3, 3] = fd5;
			fchessboard[3, 4] = fe5;
			fchessboard[3, 5] = ff5;
			fchessboard[3, 6] = fg5;
			fchessboard[3, 7] = fh5;

			fchessboard[2, 0] = fa6;
			fchessboard[2, 1] = fb6;
			fchessboard[2, 2] = fc6;
			fchessboard[2, 3] = fd6;
			fchessboard[2, 4] = fe6;
			fchessboard[2, 5] = ff6;
			fchessboard[2, 6] = fg6;
			fchessboard[2, 7] = fh6;

			fchessboard[1, 0] = fa7;
			fchessboard[1, 1] = fb7;
			fchessboard[1, 2] = fc7;
			fchessboard[1, 3] = fd7;
			fchessboard[1, 4] = fe7;
			fchessboard[1, 5] = ff7;
			fchessboard[1, 6] = fg7;
			fchessboard[1, 7] = fh7;

			fchessboard[0, 0] = fa8;
			fchessboard[0, 1] = fb8;
			fchessboard[0, 2] = fc8;
			fchessboard[0, 3] = fd8;
			fchessboard[0, 4] = fe8;
			fchessboard[0, 5] = ff8;
			fchessboard[0, 6] = fg8;
			fchessboard[0, 7] = fh8;
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
					
					if (game.GetChessBoard().GetSquare(i, j).GetPiece() != null)
					{
						// Biale
						if (game.GetChessBoard().GetSquare(i, j).GetPiece().GetColor() == Constants.White && game.GetChessBoard().GetSquare(i, j).GetPiece().GetType() == typeof(Pawn))
						{
							chessboard[i, j].Background = bPionJ;
						}
						if (game.GetChessBoard().GetSquare(i, j).GetPiece().GetColor() == Constants.White && game.GetChessBoard().GetSquare(i, j).GetPiece().GetType() == typeof(Rook))
						{
							chessboard[i, j].Background = bWiezaJ;
						}
						if (game.GetChessBoard().GetSquare(i, j).GetPiece().GetColor() == Constants.White && game.GetChessBoard().GetSquare(i, j).GetPiece().GetType() == typeof(Knight))
						{
							chessboard[i, j].Background = bKonJ;
						}
						if (game.GetChessBoard().GetSquare(i, j).GetPiece().GetColor() == Constants.White && game.GetChessBoard().GetSquare(i, j).GetPiece().GetType() == typeof(Bishop))
						{
							chessboard[i, j].Background = bLauferJ;
						}
						if (game.GetChessBoard().GetSquare(i, j).GetPiece().GetColor() == Constants.White && game.GetChessBoard().GetSquare(i, j).GetPiece().GetType() == typeof(Queen))
						{
							chessboard[i, j].Background = bKrolowaJ;
						}
						if (game.GetChessBoard().GetSquare(i, j).GetPiece().GetColor() == Constants.White && game.GetChessBoard().GetSquare(i, j).GetPiece().GetType() == typeof(King))
						{
							chessboard[i, j].Background = bKrolJ;
						}

						

						// Czarne
						if (game.GetChessBoard().GetSquare(i, j).GetPiece().GetColor() == Constants.Black && game.GetChessBoard().GetSquare(i, j).GetPiece().GetType() == typeof(Pawn))
						{
							chessboard[i, j].Background = cPionJ;
						}
						if (game.GetChessBoard().GetSquare(i, j).GetPiece().GetColor() == Constants.Black && game.GetChessBoard().GetSquare(i, j).GetPiece().GetType() == typeof(Rook))
						{
							chessboard[i, j].Background = cWiezaJ;
						}
						if (game.GetChessBoard().GetSquare(i, j).GetPiece().GetColor() == Constants.Black && game.GetChessBoard().GetSquare(i, j).GetPiece().GetType() == typeof(Knight))
						{
							chessboard[i, j].Background = cKonJ;
						}
						if (game.GetChessBoard().GetSquare(i, j).GetPiece().GetColor() == Constants.Black && game.GetChessBoard().GetSquare(i, j).GetPiece().GetType() == typeof(Bishop))
						{
							chessboard[i, j].Background = cLauferJ;
						}
						if (game.GetChessBoard().GetSquare(i, j).GetPiece().GetColor() == Constants.Black && game.GetChessBoard().GetSquare(i, j).GetPiece().GetType() == typeof(Queen))
						{
							chessboard[i, j].Background = cKrolowaJ;
						}
						if (game.GetChessBoard().GetSquare(i, j).GetPiece().GetColor() == Constants.Black && game.GetChessBoard().GetSquare(i, j).GetPiece().GetType() == typeof(King))
						{
							chessboard[i, j].Background = cKrolJ;
						}
						
					}


					//if (chessboard[i, j].Content.ToString() == "bPion")
					//{
					//	chessboard[i, j].Background = bPionJ;
					//}
					//if (chessboard[i, j].Content.ToString() == "bWieza")
					//{
					//	chessboard[i, j].Background = bWiezaJ;
					//}
					//if (chessboard[i, j].Content.ToString() == "bKon")
					//{
					//	chessboard[i, j].Background = bKonJ;
					//}
					//if (chessboard[i, j].Content.ToString() == "bLaufer")
					//{
					//	chessboard[i, j].Background = bLauferJ;
					//}
					//if (chessboard[i, j].Content.ToString() == "bKrolowa")
					//{
					//	chessboard[i, j].Background = bKrolowaJ;
					//}
					//if (chessboard[i, j].Content.ToString() == "bKrol")
					//{
					//	chessboard[i, j].Background = bKrolJ;
					//}

					//if (chessboard[i, j].Content.ToString() == "cPion")
					//{
					//	chessboard[i, j].Background = cPionJ;
					//}
					//if (chessboard[i, j].Content.ToString() == "cWieza")
					//{
					//	chessboard[i, j].Background = cWiezaJ;
					//}
					//if (chessboard[i, j].Content.ToString() == "cKon")
					//{
					//	chessboard[i, j].Background = cKonJ;
					//}
					//if (chessboard[i, j].Content.ToString() == "cLaufer")
					//{
					//	chessboard[i, j].Background = cLauferJ;
					//}
					//if (chessboard[i, j].Content.ToString() == "cKrolowa")
					//{
					//	chessboard[i, j].Background = cKrolowaJ;
					//}
					//if (chessboard[i, j].Content.ToString() == "cKrol")
					//{
					//	chessboard[i, j].Background = cKrolJ;
					//}
				}


			for (int i = 1; i < 8; i += 2)
				for (int j = 1; j < 8; j += 2)
				{
					chessboard[i, j].Background = light;
					chessboard[i, j].Tag = "";
					if (game.GetChessBoard().GetSquare(i, j).GetPiece() != null)
					{
						// Biale
						if (game.GetChessBoard().GetSquare(i, j).GetPiece().GetColor() == Constants.White && game.GetChessBoard().GetSquare(i, j).GetPiece().GetType() == typeof(Pawn))
						{
							chessboard[i, j].Background = bPionJ;
						}
						if (game.GetChessBoard().GetSquare(i, j).GetPiece().GetColor() == Constants.White && game.GetChessBoard().GetSquare(i, j).GetPiece().GetType() == typeof(Rook))
						{
							chessboard[i, j].Background = bWiezaJ;
						}
						if (game.GetChessBoard().GetSquare(i, j).GetPiece().GetColor() == Constants.White && game.GetChessBoard().GetSquare(i, j).GetPiece().GetType() == typeof(Knight))
						{
							chessboard[i, j].Background = bKonJ;
						}
						if (game.GetChessBoard().GetSquare(i, j).GetPiece().GetColor() == Constants.White && game.GetChessBoard().GetSquare(i, j).GetPiece().GetType() == typeof(Bishop))
						{
							chessboard[i, j].Background = bLauferJ;
						}
						if (game.GetChessBoard().GetSquare(i, j).GetPiece().GetColor() == Constants.White && game.GetChessBoard().GetSquare(i, j).GetPiece().GetType() == typeof(Queen))
						{
							chessboard[i, j].Background = bKrolowaJ;
						}
						if (game.GetChessBoard().GetSquare(i, j).GetPiece().GetColor() == Constants.White && game.GetChessBoard().GetSquare(i, j).GetPiece().GetType() == typeof(King))
						{
							chessboard[i, j].Background = bKrolJ;
						}



						// Czarne
						if (game.GetChessBoard().GetSquare(i, j).GetPiece().GetColor() == Constants.Black && game.GetChessBoard().GetSquare(i, j).GetPiece().GetType() == typeof(Pawn))
						{
							chessboard[i, j].Background = cPionJ;
						}
						if (game.GetChessBoard().GetSquare(i, j).GetPiece().GetColor() == Constants.Black && game.GetChessBoard().GetSquare(i, j).GetPiece().GetType() == typeof(Rook))
						{
							chessboard[i, j].Background = cWiezaJ;
						}
						if (game.GetChessBoard().GetSquare(i, j).GetPiece().GetColor() == Constants.Black && game.GetChessBoard().GetSquare(i, j).GetPiece().GetType() == typeof(Knight))
						{
							chessboard[i, j].Background = cKonJ;
						}
						if (game.GetChessBoard().GetSquare(i, j).GetPiece().GetColor() == Constants.Black && game.GetChessBoard().GetSquare(i, j).GetPiece().GetType() == typeof(Bishop))
						{
							chessboard[i, j].Background = cLauferJ;
						}
						if (game.GetChessBoard().GetSquare(i, j).GetPiece().GetColor() == Constants.Black && game.GetChessBoard().GetSquare(i, j).GetPiece().GetType() == typeof(Queen))
						{
							chessboard[i, j].Background = cKrolowaJ;
						}
						if (game.GetChessBoard().GetSquare(i, j).GetPiece().GetColor() == Constants.Black && game.GetChessBoard().GetSquare(i, j).GetPiece().GetType() == typeof(King))
						{
							chessboard[i, j].Background = cKrolJ;
						}

					}
					//// Biale

					//if (chessboard[i, j].Content.ToString() == "bPion")
					//{
					//	chessboard[i, j].Background = bPionJ;
					//}
					//if (chessboard[i, j].Content.ToString() == "bWieza")
					//{
					//	chessboard[i, j].Background = bWiezaJ;
					//}
					//if (chessboard[i, j].Content.ToString() == "bKon")
					//{
					//	chessboard[i, j].Background = bKonJ;
					//}
					//if (chessboard[i, j].Content.ToString() == "bLaufer")
					//{
					//	chessboard[i, j].Background = bLauferJ;
					//}
					//if (chessboard[i, j].Content.ToString() == "bKrolowa")
					//{
					//	chessboard[i, j].Background = bKrolowaJ;
					//}
					//if (chessboard[i, j].Content.ToString() == "bKrol")
					//{
					//	chessboard[i, j].Background = bKrolJ;
					//}

					//// Czarne

					//if (chessboard[i, j].Content.ToString() == "cPion")
					//{
					//	chessboard[i, j].Background = cPionJ;
					//}
					//if (chessboard[i, j].Content.ToString() == "cWieza")
					//{
					//	chessboard[i, j].Background = cWiezaJ;
					//}
					//if (chessboard[i, j].Content.ToString() == "cKon")
					//{
					//	chessboard[i, j].Background = cKonJ;
					//}
					//if (chessboard[i, j].Content.ToString() == "cLaufer")
					//{
					//	chessboard[i, j].Background = cLauferJ;
					//}
					//if (chessboard[i, j].Content.ToString() == "cKrolowa")
					//{
					//	chessboard[i, j].Background = cKrolowaJ;
					//}
					//if (chessboard[i, j].Content.ToString() == "cKrol")
					//{
					//	chessboard[i, j].Background = cKrolJ;
					//}
				}
					

			for (int i = 1; i < 8; i += 2)
				for (int j = 0; j < 8; j += 2)
				{
					chessboard[i, j].Background = dark;
					chessboard[i, j].Tag = "";
					if (game.GetChessBoard().GetSquare(i, j).GetPiece() != null)
					{
						// Biale
						if (game.GetChessBoard().GetSquare(i, j).GetPiece().GetColor() == Constants.White && game.GetChessBoard().GetSquare(i, j).GetPiece().GetType() == typeof(Pawn))
						{
							chessboard[i, j].Background = bPionC;
						}
						if (game.GetChessBoard().GetSquare(i, j).GetPiece().GetColor() == Constants.White && game.GetChessBoard().GetSquare(i, j).GetPiece().GetType() == typeof(Rook))
						{
							chessboard[i, j].Background = bWiezaC;
						}
						if (game.GetChessBoard().GetSquare(i, j).GetPiece().GetColor() == Constants.White && game.GetChessBoard().GetSquare(i, j).GetPiece().GetType() == typeof(Knight))
						{
							chessboard[i, j].Background = bKonC;
						}
						if (game.GetChessBoard().GetSquare(i, j).GetPiece().GetColor() == Constants.White && game.GetChessBoard().GetSquare(i, j).GetPiece().GetType() == typeof(Bishop))
						{
							chessboard[i, j].Background = bLauferC;
						}
						if (game.GetChessBoard().GetSquare(i, j).GetPiece().GetColor() == Constants.White && game.GetChessBoard().GetSquare(i, j).GetPiece().GetType() == typeof(Queen))
						{
							chessboard[i, j].Background = bKrolowaC;
						}
						if (game.GetChessBoard().GetSquare(i, j).GetPiece().GetColor() == Constants.White && game.GetChessBoard().GetSquare(i, j).GetPiece().GetType() == typeof(King))
						{
							chessboard[i, j].Background = bKrolC;
						}



						// Czarne
						if (game.GetChessBoard().GetSquare(i, j).GetPiece().GetColor() == Constants.Black && game.GetChessBoard().GetSquare(i, j).GetPiece().GetType() == typeof(Pawn))
						{
							chessboard[i, j].Background = cPionC;
						}
						if (game.GetChessBoard().GetSquare(i, j).GetPiece().GetColor() == Constants.Black && game.GetChessBoard().GetSquare(i, j).GetPiece().GetType() == typeof(Rook))
						{
							chessboard[i, j].Background = cWiezaC;
						}
						if (game.GetChessBoard().GetSquare(i, j).GetPiece().GetColor() == Constants.Black && game.GetChessBoard().GetSquare(i, j).GetPiece().GetType() == typeof(Knight))
						{
							chessboard[i, j].Background = cKonC;
						}
						if (game.GetChessBoard().GetSquare(i, j).GetPiece().GetColor() == Constants.Black && game.GetChessBoard().GetSquare(i, j).GetPiece().GetType() == typeof(Bishop))
						{
							chessboard[i, j].Background = cLauferC;
						}
						if (game.GetChessBoard().GetSquare(i, j).GetPiece().GetColor() == Constants.Black && game.GetChessBoard().GetSquare(i, j).GetPiece().GetType() == typeof(Queen))
						{
							chessboard[i, j].Background = cKrolowaC;
						}
						if (game.GetChessBoard().GetSquare(i, j).GetPiece().GetColor() == Constants.Black && game.GetChessBoard().GetSquare(i, j).GetPiece().GetType() == typeof(King))
						{
							chessboard[i, j].Background = cKrolC;
						}

					}
					////Biale

					//if (chessboard[i, j].Content.ToString() == "bPion")
					//{
					//	chessboard[i, j].Background = bPionC;
					//}
					//if (chessboard[i, j].Content.ToString() == "bWieza")
					//{
					//	chessboard[i, j].Background = bWiezaC;
					//}
					//if (chessboard[i, j].Content.ToString() == "bKon")
					//{
					//	chessboard[i, j].Background = bKonC;
					//}
					//if (chessboard[i, j].Content.ToString() == "bLaufer")
					//{
					//	chessboard[i, j].Background = bLauferC;
					//}
					//if (chessboard[i, j].Content.ToString() == "bKrolowa")
					//{
					//	chessboard[i, j].Background = bKrolowaC;
					//}
					//if (chessboard[i, j].Content.ToString() == "bKrol")
					//{
					//	chessboard[i, j].Background = bKrolC;
					//}

					//// Czarne

					//if (chessboard[i, j].Content.ToString() == "cPion")
					//{
					//	chessboard[i, j].Background = cPionC;
					//}
					//if (chessboard[i, j].Content.ToString() == "cWieza")
					//{
					//	chessboard[i, j].Background = cWiezaC;
					//}
					//if (chessboard[i, j].Content.ToString() == "cKon")
					//{
					//	chessboard[i, j].Background = cKonC;
					//}
					//if (chessboard[i, j].Content.ToString() == "cLaufer")
					//{
					//	chessboard[i, j].Background = cLauferC;
					//}
					//if (chessboard[i, j].Content.ToString() == "cKrolowa")
					//{
					//	chessboard[i, j].Background = cKrolowaC;
					//}
					//if (chessboard[i, j].Content.ToString() == "cKrol")
					//{
					//	chessboard[i, j].Background = cKrolC;
					//}


				}


			for (int i = 0; i < 8; i += 2)
				for (int j = 1; j < 8; j += 2)
				{
					chessboard[i, j].Background = dark;
					chessboard[i, j].Tag = "";

					if (game.GetChessBoard().GetSquare(i, j).GetPiece() != null)
					{
						// Biale
						if (game.GetChessBoard().GetSquare(i, j).GetPiece().GetColor() == Constants.White && game.GetChessBoard().GetSquare(i, j).GetPiece().GetType() == typeof(Pawn))
						{
							chessboard[i, j].Background = bPionC;
						}
						if (game.GetChessBoard().GetSquare(i, j).GetPiece().GetColor() == Constants.White && game.GetChessBoard().GetSquare(i, j).GetPiece().GetType() == typeof(Rook))
						{
							chessboard[i, j].Background = bWiezaC;
						}
						if (game.GetChessBoard().GetSquare(i, j).GetPiece().GetColor() == Constants.White && game.GetChessBoard().GetSquare(i, j).GetPiece().GetType() == typeof(Knight))
						{
							chessboard[i, j].Background = bKonC;
						}
						if (game.GetChessBoard().GetSquare(i, j).GetPiece().GetColor() == Constants.White && game.GetChessBoard().GetSquare(i, j).GetPiece().GetType() == typeof(Bishop))
						{
							chessboard[i, j].Background = bLauferC;
						}
						if (game.GetChessBoard().GetSquare(i, j).GetPiece().GetColor() == Constants.White && game.GetChessBoard().GetSquare(i, j).GetPiece().GetType() == typeof(Queen))
						{
							chessboard[i, j].Background = bKrolowaC;
						}
						if (game.GetChessBoard().GetSquare(i, j).GetPiece().GetColor() == Constants.White && game.GetChessBoard().GetSquare(i, j).GetPiece().GetType() == typeof(King))
						{
							chessboard[i, j].Background = bKrolC;
						}



						// Czarne
						if (game.GetChessBoard().GetSquare(i, j).GetPiece().GetColor() == Constants.Black && game.GetChessBoard().GetSquare(i, j).GetPiece().GetType() == typeof(Pawn))
						{
							chessboard[i, j].Background = cPionC;
						}
						if (game.GetChessBoard().GetSquare(i, j).GetPiece().GetColor() == Constants.Black && game.GetChessBoard().GetSquare(i, j).GetPiece().GetType() == typeof(Rook))
						{
							chessboard[i, j].Background = cWiezaC;
						}
						if (game.GetChessBoard().GetSquare(i, j).GetPiece().GetColor() == Constants.Black && game.GetChessBoard().GetSquare(i, j).GetPiece().GetType() == typeof(Knight))
						{
							chessboard[i, j].Background = cKonC;
						}
						if (game.GetChessBoard().GetSquare(i, j).GetPiece().GetColor() == Constants.Black && game.GetChessBoard().GetSquare(i, j).GetPiece().GetType() == typeof(Bishop))
						{
							chessboard[i, j].Background = cLauferC;
						}
						if (game.GetChessBoard().GetSquare(i, j).GetPiece().GetColor() == Constants.Black && game.GetChessBoard().GetSquare(i, j).GetPiece().GetType() == typeof(Queen))
						{
							chessboard[i, j].Background = cKrolowaC;
						}
						if (game.GetChessBoard().GetSquare(i, j).GetPiece().GetColor() == Constants.Black && game.GetChessBoard().GetSquare(i, j).GetPiece().GetType() == typeof(King))
						{
							chessboard[i, j].Background = cKrolC;
						}

					}
					////Biale

					//if (chessboard[i, j].Content.ToString() == "bPion")
					//{
					//	chessboard[i, j].Background = bPionC;
					//}
					//if (chessboard[i, j].Content.ToString() == "bWieza")
					//{
					//	chessboard[i, j].Background = bWiezaC;
					//}
					//if (chessboard[i, j].Content.ToString() == "bKon")
					//{
					//	chessboard[i, j].Background = bKonC;
					//}
					//if (chessboard[i, j].Content.ToString() == "bLaufer")
					//{
					//	chessboard[i, j].Background = bLauferC;
					//}
					//if (chessboard[i, j].Content.ToString() == "bKrolowa")
					//{
					//	chessboard[i, j].Background = bKrolowaC;
					//}
					//if (chessboard[i, j].Content.ToString() == "bKrol")
					//{
					//	chessboard[i, j].Background = bKrolC;
					//}

					//// Czarne

					//if (chessboard[i, j].Content.ToString() == "cPion")
					//{
					//	chessboard[i, j].Background = cPionC;
					//}
					//if (chessboard[i, j].Content.ToString() == "cWieza")
					//{
					//	chessboard[i, j].Background = cWiezaC;
					//}
					//if (chessboard[i, j].Content.ToString() == "cKon")
					//{
					//	chessboard[i, j].Background = cKonC;
					//}
					//if (chessboard[i, j].Content.ToString() == "cLaufer")
					//{
					//	chessboard[i, j].Background = cLauferC;
					//}
					//if (chessboard[i, j].Content.ToString() == "cKrolowa")
					//{
					//	chessboard[i, j].Background = cKrolowaC;
					//}
					//if (chessboard[i, j].Content.ToString() == "cKrol")
					//{
					//	chessboard[i, j].Background = cKrolC;
					//}
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

		private Piece findSelected(object sender)
		{
			for (int i = 0; i < 8; i++)
				for (int j = 0; j < 8; j++)
					if (game.GetChessBoard().GetSquare(i, j).GetSelected())
					{
						Piece temp = game.GetChessBoard().GetSquare(i, j).GetPiece();
						game.GetChessBoard().GetSquare(i, j).SetPiece(null);
						return temp;
					}
			//if (chessboard[i, j].Tag == "selected")
			//{
			//	String temp = chessboard[i, j].Content.ToString();
			//	chessboard[i, j].Content = "";
			//	return temp;
			//}
			return null;
		}

		private void fieldClick(object sender, RoutedEventArgs e)
		{

			for (int i = 0; i < 8; i++)
				for (int j = 0; j < 8; j++)
					if (chessboard[i, j].Name == (sender as Button).Name)
					{
						Console.Write("Koordynaty X = " + i + ", Koordynaty Y = " + j + "\n");
						game.GetChessBoard().GetSquare(j, j).SetSelected(true);

						if (game.GetChessBoard().GetSquare(j, j).GetHighlight())
						{
							game.GetChessBoard().GetSquare(j, j).SetPiece(findSelected(sender));
							clearSelection();
							return;
						}
					}
			
			//if ((sender as Button).Tag == "highlighted")
			//{
			//	(sender as Button).Content = findSelected(sender);
			//	clearSelection();
			//	return;
			//}
			clearSelection();

			//(sender as Button).Tag = "selected";

			highlight(sender);
		}

		private void highlight(object sender)
		{
			for (int i = 0; i < 8; i++)
				for (int j = 0; j < 8; j++)
					if (chessboard[i, j] == (sender as Button))
					{
						if (game.GetChessBoard().GetSquare(i, j).GetPiece() != null)
						{
							// Biale

							if (game.GetChessBoard().GetSquare(i, j).GetPiece().GetColor() == Constants.White && game.GetChessBoard().GetSquare(i, j).GetPiece().GetType() == typeof(Pawn))
							{
								if (i + 1 >= 0 && i + 1 <= 7 && j >= 0 && j <= 7)
								{
									game.GetChessBoard().GetSquare(i + 1, j).SetHighlight(true);
									fchessboard[i + 1, j].BorderThickness = new Thickness(2);
									fchessboard[i + 1, j].BorderBrush = highlighted;
									//chessboard[i + 1, j].Tag = "highlighted";
								}

								if (i + 2 >= 0 && i + 2 <= 7 && j >= 0 && j <= 7)
								{
									game.GetChessBoard().GetSquare(i + 2, j).SetHighlight(true);
									fchessboard[i + 2, j].BorderThickness = new Thickness(2);
									fchessboard[i + 2, j].BorderBrush = highlighted;
									//chessboard[i + 2, j].Tag = "highlighted";
								}


							}

							if (game.GetChessBoard().GetSquare(i, j).GetPiece().GetType() == typeof(Rook))
							{
								if (i - 1 >= 0 && i - 1 <= 7 && j >= 0 && j <= 7)
								{
									game.GetChessBoard().GetSquare(i - 1, j).SetHighlight(true);
									fchessboard[i - 1, j].BorderThickness = new Thickness(2);
									fchessboard[i - 1, j].BorderBrush = highlighted;
									//chessboard[i - 1, j].Tag = "highlighted";
								}


								if (i + 1 >= 0 && i + 1 <= 7 && j >= 0 && j <= 7)
								{
									game.GetChessBoard().GetSquare(i + 1, j).SetHighlight(true);
									fchessboard[i + 1, j].BorderThickness = new Thickness(2);
									fchessboard[i + 1, j].BorderBrush = highlighted;
									//chessboard[i + 1, j].Tag = "highlighted";
								}



								if (j - 1 >= 0 && j - 1 <= 7)
								{
									game.GetChessBoard().GetSquare(i, j - 1).SetHighlight(true);
									fchessboard[i, j - 1].BorderThickness = new Thickness(2);
									fchessboard[i, j - 1].BorderBrush = highlighted;
									//chessboard[i, j - 1].Tag = "highlighted";
								}


								if (j + 1 >= 0 && j + 1 <= 7)
								{
									game.GetChessBoard().GetSquare(i, j + 1).SetHighlight(true);
									fchessboard[i, j + 1].BorderThickness = new Thickness(2);
									fchessboard[i, j + 1].BorderBrush = highlighted;
									//chessboard[i, j + 1].Tag = "highlighted";
								}


								if (i - 2 >= 0 && i - 2 <= 7 && j >= 0 && j <= 7)
								{
									game.GetChessBoard().GetSquare(i - 2, j).SetHighlight(true);
									fchessboard[i - 2, j].BorderThickness = new Thickness(2);
									fchessboard[i - 2, j].BorderBrush = highlighted;
									//chessboard[i - 2, j].Tag = "highlighted";
								}


								if (i + 2 >= 0 && i + 2 <= 7 && j >= 0 && j <= 7)
								{
									game.GetChessBoard().GetSquare(i + 2, j).SetHighlight(true);
									fchessboard[i + 2, j].BorderThickness = new Thickness(2);
									fchessboard[i + 2, j].BorderBrush = highlighted;
									//chessboard[i + 2, j].Tag = "highlighted";
								}



								if (j - 2 >= 0 && j - 2 <= 7)
								{
									game.GetChessBoard().GetSquare(i, j - 2).SetHighlight(true);
									fchessboard[i, j - 2].BorderThickness = new Thickness(2);
									fchessboard[i, j - 2].BorderBrush = highlighted;
									//chessboard[i, j - 2].Tag = "highlighted";
								}


								if (j + 2 >= 0 && j + 2 <= 7)
								{
									game.GetChessBoard().GetSquare(i, j + 2).SetHighlight(true);
									fchessboard[i, j + 2].BorderThickness = new Thickness(2);
									fchessboard[i, j + 2].BorderBrush = highlighted;
									//chessboard[i, j + 2].Tag = "highlighted";
								}






								if (i - 3 >= 0 && i - 3 <= 7 && j >= 0 && j <= 7)
								{
									game.GetChessBoard().GetSquare(i - 3, j).SetHighlight(true);
									fchessboard[i - 3, j].BorderThickness = new Thickness(2);
									fchessboard[i - 3, j].BorderBrush = highlighted;
									//chessboard[i - 3, j].Tag = "highlighted";
								}


								if (i + 3 >= 0 && i + 3 <= 7 && j >= 0 && j <= 7)
								{
									game.GetChessBoard().GetSquare(i + 3, j).SetHighlight(true);
									fchessboard[i + 3, j].BorderThickness = new Thickness(2);
									fchessboard[i + 3, j].BorderBrush = highlighted;
									//chessboard[i + 3, j].Tag = "highlighted";
								}



								if (j - 3 >= 0 && j - 3 <= 7)
								{
									game.GetChessBoard().GetSquare(i, j - 3).SetHighlight(true);
									fchessboard[i, j - 3].BorderThickness = new Thickness(2);
									fchessboard[i, j - 3].BorderBrush = highlighted;
									//chessboard[i, j - 3].Tag = "highlighted";
								}


								if (j + 3 >= 0 && j + 3 <= 7)
								{
									game.GetChessBoard().GetSquare(i, j + 3).SetHighlight(true);
									fchessboard[i, j + 3].BorderThickness = new Thickness(2);
									fchessboard[i, j + 3].BorderBrush = highlighted;
									//chessboard[i, j + 3].Tag = "highlighted";
								}






								if (i - 4 >= 0 && i - 4 <= 7 && j >= 0 && j <= 7)
								{
									game.GetChessBoard().GetSquare(i - 4, j).SetHighlight(true);
									fchessboard[i - 4, j].BorderThickness = new Thickness(2);
									fchessboard[i - 4, j].BorderBrush = highlighted;
									//chessboard[i - 4, j].Tag = "highlighted";
								}


								if (i + 4 >= 0 && i + 4 <= 7 && j >= 0 && j <= 7)
								{
									game.GetChessBoard().GetSquare(i + 4, j).SetHighlight(true);
									fchessboard[i + 4, j].BorderThickness = new Thickness(2);
									fchessboard[i + 4, j].BorderBrush = highlighted;
									//chessboard[i + 4, j].Tag = "highlighted";
								}



								if (j - 4 >= 0 && j - 4 <= 7)
								{
									game.GetChessBoard().GetSquare(i, j - 4).SetHighlight(true);
									fchessboard[i, j - 4].BorderThickness = new Thickness(2);
									fchessboard[i, j - 4].BorderBrush = highlighted;
									//chessboard[i, j - 4].Tag = "highlighted";
								}


								if (j + 4 >= 0 && j + 4 <= 7)
								{
									game.GetChessBoard().GetSquare(i, j + 4).SetHighlight(true);
									fchessboard[i, j + 4].BorderThickness = new Thickness(2);
									fchessboard[i, j + 4].BorderBrush = highlighted;
									//chessboard[i, j + 4].Tag = "highlighted";
								}




								if (i - 5 >= 0 && i - 5 <= 7 && j >= 0 && j <= 7)
								{
									game.GetChessBoard().GetSquare(i - 5, j).SetHighlight(true);
									fchessboard[i - 5, j].BorderThickness = new Thickness(2);
									fchessboard[i - 5, j].BorderBrush = highlighted;
									//chessboard[i - 5, j].Tag = "highlighted";
								}


								if (i + 5 >= 0 && i + 5 <= 7 && j >= 0 && j <= 7)
								{
									game.GetChessBoard().GetSquare(i + 5, j).SetHighlight(true);
									fchessboard[i + 5, j].BorderThickness = new Thickness(2);
									fchessboard[i + 5, j].BorderBrush = highlighted;
									//chessboard[i + 5, j].Tag = "highlighted";
								}



								if (j - 5 >= 0 && j - 5 <= 7)
								{
									game.GetChessBoard().GetSquare(i, j - 5).SetHighlight(true);
									fchessboard[i, j - 5].BorderThickness = new Thickness(2);
									fchessboard[i, j - 5].BorderBrush = highlighted;
									//chessboard[i, j - 5].Tag = "highlighted";
								}


								if (j + 5 >= 0 && j + 5 <= 7)
								{
									game.GetChessBoard().GetSquare(i, j + 5).SetHighlight(true);
									fchessboard[i, j + 5].BorderThickness = new Thickness(2);
									fchessboard[i, j + 5].BorderBrush = highlighted;
									//chessboard[i, j + 5].Tag = "highlighted";
								}




								if (i - 6 >= 0 && i - 6 <= 7 && j >= 0 && j <= 7)
								{
									game.GetChessBoard().GetSquare(i - 6, j).SetHighlight(true);
									fchessboard[i - 6, j].BorderThickness = new Thickness(2);
									fchessboard[i - 6, j].BorderBrush = highlighted;
									//chessboard[i - 6, j].Tag = "highlighted";
								}


								if (i + 6 >= 0 && i + 6 <= 7 && j >= 0 && j <= 7)
								{
									game.GetChessBoard().GetSquare(i + 6, j).SetHighlight(true);
									fchessboard[i + 6, j].BorderThickness = new Thickness(2);
									fchessboard[i + 6, j].BorderBrush = highlighted;
									//chessboard[i + 6, j].Tag = "highlighted";
								}



								if (j - 6 >= 0 && j - 6 <= 7)
								{
									game.GetChessBoard().GetSquare(i, j - 6).SetHighlight(true);
									fchessboard[i, j - 6].BorderThickness = new Thickness(2);
									fchessboard[i, j - 6].BorderBrush = highlighted;
									//chessboard[i, j - 6].Tag = "highlighted";
								}


								if (j + 6 >= 0 && j + 6 <= 7)
								{
									game.GetChessBoard().GetSquare(i, j + 6).SetHighlight(true);
									fchessboard[i, j + 6].BorderThickness = new Thickness(2);
									fchessboard[i, j + 6].BorderBrush = highlighted;
									//chessboard[i, j + 6].Tag = "highlighted";
								}





								if (i - 7 >= 0 && i - 7 <= 7 && j >= 0 && j <= 7)
								{
									game.GetChessBoard().GetSquare(i - 7, j).SetHighlight(true);
									fchessboard[i - 7, j].BorderThickness = new Thickness(2);
									fchessboard[i - 7, j].BorderBrush = highlighted;
									//chessboard[i - 7, j].Tag = "highlighted";
								}


								if (i + 7 >= 0 && i + 7 <= 7 && j >= 0 && j <= 7)
								{
									game.GetChessBoard().GetSquare(i + 7, j).SetHighlight(true);
									fchessboard[i + 7, j].BorderThickness = new Thickness(2);
									fchessboard[i + 7, j].BorderBrush = highlighted;
									//chessboard[i + 7, j].Tag = "highlighted";
								}



								if (j - 7 >= 0 && j - 7 <= 7)
								{
									game.GetChessBoard().GetSquare(i, j - 7).SetHighlight(true);
									fchessboard[i, j - 7].BorderThickness = new Thickness(2);
									fchessboard[i, j - 7].BorderBrush = highlighted;
									//chessboard[i, j - 7].Tag = "highlighted";
								}


								if (j + 7 >= 0 && j + 7 <= 7)
								{
									game.GetChessBoard().GetSquare(i, j + 7).SetHighlight(true);
									fchessboard[i, j + 7].BorderThickness = new Thickness(2);
									fchessboard[i, j + 7].BorderBrush = highlighted;
									//chessboard[i, j + 7].Tag = "highlighted";
								}


							}




							if (game.GetChessBoard().GetSquare(i, j).GetPiece().GetType() == typeof(Knight))
							{
								if (i - 2 >= 0 && i - 2 <= 7 && j + 1 >= 0 && j + 1 <= 7)
								{
									game.GetChessBoard().GetSquare(i - 2, j + 1).SetHighlight(true);
									fchessboard[i - 2, j + 1].BorderThickness = new Thickness(2);
									fchessboard[i - 2, j + 1].BorderBrush = highlighted;
									//chessboard[i - 2, j + 1].Tag = "highlighted";
								}

								if (i - 2 >= 0 && i - 2 <= 7 && j - 1 >= 0 && j - 1 <= 7)
								{
									game.GetChessBoard().GetSquare(i - 2, j - 1).SetHighlight(true);
									fchessboard[i - 2, j - 1].BorderThickness = new Thickness(2);
									fchessboard[i - 2, j - 1].BorderBrush = highlighted;
									//chessboard[i - 2, j - 1].Tag = "highlighted";
								}

								if (i + 2 >= 0 && i + 2 <= 7 && j + 1 >= 0 && j + 1 <= 7)
								{
									game.GetChessBoard().GetSquare(i + 2, j + 1).SetHighlight(true);
									fchessboard[i + 2, j + 1].BorderThickness = new Thickness(2);
									fchessboard[i + 2, j + 1].BorderBrush = highlighted;
									//chessboard[i + 2, j + 1].Tag = "highlighted";
								}

								if (i + 2 >= 0 && i + 2 <= 7 && j - 1 >= 0 && j - 1 <= 7)
								{
									game.GetChessBoard().GetSquare(i + 2, j - 1).SetHighlight(true);
									fchessboard[i + 2, j - 1].BorderThickness = new Thickness(2);
									fchessboard[i + 2, j - 1].BorderBrush = highlighted;
									//chessboard[i + 2, j - 1].Tag = "highlighted";
								}

								if (i + 1 >= 0 && i + 1 <= 7 && j - 2 >= 0 && j - 2 <= 7)
								{
									game.GetChessBoard().GetSquare(i + 1, j - 2).SetHighlight(true);
									fchessboard[i + 1, j - 2].BorderThickness = new Thickness(2);
									fchessboard[i + 1, j - 2].BorderBrush = highlighted;
									//chessboard[i + 1, j - 2].Tag = "highlighted";
								}

								if (i - 1 >= 0 && i - 1 <= 7 && j - 2 >= 0 && j - 2 <= 7)
								{
									game.GetChessBoard().GetSquare(i - 1, j - 2).SetHighlight(true);
									fchessboard[i - 1, j - 2].BorderThickness = new Thickness(2);
									fchessboard[i - 1, j - 2].BorderBrush = highlighted;
									//chessboard[i - 1, j - 2].Tag = "highlighted";
								}

								if (i + 1 >= 0 && i + 1 <= 7 && j + 2 >= 0 && j + 2 <= 7)
								{
									game.GetChessBoard().GetSquare(i + 1, j + 2).SetHighlight(true);
									fchessboard[i + 1, j + 2].BorderThickness = new Thickness(2);
									fchessboard[i + 1, j + 2].BorderBrush = highlighted;
									//chessboard[i + 1, j + 2].Tag = "highlighted";
								}

								if (i - 1 >= 0 && i - 1 <= 7 && j + 2 >= 0 && j + 2 <= 7)
								{
									game.GetChessBoard().GetSquare(i - 1, j + 2).SetHighlight(true);
									fchessboard[i - 1, j + 2].BorderThickness = new Thickness(2);
									fchessboard[i - 1, j + 2].BorderBrush = highlighted;
									//chessboard[i - 1, j + 2].Tag = "highlighted";
								}

							}

							if (game.GetChessBoard().GetSquare(i, j).GetPiece().GetType() == typeof(Bishop))
							{
								if (i - 1 >= 0 && i - 1 <= 7 && j - 1 >= 0 && j - 1 <= 7)
								{
									game.GetChessBoard().GetSquare(i - 1, j - 1).SetHighlight(true);
									fchessboard[i - 1, j - 1].BorderThickness = new Thickness(2);
									fchessboard[i - 1, j - 1].BorderBrush = highlighted;
									//chessboard[i - 1, j - 1].Tag = "highlighted";
								}
								if (i - 2 >= 0 && i - 2 <= 7 && j - 2 >= 0 && j - 2 <= 7)
								{
									game.GetChessBoard().GetSquare(i - 2, j - 2).SetHighlight(true);
									fchessboard[i - 2, j - 2].BorderThickness = new Thickness(2);
									fchessboard[i - 2, j - 2].BorderBrush = highlighted;
									//chessboard[i - 2, j - 2].Tag = "highlighted";
								}
								if (i - 3 >= 0 && i - 3 <= 7 && j - 3 >= 0 && j - 3 <= 7)
								{
									game.GetChessBoard().GetSquare(i - 3, j - 3).SetHighlight(true);
									fchessboard[i - 3, j - 3].BorderThickness = new Thickness(2);
									fchessboard[i - 3, j - 3].BorderBrush = highlighted;
									//chessboard[i - 3, j - 3].Tag = "highlighted";
								}
								if (i - 4 >= 0 && i - 4 <= 7 && j - 4 >= 0 && j - 4 <= 7)
								{
									game.GetChessBoard().GetSquare(i - 4, j - 4).SetHighlight(true);
									fchessboard[i - 4, j - 4].BorderThickness = new Thickness(2);
									fchessboard[i - 4, j - 4].BorderBrush = highlighted;
									//chessboard[i - 4, j - 4].Tag = "highlighted";
								}
								if (i - 5 >= 0 && i - 5 <= 7 && j - 5 >= 0 && j - 5 <= 7)
								{
									game.GetChessBoard().GetSquare(i - 5, j - 5).SetHighlight(true);
									fchessboard[i - 5, j - 5].BorderThickness = new Thickness(2);
									fchessboard[i - 5, j - 5].BorderBrush = highlighted;
									//chessboard[i - 5, j - 5].Tag = "highlighted";
								}
								if (i - 6 >= 0 && i - 6 <= 7 && j - 6 >= 0 && j - 6 <= 7)
								{
									game.GetChessBoard().GetSquare(i - 6, j - 6).SetHighlight(true);
									fchessboard[i - 6, j - 6].BorderThickness = new Thickness(2);
									fchessboard[i - 6, j - 6].BorderBrush = highlighted;
									//chessboard[i - 6, j - 6].Tag = "highlighted";
								}
								if (i - 7 >= 0 && i - 7 <= 7 && j - 7 >= 0 && j - 7 <= 7)
								{
									game.GetChessBoard().GetSquare(i - 7, j - 7).SetHighlight(true);
									fchessboard[i - 7, j - 7].BorderThickness = new Thickness(2);
									fchessboard[i - 7, j - 7].BorderBrush = highlighted;
									//chessboard[i - 7, j - 7].Tag = "highlighted";
								}





								if (i + 1 >= 0 && i + 1 <= 7 && j + 1 >= 0 && j + 1 <= 7)
								{
									game.GetChessBoard().GetSquare(i + 1, j + 1).SetHighlight(true);
									fchessboard[i + 1, j + 1].BorderThickness = new Thickness(2);
									fchessboard[i + 1, j + 1].BorderBrush = highlighted;
									//chessboard[i + 1, j + 1].Tag = "highlighted";
								}
								if (i + 2 >= 0 && i + 2 <= 7 && j + 2 >= 0 && j + 2 <= 7)
								{
									game.GetChessBoard().GetSquare(i + 2, j + 2).SetHighlight(true);
									fchessboard[i + 2, j + 2].BorderThickness = new Thickness(2);
									fchessboard[i + 2, j + 2].BorderBrush = highlighted;
									//chessboard[i + 2, j + 2].Tag = "highlighted";
								}
								if (i + 3 >= 0 && i + 3 <= 7 && j + 3 >= 0 && j + 3 <= 7)
								{
									game.GetChessBoard().GetSquare(i + 3, j + 3).SetHighlight(true);
									fchessboard[i + 3, j + 3].BorderThickness = new Thickness(2);
									fchessboard[i + 3, j + 3].BorderBrush = highlighted;
									//chessboard[i + 3, j + 3].Tag = "highlighted";
								}
								if (i + 4 >= 0 && i + 4 <= 7 && j + 4 >= 0 && j + 4 <= 7)
								{
									game.GetChessBoard().GetSquare(i + 4, j + 4).SetHighlight(true);
									fchessboard[i + 4, j + 4].BorderThickness = new Thickness(2);
									fchessboard[i + 4, j + 4].BorderBrush = highlighted;
									//chessboard[i + 4, j + 4].Tag = "highlighted";
								}
								if (i + 5 >= 0 && i + 5 <= 7 && j + 5 >= 0 && j + 5 <= 7)
								{
									game.GetChessBoard().GetSquare(i + 5, j + 5).SetHighlight(true);
									fchessboard[i + 5, j + 5].BorderThickness = new Thickness(2);
									fchessboard[i + 5, j + 5].BorderBrush = highlighted;
									//chessboard[i + 5, j + 5].Tag = "highlighted";
								}
								if (i + 6 >= 0 && i + 6 <= 7 && j + 6 >= 0 && j + 6 <= 7)
								{
									game.GetChessBoard().GetSquare(i + 6, j + 6).SetHighlight(true);
									fchessboard[i + 6, j + 6].BorderThickness = new Thickness(2);
									fchessboard[i + 6, j + 6].BorderBrush = highlighted;
									//chessboard[i + 6, j + 6].Tag = "highlighted";
								}
								if (i + 7 >= 0 && i + 7 <= 7 && j + 7 >= 0 && j + 7 <= 7)
								{
									game.GetChessBoard().GetSquare(i + 7, j + 7).SetHighlight(true);
									fchessboard[i + 7, j + 7].BorderThickness = new Thickness(2);
									fchessboard[i + 7, j + 7].BorderBrush = highlighted;
									//chessboard[i + 7, j + 7].Tag = "highlighted";
								}





								if (i + 1 >= 0 && i + 1 <= 7 && j - 1 >= 0 && j - 1 <= 7)
								{
									game.GetChessBoard().GetSquare(i + 1, j - 1).SetHighlight(true);
									fchessboard[i + 1, j - 1].BorderThickness = new Thickness(2);
									fchessboard[i + 1, j - 1].BorderBrush = highlighted;
									//chessboard[i + 1, j - 1].Tag = "highlighted";
								}
								if (i + 2 >= 0 && i + 2 <= 7 && j - 2 >= 0 && j - 2 <= 7)
								{
									game.GetChessBoard().GetSquare(i + 2, j - 2).SetHighlight(true);
									fchessboard[i + 2, j - 2].BorderThickness = new Thickness(2);
									fchessboard[i + 2, j - 2].BorderBrush = highlighted;
									//chessboard[i + 2, j - 2].Tag = "highlighted";
								}
								if (i + 3 >= 0 && i + 3 <= 7 && j - 3 >= 0 && j - 3 <= 7)
								{
									game.GetChessBoard().GetSquare(i + 3, j - 3).SetHighlight(true);
									fchessboard[i + 3, j - 3].BorderThickness = new Thickness(2);
									fchessboard[i + 3, j - 3].BorderBrush = highlighted;
									//chessboard[i + 3, j - 3].Tag = "highlighted";
								}
								if (i + 4 >= 0 && i + 4 <= 7 && j - 4 >= 0 && j - 4 <= 7)
								{
									game.GetChessBoard().GetSquare(i + 4, j - 4).SetHighlight(true);
									fchessboard[i + 4, j - 4].BorderThickness = new Thickness(2);
									fchessboard[i + 4, j - 4].BorderBrush = highlighted;
									//chessboard[i + 4, j - 4].Tag = "highlighted";
								}
								if (i + 5 >= 0 && i + 5 <= 7 && j - 5 >= 0 && j - 5 <= 7)
								{
									game.GetChessBoard().GetSquare(i + 5, j - 5).SetHighlight(true);
									fchessboard[i + 5, j - 5].BorderThickness = new Thickness(2);
									fchessboard[i + 5, j - 5].BorderBrush = highlighted;
									//chessboard[i + 5, j - 5].Tag = "highlighted";
								}
								if (i + 6 >= 0 && i + 6 <= 7 && j - 6 >= 0 && j - 6 <= 7)
								{
									game.GetChessBoard().GetSquare(i + 6, j - 6).SetHighlight(true);
									fchessboard[i + 6, j - 6].BorderThickness = new Thickness(2);
									fchessboard[i + 6, j - 6].BorderBrush = highlighted;
									//chessboard[i + 6, j - 6].Tag = "highlighted";
								}
								if (i + 7 >= 0 && i + 7 <= 7 && j - 7 >= 0 && j - 7 <= 7)
								{
									game.GetChessBoard().GetSquare(i + 7, j - 7).SetHighlight(true);
									fchessboard[i + 7, j - 7].BorderThickness = new Thickness(2);
									fchessboard[i + 7, j - 7].BorderBrush = highlighted;
									//chessboard[i + 7, j - 7].Tag = "highlighted";
								}






								if (i - 1 >= 0 && i - 1 <= 7 && j + 1 >= 0 && j + 1 <= 7)
								{
									game.GetChessBoard().GetSquare(i - 1, j + 1).SetHighlight(true);
									fchessboard[i - 1, j + 1].BorderThickness = new Thickness(2);
									fchessboard[i - 1, j + 1].BorderBrush = highlighted;
									//chessboard[i - 1, j + 1].Tag = "highlighted";
								}
								if (i - 2 >= 0 && i - 2 <= 7 && j + 2 >= 0 && j + 2 <= 7)
								{
									game.GetChessBoard().GetSquare(i - 2, j + 2).SetHighlight(true);
									fchessboard[i - 2, j + 2].BorderThickness = new Thickness(2);
									fchessboard[i - 2, j + 2].BorderBrush = highlighted;
									//chessboard[i - 2, j + 2].Tag = "highlighted";
								}
								if (i - 3 >= 0 && i - 3 <= 7 && j + 3 >= 0 && j + 3 <= 7)
								{
									game.GetChessBoard().GetSquare(i - 3, j + 3).SetHighlight(true);
									fchessboard[i - 3, j + 3].BorderThickness = new Thickness(2);
									fchessboard[i - 3, j + 3].BorderBrush = highlighted;
									//chessboard[i - 3, j + 3].Tag = "highlighted";
								}
								if (i - 4 >= 0 && i - 4 <= 7 && j + 4 >= 0 && j + 4 <= 7)
								{
									game.GetChessBoard().GetSquare(i - 4, j + 4).SetHighlight(true);
									fchessboard[i - 4, j + 4].BorderThickness = new Thickness(2);
									fchessboard[i - 4, j + 4].BorderBrush = highlighted;
									//chessboard[i - 4, j + 4].Tag = "highlighted";
								}
								if (i - 5 >= 0 && i - 5 <= 7 && j + 5 >= 0 && j + 5 <= 7)
								{
									game.GetChessBoard().GetSquare(i - 5, j + 5).SetHighlight(true);
									fchessboard[i - 5, j + 5].BorderThickness = new Thickness(2);
									fchessboard[i - 5, j + 5].BorderBrush = highlighted;
									//chessboard[i - 5, j + 5].Tag = "highlighted";
								}
								if (i - 6 >= 0 && i - 6 <= 7 && j + 6 >= 0 && j + 6 <= 7)
								{
									game.GetChessBoard().GetSquare(i - 6, j + 6).SetHighlight(true);
									fchessboard[i - 6, j + 6].BorderThickness = new Thickness(2);
									fchessboard[i - 6, j + 6].BorderBrush = highlighted;
									//chessboard[i - 6, j + 6].Tag = "highlighted";
								}
								if (i - 7 >= 0 && i - 7 <= 7 && j + 7 >= 0 && j + 7 <= 7)
								{
									game.GetChessBoard().GetSquare(i - 7, j + 7).SetHighlight(true);
									fchessboard[i - 7, j + 7].BorderThickness = new Thickness(2);
									fchessboard[i - 7, j + 7].BorderBrush = highlighted;
									//chessboard[i - 7, j + 7].Tag = "highlighted";
								}







							}

							if (game.GetChessBoard().GetSquare(i, j).GetPiece().GetType() == typeof(Queen))
							{
								if (i - 1 >= 0 && i - 1 <= 7 && j - 1 >= 0 && j - 1 <= 7)
								{
									game.GetChessBoard().GetSquare(i - 1, j - 1).SetHighlight(true);
									fchessboard[i - 1, j - 1].BorderThickness = new Thickness(2);
									fchessboard[i - 1, j - 1].BorderBrush = highlighted;
									//chessboard[i - 1, j - 1].Tag = "highlighted";
								}
								if (i - 2 >= 0 && i - 2 <= 7 && j - 2 >= 0 && j - 2 <= 7)
								{
									game.GetChessBoard().GetSquare(i - 2, j - 2).SetHighlight(true);
									fchessboard[i - 2, j - 2].BorderThickness = new Thickness(2);
									fchessboard[i - 2, j - 2].BorderBrush = highlighted;
									//chessboard[i - 2, j - 2].Tag = "highlighted";
								}
								if (i - 3 >= 0 && i - 3 <= 7 && j - 3 >= 0 && j - 3 <= 7)
								{
									game.GetChessBoard().GetSquare(i - 3, j - 3).SetHighlight(true);
									fchessboard[i - 3, j - 3].BorderThickness = new Thickness(2);
									fchessboard[i - 3, j - 3].BorderBrush = highlighted;
									//chessboard[i - 3, j - 3].Tag = "highlighted";
								}
								if (i - 4 >= 0 && i - 4 <= 7 && j - 4 >= 0 && j - 4 <= 7)
								{
									game.GetChessBoard().GetSquare(i - 4, j - 4).SetHighlight(true);
									fchessboard[i - 4, j - 4].BorderThickness = new Thickness(2);
									fchessboard[i - 4, j - 4].BorderBrush = highlighted;
									//chessboard[i - 4, j - 4].Tag = "highlighted";
								}
								if (i - 5 >= 0 && i - 5 <= 7 && j - 5 >= 0 && j - 5 <= 7)
								{
									game.GetChessBoard().GetSquare(i - 5, j - 5).SetHighlight(true);
									fchessboard[i - 5, j - 5].BorderThickness = new Thickness(2);
									fchessboard[i - 5, j - 5].BorderBrush = highlighted;
									//chessboard[i - 5, j - 5].Tag = "highlighted";
								}
								if (i - 6 >= 0 && i - 6 <= 7 && j - 6 >= 0 && j - 6 <= 7)
								{
									game.GetChessBoard().GetSquare(i - 6, j - 6).SetHighlight(true);
									fchessboard[i - 6, j - 6].BorderThickness = new Thickness(2);
									fchessboard[i - 6, j - 6].BorderBrush = highlighted;
									//chessboard[i - 6, j - 6].Tag = "highlighted";
								}
								if (i - 7 >= 0 && i - 7 <= 7 && j - 7 >= 0 && j - 7 <= 7)
								{
									game.GetChessBoard().GetSquare(i - 7, j - 7).SetHighlight(true);
									fchessboard[i - 7, j - 7].BorderThickness = new Thickness(2);
									fchessboard[i - 7, j - 7].BorderBrush = highlighted;
									//chessboard[i - 7, j - 7].Tag = "highlighted";
								}





								if (i + 1 >= 0 && i + 1 <= 7 && j + 1 >= 0 && j + 1 <= 7)
								{
									game.GetChessBoard().GetSquare(i + 1, j + 1).SetHighlight(true);
									fchessboard[i + 1, j + 1].BorderThickness = new Thickness(2);
									fchessboard[i + 1, j + 1].BorderBrush = highlighted;
									//chessboard[i + 1, j + 1].Tag = "highlighted";
								}
								if (i + 2 >= 0 && i + 2 <= 7 && j + 2 >= 0 && j + 2 <= 7)
								{
									game.GetChessBoard().GetSquare(i + 2, j + 2).SetHighlight(true);
									fchessboard[i + 2, j + 2].BorderThickness = new Thickness(2);
									fchessboard[i + 2, j + 2].BorderBrush = highlighted;
									//chessboard[i + 2, j + 2].Tag = "highlighted";
								}
								if (i + 3 >= 0 && i + 3 <= 7 && j + 3 >= 0 && j + 3 <= 7)
								{
									game.GetChessBoard().GetSquare(i + 3, j + 3).SetHighlight(true);
									fchessboard[i + 3, j + 3].BorderThickness = new Thickness(2);
									fchessboard[i + 3, j + 3].BorderBrush = highlighted;
									//chessboard[i + 3, j + 3].Tag = "highlighted";
								}
								if (i + 4 >= 0 && i + 4 <= 7 && j + 4 >= 0 && j + 4 <= 7)
								{
									game.GetChessBoard().GetSquare(i + 4, j + 4).SetHighlight(true);
									fchessboard[i + 4, j + 4].BorderThickness = new Thickness(2);
									fchessboard[i + 4, j + 4].BorderBrush = highlighted;
									//chessboard[i + 4, j + 4].Tag = "highlighted";
								}
								if (i + 5 >= 0 && i + 5 <= 7 && j + 5 >= 0 && j + 5 <= 7)
								{
									game.GetChessBoard().GetSquare(i + 5, j + 5).SetHighlight(true);
									fchessboard[i + 5, j + 5].BorderThickness = new Thickness(2);
									fchessboard[i + 5, j + 5].BorderBrush = highlighted;
									//chessboard[i + 5, j + 5].Tag = "highlighted";
								}
								if (i + 6 >= 0 && i + 6 <= 7 && j + 6 >= 0 && j + 6 <= 7)
								{
									game.GetChessBoard().GetSquare(i + 6, j + 6).SetHighlight(true);
									fchessboard[i + 6, j + 6].BorderThickness = new Thickness(2);
									fchessboard[i + 6, j + 6].BorderBrush = highlighted;
									//chessboard[i + 6, j + 6].Tag = "highlighted";
								}
								if (i + 7 >= 0 && i + 7 <= 7 && j + 7 >= 0 && j + 7 <= 7)
								{
									game.GetChessBoard().GetSquare(i + 7, j + 7).SetHighlight(true);
									fchessboard[i + 7, j + 7].BorderThickness = new Thickness(2);
									fchessboard[i + 7, j + 7].BorderBrush = highlighted;
									//chessboard[i + 7, j + 7].Tag = "highlighted";
								}





								if (i + 1 >= 0 && i + 1 <= 7 && j - 1 >= 0 && j - 1 <= 7)
								{
									game.GetChessBoard().GetSquare(i + 1, j - 1).SetHighlight(true);
									fchessboard[i + 1, j - 1].BorderThickness = new Thickness(2);
									fchessboard[i + 1, j - 1].BorderBrush = highlighted;
									//chessboard[i + 1, j - 1].Tag = "highlighted";
								}
								if (i + 2 >= 0 && i + 2 <= 7 && j - 2 >= 0 && j - 2 <= 7)
								{
									game.GetChessBoard().GetSquare(i + 2, j - 2).SetHighlight(true);
									fchessboard[i + 2, j - 2].BorderThickness = new Thickness(2);
									fchessboard[i + 2, j - 2].BorderBrush = highlighted;
									//chessboard[i + 2, j - 2].Tag = "highlighted";
								}
								if (i + 3 >= 0 && i + 3 <= 7 && j - 3 >= 0 && j - 3 <= 7)
								{
									game.GetChessBoard().GetSquare(i + 3, j - 3).SetHighlight(true);
									fchessboard[i + 3, j - 3].BorderThickness = new Thickness(2);
									fchessboard[i + 3, j - 3].BorderBrush = highlighted;
									//chessboard[i + 3, j - 3].Tag = "highlighted";
								}
								if (i + 4 >= 0 && i + 4 <= 7 && j - 4 >= 0 && j - 4 <= 7)
								{
									game.GetChessBoard().GetSquare(i + 4, j - 4).SetHighlight(true);
									fchessboard[i + 4, j - 4].BorderThickness = new Thickness(2);
									fchessboard[i + 4, j - 4].BorderBrush = highlighted;
									//chessboard[i + 4, j - 4].Tag = "highlighted";
								}
								if (i + 5 >= 0 && i + 5 <= 7 && j - 5 >= 0 && j - 5 <= 7)
								{
									game.GetChessBoard().GetSquare(i + 5, j - 5).SetHighlight(true);
									fchessboard[i + 5, j - 5].BorderThickness = new Thickness(2);
									fchessboard[i + 5, j - 5].BorderBrush = highlighted;
									//chessboard[i + 5, j - 5].Tag = "highlighted";
								}
								if (i + 6 >= 0 && i + 6 <= 7 && j - 6 >= 0 && j - 6 <= 7)
								{
									game.GetChessBoard().GetSquare(i + 6, j - 6).SetHighlight(true);
									fchessboard[i + 6, j - 6].BorderThickness = new Thickness(2);
									fchessboard[i + 6, j - 6].BorderBrush = highlighted;
									//chessboard[i + 6, j - 6].Tag = "highlighted";
								}
								if (i + 7 >= 0 && i + 7 <= 7 && j - 7 >= 0 && j - 7 <= 7)
								{
									game.GetChessBoard().GetSquare(i + 7, j - 7).SetHighlight(true);
									fchessboard[i + 7, j - 7].BorderThickness = new Thickness(2);
									fchessboard[i + 7, j - 7].BorderBrush = highlighted;
									//chessboard[i + 7, j - 7].Tag = "highlighted";
								}






								if (i - 1 >= 0 && i - 1 <= 7 && j + 1 >= 0 && j + 1 <= 7)
								{
									game.GetChessBoard().GetSquare(i - 1, j + 1).SetHighlight(true);
									fchessboard[i - 1, j + 1].BorderThickness = new Thickness(2);
									fchessboard[i - 1, j + 1].BorderBrush = highlighted;
									//chessboard[i - 1, j + 1].Tag = "highlighted";
								}
								if (i - 2 >= 0 && i - 2 <= 7 && j + 2 >= 0 && j + 2 <= 7)
								{
									game.GetChessBoard().GetSquare(i - 2, j + 2).SetHighlight(true);
									fchessboard[i - 2, j + 2].BorderThickness = new Thickness(2);
									fchessboard[i - 2, j + 2].BorderBrush = highlighted;
									//chessboard[i - 2, j + 2].Tag = "highlighted";
								}
								if (i - 3 >= 0 && i - 3 <= 7 && j + 3 >= 0 && j + 3 <= 7)
								{
									game.GetChessBoard().GetSquare(i - 3, j + 3).SetHighlight(true);
									fchessboard[i - 3, j + 3].BorderThickness = new Thickness(2);
									fchessboard[i - 3, j + 3].BorderBrush = highlighted;
									//chessboard[i - 3, j + 3].Tag = "highlighted";
								}
								if (i - 4 >= 0 && i - 4 <= 7 && j + 4 >= 0 && j + 4 <= 7)
								{
									game.GetChessBoard().GetSquare(i - 4, j + 4).SetHighlight(true);
									fchessboard[i - 4, j + 4].BorderThickness = new Thickness(2);
									fchessboard[i - 4, j + 4].BorderBrush = highlighted;
									//chessboard[i - 4, j + 4].Tag = "highlighted";
								}
								if (i - 5 >= 0 && i - 5 <= 7 && j + 5 >= 0 && j + 5 <= 7)
								{
									game.GetChessBoard().GetSquare(i - 5, j + 5).SetHighlight(true);
									fchessboard[i - 5, j + 5].BorderThickness = new Thickness(2);
									fchessboard[i - 5, j + 5].BorderBrush = highlighted;
									//chessboard[i - 5, j + 5].Tag = "highlighted";
								}
								if (i - 6 >= 0 && i - 6 <= 7 && j + 6 >= 0 && j + 6 <= 7)
								{
									game.GetChessBoard().GetSquare(i - 6, j + 6).SetHighlight(true);
									fchessboard[i - 6, j + 6].BorderThickness = new Thickness(2);
									fchessboard[i - 6, j + 6].BorderBrush = highlighted;
									//chessboard[i - 6, j + 6].Tag = "highlighted";
								}
								if (i - 7 >= 0 && i - 7 <= 7 && j + 7 >= 0 && j + 7 <= 7)
								{
									game.GetChessBoard().GetSquare(i - 7, j + 7).SetHighlight(true);
									fchessboard[i - 7, j + 7].BorderThickness = new Thickness(2);
									fchessboard[i - 7, j + 7].BorderBrush = highlighted;
									//chessboard[i - 7, j + 7].Tag = "highlighted";
								}






								if (i - 1 >= 0 && i - 1 <= 7 && j >= 0 && j <= 7)
								{
									game.GetChessBoard().GetSquare(i - 1, j).SetHighlight(true);
									fchessboard[i - 1, j].BorderThickness = new Thickness(2);
									fchessboard[i - 1, j].BorderBrush = highlighted;
									//chessboard[i - 1, j].Tag = "highlighted";
								}


								if (i + 1 >= 0 && i + 1 <= 7 && j >= 0 && j <= 7)
								{
									game.GetChessBoard().GetSquare(i + 1, j).SetHighlight(true);
									fchessboard[i + 1, j].BorderThickness = new Thickness(2);
									fchessboard[i + 1, j].BorderBrush = highlighted;
									//chessboard[i + 1, j].Tag = "highlighted";
								}



								if (j - 1 >= 0 && j - 1 <= 7)
								{
									game.GetChessBoard().GetSquare(i, j - 1).SetHighlight(true);
									fchessboard[i, j - 1].BorderThickness = new Thickness(2);
									fchessboard[i, j - 1].BorderBrush = highlighted;
									//chessboard[i, j - 1].Tag = "highlighted";
								}


								if (j + 1 >= 0 && j + 1 <= 7)
								{
									game.GetChessBoard().GetSquare(i, j + 1).SetHighlight(true);
									fchessboard[i, j + 1].BorderThickness = new Thickness(2);
									fchessboard[i, j + 1].BorderBrush = highlighted;
									//chessboard[i, j + 1].Tag = "highlighted";
								}


								if (i - 2 >= 0 && i - 2 <= 7 && j >= 0 && j <= 7)
								{
									game.GetChessBoard().GetSquare(i - 2, j).SetHighlight(true);
									fchessboard[i - 2, j].BorderThickness = new Thickness(2);
									fchessboard[i - 2, j].BorderBrush = highlighted;
									//chessboard[i - 2, j].Tag = "highlighted";
								}


								if (i + 2 >= 0 && i + 2 <= 7 && j >= 0 && j <= 7)
								{
									game.GetChessBoard().GetSquare(i + 2, j).SetHighlight(true);
									fchessboard[i + 2, j].BorderThickness = new Thickness(2);
									fchessboard[i + 2, j].BorderBrush = highlighted;
									//chessboard[i + 2, j].Tag = "highlighted";
								}



								if (j - 2 >= 0 && j - 2 <= 7)
								{
									game.GetChessBoard().GetSquare(i, j - 2).SetHighlight(true);
									fchessboard[i, j - 2].BorderThickness = new Thickness(2);
									fchessboard[i, j - 2].BorderBrush = highlighted;
									//chessboard[i, j - 2].Tag = "highlighted";
								}


								if (j + 2 >= 0 && j + 2 <= 7)
								{
									game.GetChessBoard().GetSquare(i, j + 2).SetHighlight(true);
									fchessboard[i, j + 2].BorderThickness = new Thickness(2);
									fchessboard[i, j + 2].BorderBrush = highlighted;
									//chessboard[i, j + 2].Tag = "highlighted";
								}






								if (i - 3 >= 0 && i - 3 <= 7 && j >= 0 && j <= 7)
								{
									game.GetChessBoard().GetSquare(i - 3, j).SetHighlight(true);
									fchessboard[i - 3, j].BorderThickness = new Thickness(2);
									fchessboard[i - 3, j].BorderBrush = highlighted;
									//chessboard[i - 3, j].Tag = "highlighted";
								}


								if (i + 3 >= 0 && i + 3 <= 7 && j >= 0 && j <= 7)
								{
									game.GetChessBoard().GetSquare(i + 3, j).SetHighlight(true);
									fchessboard[i + 3, j].BorderThickness = new Thickness(2);
									fchessboard[i + 3, j].BorderBrush = highlighted;
									//chessboard[i + 3, j].Tag = "highlighted";
								}



								if (j - 3 >= 0 && j - 3 <= 7)
								{
									game.GetChessBoard().GetSquare(i, j - 3).SetHighlight(true);
									fchessboard[i, j - 3].BorderThickness = new Thickness(2);
									fchessboard[i, j - 3].BorderBrush = highlighted;
									//chessboard[i, j - 3].Tag = "highlighted";
								}


								if (j + 3 >= 0 && j + 3 <= 7)
								{
									game.GetChessBoard().GetSquare(i, j + 3).SetHighlight(true);
									fchessboard[i, j + 3].BorderThickness = new Thickness(2);
									fchessboard[i, j + 3].BorderBrush = highlighted;
									//chessboard[i, j + 3].Tag = "highlighted";
								}






								if (i - 4 >= 0 && i - 4 <= 7 && j >= 0 && j <= 7)
								{
									game.GetChessBoard().GetSquare(i - 4, j).SetHighlight(true);
									fchessboard[i - 4, j].BorderThickness = new Thickness(2);
									fchessboard[i - 4, j].BorderBrush = highlighted;
									//chessboard[i - 4, j].Tag = "highlighted";
								}


								if (i + 4 >= 0 && i + 4 <= 7 && j >= 0 && j <= 7)
								{
									game.GetChessBoard().GetSquare(i + 4, j).SetHighlight(true);
									fchessboard[i + 4, j].BorderThickness = new Thickness(2);
									fchessboard[i + 4, j].BorderBrush = highlighted;
									//chessboard[i + 4, j].Tag = "highlighted";
								}



								if (j - 4 >= 0 && j - 4 <= 7)
								{
									game.GetChessBoard().GetSquare(i, j - 4).SetHighlight(true);
									fchessboard[i, j - 4].BorderThickness = new Thickness(2);
									fchessboard[i, j - 4].BorderBrush = highlighted;
									//chessboard[i, j - 4].Tag = "highlighted";
								}


								if (j + 4 >= 0 && j + 4 <= 7)
								{
									game.GetChessBoard().GetSquare(i, j + 4).SetHighlight(true);
									fchessboard[i, j + 4].BorderThickness = new Thickness(2);
									fchessboard[i, j + 4].BorderBrush = highlighted;
									//chessboard[i, j + 4].Tag = "highlighted";
								}




								if (i - 5 >= 0 && i - 5 <= 7 && j >= 0 && j <= 7)
								{
									game.GetChessBoard().GetSquare(i - 5, j).SetHighlight(true);
									fchessboard[i - 5, j].BorderThickness = new Thickness(2);
									fchessboard[i - 5, j].BorderBrush = highlighted;
									//chessboard[i - 5, j].Tag = "highlighted";
								}


								if (i + 5 >= 0 && i + 5 <= 7 && j >= 0 && j <= 7)
								{
									game.GetChessBoard().GetSquare(i + 5, j).SetHighlight(true);
									fchessboard[i + 5, j].BorderThickness = new Thickness(2);
									fchessboard[i + 5, j].BorderBrush = highlighted;
									//chessboard[i + 5, j].Tag = "highlighted";
								}



								if (j - 5 >= 0 && j - 5 <= 7)
								{
									game.GetChessBoard().GetSquare(i, j - 5).SetHighlight(true);
									fchessboard[i, j - 5].BorderThickness = new Thickness(2);
									fchessboard[i, j - 5].BorderBrush = highlighted;
									//chessboard[i, j - 5].Tag = "highlighted";
								}


								if (j + 5 >= 0 && j + 5 <= 7)
								{
									game.GetChessBoard().GetSquare(i, j + 5).SetHighlight(true);
									fchessboard[i, j + 5].BorderThickness = new Thickness(2);
									fchessboard[i, j + 5].BorderBrush = highlighted;
									//chessboard[i, j + 5].Tag = "highlighted";
								}




								if (i - 6 >= 0 && i - 6 <= 7 && j >= 0 && j <= 7)
								{
									game.GetChessBoard().GetSquare(i - 6, j).SetHighlight(true);
									fchessboard[i - 6, j].BorderThickness = new Thickness(2);
									fchessboard[i - 6, j].BorderBrush = highlighted;
									//chessboard[i - 6, j].Tag = "highlighted";
								}


								if (i + 6 >= 0 && i + 6 <= 7 && j >= 0 && j <= 7)
								{
									game.GetChessBoard().GetSquare(i + 6, j).SetHighlight(true);
									fchessboard[i + 6, j].BorderThickness = new Thickness(2);
									fchessboard[i + 6, j].BorderBrush = highlighted;
									//chessboard[i + 6, j].Tag = "highlighted";
								}



								if (j - 6 >= 0 && j - 6 <= 7)
								{
									game.GetChessBoard().GetSquare(i, j - 6).SetHighlight(true);
									fchessboard[i, j - 6].BorderThickness = new Thickness(2);
									fchessboard[i, j - 6].BorderBrush = highlighted;
									//chessboard[i, j - 6].Tag = "highlighted";
								}


								if (j + 6 >= 0 && j + 6 <= 7)
								{
									game.GetChessBoard().GetSquare(i, j + 6).SetHighlight(true);
									fchessboard[i, j + 6].BorderThickness = new Thickness(2);
									fchessboard[i, j + 6].BorderBrush = highlighted;
									//chessboard[i, j + 6].Tag = "highlighted";
								}





								if (i - 7 >= 0 && i - 7 <= 7 && j >= 0 && j <= 7)
								{
									game.GetChessBoard().GetSquare(i - 7, j).SetHighlight(true);
									fchessboard[i - 7, j].BorderThickness = new Thickness(2);
									fchessboard[i - 7, j].BorderBrush = highlighted;
									//chessboard[i - 7, j].Tag = "highlighted";
								}


								if (i + 7 >= 0 && i + 7 <= 7 && j >= 0 && j <= 7)
								{
									game.GetChessBoard().GetSquare(i + 7, j).SetHighlight(true);
									fchessboard[i + 7, j].BorderThickness = new Thickness(2);
									fchessboard[i + 7, j].BorderBrush = highlighted;
									//chessboard[i + 7, j].Tag = "highlighted";
								}



								if (j - 7 >= 0 && j - 7 <= 7)
								{
									game.GetChessBoard().GetSquare(i, j - 7).SetHighlight(true);
									fchessboard[i, j - 7].BorderThickness = new Thickness(2);
									fchessboard[i, j - 7].BorderBrush = highlighted;
									//chessboard[i, j - 7].Tag = "highlighted";
								}


								if (j + 7 >= 0 && j + 7 <= 7)
								{
									game.GetChessBoard().GetSquare(i, j + 7).SetHighlight(true);
									fchessboard[i, j + 7].BorderThickness = new Thickness(2);
									fchessboard[i, j + 7].BorderBrush = highlighted;
									//chessboard[i, j + 7].Tag = "highlighted";
								}




							}

							if (game.GetChessBoard().GetSquare(i, j).GetPiece().GetType() == typeof(King))
							{
								if (i - 1 >= 0 && i - 1 <= 7 && j - 1 >= 0 && j - 1 <= 7)
								{
									game.GetChessBoard().GetSquare(i - 1, j - 1).SetHighlight(true);
									fchessboard[i - 1, j - 1].BorderThickness = new Thickness(2);
									fchessboard[i - 1, j - 1].BorderBrush = highlighted;
									//chessboard[i - 1, j - 1].Tag = "highlighted";
								}






								if (i + 1 >= 0 && i + 1 <= 7 && j + 1 >= 0 && j + 1 <= 7)
								{
									game.GetChessBoard().GetSquare(i + 1, j + 1).SetHighlight(true);
									fchessboard[i + 1, j + 1].BorderThickness = new Thickness(2);
									fchessboard[i + 1, j + 1].BorderBrush = highlighted;
									//chessboard[i + 1, j + 1].Tag = "highlighted";
								}






								if (i + 1 >= 0 && i + 1 <= 7 && j - 1 >= 0 && j - 1 <= 7)
								{
									game.GetChessBoard().GetSquare(i + 1, j - 1).SetHighlight(true);
									fchessboard[i + 1, j - 1].BorderThickness = new Thickness(2);
									fchessboard[i + 1, j - 1].BorderBrush = highlighted;
									//chessboard[i + 1, j - 1].Tag = "highlighted";
								}







								if (i - 1 >= 0 && i - 1 <= 7 && j + 1 >= 0 && j + 1 <= 7)
								{
									game.GetChessBoard().GetSquare(i - 1, j + 1).SetHighlight(true);
									fchessboard[i - 1, j + 1].BorderThickness = new Thickness(2);
									fchessboard[i - 1, j + 1].BorderBrush = highlighted;
									//chessboard[i - 1, j + 1].Tag = "highlighted";
								}







								if (i - 1 >= 0 && i - 1 <= 7 && j >= 0 && j <= 7)
								{
									game.GetChessBoard().GetSquare(i - 1, j).SetHighlight(true);
									fchessboard[i - 1, j].BorderThickness = new Thickness(2);
									fchessboard[i - 1, j].BorderBrush = highlighted;
									//chessboard[i - 1, j].Tag = "highlighted";
								}


								if (i + 1 >= 0 && i + 1 <= 7 && j >= 0 && j <= 7)
								{
									game.GetChessBoard().GetSquare(i + 1, j).SetHighlight(true);
									fchessboard[i + 1, j].BorderThickness = new Thickness(2);
									fchessboard[i + 1, j].BorderBrush = highlighted;
									//chessboard[i + 1, j].Tag = "highlighted";
								}



								if (j - 1 >= 0 && j - 1 <= 7)
								{
									game.GetChessBoard().GetSquare(i, j - 1).SetHighlight(true);
									fchessboard[i, j - 1].BorderThickness = new Thickness(2);
									fchessboard[i, j - 1].BorderBrush = highlighted;
									//chessboard[i, j - 1].Tag = "highlighted";
								}


								if (j + 1 >= 0 && j + 1 <= 7)
								{
									game.GetChessBoard().GetSquare(i, j + 1).SetHighlight(true);
									fchessboard[i, j + 1].BorderThickness = new Thickness(2);
									fchessboard[i, j + 1].BorderBrush = highlighted;
									//chessboard[i, j + 1].Tag = "highlighted";
								}






							}

							// Czarne

							if (game.GetChessBoard().GetSquare(i, j).GetPiece().GetColor() == Constants.Black && game.GetChessBoard().GetSquare(i, j).GetPiece().GetType() == typeof(Pawn))
							{
								if (i - 1 >= 0 && i - 1 <= 7 && j >= 0 && j <= 7)
								{
									game.GetChessBoard().GetSquare(i - 1, j).SetHighlight(true);
									fchessboard[i - 1, j].BorderThickness = new Thickness(2);
									fchessboard[i - 1, j].BorderBrush = highlighted;
									//chessboard[i + 1, j].Tag = "highlighted";
								}

								if (i - 2 >= 0 && i - 2 <= 7 && j >= 0 && j <= 7)
								{
									game.GetChessBoard().GetSquare(i - 2, j).SetHighlight(true);
									fchessboard[i - 2, j].BorderThickness = new Thickness(2);
									fchessboard[i - 2, j].BorderBrush = highlighted;
									//chessboard[i + 2, j].Tag = "highlighted";
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


			//for (int i = 0; i < 8; i++)
			//	for (int j = 0; j < 8; j++)
			//		if (chessboard[i, j] == (sender as Button))
			//		{
			//			// Biale

			//			if (chessboard[i, j].Content.ToString() == "bPion")
			//			{
			//				if (i + 1 >= 0 && i + 1 <= 7 && j >= 0 && j <= 7)
			//				{
			//					fchessboard[i + 1, j].BorderThickness = new Thickness(2);
			//					fchessboard[i + 1, j].BorderBrush = highlighted;
			//					chessboard[i + 1, j].Tag = "highlighted";
			//				}

			//				if (i + 2 >= 0 && i + 2 <= 7 && j >= 0 && j <= 7)
			//				{
			//					fchessboard[i + 2, j].BorderThickness = new Thickness(2);
			//					fchessboard[i + 2, j].BorderBrush = highlighted;
			//					chessboard[i + 2, j].Tag = "highlighted";
			//				}


			//			}

			//			if (chessboard[i, j].Content.ToString() == "bWieza" || chessboard[i, j].Content.ToString() == "cWieza")
			//			{
			//				if (i - 1 >= 0 && i - 1 <= 7 && j >= 0 && j <= 7)
			//				{
			//					fchessboard[i - 1, j].BorderThickness = new Thickness(2);
			//					fchessboard[i - 1, j].BorderBrush = highlighted;
			//					chessboard[i - 1, j].Tag = "highlighted";
			//				}


			//				if (i + 1 >= 0 && i + 1 <= 7 && j >= 0 && j <= 7)
			//				{
			//					fchessboard[i + 1, j].BorderThickness = new Thickness(2);
			//					fchessboard[i + 1, j].BorderBrush = highlighted;
			//					chessboard[i + 1, j].Tag = "highlighted";
			//				}



			//				if (j - 1 >= 0 && j - 1 <= 7)
			//				{
			//					fchessboard[i, j - 1].BorderThickness = new Thickness(2);
			//					fchessboard[i, j - 1].BorderBrush = highlighted;
			//					chessboard[i, j - 1].Tag = "highlighted";
			//				}


			//				if (j + 1 >= 0 && j + 1 <= 7)
			//				{
			//					fchessboard[i, j + 1].BorderThickness = new Thickness(2);
			//					fchessboard[i, j + 1].BorderBrush = highlighted;
			//					chessboard[i, j + 1].Tag = "highlighted";
			//				}


			//				if (i - 2 >= 0 && i - 2 <= 7 && j >= 0 && j <= 7)
			//				{
			//					fchessboard[i - 2, j].BorderThickness = new Thickness(2);
			//					fchessboard[i - 2, j].BorderBrush = highlighted;
			//					chessboard[i - 2, j].Tag = "highlighted";
			//				}


			//				if (i + 2 >= 0 && i + 2 <= 7 && j >= 0 && j <= 7)
			//				{
			//					fchessboard[i + 2, j].BorderThickness = new Thickness(2);
			//					fchessboard[i + 2, j].BorderBrush = highlighted;
			//					chessboard[i + 2, j].Tag = "highlighted";
			//				}



			//				if (j - 2 >= 0 && j - 2 <= 7)
			//				{
			//					fchessboard[i, j - 2].BorderThickness = new Thickness(2);
			//					fchessboard[i, j - 2].BorderBrush = highlighted;
			//					chessboard[i, j - 2].Tag = "highlighted";
			//				}


			//				if (j + 2 >= 0 && j + 2 <= 7)
			//				{
			//					fchessboard[i, j + 2].BorderThickness = new Thickness(2);
			//					fchessboard[i, j + 2].BorderBrush = highlighted;
			//					chessboard[i, j + 2].Tag = "highlighted";
			//				}


			//				if (i - 3 >= 0 && i - 3 <= 7 && j >= 0 && j <= 7)
			//				{
			//					fchessboard[i - 3, j].BorderThickness = new Thickness(2);
			//					fchessboard[i - 3, j].BorderBrush = highlighted;
			//					chessboard[i - 3, j].Tag = "highlighted";
			//				}


			//				if (i + 3 >= 0 && i + 3 <= 7 && j >= 0 && j <= 7)
			//				{
			//					fchessboard[i + 3, j].BorderThickness = new Thickness(2);
			//					fchessboard[i + 3, j].BorderBrush = highlighted;
			//					chessboard[i + 3, j].Tag = "highlighted";
			//				}



			//				if (j - 3 >= 0 && j - 3 <= 7)
			//				{
			//					fchessboard[i, j - 3].BorderThickness = new Thickness(2);
			//					fchessboard[i, j - 3].BorderBrush = highlighted;
			//					chessboard[i, j - 3].Tag = "highlighted";
			//				}


			//				if (j + 3 >= 0 && j + 3 <= 7)
			//				{
			//					fchessboard[i, j + 3].BorderThickness = new Thickness(2);
			//					fchessboard[i, j + 3].BorderBrush = highlighted;
			//					chessboard[i, j + 3].Tag = "highlighted";
			//				}


			//				if (i - 4 >= 0 && i - 4 <= 7 && j >= 0 && j <= 7)
			//				{
			//					fchessboard[i - 4, j].BorderThickness = new Thickness(2);
			//					fchessboard[i - 4, j].BorderBrush = highlighted;
			//					chessboard[i - 4, j].Tag = "highlighted";
			//				}


			//				if (i + 4 >= 0 && i + 4 <= 7 && j >= 0 && j <= 7)
			//				{
			//					fchessboard[i + 4, j].BorderThickness = new Thickness(2);
			//					fchessboard[i + 4, j].BorderBrush = highlighted;
			//					chessboard[i + 4, j].Tag = "highlighted";
			//				}



			//				if (j - 4 >= 0 && j - 4 <= 7)
			//				{
			//					fchessboard[i, j - 4].BorderThickness = new Thickness(2);
			//					fchessboard[i, j - 4].BorderBrush = highlighted;
			//					chessboard[i, j - 4].Tag = "highlighted";
			//				}


			//				if (j + 4 >= 0 && j + 4 <= 7)
			//				{
			//					fchessboard[i, j + 4].BorderThickness = new Thickness(2);
			//					fchessboard[i, j + 4].BorderBrush = highlighted;
			//					chessboard[i, j + 4].Tag = "highlighted";
			//				}


			//				if (i - 5 >= 0 && i - 5 <= 7 && j >= 0 && j <= 7)
			//				{
			//					fchessboard[i - 5, j].BorderThickness = new Thickness(2);
			//					fchessboard[i - 5, j].BorderBrush = highlighted;
			//					chessboard[i - 5, j].Tag = "highlighted";
			//				}


			//				if (i + 5 >= 0 && i + 5 <= 7 && j >= 0 && j <= 7)
			//				{
			//					fchessboard[i + 5, j].BorderThickness = new Thickness(2);
			//					fchessboard[i + 5, j].BorderBrush = highlighted;
			//					chessboard[i + 5, j].Tag = "highlighted";
			//				}



			//				if (j - 5 >= 0 && j - 5 <= 7)
			//				{
			//					fchessboard[i, j - 5].BorderThickness = new Thickness(2);
			//					fchessboard[i, j - 5].BorderBrush = highlighted;
			//					chessboard[i, j - 5].Tag = "highlighted";
			//				}


			//				if (j + 5 >= 0 && j + 5 <= 7)
			//				{
			//					fchessboard[i, j + 5].BorderThickness = new Thickness(2);
			//					fchessboard[i, j + 5].BorderBrush = highlighted;
			//					chessboard[i, j + 5].Tag = "highlighted";
			//				}


			//				if (i - 6 >= 0 && i - 6 <= 7 && j >= 0 && j <= 7)
			//				{
			//					fchessboard[i - 6, j].BorderThickness = new Thickness(2);
			//					fchessboard[i - 6, j].BorderBrush = highlighted;
			//					chessboard[i - 6, j].Tag = "highlighted";
			//				}


			//				if (i + 6 >= 0 && i + 6 <= 7 && j >= 0 && j <= 7)
			//				{
			//					fchessboard[i + 6, j].BorderThickness = new Thickness(2);
			//					fchessboard[i + 6, j].BorderBrush = highlighted;
			//					chessboard[i + 6, j].Tag = "highlighted";
			//				}



			//				if (j - 6 >= 0 && j - 6 <= 7)
			//				{
			//					fchessboard[i, j - 6].BorderThickness = new Thickness(2);
			//					fchessboard[i, j - 6].BorderBrush = highlighted;
			//					chessboard[i, j - 6].Tag = "highlighted";
			//				}


			//				if (j + 6 >= 0 && j + 6 <= 7)
			//				{
			//					fchessboard[i, j + 6].BorderThickness = new Thickness(2);
			//					fchessboard[i, j + 6].BorderBrush = highlighted;
			//					chessboard[i, j + 6].Tag = "highlighted";
			//				}


			//				if (i - 7 >= 0 && i - 7 <= 7 && j >= 0 && j <= 7)
			//				{
			//					fchessboard[i - 7, j].BorderThickness = new Thickness(2);
			//					fchessboard[i - 7, j].BorderBrush = highlighted;
			//					chessboard[i - 7, j].Tag = "highlighted";
			//				}


			//				if (i + 7 >= 0 && i + 7 <= 7 && j >= 0 && j <= 7)
			//				{
			//					fchessboard[i + 7, j].BorderThickness = new Thickness(2);
			//					fchessboard[i + 7, j].BorderBrush = highlighted;
			//					chessboard[i + 7, j].Tag = "highlighted";
			//				}



			//				if (j - 7 >= 0 && j - 7 <= 7)
			//				{
			//					fchessboard[i, j - 7].BorderThickness = new Thickness(2);
			//					fchessboard[i, j - 7].BorderBrush = highlighted;
			//					chessboard[i, j - 7].Tag = "highlighted";
			//				}


			//				if (j + 7 >= 0 && j + 7 <= 7)
			//				{
			//					fchessboard[i, j + 7].BorderThickness = new Thickness(2);
			//					fchessboard[i, j + 7].BorderBrush = highlighted;
			//					chessboard[i, j + 7].Tag = "highlighted";
			//				}


			//			}

			//			if (chessboard[i, j].Content.ToString() == "bKon" || chessboard[i, j].Content.ToString() == "cKon")
			//			{
			//				if (i - 2 >= 0 && i - 2 <= 7 && j + 1 >= 0 && j + 1 <= 7)
			//				{
			//					fchessboard[i - 2, j + 1].BorderThickness = new Thickness(2);
			//					fchessboard[i - 2, j + 1].BorderBrush = highlighted;
			//					chessboard[i - 2, j + 1].Tag = "highlighted";
			//				}

			//				if (i - 2 >= 0 && i - 2 <= 7 && j - 1 >= 0 && j - 1 <= 7)
			//				{
			//					fchessboard[i - 2, j - 1].BorderThickness = new Thickness(2);
			//					fchessboard[i - 2, j - 1].BorderBrush = highlighted;
			//					chessboard[i - 2, j - 1].Tag = "highlighted";
			//				}

			//				if (i + 2 >= 0 && i + 2 <= 7 && j + 1 >= 0 && j + 1 <= 7)
			//				{
			//					fchessboard[i + 2, j + 1].BorderThickness = new Thickness(2);
			//					fchessboard[i + 2, j + 1].BorderBrush = highlighted;
			//					chessboard[i + 2, j + 1].Tag = "highlighted";
			//				}

			//				if (i + 2 >= 0 && i + 2 <= 7 && j - 1 >= 0 && j - 1 <= 7)
			//				{
			//					fchessboard[i + 2, j - 1].BorderThickness = new Thickness(2);
			//					fchessboard[i + 2, j - 1].BorderBrush = highlighted;
			//					chessboard[i + 2, j - 1].Tag = "highlighted";
			//				}

			//				if (i + 1 >= 0 && i + 1 <= 7 && j - 2 >= 0 && j - 2 <= 7)
			//				{
			//					fchessboard[i + 1, j - 2].BorderThickness = new Thickness(2);
			//					fchessboard[i + 1, j - 2].BorderBrush = highlighted;
			//					chessboard[i + 1, j - 2].Tag = "highlighted";
			//				}

			//				if (i - 1 >= 0 && i - 1 <= 7 && j - 2 >= 0 && j - 2 <= 7)
			//				{
			//					fchessboard[i - 1, j - 2].BorderThickness = new Thickness(2);
			//					fchessboard[i - 1, j - 2].BorderBrush = highlighted;
			//					chessboard[i - 1, j - 2].Tag = "highlighted";
			//				}

			//				if (i + 1 >= 0 && i + 1 <= 7 && j + 2 >= 0 && j + 2 <= 7)
			//				{
			//					fchessboard[i + 1, j + 2].BorderThickness = new Thickness(2);
			//					fchessboard[i + 1, j + 2].BorderBrush = highlighted;
			//					chessboard[i + 1, j + 2].Tag = "highlighted";
			//				}

			//				if (i - 1 >= 0 && i - 1 <= 7 && j + 2 >= 0 && j + 2 <= 7)
			//				{
			//					fchessboard[i - 1, j + 2].BorderThickness = new Thickness(2);
			//					fchessboard[i - 1, j + 2].BorderBrush = highlighted;
			//					chessboard[i - 1, j + 2].Tag = "highlighted";
			//				}

			//			}

			//			if (chessboard[i, j].Content.ToString() == "bLaufer" || chessboard[i, j].Content.ToString() == "cLaufer")
			//			{
			//				if (i - 1 >= 0 && i - 1 <= 7 && j - 1 >= 0 && j - 1 <= 7)
			//				{
			//					fchessboard[i - 1, j - 1].BorderThickness = new Thickness(2);
			//					fchessboard[i - 1, j - 1].BorderBrush = highlighted;
			//					chessboard[i - 1, j - 1].Tag = "highlighted";
			//				}
			//				if (i - 2 >= 0 && i - 2 <= 7 && j - 2 >= 0 && j - 2 <= 7)
			//				{
			//					fchessboard[i - 2, j - 2].BorderThickness = new Thickness(2);
			//					fchessboard[i - 2, j - 2].BorderBrush = highlighted;
			//					chessboard[i - 2, j - 2].Tag = "highlighted";
			//				}
			//				if (i - 3 >= 0 && i - 3 <= 7 && j - 3 >= 0 && j - 3 <= 7)
			//				{
			//					fchessboard[i - 3, j - 3].BorderThickness = new Thickness(2);
			//					fchessboard[i - 3, j - 3].BorderBrush = highlighted;
			//					chessboard[i - 3, j - 3].Tag = "highlighted";
			//				}
			//				if (i - 4 >= 0 && i - 4 <= 7 && j - 4 >= 0 && j - 4 <= 7)
			//				{
			//					fchessboard[i - 4, j - 4].BorderThickness = new Thickness(2);
			//					fchessboard[i - 4, j - 4].BorderBrush = highlighted;
			//					chessboard[i - 4, j - 4].Tag = "highlighted";
			//				}
			//				if (i - 5 >= 0 && i - 5 <= 7 && j - 5 >= 0 && j - 5 <= 7)
			//				{
			//					fchessboard[i - 5, j - 5].BorderThickness = new Thickness(2);
			//					fchessboard[i - 5, j - 5].BorderBrush = highlighted;
			//					chessboard[i - 5, j - 5].Tag = "highlighted";
			//				}
			//				if (i - 6 >= 0 && i - 6 <= 7 && j - 6 >= 0 && j - 6 <= 7)
			//				{
			//					fchessboard[i - 6, j - 6].BorderThickness = new Thickness(2);
			//					fchessboard[i - 6, j - 6].BorderBrush = highlighted;
			//					chessboard[i - 6, j - 6].Tag = "highlighted";
			//				}
			//				if (i - 7 >= 0 && i - 7 <= 7 && j - 7 >= 0 && j - 7 <= 7)
			//				{
			//					fchessboard[i - 7, j - 7].BorderThickness = new Thickness(2);
			//					fchessboard[i - 7, j - 7].BorderBrush = highlighted;
			//					chessboard[i - 7, j - 7].Tag = "highlighted";
			//				}





			//				if (i + 1 >= 0 && i + 1 <= 7 && j + 1 >= 0 && j + 1 <= 7)
			//				{
			//					fchessboard[i + 1, j + 1].BorderThickness = new Thickness(2);
			//					fchessboard[i + 1, j + 1].BorderBrush = highlighted;
			//					chessboard[i + 1, j + 1].Tag = "highlighted";
			//				}
			//				if (i + 2 >= 0 && i + 2 <= 7 && j + 2 >= 0 && j + 2 <= 7)
			//				{
			//					fchessboard[i + 2, j + 2].BorderThickness = new Thickness(2);
			//					fchessboard[i + 2, j + 2].BorderBrush = highlighted;
			//					chessboard[i + 2, j + 2].Tag = "highlighted";
			//				}
			//				if (i + 3 >= 0 && i + 3 <= 7 && j + 3 >= 0 && j + 3 <= 7)
			//				{
			//					fchessboard[i + 3, j + 3].BorderThickness = new Thickness(2);
			//					fchessboard[i + 3, j + 3].BorderBrush = highlighted;
			//					chessboard[i + 3, j + 3].Tag = "highlighted";
			//				}
			//				if (i + 4 >= 0 && i + 4 <= 7 && j + 4 >= 0 && j + 4 <= 7)
			//				{
			//					fchessboard[i + 4, j + 4].BorderThickness = new Thickness(2);
			//					fchessboard[i + 4, j + 4].BorderBrush = highlighted;
			//					chessboard[i + 4, j + 4].Tag = "highlighted";
			//				}
			//				if (i + 5 >= 0 && i + 5 <= 7 && j + 5 >= 0 && j + 5 <= 7)
			//				{
			//					fchessboard[i + 5, j + 5].BorderThickness = new Thickness(2);
			//					fchessboard[i + 5, j + 5].BorderBrush = highlighted;
			//					chessboard[i + 5, j + 5].Tag = "highlighted";
			//				}
			//				if (i + 6 >= 0 && i + 6 <= 7 && j + 6 >= 0 && j + 6 <= 7)
			//				{
			//					fchessboard[i + 6, j + 6].BorderThickness = new Thickness(2);
			//					fchessboard[i + 6, j + 6].BorderBrush = highlighted;
			//					chessboard[i + 6, j + 6].Tag = "highlighted";
			//				}
			//				if (i + 7 >= 0 && i + 7 <= 7 && j + 7 >= 0 && j + 7 <= 7)
			//				{
			//					fchessboard[i + 7, j + 7].BorderThickness = new Thickness(2);
			//					fchessboard[i + 7, j + 7].BorderBrush = highlighted;
			//					chessboard[i + 7, j + 7].Tag = "highlighted";
			//				}





			//				if (i + 1 >= 0 && i + 1 <= 7 && j - 1 >= 0 && j - 1 <= 7)
			//				{
			//					fchessboard[i + 1, j - 1].BorderThickness = new Thickness(2);
			//					fchessboard[i + 1, j - 1].BorderBrush = highlighted;
			//					chessboard[i + 1, j - 1].Tag = "highlighted";
			//				}
			//				if (i + 2 >= 0 && i + 2 <= 7 && j - 2 >= 0 && j - 2 <= 7)
			//				{
			//					fchessboard[i + 2, j - 2].BorderThickness = new Thickness(2);
			//					fchessboard[i + 2, j - 2].BorderBrush = highlighted;
			//					chessboard[i + 2, j - 2].Tag = "highlighted";
			//				}
			//				if (i + 3 >= 0 && i + 3 <= 7 && j - 3 >= 0 && j - 3 <= 7)
			//				{
			//					fchessboard[i + 3, j - 3].BorderThickness = new Thickness(2);
			//					fchessboard[i + 3, j - 3].BorderBrush = highlighted;
			//					chessboard[i + 3, j - 3].Tag = "highlighted";
			//				}
			//				if (i + 4 >= 0 && i + 4 <= 7 && j - 4 >= 0 && j - 4 <= 7)
			//				{
			//					fchessboard[i + 4, j - 4].BorderThickness = new Thickness(2);
			//					fchessboard[i + 4, j - 4].BorderBrush = highlighted;
			//					chessboard[i + 4, j - 4].Tag = "highlighted";
			//				}
			//				if (i + 5 >= 0 && i + 5 <= 7 && j - 5 >= 0 && j - 5 <= 7)
			//				{
			//					fchessboard[i + 5, j - 5].BorderThickness = new Thickness(2);
			//					fchessboard[i + 5, j - 5].BorderBrush = highlighted;
			//					chessboard[i + 5, j - 5].Tag = "highlighted";
			//				}
			//				if (i + 6 >= 0 && i + 6 <= 7 && j - 6 >= 0 && j - 6 <= 7)
			//				{
			//					fchessboard[i + 6, j - 6].BorderThickness = new Thickness(2);
			//					fchessboard[i + 6, j - 6].BorderBrush = highlighted;
			//					chessboard[i + 6, j - 6].Tag = "highlighted";
			//				}
			//				if (i + 7 >= 0 && i + 7 <= 7 && j - 7 >= 0 && j - 7 <= 7)
			//				{
			//					fchessboard[i + 7, j - 7].BorderThickness = new Thickness(2);
			//					fchessboard[i + 7, j - 7].BorderBrush = highlighted;
			//					chessboard[i + 7, j - 7].Tag = "highlighted";
			//				}





			//				if (i - 1 >= 0 && i - 1 <= 7 && j + 1 >= 0 && j + 1 <= 7)
			//				{
			//					fchessboard[i - 1, j + 1].BorderThickness = new Thickness(2);
			//					fchessboard[i - 1, j + 1].BorderBrush = highlighted;
			//					chessboard[i - 1, j + 1].Tag = "highlighted";
			//				}
			//				if (i - 2 >= 0 && i - 2 <= 7 && j + 2 >= 0 && j + 2 <= 7)
			//				{
			//					fchessboard[i - 2, j + 2].BorderThickness = new Thickness(2);
			//					fchessboard[i - 2, j + 2].BorderBrush = highlighted;
			//					chessboard[i - 2, j + 2].Tag = "highlighted";
			//				}
			//				if (i - 3 >= 0 && i - 3 <= 7 && j + 3 >= 0 && j + 3 <= 7)
			//				{
			//					fchessboard[i - 3, j + 3].BorderThickness = new Thickness(2);
			//					fchessboard[i - 3, j + 3].BorderBrush = highlighted;
			//					chessboard[i - 3, j + 3].Tag = "highlighted";
			//				}
			//				if (i - 4 >= 0 && i - 4 <= 7 && j + 4 >= 0 && j + 4 <= 7)
			//				{
			//					fchessboard[i - 4, j + 4].BorderThickness = new Thickness(2);
			//					fchessboard[i - 4, j + 4].BorderBrush = highlighted;
			//					chessboard[i - 4, j + 4].Tag = "highlighted";
			//				}
			//				if (i - 5 >= 0 && i - 5 <= 7 && j + 5 >= 0 && j + 5 <= 7)
			//				{
			//					fchessboard[i - 5, j + 5].BorderThickness = new Thickness(2);
			//					fchessboard[i - 5, j + 5].BorderBrush = highlighted;
			//					chessboard[i - 5, j + 5].Tag = "highlighted";
			//				}
			//				if (i - 6 >= 0 && i - 6 <= 7 && j + 6 >= 0 && j + 6 <= 7)
			//				{
			//					fchessboard[i - 6, j + 6].BorderThickness = new Thickness(2);
			//					fchessboard[i - 6, j + 6].BorderBrush = highlighted;
			//					chessboard[i - 6, j + 6].Tag = "highlighted";
			//				}
			//				if (i - 7 >= 0 && i - 7 <= 7 && j + 7 >= 0 && j + 7 <= 7)
			//				{
			//					fchessboard[i - 7, j + 7].BorderThickness = new Thickness(2);
			//					fchessboard[i - 7, j + 7].BorderBrush = highlighted;
			//					chessboard[i - 7, j + 7].Tag = "highlighted";
			//				}






			//			}

			//			if (chessboard[i, j].Content.ToString() == "bKrolowa" || chessboard[i, j].Content.ToString() == "cKrolowa")
			//			{
			//				if (i - 1 >= 0 && i - 1 <= 7 && j - 1 >= 0 && j - 1 <= 7)
			//				{
			//					fchessboard[i - 1, j - 1].BorderThickness = new Thickness(2);
			//					fchessboard[i - 1, j - 1].BorderBrush = highlighted;
			//					chessboard[i - 1, j - 1].Tag = "highlighted";
			//				}
			//				if (i - 2 >= 0 && i - 2 <= 7 && j - 2 >= 0 && j - 2 <= 7)
			//				{
			//					fchessboard[i - 2, j - 2].BorderThickness = new Thickness(2);
			//					fchessboard[i - 2, j - 2].BorderBrush = highlighted;
			//					chessboard[i - 2, j - 2].Tag = "highlighted";
			//				}
			//				if (i - 3 >= 0 && i - 3 <= 7 && j - 3 >= 0 && j - 3 <= 7)
			//				{
			//					fchessboard[i - 3, j - 3].BorderThickness = new Thickness(2);
			//					fchessboard[i - 3, j - 3].BorderBrush = highlighted;
			//					chessboard[i - 3, j - 3].Tag = "highlighted";
			//				}
			//				if (i - 4 >= 0 && i - 4 <= 7 && j - 4 >= 0 && j - 4 <= 7)
			//				{
			//					fchessboard[i - 4, j - 4].BorderThickness = new Thickness(2);
			//					fchessboard[i - 4, j - 4].BorderBrush = highlighted;
			//					chessboard[i - 4, j - 4].Tag = "highlighted";
			//				}
			//				if (i - 5 >= 0 && i - 5 <= 7 && j - 5 >= 0 && j - 5 <= 7)
			//				{
			//					fchessboard[i - 5, j - 5].BorderThickness = new Thickness(2);
			//					fchessboard[i - 5, j - 5].BorderBrush = highlighted;
			//					chessboard[i - 5, j - 5].Tag = "highlighted";
			//				}
			//				if (i - 6 >= 0 && i - 6 <= 7 && j - 6 >= 0 && j - 6 <= 7)
			//				{
			//					fchessboard[i - 6, j - 6].BorderThickness = new Thickness(2);
			//					fchessboard[i - 6, j - 6].BorderBrush = highlighted;
			//					chessboard[i - 6, j - 6].Tag = "highlighted";
			//				}
			//				if (i - 7 >= 0 && i - 7 <= 7 && j - 7 >= 0 && j - 7 <= 7)
			//				{
			//					fchessboard[i - 7, j - 7].BorderThickness = new Thickness(2);
			//					fchessboard[i - 7, j - 7].BorderBrush = highlighted;
			//					chessboard[i - 7, j - 7].Tag = "highlighted";
			//				}





			//				if (i + 1 >= 0 && i + 1 <= 7 && j + 1 >= 0 && j + 1 <= 7)
			//				{
			//					fchessboard[i + 1, j + 1].BorderThickness = new Thickness(2);
			//					fchessboard[i + 1, j + 1].BorderBrush = highlighted;
			//					chessboard[i + 1, j + 1].Tag = "highlighted";
			//				}
			//				if (i + 2 >= 0 && i + 2 <= 7 && j + 2 >= 0 && j + 2 <= 7)
			//				{
			//					fchessboard[i + 2, j + 2].BorderThickness = new Thickness(2);
			//					fchessboard[i + 2, j + 2].BorderBrush = highlighted;
			//					chessboard[i + 2, j + 2].Tag = "highlighted";
			//				}
			//				if (i + 3 >= 0 && i + 3 <= 7 && j + 3 >= 0 && j + 3 <= 7)
			//				{
			//					fchessboard[i + 3, j + 3].BorderThickness = new Thickness(2);
			//					fchessboard[i + 3, j + 3].BorderBrush = highlighted;
			//					chessboard[i + 3, j + 3].Tag = "highlighted";
			//				}
			//				if (i + 4 >= 0 && i + 4 <= 7 && j + 4 >= 0 && j + 4 <= 7)
			//				{
			//					fchessboard[i + 4, j + 4].BorderThickness = new Thickness(2);
			//					fchessboard[i + 4, j + 4].BorderBrush = highlighted;
			//					chessboard[i + 4, j + 4].Tag = "highlighted";
			//				}
			//				if (i + 5 >= 0 && i + 5 <= 7 && j + 5 >= 0 && j + 5 <= 7)
			//				{
			//					fchessboard[i + 5, j + 5].BorderThickness = new Thickness(2);
			//					fchessboard[i + 5, j + 5].BorderBrush = highlighted;
			//					chessboard[i + 5, j + 5].Tag = "highlighted";
			//				}
			//				if (i + 6 >= 0 && i + 6 <= 7 && j + 6 >= 0 && j + 6 <= 7)
			//				{
			//					fchessboard[i + 6, j + 6].BorderThickness = new Thickness(2);
			//					fchessboard[i + 6, j + 6].BorderBrush = highlighted;
			//					chessboard[i + 6, j + 6].Tag = "highlighted";
			//				}
			//				if (i + 7 >= 0 && i + 7 <= 7 && j + 7 >= 0 && j + 7 <= 7)
			//				{
			//					fchessboard[i + 7, j + 7].BorderThickness = new Thickness(2);
			//					fchessboard[i + 7, j + 7].BorderBrush = highlighted;
			//					chessboard[i + 7, j + 7].Tag = "highlighted";
			//				}





			//				if (i + 1 >= 0 && i + 1 <= 7 && j - 1 >= 0 && j - 1 <= 7)
			//				{
			//					fchessboard[i + 1, j - 1].BorderThickness = new Thickness(2);
			//					fchessboard[i + 1, j - 1].BorderBrush = highlighted;
			//					chessboard[i + 1, j - 1].Tag = "highlighted";
			//				}
			//				if (i + 2 >= 0 && i + 2 <= 7 && j - 2 >= 0 && j - 2 <= 7)
			//				{
			//					fchessboard[i + 2, j - 2].BorderThickness = new Thickness(2);
			//					fchessboard[i + 2, j - 2].BorderBrush = highlighted;
			//					chessboard[i + 2, j - 2].Tag = "highlighted";
			//				}
			//				if (i + 3 >= 0 && i + 3 <= 7 && j - 3 >= 0 && j - 3 <= 7)
			//				{
			//					fchessboard[i + 3, j - 3].BorderThickness = new Thickness(2);
			//					fchessboard[i + 3, j - 3].BorderBrush = highlighted;
			//					chessboard[i + 3, j - 3].Tag = "highlighted";
			//				}
			//				if (i + 4 >= 0 && i + 4 <= 7 && j - 4 >= 0 && j - 4 <= 7)
			//				{
			//					fchessboard[i + 4, j - 4].BorderThickness = new Thickness(2);
			//					fchessboard[i + 4, j - 4].BorderBrush = highlighted;
			//					chessboard[i + 4, j - 4].Tag = "highlighted";
			//				}
			//				if (i + 5 >= 0 && i + 5 <= 7 && j - 5 >= 0 && j - 5 <= 7)
			//				{
			//					fchessboard[i + 5, j - 5].BorderThickness = new Thickness(2);
			//					fchessboard[i + 5, j - 5].BorderBrush = highlighted;
			//					chessboard[i + 5, j - 5].Tag = "highlighted";
			//				}
			//				if (i + 6 >= 0 && i + 6 <= 7 && j - 6 >= 0 && j - 6 <= 7)
			//				{
			//					fchessboard[i + 6, j - 6].BorderThickness = new Thickness(2);
			//					fchessboard[i + 6, j - 6].BorderBrush = highlighted;
			//					chessboard[i + 6, j - 6].Tag = "highlighted";
			//				}
			//				if (i + 7 >= 0 && i + 7 <= 7 && j - 7 >= 0 && j - 7 <= 7)
			//				{
			//					fchessboard[i + 7, j - 7].BorderThickness = new Thickness(2);
			//					fchessboard[i + 7, j - 7].BorderBrush = highlighted;
			//					chessboard[i + 7, j - 7].Tag = "highlighted";
			//				}





			//				if (i - 1 >= 0 && i - 1 <= 7 && j + 1 >= 0 && j + 1 <= 7)
			//				{
			//					fchessboard[i - 1, j + 1].BorderThickness = new Thickness(2);
			//					fchessboard[i - 1, j + 1].BorderBrush = highlighted;
			//					chessboard[i - 1, j + 1].Tag = "highlighted";
			//				}
			//				if (i - 2 >= 0 && i - 2 <= 7 && j + 2 >= 0 && j + 2 <= 7)
			//				{
			//					fchessboard[i - 2, j + 2].BorderThickness = new Thickness(2);
			//					fchessboard[i - 2, j + 2].BorderBrush = highlighted;
			//					chessboard[i - 2, j + 2].Tag = "highlighted";
			//				}
			//				if (i - 3 >= 0 && i - 3 <= 7 && j + 3 >= 0 && j + 3 <= 7)
			//				{
			//					fchessboard[i - 3, j + 3].BorderThickness = new Thickness(2);
			//					fchessboard[i - 3, j + 3].BorderBrush = highlighted;
			//					chessboard[i - 3, j + 3].Tag = "highlighted";
			//				}
			//				if (i - 4 >= 0 && i - 4 <= 7 && j + 4 >= 0 && j + 4 <= 7)
			//				{
			//					fchessboard[i - 4, j + 4].BorderThickness = new Thickness(2);
			//					fchessboard[i - 4, j + 4].BorderBrush = highlighted;
			//					chessboard[i - 4, j + 4].Tag = "highlighted";
			//				}
			//				if (i - 5 >= 0 && i - 5 <= 7 && j + 5 >= 0 && j + 5 <= 7)
			//				{
			//					fchessboard[i - 5, j + 5].BorderThickness = new Thickness(2);
			//					fchessboard[i - 5, j + 5].BorderBrush = highlighted;
			//					chessboard[i - 5, j + 5].Tag = "highlighted";
			//				}
			//				if (i - 6 >= 0 && i - 6 <= 7 && j + 6 >= 0 && j + 6 <= 7)
			//				{
			//					fchessboard[i - 6, j + 6].BorderThickness = new Thickness(2);
			//					fchessboard[i - 6, j + 6].BorderBrush = highlighted;
			//					chessboard[i - 6, j + 6].Tag = "highlighted";
			//				}
			//				if (i - 7 >= 0 && i - 7 <= 7 && j + 7 >= 0 && j + 7 <= 7)
			//				{
			//					fchessboard[i - 7, j + 7].BorderThickness = new Thickness(2);
			//					fchessboard[i - 7, j + 7].BorderBrush = highlighted;
			//					chessboard[i - 7, j + 7].Tag = "highlighted";
			//				}

			//				if (i - 1 >= 0 && i - 1 <= 7 && j >= 0 && j <= 7)
			//				{
			//					fchessboard[i - 1, j].BorderThickness = new Thickness(2);
			//					fchessboard[i - 1, j].BorderBrush = highlighted;
			//					chessboard[i - 1, j].Tag = "highlighted";
			//				}


			//				if (i + 1 >= 0 && i + 1 <= 7 && j >= 0 && j <= 7)
			//				{
			//					fchessboard[i + 1, j].BorderThickness = new Thickness(2);
			//					fchessboard[i + 1, j].BorderBrush = highlighted;
			//					chessboard[i + 1, j].Tag = "highlighted";
			//				}



			//				if (j - 1 >= 0 && j - 1 <= 7)
			//				{
			//					fchessboard[i, j - 1].BorderThickness = new Thickness(2);
			//					fchessboard[i, j - 1].BorderBrush = highlighted;
			//					chessboard[i, j - 1].Tag = "highlighted";
			//				}


			//				if (j + 1 >= 0 && j + 1 <= 7)
			//				{
			//					fchessboard[i, j + 1].BorderThickness = new Thickness(2);
			//					fchessboard[i, j + 1].BorderBrush = highlighted;
			//					chessboard[i, j + 1].Tag = "highlighted";
			//				}


			//				if (i - 2 >= 0 && i - 2 <= 7 && j >= 0 && j <= 7)
			//				{
			//					fchessboard[i - 2, j].BorderThickness = new Thickness(2);
			//					fchessboard[i - 2, j].BorderBrush = highlighted;
			//					chessboard[i - 2, j].Tag = "highlighted";
			//				}


			//				if (i + 2 >= 0 && i + 2 <= 7 && j >= 0 && j <= 7)
			//				{
			//					fchessboard[i + 2, j].BorderThickness = new Thickness(2);
			//					fchessboard[i + 2, j].BorderBrush = highlighted;
			//					chessboard[i + 2, j].Tag = "highlighted";
			//				}



			//				if (j - 2 >= 0 && j - 2 <= 7)
			//				{
			//					fchessboard[i, j - 2].BorderThickness = new Thickness(2);
			//					fchessboard[i, j - 2].BorderBrush = highlighted;
			//					chessboard[i, j - 2].Tag = "highlighted";
			//				}


			//				if (j + 2 >= 0 && j + 2 <= 7)
			//				{
			//					fchessboard[i, j + 2].BorderThickness = new Thickness(2);
			//					fchessboard[i, j + 2].BorderBrush = highlighted;
			//					chessboard[i, j + 2].Tag = "highlighted";
			//				}


			//				if (i - 3 >= 0 && i - 3 <= 7 && j >= 0 && j <= 7)
			//				{
			//					fchessboard[i - 3, j].BorderThickness = new Thickness(2);
			//					fchessboard[i - 3, j].BorderBrush = highlighted;
			//					chessboard[i - 3, j].Tag = "highlighted";
			//				}


			//				if (i + 3 >= 0 && i + 3 <= 7 && j >= 0 && j <= 7)
			//				{
			//					fchessboard[i + 3, j].BorderThickness = new Thickness(2);
			//					fchessboard[i + 3, j].BorderBrush = highlighted;
			//					chessboard[i + 3, j].Tag = "highlighted";
			//				}



			//				if (j - 3 >= 0 && j - 3 <= 7)
			//				{
			//					fchessboard[i, j - 3].BorderThickness = new Thickness(2);
			//					fchessboard[i, j - 3].BorderBrush = highlighted;
			//					chessboard[i, j - 3].Tag = "highlighted";
			//				}


			//				if (j + 3 >= 0 && j + 3 <= 7)
			//				{
			//					fchessboard[i, j + 3].BorderThickness = new Thickness(2);
			//					fchessboard[i, j + 3].BorderBrush = highlighted;
			//					chessboard[i, j + 3].Tag = "highlighted";
			//				}


			//				if (i - 4 >= 0 && i - 4 <= 7 && j >= 0 && j <= 7)
			//				{
			//					fchessboard[i - 4, j].BorderThickness = new Thickness(2);
			//					fchessboard[i - 4, j].BorderBrush = highlighted;
			//					chessboard[i - 4, j].Tag = "highlighted";
			//				}


			//				if (i + 4 >= 0 && i + 4 <= 7 && j >= 0 && j <= 7)
			//				{
			//					fchessboard[i + 4, j].BorderThickness = new Thickness(2);
			//					fchessboard[i + 4, j].BorderBrush = highlighted;
			//					chessboard[i + 4, j].Tag = "highlighted";
			//				}



			//				if (j - 4 >= 0 && j - 4 <= 7)
			//				{
			//					fchessboard[i, j - 4].BorderThickness = new Thickness(2);
			//					fchessboard[i, j - 4].BorderBrush = highlighted;
			//					chessboard[i, j - 4].Tag = "highlighted";
			//				}


			//				if (j + 4 >= 0 && j + 4 <= 7)
			//				{
			//					fchessboard[i, j + 4].BorderThickness = new Thickness(2);
			//					fchessboard[i, j + 4].BorderBrush = highlighted;
			//					chessboard[i, j + 4].Tag = "highlighted";
			//				}


			//				if (i - 5 >= 0 && i - 5 <= 7 && j >= 0 && j <= 7)
			//				{
			//					fchessboard[i - 5, j].BorderThickness = new Thickness(2);
			//					fchessboard[i - 5, j].BorderBrush = highlighted;
			//					chessboard[i - 5, j].Tag = "highlighted";
			//				}


			//				if (i + 5 >= 0 && i + 5 <= 7 && j >= 0 && j <= 7)
			//				{
			//					fchessboard[i + 5, j].BorderThickness = new Thickness(2);
			//					fchessboard[i + 5, j].BorderBrush = highlighted;
			//					chessboard[i + 5, j].Tag = "highlighted";
			//				}



			//				if (j - 5 >= 0 && j - 5 <= 7)
			//				{
			//					fchessboard[i, j - 5].BorderThickness = new Thickness(2);
			//					fchessboard[i, j - 5].BorderBrush = highlighted;
			//					chessboard[i, j - 5].Tag = "highlighted";
			//				}


			//				if (j + 5 >= 0 && j + 5 <= 7)
			//				{
			//					fchessboard[i, j + 5].BorderThickness = new Thickness(2);
			//					fchessboard[i, j + 5].BorderBrush = highlighted;
			//					chessboard[i, j + 5].Tag = "highlighted";
			//				}


			//				if (i - 6 >= 0 && i - 6 <= 7 && j >= 0 && j <= 7)
			//				{
			//					fchessboard[i - 6, j].BorderThickness = new Thickness(2);
			//					fchessboard[i - 6, j].BorderBrush = highlighted;
			//					chessboard[i - 6, j].Tag = "highlighted";
			//				}


			//				if (i + 6 >= 0 && i + 6 <= 7 && j >= 0 && j <= 7)
			//				{
			//					fchessboard[i + 6, j].BorderThickness = new Thickness(2);
			//					fchessboard[i + 6, j].BorderBrush = highlighted;
			//					chessboard[i + 6, j].Tag = "highlighted";
			//				}



			//				if (j - 6 >= 0 && j - 6 <= 7)
			//				{
			//					fchessboard[i, j - 6].BorderThickness = new Thickness(2);
			//					fchessboard[i, j - 6].BorderBrush = highlighted;
			//					chessboard[i, j - 6].Tag = "highlighted";
			//				}


			//				if (j + 6 >= 0 && j + 6 <= 7)
			//				{
			//					fchessboard[i, j + 6].BorderThickness = new Thickness(2);
			//					fchessboard[i, j + 6].BorderBrush = highlighted;
			//					chessboard[i, j + 6].Tag = "highlighted";
			//				}


			//				if (i - 7 >= 0 && i - 7 <= 7 && j >= 0 && j <= 7)
			//				{
			//					fchessboard[i - 7, j].BorderThickness = new Thickness(2);
			//					fchessboard[i - 7, j].BorderBrush = highlighted;
			//					chessboard[i - 7, j].Tag = "highlighted";
			//				}


			//				if (i + 7 >= 0 && i + 7 <= 7 && j >= 0 && j <= 7)
			//				{
			//					fchessboard[i + 7, j].BorderThickness = new Thickness(2);
			//					fchessboard[i + 7, j].BorderBrush = highlighted;
			//					chessboard[i + 7, j].Tag = "highlighted";
			//				}



			//				if (j - 7 >= 0 && j - 7 <= 7)
			//				{
			//					fchessboard[i, j - 7].BorderThickness = new Thickness(2);
			//					fchessboard[i, j - 7].BorderBrush = highlighted;
			//					chessboard[i, j - 7].Tag = "highlighted";
			//				}


			//				if (j + 7 >= 0 && j + 7 <= 7)
			//				{
			//					fchessboard[i, j + 7].BorderThickness = new Thickness(2);
			//					fchessboard[i, j + 7].BorderBrush = highlighted;
			//					chessboard[i, j + 7].Tag = "highlighted";
			//				}
			//			}

			//			if (chessboard[i, j].Content.ToString() == "bKrol" || chessboard[i, j].Content.ToString() == "cKrol")
			//			{
			//				if (i - 1 >= 0 && i - 1 <= 7 && j >= 0 && j <= 7)
			//				{
			//					fchessboard[i - 1, j].BorderThickness = new Thickness(2);
			//					fchessboard[i - 1, j].BorderBrush = highlighted;
			//					chessboard[i - 1, j].Tag = "highlighted";
			//				}


			//				if (i + 1 >= 0 && i + 1 <= 7 && j >= 0 && j <= 7)
			//				{
			//					fchessboard[i + 1, j].BorderThickness = new Thickness(2);
			//					fchessboard[i + 1, j].BorderBrush = highlighted;
			//					chessboard[i + 1, j].Tag = "highlighted";
			//				}



			//				if (j - 1 >= 0 && j - 1 <= 7)
			//				{
			//					fchessboard[i, j - 1].BorderThickness = new Thickness(2);
			//					fchessboard[i, j - 1].BorderBrush = highlighted;
			//					chessboard[i, j - 1].Tag = "highlighted";
			//				}


			//				if (j + 1 >= 0 && j + 1 <= 7)
			//				{
			//					fchessboard[i, j + 1].BorderThickness = new Thickness(2);
			//					fchessboard[i, j + 1].BorderBrush = highlighted;
			//					chessboard[i, j + 1].Tag = "highlighted";
			//				}




			//				if (i - 1 >= 0 && i - 1 <= 7 && j - 1 >= 0 && j - 1 <= 7)
			//				{
			//					fchessboard[i - 1, j - 1].BorderThickness = new Thickness(2);
			//					fchessboard[i - 1, j - 1].BorderBrush = highlighted;
			//					chessboard[i - 1, j - 1].Tag = "highlighted";
			//				}





			//				if (i + 1 >= 0 && i + 1 <= 7 && j + 1 >= 0 && j + 1 <= 7)
			//				{
			//					fchessboard[i + 1, j + 1].BorderThickness = new Thickness(2);
			//					fchessboard[i + 1, j + 1].BorderBrush = highlighted;
			//					chessboard[i + 1, j + 1].Tag = "highlighted";
			//				}





			//				if (i + 1 >= 0 && i + 1 <= 7 && j - 1 >= 0 && j - 1 <= 7)
			//				{
			//					fchessboard[i + 1, j - 1].BorderThickness = new Thickness(2);
			//					fchessboard[i + 1, j - 1].BorderBrush = highlighted;
			//					chessboard[i + 1, j - 1].Tag = "highlighted";
			//				}





			//				if (i - 1 >= 0 && i - 1 <= 7 && j + 1 >= 0 && j + 1 <= 7)
			//				{
			//					fchessboard[i - 1, j + 1].BorderThickness = new Thickness(2);
			//					fchessboard[i - 1, j + 1].BorderBrush = highlighted;
			//					chessboard[i - 1, j + 1].Tag = "highlighted";
			//				}



			//			}

			//			// Czarne

			//			if (chessboard[i, j].Content.ToString() == "cPion")
			//			{
			//				if (i - 1 >= 0 && i - 1 <= 7 && j >= 0 && j <= 7)
			//				{
			//					fchessboard[i - 1, j].BorderThickness = new Thickness(2);
			//					fchessboard[i - 1, j].BorderBrush = highlighted;
			//					chessboard[i - 1, j].Tag = "highlighted";
			//				}



			//				if (i - 2 >= 0 && i - 2 <= 7 && j >= 0 && j <= 7)
			//				{
			//					fchessboard[i - 2, j].BorderThickness = new Thickness(2);
			//					fchessboard[i - 2, j].BorderBrush = highlighted;
			//					chessboard[i - 2, j].Tag = "highlighted";
			//				}

			//			}
			//			//if (chessboard[i, j].Content.ToString() == "cWieza")
			//			//{
			//			//	chessboard[i + 1, j].Background = highlighted;
			//			//	chessboard[i + 2, j].Background = highlighted;
			//			//}
			//			//if (chessboard[i, j].Content.ToString() == "cKon")
			//			//{
			//			//	chessboard[i + 1, j].Background = highlighted;
			//			//	chessboard[i + 2, j].Background = highlighted;
			//			//}
			//			//if (chessboard[i, j].Content.ToString() == "cLaufer")
			//			//{
			//			//	chessboard[i + 1, j].Background = highlighted;
			//			//	chessboard[i + 2, j].Background = highlighted;
			//			//}
			//			//if (chessboard[i, j].Content.ToString() == "cKrolowa")
			//			//{
			//			//	chessboard[i + 1, j].Background = highlighted;
			//			//	chessboard[i + 2, j].Background = highlighted;
			//			//}
			//			//if (chessboard[i, j].Content.ToString() == "cKrol")
			//			//{
			//			//	chessboard[i + 1, j].Background = highlighted;
			//			//	chessboard[i + 2, j].Background = highlighted;
			//			//}
			//		}
		}

		private void startButton_Click(object sender, RoutedEventArgs e)
		{
			startButton.Visibility = Visibility.Hidden;
			startBackground.Visibility = Visibility.Hidden;
		}

		private void endButtton_Click(object sender, RoutedEventArgs e)
		{
			endBackground.Visibility = Visibility.Visible;
			endLabel.Visibility = Visibility.Visible;
		}
	}
}
