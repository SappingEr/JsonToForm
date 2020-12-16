namespace JsonToFofm.Models
{
    public class CheckBox: FormGroup
    {
        public bool Checked { get; set; }

        public CheckBox() { }

        public CheckBox(string name, string label, string attrClass,
            bool required, string placeholder, bool disabled, ValidationRules rules, bool checkedBox) :
            base(name, label, attrClass, required, placeholder, disabled, rules)
        {
            Checked = checkedBox;
        }
    }
}
