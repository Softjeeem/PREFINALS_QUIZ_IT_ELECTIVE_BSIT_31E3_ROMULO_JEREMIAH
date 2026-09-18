using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PortfolioApp.Data;
using PortfolioApp.Models;

namespace PortfolioApp.Controllers
{
    [Authorize]
    public class ProjectController : Controller
    {
        // GET: /Project/Details/5
        public IActionResult Details(int id)
        {
            var project = ProjectData.GetById(id);
            if (project == null)
            {
                return NotFound();
            }

            ViewBag.Comments = CommentStore.GetForProject(id);
            ViewBag.NewComment = new CommentInputModel { ProjectId = id };
            return View(project);
        }

        // POST: /Project/AddComment
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult AddComment(CommentInputModel input)
        {
            var project = ProjectData.GetById(input.ProjectId);
            if (project == null)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                CommentStore.Add(input.ProjectId, input.Author, input.Message);
            }

            return RedirectToAction(nameof(Details), new { id = input.ProjectId });
        }
    }
}
