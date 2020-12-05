namespace JsonToFofm.Models
{
    public class Text : FormGroup
    {
        public string Value { get; set; }

        public Text() { }

        public Text(string name, string label, string attrClass,
            bool required, string placeholder, bool disabled, ValidationRules rules, string value) :
            base(name, label, attrClass, required, placeholder, disabled, rules)
        {
            Value = value;
        }
    }
}
