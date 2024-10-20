using Microsoft.AspNetCore.Mvc;
using MyPortfolio.DAL.Contect;

namespace MyPortfolio.ViewComponents
{
    public class ProjectComponentPartial : ViewComponent
    {
        private readonly AppDbContext _context;

        public ProjectComponentPartial(AppDbContext context)
        {
            _context = context;
        }

        public IViewComponentResult Invoke()
        {
            var models = _context.Projects.ToList();
            return View(models);
        }
    }
}
