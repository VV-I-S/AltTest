using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCalttest.Models
{
    public class TestPlanDoc
    {
        public int TestPlanDocId { get; set; }
        public int TestPlanId { get; set; }
        public int TestDocId { get; set; }
        public TestDoc TestDoc { get; set; } = null!;
        public TestPlan TestPlan { get; set; } = null!;
        public string Status { get; set; } = null;
    }
}
