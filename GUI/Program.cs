using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
	internal static class Program
	{
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
<<<<<<< HEAD
			//Application.Run(new LOGIN_GUI());
			Application.Run(new TEST_GUI());

=======
			Application.Run(new LOGIN_GUI());
			//Application.Run(new RDLC_GUI());
>>>>>>> 6ee70094013bec07e18934daf55f504953dcf267
		}
	}
}
