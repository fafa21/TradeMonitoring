using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Interface
{
    public interface IEntity<Tkey>
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        Tkey Id { get; set; }

        DateTime CreateDate { get; set; }

        bool IsActive { get; set; }
    }
}
