using Microsoft.AspNetCore.Mvc;

namespace MyPortfolio.ViewComponents
{
    public class StatisticComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }

    }
}
