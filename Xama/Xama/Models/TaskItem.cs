﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Xama.Models {
	public class TaskItem {

		public int Id { get; set; }

		public string Title { get; set; }
		public string Priority { get; set; }
		public DateTime DeadLine { get; set; }
		public string Category { get; set; }
		public string Comment { get; set; }
		public bool Done { get; set; }
		public int UserId { get; set; }

	

	}

}

