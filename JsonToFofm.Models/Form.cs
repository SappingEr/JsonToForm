using System.Text.Json;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Collections;

namespace JsonToFofm.Models
{
    
    public class Form
    {
        public string Type { get; set; } = "form";

        public string Name { get; set; }

        public List<object> Items { get; set; } = new List<object>();

        public string PostMessage { get; set; }
    }
}
