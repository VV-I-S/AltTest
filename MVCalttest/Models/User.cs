using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCalttest.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string? Role { get; set; }
        public List<UserProject> UserProjects { get; set; } = new();
        public List<RegressTemplate> RegressTemplates { get; set; } = new();
        public List<RegressResult> RegressResults { get; set; } = new();
        public List<TestDoc> TestDocs { get; set; } = new();

    }
}
