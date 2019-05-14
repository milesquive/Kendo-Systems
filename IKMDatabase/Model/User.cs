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
        public String firstName { get; set; }

        public String lastName { get; set; }
        public String userName { get; set; }
        public Int16 phoneNumber { get; set; }
        public Model.Manager manager { get; set; }
        public Model.Department department { get; set; }
        public String title { get; set; }
        public String displayName { get; set; }
    }
}
