using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmailClean
{
    public interface Iclock
    {
        DateTime Now { get; }
    }

    public class SystemClock : Iclock
    {
        public DateTime Now { get { return DateTime.Now; } }
    }
}
