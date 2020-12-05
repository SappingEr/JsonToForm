namespace JsonToFofm.Models
{
    public class TextArea : Text
    {
        public TextArea() { }

        public TextArea(string name, string label, string attrClass,
            bool required, string placeholder, bool disabled, ValidationRules rules, string value) :
            base(name, label, attrClass, required, placeholder, disabled, rules, value)
        { 
        }        
    }
}
