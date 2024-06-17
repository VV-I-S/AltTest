using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCalttest.Models
{
    public class UserProject
    {
        public int UserProjectId { get; set; }
        public int UserId { get; set; }
        public int ProjectId { get; set; }
        public User User { get; set; } = null!;
        public Project Project { get; set; } = null!;

    }
}
