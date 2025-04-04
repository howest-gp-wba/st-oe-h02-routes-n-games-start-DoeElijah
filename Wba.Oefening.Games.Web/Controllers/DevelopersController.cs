using System.Text;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Primitives;
using Wba.Oefening.Games.Core.Entities;
using Wba.Oefening.Games.Core.Repositories;
using Wba.Oefening.Games.Web.Services;

namespace Wba.Oefening.Games.Web.Controllers
{
    public class DevelopersController : Controller
    {
        private readonly DeveloperRepository _developerRepository = new DeveloperRepository();
        private readonly FormatService _formatService = new FormatService();
        public IActionResult Index()
        {
            return Content(_formatService.FormatDeveloperInfo(_developerRepository.GetDevelopers()), "text/html");
        }


        public IActionResult ShowDeveloper(int id)
        {
            Developer selectedDev = _developerRepository.GetDevelopers().FirstOrDefault(dev => dev.Id == id);

            if (selectedDev == null)
            {
                return NotFound($"The developer with id {id} was not found.");
            }
            else { 
                return Content(_formatService.FormatDeveloperInfo(selectedDev), "text/html"); 
            }



        }
    }
}
