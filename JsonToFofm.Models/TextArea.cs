using System;
using System.Collections.Generic;
using System.Text;

namespace JsonToFofm.Models
{
    public class TextArea: Item
    {
        public string Type { get; set; } = "textarea";

        public Rules ValidationRules { get; set; }
        public string Placeholder { get; set; }

        public string Value { get; set; }
    }
}
