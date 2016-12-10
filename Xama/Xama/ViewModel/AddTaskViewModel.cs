using System.ComponentModel;
using System.Runtime.CompilerServices;
using Xama.Entitis;
using Xamarin.Forms;

namespace Xama.ViewModel {

	public class AddTaskViewModel : INotifyPropertyChanged {
		public event PropertyChangedEventHandler PropertyChanged;

		private TaskItem _item;

		public TaskItem Item {
			get { return _item; }
			set {
				_item = value;
				OnPropertyChanged();
			}
		}

		public AddTaskViewModel() {
			Item = new TaskItem();
		}

		private string _message;
		public string Message {
			get { return _message; }
			set {
				_message = value;
				OnPropertyChanged();
			}
		}

		public Command SaveCommand {
			get { return new Command(() => { Message = $"{Item.Title} - {Item.DeadLine} - {Item.Done} - "; }); }
		}

		protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null) {
			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
		}
	}

}
