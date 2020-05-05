using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BalloShoopApp.Domain.Entities
{
    public class Department
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime CreatedAt { get; set; }
        public int CreatedUser { get; set; }
        public DateTime UpdatedAt { get; set; }
        public int UpdatedUser { get; set; }
    }
}
