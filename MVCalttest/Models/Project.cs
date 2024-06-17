using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCalttest.Models
{
    public class Project
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public List<UserProject> UserProjects { get; set; } = new();
        public List<Section> Section { get; set; } = new();

    }
}
