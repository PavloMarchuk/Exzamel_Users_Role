using Exzamel_Users_Role.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exzamel_Users_Role
	{
	public partial class Form1: Form
		{
		DbUserInRoleContext context;
		
		BindingSource bsUsers = new BindingSource();
		BindingSource bsRoles = new BindingSource();

		public Form1()
			{
			InitializeComponent();
			}

		private void Form1_Load(object sender, EventArgs e)
			{
			context = new DbUserInRoleContext();

			int kk = 0;
			var list = context.Users;
			foreach(var item in context.Users)
				kk++;
			foreach(var item in context.Roles)
				kk++;

			
			bsUsers.DataSource = context.Users.Local;
			DGV1.DataSource = bsUsers;

			bsRoles.DataSource = context.Roles.Local;
			clbRoles.DataSource = bsRoles;
			clbRoles.DisplayMember = "RoleName" ;



			}

	
		}
	}
