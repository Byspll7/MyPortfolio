using Microsoft.AspNetCore.Mvc;
using MyPortfolio.DAL.Context;
using MyPortfolio.DAL.Entites;

namespace MyPortfolio.Controllers
{
	public class ExperienceController : Controller
	{
		MyPortfolioContext context = new MyPortfolioContext();
		public IActionResult ExperienceList()
		{
			var values = context.Experiances.ToList();
			return View(values);
		}

		[HttpGet]
		public IActionResult CreateExperience()
		{
			return View();
		}

		[HttpPost]
		public IActionResult CreateExperience(Experience experience)
		{
			context.Experiances.Add(experience);
			context.SaveChanges();
			return RedirectToAction("ExperienceList");
		}

		public IActionResult DeleteExperience(int id)
		{
			var value = context.Experiances.Find(id);
			context.Experiances.Remove(value);
			context.SaveChanges();
			return RedirectToAction("ExperienceList");
		}

		[HttpGet]
		public IActionResult UpdateExperience(int id)
		{
			var value = context.Experiances.Find(id);
			return View(value);
		}

		[HttpPost]
		public IActionResult UpdateExperience(Experience experience)
		{
			context.Experiances.Update(experience);
			context.SaveChanges();
			return RedirectToAction("ExperienceList");
		}
		
	}
}
