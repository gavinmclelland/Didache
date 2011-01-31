﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace Didache {


	public class InteractionThread {
		[Key]
		public int ThreadID { get; set; }
		public int TaskID { get; set; }

		[Required]
		public string Subject { get; set; }

		public int UserID  { get; set; }
		public string UserName { get; set; }
		public DateTime ThreadDate { get; set; }

		public int TotalViews { get; set; }
		public int TotalReplies { get; set; }

		public virtual ICollection<Post> Posts { get; set; }
	}



}
