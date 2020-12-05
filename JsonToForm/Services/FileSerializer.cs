using JsonToFofm.Models;
using JsonToFofm.Models.DataInitialization;
using JsonToForm.Interfaces;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using System.IO;

namespace JsonToForm.Services
{
    public class FileDeserializer : IFileSerializer
    {


        public void FormToJson()
        {
            JsonSerializer serializer = new JsonSerializer();
            Form form = JsonFormInitializer.InitializeFormData();
            using StreamWriter sw = new StreamWriter(@"c:\json.txt");
            using JsonWriter writer = new JsonTextWriter(sw);
            serializer.Serialize(writer, form);

        }

        public Form ReadJson(IFormFile jsonFile)
        {
            throw new System.NotImplementedException();
        }
    }
}
