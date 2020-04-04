using System;
using System.Collections.Generic;
using System.Text;

namespace JsonToFofm.Models
{
    public class CheckBox: Item
    {
        public string Type { get; set; } = "checkbox";

        public Rules ValidationRules { get; set; }

        public string Value { get; set; }        

        public bool Checked { get; set; }
    }
}
