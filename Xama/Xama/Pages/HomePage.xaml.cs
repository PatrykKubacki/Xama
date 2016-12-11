using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using System;
using System.Net.Http;
using Newtonsoft.Json;
using Xama.Models;

namespace Xama.Pages {
	public partial class HomePage : ContentPage {

		private IList<User> _users = new List<User>();

		public HomePage() {
			InitializeComponent();

		}

		private async Task GetSomethingFromApi() {
			using (var client = new HttpClient()) {
				//client.BaseAddress = new Uri();
				var response = await client.GetStringAsync("http://serwertodo.azurewebsites.net/api/Values");
				_users  = JsonConvert.DeserializeObject<IEnumerable<User>>(response).ToList();
			}
		}

		private async void Login(object sender, EventArgs e) {
			await GetSomethingFromApi();

			LoginEnty.Text = _users.First().Login;

			await Navigation.PushAsync(new TasksPage());
		}




	}
}
