using System.Text;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Primitives;
using Wba.Oefening.Games.Core.Entities;
using Wba.Oefening.Games.Core.Repositories;
using Wba.Oefening.Games.Web.Services;

namespace Wba.Oefening.Games.Web.Controllers
{
    public class GamesController : Controller
    {
        private readonly GameRepository _gameRepository;
        private readonly FormatService _formatService;

        public GamesController()
        {
            _gameRepository = new GameRepository();
            _formatService = new FormatService();
        }

        /**
         * show the info of one game
         */
        public IActionResult ShowGame(int id)
        {

            var game = _gameRepository.GetGames().FirstOrDefault(g => g.Id == id);
            if (game == null)
            {
                return NotFound("The game was not found.");
            }
            //else format the game and it's properties and sent it back
            return Content(_formatService.FormatGameInfo(game), "text/html");
        }

        public IActionResult Index()
        {
            //get the games


            return Content(_formatService.FormatGameInfo(_gameRepository.GetGames()), "text/html");
        }

    }
}
