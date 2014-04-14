using openTill.Persistence;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace openTill.GUI
{
	/// <summary>
	/// Interaction logic for App.xaml
	/// </summary>
	public partial class App : Application
	{
        /// <summary>
        /// On Startup
        /// </summary>
        /// <param name="e">e</param>
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);
            AutomapperBootstrapper.Initialize();
        }
	}
}
