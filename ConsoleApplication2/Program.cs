using Exzamel_Users_Role.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
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
			foreach(var item in context.Roles) { }
						
			SqlParameter parameter = new SqlParameter("@role", "manager");
			var usersONtitels = context.Database.SqlQuery<ResulFunc>("select* from UsersByRoleFunc3(@role)", parameter);

			Console.WriteLine("===== \tMенеджери:");
			foreach(var i in usersONtitels)
				Console.WriteLine($"{i.UserName}\t {i.DateBirthday} Посада:{i.JobTitleId} ");


			Console.WriteLine("===================================");
			Console.WriteLine("===== \t programmer:");
			parameter = new SqlParameter("@role", "programmer");
			usersONtitels = context.Database.SqlQuery<ResulFunc>("select* from UsersByRoleFunc3(@role)", parameter);
			foreach(var i in usersONtitels)
				Console.WriteLine($"{i.UserName}\t {i.DateBirthday} Посада:{i.JobTitleId} ");



			Console.WriteLine("===================================");
			Console.WriteLine("Имя пользователя, еmail и дату рождения, дата рождения которых находится в интервале между 01.03.1989 и 21.07.1993");
			//⦁	Имя пользователя, еmail и дату рождения, дата рождения которых находится в интервале между 01.03.1989 и 21.07.1993
			var liq1 = context.Users.Where(u => u.DateBirthday > new DateTime(1989, 03, 01) && u.DateBirthday < new DateTime(1993, 07, 21));
			foreach(var U in liq1)
				{
				Console.WriteLine($"{U.UserName}\t {U.Email}\t {U.DateBirthday}");
				}

			Console.WriteLine("===================================?");
			Console.WriteLine("	Имя пользователя, еmail, имя роли пользователя vasja и luba .");
			
			var q2 = context.Users_In_Roles.Where(i => i.UserObj.UserName == "vasja" ||
			  i.UserObj.UserName == "luba").Select(u => new
				  {
				  u.UserObj.UserName,
				  u.RoleObj.RoleName,
				  u.UserObj.Email
				  }).ToList();			
						
			foreach(var j in q2)
				{
				Console.WriteLine($"{j.UserName}\t {j.Email} \t{j.RoleName}");
				}


			//Имена ВСЕХ пользователей, еmail и количество ролей.
			Console.WriteLine($"Имена ВСЕХ пользователей, еmail и количество ролей.");
			var countUR = context.Users_In_Roles.GroupBy(uir => uir.UserObj);
			foreach(var j in countUR)
				{
				Console.WriteLine($"{j.First().UserObj.UserName} \t {j.First().UserObj.Email} \t{j.Count()} ");
				}
				

			Console.WriteLine("===================================?");
			Console.WriteLine("	Имя роли, количество пользователей в каждой из них");
			var linq3 = context.Roles.Join
				(
				context.Users_In_Roles,
				r => r.RoleId,
				UiR => UiR.RoleId,
				(r, UiR) => new
					{
					RoleName = r.RoleName,
					count = UiR.UserObj.UserName					}
				);

			var linq3_1 = linq3.GroupBy(d => d.RoleName);
			foreach(var g in linq3_1) Console.WriteLine(g.First().RoleName + " \t" + g.Count());


			//Список пользователей, которым не назначена роль
			Console.WriteLine("===================================?");
			Console.WriteLine("	Список пользователей, которым не назначена роль");
			var linq4 = context.Users.Where(u => u.Roles == null).Select(y => y.UserName);
			//int a = linq4.Count();

			


			//Список пользователей, у которых более 2 ролей
			//Список ролей, которые не назначены ни одному пользователю.



			}
		}
	}
