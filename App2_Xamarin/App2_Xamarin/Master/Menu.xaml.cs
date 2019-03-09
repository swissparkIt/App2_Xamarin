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
            //Navigation.PushAsync(new Pages.Perfil1());
            //Detail = new Pages.Perfil1();
            Detail = new NavigationPage(new Pages.Perfil1());
            IsPresented = false;
        }

        private void GoPagXamarin(object sender, EventArgs args)
        {
            //Navigation.PushAsync(new Pages.Xamarin());
            //Detail = new Pages.Xamarin();
            Detail = new NavigationPage(Detail = new Pages.Xamarin());
            IsPresented = false;
        }

    }
}