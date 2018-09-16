using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CFSessionDB.ViewModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CFSessionDB.View
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class SessionListPage : ContentPage
	{
		public SessionListPage ()
		{
			InitializeComponent ();
            BindingContext = new SessionListViewModel(Navigation);
		}
	}
}