namespace JsonToFofm.Models
{
    public abstract class Input
    {
        public string Text { get; set; }

        public Input() { }

        public Input(string text)
        {
            Text = text;
        }
    }
}
