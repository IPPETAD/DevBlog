namespace DevBlog.Migrations
{
	using System;
	using System.Data.Entity;
	using System.Data.Entity.Migrations;
	using System.Linq;
	using DevBlog.Models;
	using Microsoft.AspNet.Identity;
	using Microsoft.AspNet.Identity.EntityFramework;

	internal sealed class Configuration : DbMigrationsConfiguration<ApplicationDbContext>
	{
		public Configuration()
		{
			AutomaticMigrationsEnabled = false;
		}

		protected override void Seed(ApplicationDbContext context)
		{
			//  This method will be called after migrating to the latest version.

			//  You can use the DbSet<T>.AddOrUpdate() helper extension method 
			//  to avoid creating duplicate seed data. E.g.
			//
			//    context.People.AddOrUpdate(
			//      p => p.FullName,
			//      new Person { FullName = "Andrew Peters" },
			//      new Person { FullName = "Brice Lambson" },
			//      new Person { FullName = "Rowan Miller" }
			//    );
			//

			CreateRoles(context);
		}

		private void CreateRoles(ApplicationDbContext context)
		{
			var store = new RoleStore<IdentityRole>(context);
			var manager = new RoleManager<IdentityRole>(store);

			// Only create the roles if they don't already exist
			if (!context.Roles.Any(x => x.Name == BlogRole.ADMIN))
			{
				manager.Create(new IdentityRole() { Name = BlogRole.ADMIN });
			}
			if (!context.Roles.Any(x => x.Name == BlogRole.AUTHOR))
			{
				manager.Create(new IdentityRole() { Name = BlogRole.AUTHOR });
			}
		}
	}
}
