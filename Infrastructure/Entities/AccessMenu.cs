using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Entities
{
    public class AccessMenu : BaseEntity<int>
    {

        public string Name { get; set; }
        public string Description { get; set; }
        public int RoleId { get; set; }
        public string ActionName { get; set; }
        public string ControlName { get; set; }
        public bool IsShow { get; set; }

        public virtual ICollection<RoleAceessMenuMap> RoleAceessMenuMap { get; set; }
    }
}
