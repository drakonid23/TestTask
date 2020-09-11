using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Forum.Models
{
    public class ForumTheme
    {
        public int Id { get; set; }
        public string themeName { get; set; }
        public string questionDescription { get; set; }
        public string creator { get; set; }
        public DateTime themeDate { get; set; }
        public List<Comment> comments { get; set; }
    }
}