using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Forum.Models
{
    public class Comment
    {
        public int Id { get; set; }

        public string text { get; set; }

        public string Creator { get; set; }

        public DateTime CreationDate { get; set; }

        public int themeId { get; set; }
        public ForumTheme theme { get; set; }
    }
}