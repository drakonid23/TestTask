using Forum.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Forum.Controllers
{
    public class HomeController : Controller
    {
        CommentsContext cm = new CommentsContext();
        public ActionResult Index()
        {
            IEnumerable<ForumTheme> themes = cm.forumThemes;

            ViewBag.ForumThemes = themes;

            return View();
        }

 

        [HttpGet]
        public ActionResult AddTheme()
        {

            return View();
        }
        [HttpPost]
        public ActionResult AddTheme(ForumTheme theme)
        {
            theme.themeDate = DateTime.Now;
            cm.forumThemes.Add(theme);
            cm.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult Theme(int id)
        {
            ForumTheme theme = cm.forumThemes.Where(m => m.Id == id).FirstOrDefault();
            List<Comment> themeComments = cm.comments.Where(a => a.theme.Id == id).ToList();
            ViewBag.theme = theme;
            ViewBag.CommentList = themeComments;
            return View();
        }
        [HttpPost]
        public ActionResult NewComment(Comment comment)
        {
            comment.CreationDate = DateTime.Now;
            cm.comments.Add(comment);
            cm.SaveChanges();
            return RedirectToAction($"Theme/{comment.themeId}");
        }
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}