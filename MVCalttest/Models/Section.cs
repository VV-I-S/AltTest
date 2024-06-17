using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCalttest.Models
{
    public class Section
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int ParentId { get; set; }
        public int ProjectId { get; set; }
        public Project Project { get; set; } = null!;
        public List<TestDoc> TestDocs { get; set; } = new();
    }
}
