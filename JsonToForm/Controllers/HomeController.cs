using JsonToFofm.Models;
using JsonToForm.Interfaces;
using JsonToForm.Models;
using JsonToForm.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace JsonToForm.Controllers
{
    public class HomeController : Controller
    {
        private IFileSerializer _fileSerializer;
        private FormSerializer _formSerializer;

        public HomeController(IFileSerializer fileSerializer, FormSerializer formSerializer)
        {
            _fileSerializer = fileSerializer;
            _formSerializer = formSerializer;
        }

        public IActionResult GetJson()
        {
            return View();
        }

        [HttpPost]
        //public IActionResult GenerateForm([FromForm]IFormFile jsonFile)
        //{
        //    if (jsonFile != null)
        //    {
        //        FormsViewModel model = new FormsViewModel();

        //        Form jsonForm = _fileSerializer.ReadJson(jsonFile);

        //        if (jsonForm != null)
        //        {
        //            model.Name = jsonForm.Name;
        //            model.Name = jsonForm.PostMessage;

        //            Form deserializedForm = _formSerializer.DeserializeForm(jsonForm);

        //            if (deserializedForm.Items.Count > 0)
        //            {
        //                model.Items = deserializedForm.Items;
        //                return View(model);
        //            }
        //            else
        //            {
        //                TempData["message"] = "Поддерживаемые типы форм не найдены!";
        //                return View(model);
        //            }

        //        }

        //        TempData["message"] = "Ошибка десериализации файла!";
        //        return RedirectToAction("GetJson");
        //    }

        //    TempData["message"] = "Ошибка! Файл не обнаружен!";
        //    return RedirectToAction("GetJson");
        //}

        // Контроллер для создания тестовых файлов
        public IActionResult CreateTestFile()
        {
            _fileSerializer.FormToJsonAsync();

            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

