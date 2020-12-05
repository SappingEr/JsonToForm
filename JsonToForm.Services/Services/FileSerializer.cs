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
    class FileSerializer : IFileSerializer
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
            throw new NotImplementedException();
        }
    }
}
