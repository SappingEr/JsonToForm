using JsonToFofm.Models;
using Microsoft.AspNetCore.Http;

namespace JsonToForm.Services
{
    public interface IFileSerializer
    {
        void FormToJsonAsync();

        Form ReadJson(IFormFile jsonFile);
    }
}
