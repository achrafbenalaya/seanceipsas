using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace seanceipsas
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Page1 : ContentPage
	{
		public Page1 ()
		{
			InitializeComponent ();
		}

	    private async void Button_OnClicked(object sender, EventArgs e)
	    {
	        await DisplayAlert("Hello", "Welcome IPSAS STUDENT", "OK");
	    }
	}
}