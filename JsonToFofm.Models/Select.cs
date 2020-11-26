using System.Collections.Generic;

namespace JsonToFofm.Models
{
    public class Select : FormGroup
    {
        public IList<Options> Options { get; set; } = new List<Options>();

        public bool Multiple { get; set; }
    }
}
