using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xama.ViewModel;
using Xamarin.Forms;

namespace Xama.Pages {
	public partial class AddTaskPage : ContentPage {
		public AddTaskPage() {
			InitializeComponent();

			BindingContext = new AddTaskViewModel();
		}

		private async void CancelCommand(object sender, EventArgs e) {
			await Navigation.PopAsync();
		}
	}
}
