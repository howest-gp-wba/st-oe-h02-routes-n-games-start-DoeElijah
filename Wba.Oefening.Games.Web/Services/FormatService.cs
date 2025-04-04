using System.Text;
using Wba.Oefening.Games.Core.Entities;

namespace Wba.Oefening.Games.Web.Services
{
    public class FormatService : IFormatService
    {
        public string FormatGameInfo(Game game)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("<h3>Game Info</h3>");
            sb.Append("<ul>");
            sb.Append("<li>" + "Id: " + $"<a href='/Games/{game.Id}'>" + game.Id + "</a>" + "</li>").Append("<li>" + "Title: " + game.Title + "</li>").Append("<li>" + "Developer: " + game.Developer.Name + "</li>").Append("<li>" + "Rating: " + (game.Rating != null ? game.Rating : "Not specified") + "</li>");
            sb.Append("</ul>");
            return sb.ToString();


        }
        public string FormatGameInfo(IEnumerable<Game> games)
        {


            StringBuilder sb = new StringBuilder();

            foreach (Game game in games)
            {
                sb.Append(FormatGameInfo(game));
            }
            return sb.ToString();


        }
        public string FormatDeveloperInfo(Developer developer)
        {
            StringBuilder sb = new StringBuilder();

            sb.Append("<h3>Developer Info</h3>");
            sb.Append($"<ul>" +
                $"<li>Id: " + developer.Id + "</li>" +
                $"<li>Dev: " + $"<a href='/Developers/{developer.Id}'>" + developer.Name + "</a></li>" +
                $"</ul>"
                );
            return sb.ToString();
        }
        public string FormatDeveloperInfo(IEnumerable<Developer> developers)
        {
            StringBuilder sb = new StringBuilder();

            foreach (Developer dev in developers) { sb.Append(FormatDeveloperInfo(dev)); }
            return sb.ToString();
        }
    }
}
