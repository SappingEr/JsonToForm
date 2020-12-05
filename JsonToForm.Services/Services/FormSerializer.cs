using JsonToFofm.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text.Encodings.Web;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Text.Unicode;

namespace JsonToForm.Services
{
    public class FormSerializer
    {
        //readonly JsonSerializerOptions options = new JsonSerializerOptions
        //{
        //    PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
        //    Encoder = JavaScriptEncoder.Create(UnicodeRanges.All),
        //    WriteIndented = true
        //};

        //public Form DeserializeForm(Form form)
        //{
        //    List<Type> typesForms = new List<Type>();
        //    List<string> allFormsNames = new List<string>();

        //    Assembly assembly = Assembly.Load("JsonToFofm.Models");
        //    Type[] types = assembly.GetTypes();

        //    foreach (var item in types)
        //    {
        //        foreach (var prop in item.GetProperties())
        //        {
        //            var name = prop.Name;
        //            if (name == "Type")
        //            {
        //                typesForms.Add(item);
        //                allFormsNames.Add(item.Name.ToLower());
        //                break;
        //            }
        //        }
        //    }

        //    if (form.Items.Count > 0)
        //    {

        //        Form deserializeForm = new Form();
        //        options.Converters.Add(new JsonStringEnumConverter(JsonNamingPolicy.CamelCase));
        //        deserializeForm.Name = form.Name;
        //        deserializeForm.PostMessage = form.PostMessage;

        //        foreach (var i in form.Items)
        //        {
        //            string objectString = i.ToString();

        //            string type = JsonSerializer.Deserialize<Form>(objectString, options).Type;

        //            if (allFormsNames.Contains(type))
        //            {
        //                var deserializeType = typesForms.Where(i => i.Name.ToLower() == type).FirstOrDefault();
        //                deserializeForm.Items.Add(JsonSerializer.Deserialize(objectString, deserializeType, options));
        //            }
        //        }
        //        return deserializeForm;
        //    }
        //    return null;
        //}
    }
}
