﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exzamel_Users_Role.BOL
	{
	public class UserInRole
		{
			


		[Key]
		public int UserInRoleId { get; set; }
		public int UserId { get; set; }
		public int RoleId { get; set; }
		public DateTime HireDate { get; set; }

		public virtual User User { get; set; }
		public virtual Role Role { get; set; }

		}
	}
