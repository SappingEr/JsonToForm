using JsonToFofm.Models;
using JsonToFofm.Models.DataInitialization;
using JsonToForm.Services.Interfaces;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace JsonToForm.Services.Services
{
    public class JsonFileSerializer : IJsonFileSerializer
    {
        public void FormToJsonFile()
        {
            JsonSerializer serializer = new JsonSerializer();
            serializer.Formatting = Formatting.Indented;
            Form form = JsonFormInitializer.InitializeFormData();
            using StreamWriter sw = new StreamWriter(@"c:\json.txt");
            using JsonWriter writer = new JsonTextWriter(sw);
            serializer.Serialize(writer, form);
        }

        public Form ReadJson(IFormFile jsonFile)
        {
            string fileContent = null;
            using (var reader = new StreamReader(jsonFile.OpenReadStream()))
            {
                fileContent = reader.ReadToEnd();
            }
            Form form = JsonConvert.DeserializeObject<Form>(fileContent);

            return form;
        }
    }
}
