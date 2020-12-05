using JsonToFofm.Models;
using Microsoft.AspNetCore.Http;

namespace JsonToForm.Services.Interfaces
{
    public interface IFileSerializer
    {
        void FormToJson();

        Form ReadJson(IFormFile jsonFile);
    }
}
