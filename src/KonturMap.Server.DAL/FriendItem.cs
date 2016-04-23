using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KonturMap.Server.DAL
{
    public class FriendItem
    {
        public long Phone { get; set; }
        public DateTimeOffset LastSeen { get; set; }
        public bool CanAccess { get; set; } 
    }
}
