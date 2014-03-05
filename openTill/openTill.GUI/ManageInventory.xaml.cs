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
	/// Interaction logic for ManageInventory.xaml
	/// </summary>
	public partial class ManageInventory : Window
	{
		public ManageInventory()
		{
            InitializeComponent();
		}

        private void btnEditInv_Click(object sender, RoutedEventArgs e)
        {
            //EditInventory ei = new EditInventory();

            //ei.ShowDialog();
			lblContextName.Content = "EDIT ITEM";
        }

		private void btnAddInv_Click(object sender, RoutedEventArgs e)
		{
			lblContextName.Content = "ADD ITEM";
		}

		private void btnRemoveInv_Click(object sender, RoutedEventArgs e)
		{
			lblContextName.Content = "REMOVE ITEM";
		}

		private void btnFindItem_Click(object sender, RoutedEventArgs e)
		{
			lblContextName.Content = "FIND ITEM";
		}
	}
}
