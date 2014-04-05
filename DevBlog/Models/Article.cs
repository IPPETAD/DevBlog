using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DevBlog.Models
{
	public class Article
	{

		public int Id { get; set; }

		public string Body { get; set; }

		public ApplicationUser Author { get; set; }

		public ICollection<Comment> Comments { get; set; }
	}
}