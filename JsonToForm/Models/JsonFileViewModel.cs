using JsonToForm.Extensions;
using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;

namespace JsonToForm.Models
{
    public class JsonFileViewModel
    {
        [Required(ErrorMessage = "Выберите файл.")]
        [DataType(DataType.Upload)]
        [MaxFileSize(4_194_304)]
        [AllowedExtensions(new string[] { ".json" })]
        public IFormFile Photo { get; set; }
    }
}
