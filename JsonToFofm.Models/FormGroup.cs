namespace JsonToFofm.Models
{
    public abstract class FormGroup : FormInput
    {
        public string Name { get; set; }

        public string Label { get; set; }       

        public bool Required { get; set; }        

        public ValidationRules ValidationRules { get; set; }        

        public string Placeholder { get; set; }

        public bool Disabled { get; set; }
       
    }
}
