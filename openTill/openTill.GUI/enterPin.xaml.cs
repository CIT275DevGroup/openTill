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
	/// Interaction logic for enterPin.xaml
	/// </summary>
	public partial class enterPin : Window
	{
        /// <summary>
        /// Enter Pin Forms
        /// </summary>
		public enterPin()
		{
			InitializeComponent();
		}

		private void btnCancel_Click(object sender, RoutedEventArgs e)
		{
			this.Close();
		}

		private void btnSubmit_Click(object sender, RoutedEventArgs e)
		{
			string pass = txtPIN.Password;
		}
	}
}
