using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ASM_PS28709.Context;

namespace ASM_PS28709
{
    public class handing
    {
        public AssignmentC3Entities EnityDB;
        public handing() { EnityDB = new AssignmentC3Entities(); }
        public string objGet()
        {
            return EnityDB.users.ToList().FirstOrDefault().username;
        }
    }
}
