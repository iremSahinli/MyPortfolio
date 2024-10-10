using Microsoft.AspNetCore.Mvc;

namespace MyPortfolio.ViewComponents
{
    public class MyTecnologiesComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
