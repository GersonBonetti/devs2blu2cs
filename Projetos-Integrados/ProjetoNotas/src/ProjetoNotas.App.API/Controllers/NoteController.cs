using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProjetoNotas.Domain.DTO;
using ProjetoNotas.Domain.Interfaces.IService;

namespace ProjetoNotas.App.API.Controllers
{
    public class NoteController : Controller
    {
        private readonly INoteService _noteService;

        public NoteController(INoteService service)
        {
            _noteService = service;
        }

        public JsonResult Index()
        {
            var users = _noteService.FindAll();
            return Json(users);
        }

        public JsonResult FindById(int id)
        {
            var user = _noteService.FindById(id);
            return Json(user);
        }


        /*public ActionResult Details(int id)
        {
            return View();
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create()
        {
            if (ModelState.IsValid)
            {
                if (await _noteService.Save(user) > 0)
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
            return View(await _noteService.FindById(id));
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
                if (await _noteService.Save(user) > 0)
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
