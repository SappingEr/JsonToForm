
using JsonToForm.Models;
using JsonToForm.Services.Services;
using JsonToForm.Services.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace JsonToForm.Controllers
{
    public class HomeController : Controller
    {
        private readonly IJsonFileSerializer _fileSerializer;       

        public HomeController(IJsonFileSerializer fileSerializer)
        {
            _fileSerializer = fileSerializer;
            
        }

        public IActionResult GetJson()
        {
            return View();
        }

        [HttpPost]
        public IActionResult GenerateForm([FromForm] IFormFile jsonFile)
        {
            if (jsonFile != null)
            {
                FormsViewModel model = new FormsViewModel();

                Form jsonForm = _fileSerializer.ReadJson(jsonFile);

                

                TempData["message"] = "Ошибка десериализации файла!";
                return RedirectToAction("GetJson");
            }

            TempData["message"] = "Ошибка! Файл не обнаружен!";
            return RedirectToAction("GetJson");
        }

        // Контроллер для создания тестовых файлов
        [HttpGet]
        public IActionResult CreateTestFile()
        {
            _fileSerializer.FormToJsonFile();

            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

