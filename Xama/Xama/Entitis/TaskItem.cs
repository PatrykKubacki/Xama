using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Xama.Entitis {

	public class TaskItem {

		public int Id { get; set; }

		public string Title { get; set; }
		//TODO Zmien typ na enuma
		//public Priority Priority { get; set; }
		public string Priority { get; set; }
		public DateTime DeadLine { get; set; }
		public string Category { get; set; }
		public string Comment { get; set; }
		public bool Done { get; set; }
		public int UserId { get; set; }

		public override string ToString() {
			return $"{Title}-{Done}";
		}
	}

	//TODO Zmien typ na enuma
	/*
		[Flags]
		enum Priority {
			Undefine = 0,
			Low = 1,
			Medium = 2,
			High= 4,	
		}
	*/
}
