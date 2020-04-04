using System;
using System.Collections.Generic;
using System.Text;

namespace JsonToFofm.Models
{
    public class Button
    {
        public string Type { get; set; } = "button";

        public string Class { get; set; }

        public string Text { get; set; }
    }
}
