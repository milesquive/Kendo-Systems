using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.Design;

namespace IKMDatabase.Entities
{
    public class Identity
    {
        [Required]
        [Key]
        public int id { get; set; }
    }
}
