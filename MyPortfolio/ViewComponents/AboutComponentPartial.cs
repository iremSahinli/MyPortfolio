using Microsoft.AspNetCore.Mvc;
using MyPortfolio.DAL.Contect;

namespace MyPortfolio.ViewComponents
{
    public class AboutComponentPartial : ViewComponent
    {
        private readonly AppDbContext _context;

        public AboutComponentPartial(AppDbContext context)
        {
            _context = context;
        }

        public IViewComponentResult Invoke()
        {
            var model = _context.Abouts.FirstOrDefault();
            return View(model);
        }
    }
}
