using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProjetoNotas.Domain.DTO;
using ProjetoNotas.Domain.Interfaces.IService;

namespace ProjetoNotas.App.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : Controller
    {
        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpGet]
        public async Task<JsonResult> Index()
        {
            return Json(_userService.FindAll());
        }

        /*public JsonResult FindById(int id)
        {
            var user = _userService.FindById(id);
            return Json(user);
        }


        public ActionResult Details(int id)
        {
            return View();
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind("Id, Name, Login, Password")] UserDTO user)
        {
            if (ModelState.IsValid)
            {
                if (await _userService.Save(user) > 0)
                {
                    return RedirectToAction(nameof(Index));
                }
            }
            return View(user);
        }

        public async Task<ActionResult> Edit(int id)
        {
            if (id == null)
            {
                return NotFound();
            }
            return View(await _userService.FindById(id));
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit(int? id, [Bind("Name, Login, Password")] UserDTO user)
        {
            if (!(id == user.Id))
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                if (await _userService.Save(user) > 0)
                {
                    return RedirectToAction(nameof(Index));
                }
            }
            return View(user);
        }

        public ActionResult Delete(int id)
        {
            return View();
        }*/

        /*[HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<JsonResult> Delete(int? id)
        {
            return Json();
        }*/
    }
}
