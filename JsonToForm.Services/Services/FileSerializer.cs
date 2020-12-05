using JsonToFofm.Models;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;

namespace JsonToForm.Services
{
    public class FileSerializer : IFileSerializer
    {
        

        public async void FormToJsonAsync()
        {
           



            //options.Converters.Add(new JsonStringEnumConverter(JsonNamingPolicy.CamelCase));
            //FileStream fs = new FileStream(@"\TFile.json", FileMode.OpenOrCreate);
            //Form form = JsonFormInitializer.InitializeFormData();
            //await JsonSerializer.SerializeAsync(fs, form, form.GetType(), options);
        }

        public Form ReadJson(IFormFile jsonFile)
        {
            throw new System.NotImplementedException();
        }
    }
}
