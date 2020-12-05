using System.Collections.Generic;

namespace JsonToFofm.Models
{
    public class Select : FormGroup
    {
        public List<Options> Options { get; set; } = new List<Options>();

        public bool Multiple { get; set; }

        public Select() { }

        public Select(string name, string label, string attrClass,
            bool required, string placeholder, bool disabled, ValidationRules rules, 
            bool myltiple, List<Options> options) :
            base(name, label, attrClass, required, placeholder, disabled, rules)
        {
            Multiple = myltiple;
            Options = options;
        }
       
    }
}
