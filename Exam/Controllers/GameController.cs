using Exam.Models;
using Exam.Models.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Exam.Controllers
{
    public class GameController(IGameFieldModel field) : Controller
    {

        [HttpPost]
        [Route("Up")]
        public IActionResult Up()
        {
            field.Up();
            return PartialView("GameField", field);
        }
        [HttpPost]
        [Route("Down")]
        public IActionResult Down()
        {
            field.Down();
            return PartialView("GameField", field);
        }
        [HttpPost]
        [Route("Right")]
        public IActionResult Right()
        {
            field.Right();
            return PartialView("GameField", field);
        }
        [HttpPost]
        [Route("Left")]
        public IActionResult Left()
        {
            field.Left();
            return PartialView("GameField", field);
        }
        public IActionResult Game()
        {
            return View(field);
        }
    }
}
