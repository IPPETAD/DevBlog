using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DevBlog.Models
{
	public class Comment
	{
		public Comment()
		{
			Children = new List<Comment>();
		}

		public int Id { get; set; }

		public string Body { get; set; }

		public DateTime DateCreated { get; set; }

		public DateTime? DateEdited { get; set; }

		public virtual ApplicationUser Author { get; set; }

		public virtual Article Article { get; set; }

		public virtual Comment Parent { get; set; }

		public virtual ICollection<Comment> Children { get; set; }

	}
}