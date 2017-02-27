using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Statoil.MadShared
{
    public class Error
    {
        public int Code { get; internal set; }
        public string Message { get; set; }
        public string System { get; set; }
    }
}
