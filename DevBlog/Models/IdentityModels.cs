using System;
using Microsoft.AspNet.Identity.EntityFramework;

namespace DevBlog.Models
{
	// You can add profile data for the user by adding more properties to your ApplicationUser class, please visit http://go.microsoft.com/fwlink/?LinkID=317594 to learn more.
	public class ApplicationUser : IdentityUser
	{
		public string RealName { get; set; }

		public string Email { get; set; }

		public DateTime DateCreated { get; set; }

		public DateTime LastLoggedIn { get; set; }

		public string PhotoUrl { get; set; }

		public string Descrition { get; set; }
	}
}