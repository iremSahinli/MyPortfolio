using Microsoft.AspNetCore.Mvc;
using MyPortfolio.DAL.Contect;

namespace MyPortfolio.ViewComponents
{
    public class FeatureComponentPartial : ViewComponent
    {
        private readonly AppDbContext _context;

        public FeatureComponentPartial(AppDbContext context)
        {
            _context = context;
        }

        public IViewComponentResult Invoke()
        {
            var model = _context.Features.FirstOrDefault();
            return View(model);
        }
    }
}
