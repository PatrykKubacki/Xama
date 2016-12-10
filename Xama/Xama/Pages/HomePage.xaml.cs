using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xama.Entitis;
using Xamarin.Forms;

namespace Xama.Pages {
	public partial class HomePage : ContentPage {

		public List<User> Users { get; set; }

		public HomePage() {
			InitializeComponent();
			Users = new List<User> {
				new User(1,"admin","admin"),
			};
		}

	    private async void Login(object sender, EventArgs e) {
		    await Navigation.PushAsync(new TasksPage());
	    }

		
	}
}
