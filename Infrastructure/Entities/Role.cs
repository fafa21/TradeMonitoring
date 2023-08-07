using ApplicationCore.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Entities
{
    public class Role : BaseEntity<int>
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public ICollection<UserInRole> UserInRoles { get; set; }
        public ICollection<RoleAceessMenuMap> RoleAceessMenuMaps { get; set; }
    }
}
