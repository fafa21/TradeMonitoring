using ApplicationCore.Interface;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Entities
{
    public class BaseEntity<T>
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public T Id { get; set; }
        public DateTime CreateDate { get; set; }

        public bool IsActive { get; set; }
    }
    //public class BaseEntity : IEntity<int>

    //{
    //    public DateTime CreateDate { get; set; }

    //    public bool IsActive { get; set; }
    //    public int Id { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    //}
}
