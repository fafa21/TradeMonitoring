using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Entities
{
    public class RoleAceessMenuMap : BaseEntity<int>
    {
        public int RoleId { get; set; }

        public int AccessMenuId { get; set; }
        public virtual Role Roles { get; set; }
        public virtual AccessMenu AccessMenus { get; set; }
    }
}
