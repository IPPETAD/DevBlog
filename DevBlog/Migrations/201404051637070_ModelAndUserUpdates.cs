namespace DevBlog.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ModelAndUserUpdates : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Articles", "Title", c => c.String());
            AddColumn("dbo.Articles", "DatePublished", c => c.DateTime(nullable: false));
            AddColumn("dbo.Articles", "DateEdited", c => c.DateTime());
            AddColumn("dbo.AspNetUsers", "RealName", c => c.String());
            AddColumn("dbo.AspNetUsers", "Email", c => c.String());
            AddColumn("dbo.AspNetUsers", "DateCreated", c => c.DateTime());
            AddColumn("dbo.AspNetUsers", "LastLoggedIn", c => c.DateTime());
            AddColumn("dbo.AspNetUsers", "PhotoUrl", c => c.String());
            AddColumn("dbo.AspNetUsers", "Descrition", c => c.String());
            AddColumn("dbo.Comments", "DateCreated", c => c.DateTime(nullable: false));
            AddColumn("dbo.Comments", "DateEdited", c => c.DateTime());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Comments", "DateEdited");
            DropColumn("dbo.Comments", "DateCreated");
            DropColumn("dbo.AspNetUsers", "Descrition");
            DropColumn("dbo.AspNetUsers", "PhotoUrl");
            DropColumn("dbo.AspNetUsers", "LastLoggedIn");
            DropColumn("dbo.AspNetUsers", "DateCreated");
            DropColumn("dbo.AspNetUsers", "Email");
            DropColumn("dbo.AspNetUsers", "RealName");
            DropColumn("dbo.Articles", "DateEdited");
            DropColumn("dbo.Articles", "DatePublished");
            DropColumn("dbo.Articles", "Title");
        }
    }
}
