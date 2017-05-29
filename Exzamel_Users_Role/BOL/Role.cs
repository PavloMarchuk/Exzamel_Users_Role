using Exzamel_Users_Role.BOL;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exzamel_Users_Role
	{
	public class Role
		{
		public Role()
			{
			Users = new List<User>();
			}

		[Key]
		public int RoleId { get; set; }
		public string RoleName { get; set; }
		public string Description { get; set; }

		public virtual List<User> Users { get; set; }	
		}
	}
