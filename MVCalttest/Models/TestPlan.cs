using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCalttest.Models
{
    public class TestPlan
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime DateOfCreate { get; set; }
        public string Status { get; set; }
        public TestDoc TestDoc { get; set; } = null!;
        public List<TestPlanDoc> TestPlanDoc { get; set; } = new();
    }
}
