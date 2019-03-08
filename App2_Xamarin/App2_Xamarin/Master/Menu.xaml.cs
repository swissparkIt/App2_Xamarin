using System;
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
            Navigation.PushAsync(new Pages.Perfil1());
        }

        private void GoPagXamarin(object sender, EventArgs args)
        {
            Navigation.PushAsync(new Pages.Xamarin());
        }

    }
}