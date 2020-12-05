using System.Collections.Generic;

namespace JsonToFofm.Models
{

    public class Form
    {
        public string Name { get; set; }

        public List<Input> Inputs { get; set; } = new List<Input>();

        public string PostMessage { get; set; }

        public Form() { }

        public Form(string name, string postMessage)
        {
            Name = name;
            PostMessage = postMessage;
        }
    }
}
