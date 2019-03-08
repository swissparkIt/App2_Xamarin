using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App2_Xamarin.Master
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Menu : MasterDetailPage
	{
		public Menu ()
		{
			InitializeComponent ();
		}

        private void GoPagPerfil1(object sender, EventArgs args)
        {
            //MainPage = new App2_Xamarin.Pages.Perfil1();
        }

        private void GoPagXamarin(object sender, EventArgs args)
        {

        }

    }
}