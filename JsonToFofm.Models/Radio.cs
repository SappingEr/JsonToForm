using System;
using System.Collections.Generic;
using System.Text;

namespace JsonToFofm.Models
{
    public class Radio: Item
    {
        public string Type { get; set; } = "radio";

        public Rules ValidationRules { get; set; }

        public string Text { get; set; }

        public string Value { get; set; }

        public bool Checked { get; set; }
    }
}
