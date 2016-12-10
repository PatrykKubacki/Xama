using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace Xama.Pages {
	public partial class TasksReview : ContentPage {
		public TasksReview() {
			InitializeComponent();
		}

		private async void Add(object sender, EventArgs e) {
			await Navigation.PushAsync(new AddTaskPage());
		}
	}
}
