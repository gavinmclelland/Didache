﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Didache {
	public class UserRoles {

		public static string Administrator {
			get {
				return "oe-administrator";
			}
		}


		public static string Builder {
			get {
				return "oe-builder";
			}
		}


		public static string Facilitator {
			get {
				return "oe-facilitator";
			}
		}

		public static string Faculty {
			get {
				return "oe-faculty";
			}
		}

		public static string[] SiteRoles {
			get {
				return new string[] { Administrator, Builder, Facilitator, Faculty };
			}
		}

	}
}
