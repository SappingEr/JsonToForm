using System;
using System.Collections.Generic;
using System.Text;

namespace JsonToFofm.Models
{
    public class Text: Item
    {
        public string Type { get; set; } = "text";

        public Rules ValidationRules { get; set; }

        public string Value { get; set; }

        public string Placeholder { get; set; }
    }
}
