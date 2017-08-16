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

namespace WpfApplication1
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		public MainWindow()
		{
			InitializeComponent();

			ButtonItem.CreateList();
		}

		private void button_Click(object sender, RoutedEventArgs e)
		{
			ButtonItem.ChangeButton(button1);
		}
	}

	static class ButtonItem
	{
		static List<string> thingsToSay = new List<string>();
		static int i = 0;
		static int X = 50;
		static int Y = 50;

		public static void CreateList()
		{
			thingsToSay.Add("Ahem - do not click!");
			thingsToSay.Add("Your boss is calling...");
			thingsToSay.Add("The Feds are on their way...");
			thingsToSay.Add("And yet you keep clicking the illegal button...");
			thingsToSay.Add("Alright... I give up.");
			thingsToSay.Add("You win.");
			thingsToSay.Add("Bye.");
		}

		static string GetSaying()
		{
			return thingsToSay[i++];
		}

		static int x(int x)
		{
			X = Convert.ToInt32(x * 1.2);
			return X;
		}
		static int y(int y)
		{
			Y = Convert.ToInt32(y * 1.2);
			return Y;
		}

		public static void ChangeButton(Button toChange)
		{
			if (i >= thingsToSay.Count)
			{
				toChange.Visibility = Visibility.Hidden;
			}
			else
			{
				toChange.Content = thingsToSay[i++];
				toChange.Margin = new Thickness(x(X), y(Y), 0, 0);
			}

		}

	}

}
