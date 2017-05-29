using Exzamel_Users_Role.BOL;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exzamel_Users_Role.Model
	{
	public class DbUserInRoleContext: DbContext
		{
		public DbUserInRoleContext() : base("name=TMPmyExam")
			{
			Database.SetInitializer<DbUserInRoleContext>(new DbInitialize());			
			}

		public DbSet<User> Users { get; set; }
		public DbSet<Role> Roles { get; set; }
		public DbSet<UserInRole> Users_In_Roles { get; set; }
		}



	public class DbInitialize: CreateDatabaseIfNotExists<DbUserInRoleContext>
		{
		protected override void Seed(DbUserInRoleContext context)
			{			
			foreach(var item in DataManager.users)
				{
				context.Users.Add(item);
				}
			foreach(var item in DataManager.roles)
				{
				context.Roles.Add(item);
				}
			foreach(var item in DataManager.userinroles)
				{
				context.Users_In_Roles.Add(item);
				}


			base.Seed(context);
			}
		}
	}
