using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Entities
{
    [Table("User")]
    public class User : BaseEntity<int>
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public string? Email { get; set; }
        public  ICollection<UserInRole> userInRoles { get; set; }
    }
}
