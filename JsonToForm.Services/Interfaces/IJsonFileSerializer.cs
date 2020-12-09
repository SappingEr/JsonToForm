using JsonToFofm.Models;
using Microsoft.AspNetCore.Http;

namespace JsonToForm.Services.Interfaces
{
    public interface IJsonFileSerializer
    {
        void FormToJsonFile();

        Form ReadJson(IFormFile jsonFile);
    }
}
