using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DevBlog.Models
{
	public class Comment
	{
		public int Id { get; set; }
		public string Body { get; set; }

		public ApplicationUser Author { get; set; }

		public Article Article { get; set; }

		public Comment Parent { get; set; }

		public ICollection<Comment> Children { get; set; }

	}
}