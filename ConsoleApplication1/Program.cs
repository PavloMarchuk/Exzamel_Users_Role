using Exzamel_Users_Role.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConsoleApplication1
	{
	class ResulFunc
		{
		public string UserName { get; set; }
		public DateTime DateBirthday { get; set; }
		public int? JobTitleId { get; set; }
		}


	class Program
		{
		static void Main(string[] args)
			{

			DbUserInRoleContext context = new DbUserInRoleContext();


			var U = context.Users.Local;
			foreach(var item in U)
				{
				Console.WriteLine(U.Count);
				}
			//SqlParameter parameter = new SqlParameter("@role", "manager");

				
				
			//	var usersONtitels = context.Database.SqlQuery<ResulFunc>("select* from UsersByRoleFunc3('@role')", parameter);

			//	Console.WriteLine("Mенеджери:");
			//	foreach(var i in usersONtitels)
			//		{
					
			//		Console.WriteLine($"{i.UserName} \t{i.DateBirthday}\t Посада={i.JobTitleId}");
			//		}

				
			}
		}
	}
