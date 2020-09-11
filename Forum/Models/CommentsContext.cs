using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
namespace Forum.Models
{
    public class CommentsContext:DbContext
    {
        public DbSet<Comment> comments { get; set;}

        public DbSet<ForumTheme> forumThemes { get; set; }
    }
}