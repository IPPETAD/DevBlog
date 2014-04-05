﻿using System.Collections.Generic;
using System.Data.Entity;

namespace DevBlog.Models
{
	public class Article
	{
		public Article()
		{
			Comments = new List<Comment>();
		}

		public int Id { get; set; }

		public string Body { get; set; }

		public string Title { get; set; }

		public DateTime DatePublished { get; set; }

		public DateTime? DateEdited { get; set; }

		public virtual ApplicationUser Author { get; set; }

		public virtual ICollection<Comment> Comments { get; set; }
	}

    public class ArticleDBContext : DbContext
    {
        public DbSet<Article> Articles { get; set; }
    }
}