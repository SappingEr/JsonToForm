using JsonToFofm.Models;
using Microsoft.AspNetCore.Http;

namespace JsonToForm.Interfaces
{
    public interface IFileSerializer
    {
        void FormToJsonAsync();

        Form ReadJson(IFormFile jsonFile);
    }
}
