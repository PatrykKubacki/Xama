using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Xama.Models;
using Xamarin.Forms;

namespace Xama.Pages {

	public partial class TasksReview : ContentPage {
		private IList<TaskItem> _taskItems = new List<TaskItem>();

		public TasksReview() {
			InitializeComponent();
			//await GetSomethingFromApi();
		}

		protected override async void OnAppearing() {
			base.OnAppearing();
			await GetSomethingFromApi();
			TasksListView.ItemsSource = _taskItems;
		}

		private async Task GetSomethingFromApi() {
			using (var client = new HttpClient()) {
				var response = await client.GetStringAsync("http://serwertodo.azurewebsites.net/api/Value2");
				_taskItems = JsonConvert.DeserializeObject<IEnumerable<TaskItem>>(response).ToList();
			}
		}

		private async void Add(object sender, EventArgs e) {
			await Navigation.PushAsync(new AddTaskPage());
		}

		private void Delete(object sender, EventArgs e) {
		}
	}

}
