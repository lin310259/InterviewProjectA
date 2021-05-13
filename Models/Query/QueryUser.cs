using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models.Query
{
    public class QueryUser
    {
        public long? UserPK { get; set; }
        public string UserIDNO { get; set; }

        public string UserAccount { get; set; }

        public string UserName { get; set; }
    }
}
