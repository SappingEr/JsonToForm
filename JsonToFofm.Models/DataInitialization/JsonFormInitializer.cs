using System;
using System.Collections.Generic;
using System.Text;

namespace JsonToFofm.Models.DataInitialization
{
    public class JsonFormInitializer
    {
        public static Form InitializeFormData()
        {
            Form form = new Form() { Name = "TestForm", PostMessage = "Good morning..." };
            Filler filler = new Filler() { Type = "filler", Message = "Форма сгенерированная из файла json" };

            Text text = new Text()
            {
                Name = "userName",
                Label = "Введите Имя",
                ValidationRules = Rules.text,
                Placeholder = "Имя",
                Disabled = true
            };

            Text text2 = new Text()
            {
                Name = "tel",
                Label = "Введите Email",
                ValidationRules = Rules.email,
                Required = true
            };

            Text text3 = new Text()
            {
                Name = "tel",
                Placeholder = "Номер телефона",
                ValidationRules = Rules.tel
            };

            form.Items.Add(filler);
            form.Items.Add(text);
            form.Items.Add(text2);
            form.Items.Add(text3);

            return form;
        }
    }
}
