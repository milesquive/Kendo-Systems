using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.ComponentModel.DataAnnotations;

namespace IKMDatabase.Entities
{
    public class User : Identity
    {
      
        public string userNumber { get; set; }
        public String name { get; set; }
    }
}
