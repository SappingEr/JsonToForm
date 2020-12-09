using System.Collections.Generic;

namespace JsonToFofm.Models.DataInitialization
{
    public class JsonFormInitializer
    {
        public static Form InitializeFormData()
        {
            Form form = new Form("Some Name form", "Good Bye");

            Filler textFiller = new Filler("Text Area");

            form.Inputs.Add(textFiller);

            Text text = new Text("Text Form", "Text", "form-control",
                false, "Some text", false, ValidationRules.text, "");

            TextArea textArea = new TextArea("Text Area Form", "Text Area", "",
                false, "", false, ValidationRules.text, "");

            form.Inputs.Add(text);
            form.Inputs.Add(textArea);

            List<Options> options = new List<Options>
            {
                new Options { Value = 1, Text = "One" },
                new Options { Value = 2, Text = "Two" },
                new Options { Value = 3, Text = "Three", Selected = true }
            };

            Select select = new Select("Select List", "Select List", "",
                false, "", false, ValidationRules.select, true, options);

            form.Inputs.Add(select);

            List<RadioListItem> radio = new List<RadioListItem>
            {
                new RadioListItem { Value = "One", Text = "SomeElse" },
                new RadioListItem { Value = "Two", Text = "SomeElse1" },
                new RadioListItem { Value = "Three", Text = "SomeElse2", Checked = true }
            };

            Radio radioForm = new Radio("Radio", "Radio", "", false, "", false, ValidationRules.radio, radio);

            form.Inputs.Add(radioForm);

            Button button = new Button { Text = "Confirm", Class = "" };

            form.Inputs.Add(button);

            return form;
        }
    }
}
