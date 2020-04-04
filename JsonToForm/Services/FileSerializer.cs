using JsonToFofm.Models;
using JsonToFofm.Models.DataInitialization;
using JsonToForm.Interfaces;
using Microsoft.AspNetCore.Http;
using System.IO;
using System.Text.Encodings.Web;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Text.Unicode;

namespace JsonToForm.Services
{
    public class FileSerializer : IFileSerializer
    {
        JsonSerializerOptions options = new JsonSerializerOptions
        {
            PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
            Encoder = JavaScriptEncoder.Create(UnicodeRanges.All),
            WriteIndented = true
        };

        public async void FormToJsonAsync()
        {
            options.Converters.Add(new JsonStringEnumConverter(JsonNamingPolicy.CamelCase));
            FileStream fs = new FileStream(@"\TFile.json", FileMode.OpenOrCreate);
            Form form = JsonFormInitializer.InitializeFormData();
            await JsonSerializer.SerializeAsync(fs, form, form.GetType(), options);
        }

        public Form ReadJson(IFormFile jsonFile)
        {
            string jsonString;
            options.Converters.Add(new JsonStringEnumConverter(JsonNamingPolicy.CamelCase));
            var reader = new StreamReader(jsonFile.OpenReadStream());
            jsonString = reader.ReadToEnd();

            if (jsonString.Length > 0)
            {
                Form form = JsonSerializer.Deserialize<Form>(jsonString, options);
                return form;
            }
            return null;
        }
    }
}
