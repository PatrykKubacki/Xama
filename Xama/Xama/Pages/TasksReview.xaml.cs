using System;
using System.Collections.Generic;
using Xama.Entitis;
using Xamarin.Forms;

namespace Xama.Pages {

	public partial class TasksReview : ContentPage {
		public List<TaskItem> Tasks { get; set; }

		public TasksReview() {
			InitializeComponent();
			Tasks = new List<TaskItem> {
				new TaskItem { Title = "Wynieś smieci",
							   Done = false,
							   DeadLine = DateTime.Now,
							   Category = "Dzisiejsze",
							   Id = 1,
							   UserId = 1,
							   Comment = "Goła baba",
							   Priority = "Wysoki"
				},
					new TaskItem { Title = "Zrób zakupy",
							   Done = false,
							   DeadLine = DateTime.Now,
							   Category = "Dzisiejsze",
							   Id = 1,
							   UserId = 1,
							   Comment = "Jajka i chleb",
							   Priority = "Wysoki"
				}
			};
			TasksListView.ItemsSource = Tasks;
		}

		private async void Add(object sender, EventArgs e) {
			await Navigation.PushAsync(new AddTaskPage());
		}

		private void Delete(object sender, EventArgs e) {
		}
	}

}
