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
        

        public async void FormToJsonAsync()
        {
            options.Converters.Add(new JsonStringEnumConverter(JsonNamingPolicy.CamelCase));
            FileStream fs = new FileStream(@"\TFile.json", FileMode.OpenOrCreate);
            Form form = JsonFormInitializer.InitializeFormData();
            await JsonSerializer.SerializeAsync(fs, form, form.GetType(), options);
        }

       
    }
}
