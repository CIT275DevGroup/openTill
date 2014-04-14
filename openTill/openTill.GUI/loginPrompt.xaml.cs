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
	/// Interaction logic for loginPrompt.xaml
	/// </summary>
	public partial class loginPrompt : Window
	{
        /// <summary>
        /// Login Prompt Form
        /// </summary>
		public loginPrompt()
		{
			InitializeComponent();
		}

		private void btnCancel_Click(object sender, RoutedEventArgs e)
		{
			this.Close();
		}

		private void btnSubmit_Click(object sender, RoutedEventArgs e)
		{
			String pass = txtPass.Password;
		}
	}
}
