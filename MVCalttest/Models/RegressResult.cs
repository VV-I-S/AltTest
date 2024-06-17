using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCalttest.Models
{
    public class RegressResult
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public DateTime DateOfCreate { get; set; }
        public string Content { get; set; }
        public int UserId { get; set; }
        public User User { get; set; } = null!;

    }
}
