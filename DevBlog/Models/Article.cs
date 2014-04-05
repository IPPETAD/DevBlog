using System.Collections.Generic;
using System.Data.Entity;

namespace DevBlog.Models
{
	public class Article
	{

		public int Id { get; set; }

		public string Body { get; set; }

		public ApplicationUser Author { get; set; }

		public ICollection<Comment> Comments { get; set; }
	}

    public class ArticleDBContext : DbContext
    {
        public DbSet<Article> Articles { get; set; }
    }
}