using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public class BusinessResault
    {
        bool IsOK { get; set; }
        string Result { get; set; }
        string [] Messages { get; set; }
    }
}
