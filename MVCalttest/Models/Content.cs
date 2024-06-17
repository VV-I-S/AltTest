using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCalttest.Models
{
    public class Content
    {
        public int Id { get; set; }
        public string ContentText { get; set; }
        public int Row { get; set; }
        public int Column { get; set; }
        public int TestDocId { get; set; }
        public TestDoc TestDoc { get; set; } = null!;
    }
}
