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

namespace openTill.GUI
{
	/// <summary>
	/// Interaction logic for NoScan.xaml
	/// </summary>
	public partial class NoScan : Window
	{
		public NoScan()
		{
			InitializeComponent();
		}

		private void btnZero_Click(object sender, RoutedEventArgs e)
		{
			txtEntry.Text = txtEntry.Text + "0";
		}

		private void btnOne_Click(object sender, RoutedEventArgs e)
		{
			txtEntry.Text = txtEntry.Text + "1";
		}

		private void btnTwo_Click(object sender, RoutedEventArgs e)
		{
			txtEntry.Text = txtEntry.Text + "2";
		}

		private void btnThree_Click(object sender, RoutedEventArgs e)
		{
			txtEntry.Text = txtEntry.Text + "3";
		}

		private void btnFour_Click(object sender, RoutedEventArgs e)
		{
			txtEntry.Text = txtEntry.Text + "4";
		}

		private void btnFive_Click(object sender, RoutedEventArgs e)
		{
			txtEntry.Text = txtEntry.Text + "5";
		}

		private void btnSix_Click(object sender, RoutedEventArgs e)
		{
			txtEntry.Text = txtEntry.Text + "6";
		}

		private void btnSeven_Click(object sender, RoutedEventArgs e)
		{
			txtEntry.Text = txtEntry.Text + "7";
		}

		private void btnEight_Click(object sender, RoutedEventArgs e)
		{
			txtEntry.Text = txtEntry.Text + "8";
		}

		private void btnNine_Click(object sender, RoutedEventArgs e)
		{
			txtEntry.Text = txtEntry.Text + "9";
		}

		private void btnCancel_Click(object sender, RoutedEventArgs e)
		{
			txtEntry.Clear();
		}
	}
}
