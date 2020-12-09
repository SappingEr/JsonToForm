
using JsonToForm.Models;
using JsonToForm.Services.Services;
using JsonToForm.Services.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using JsonToFofm.Models;

namespace JsonToForm.Controllers
{
    public class HomeController : Controller
    {
        private readonly IJsonFileSerializer fileSerializer;       

        public HomeController(IJsonFileSerializer fileSerializer)
        {
            this.fileSerializer = fileSerializer;
            
        }

        [HttpGet]
        public IActionResult GetJson()
        {
            JsonFileViewModel fileModel = new JsonFileViewModel();
            return View(fileModel);
        }

        [HttpPost]
        public IActionResult GetJson(JsonFileViewModel fileModel)
        {
            if (ModelState.IsValid)
            {
                IFormFile formFile = fileModel.FileJson;

                if (formFile != null && formFile.Length > 0)
                {
                    FormsViewModel formModel = new FormsViewModel();
                    Form form = fileSerializer.ReadJson(formFile);
                    formModel.Form = form;
                    return RedirectToAction("GenerateForm", "Home", form);
                }

                ModelState.AddModelError("", "Uploaded file is empty or null.");
                return View(fileModel);
            }
            return View(fileModel);
        }

        [HttpPost]
        public IActionResult GenerateForm(FormsViewModel formModel)
        {
            if (formModel.Form != null)
            {
                return View(formModel);
            }

            return BadRequest();
        }

        // Контроллер для создания тестовых файлов
        [HttpGet]
        public IActionResult CreateTestFile()
        {
            fileSerializer.FormToJsonFile();

            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

