using System.Collections.Generic;

namespace JsonToFofm.Models
{
    public class Radio : FormGroup
    {
        public List<RadioListItem> Items { get; set; }

        public Radio() { }

        public Radio(string name, string label, string attrClass, bool required,
             string placeholder, bool disabled, ValidationRules rules, List<RadioListItem> items) :
             base(name, label, attrClass, required, placeholder, disabled, rules)
        {
            Items = items;
        }
    }
}
