using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCalttest.Models
{
    public class TestDoc
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public DateTime DateOfCreate { get; set; }
        public int UserId { get; set; }
        public User User { get; set; } = null!;
        public int SectionId { get; set; }
        public Section Section { get; set; } = null!;
        public int Rows { get; set; }
        public int Columns { get; set; }
        public string Tags { get; set; }
        public List<Content> Contents { get; set; } = new();
        public List<TestPlanDoc> TestPlanDoc { get; set; } = new();
    }
}
