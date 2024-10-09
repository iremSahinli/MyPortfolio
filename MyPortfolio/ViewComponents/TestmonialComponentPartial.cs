using Microsoft.AspNetCore.Mvc;

namespace MyPortfolio.ViewComponents
{
    public class TestmonialComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
