using System;
using System.Collections.Generic;
using System.Text;

namespace JsonToFofm.Models
{
    public class Select: Item
    {
        public string Type { get; set; } = "select";

        public IList<SelectListItem> SelectList { get; set; } = new List<SelectListItem>();

        public bool Multiple { get; set; }
    }
}
