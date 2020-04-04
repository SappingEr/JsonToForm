using System;
using System.Collections.Generic;
using System.Text;

namespace JsonToFofm.Models
{
    abstract public class Item
    {
        public string Name { get; set; }       

        public bool Required { get; set; }

        public string Label { get; set; }

        public string Class { get; set; }

        public bool Disabled { get; set; }

    }
}
