using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class Enum
    {
        public enum Sex {
            Unknow=0,
            Male = 1,
            Female = 2,
            ThirdSex = 3
        }

        public enum DataStatus
        {
            Normal = 0,
            Deleted = 1,
            Default = 2,
        }
    }
}
