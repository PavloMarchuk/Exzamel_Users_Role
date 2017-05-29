using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exzamel_Users_Role.BOL
	{
	public class User
		{
		public User()
			{
			Roles = new List<Role>();
			}

		[Key]
		public int UserId { get; set; }
		public string Email { get; set; }
		public string UserName { get; set; }
		public DateTime DateBirthday { get; set; }
		public int? JobTitleId { get; set; }

		
		public virtual List<Role> Roles { get; set; }
		}

	}
