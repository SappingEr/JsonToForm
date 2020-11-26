using System.Collections.Generic;

namespace JsonToFofm.Models
{

    public class Form
    {
        public string Name { get; set; }

        public List<FormInput> Inputs { get; set; } = new List<FormInput>();

        public string PostMessage { get; set; }
    }
}
