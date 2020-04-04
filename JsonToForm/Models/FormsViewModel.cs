using System.Collections.Generic;

namespace JsonToForm.Models
{
    public class FormsViewModel
    {
        public string Name { get; set; }

        public string PostMessage { get; set; }

        public List<object> Items { get; set; } = new List<object>();

    }
}
