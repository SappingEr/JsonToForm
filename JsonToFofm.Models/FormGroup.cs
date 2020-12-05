namespace JsonToFofm.Models
{
    public abstract class FormGroup : Input
    {
        public string Name { get; set; }

        public string Label { get; set; }

        public string Class { get; set; }

        public bool Required { get; set; }       

        public string Placeholder { get; set; }

        public bool Disabled { get; set; }

        public ValidationRules ValidationRules { get; set; }

        public FormGroup() { }

        public FormGroup(string name, string label, string attrClass,
            bool required, string placeholder, bool disabled, ValidationRules rules)
        {
            Name = name;
            Label = label;
            Class = attrClass;
            Required = required;
            Placeholder = placeholder;
            Disabled = disabled;
            ValidationRules = rules;
        }
    }
}
