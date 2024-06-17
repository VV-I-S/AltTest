using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCalttest.Models
{
    public class RegressTemplate
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string EnvironmentOld { get; set; }
        public string EnvironmentNew { get; set; }
        public string Themes { get; set; }
        public string Device { get; set; }
        public string Additional { get; set; }
        public int UserId { get; set; }
        public User User { get; set; } = null!;

    }
}
