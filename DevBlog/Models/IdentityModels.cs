using System;
using Microsoft.AspNet.Identity.EntityFramework;
using System.ComponentModel.DataAnnotations;

namespace DevBlog.Models
{
	// You can add profile data for the user by adding more properties to your ApplicationUser class, please visit http://go.microsoft.com/fwlink/?LinkID=317594 to learn more.
	public class ApplicationUser : IdentityUser
	{
        [Display(Name="Real Name")]
		public string RealName { get; set; }

		public string Email { get; set; }

        [Display(Name="Date Created")]
		public DateTime DateCreated { get; set; }

        [Display(Name="Last Logged In")]
		public DateTime LastLoggedIn { get; set; }
        
        [Display(Name="Photo URL")]
		public string PhotoUrl { get; set; }

		public string Descrition { get; set; }
	}
}