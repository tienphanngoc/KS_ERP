using System;
using System.Collections.Generic;
using System.Text;

namespace KSERP.Data.Entities.System
{
    public class SystemActivity
    {
        public long Id { get; set; }
        public int FunctionId { get; set; }
        public int ActionId { get; set; }
        public int ActorId { get; set; }
        public DateTime Time { get; set; }
        public string ClientIp { get; set; }
        public string MacAddress { get; set; }
        public string DeviceName { get; set; }
        public string OS { get; set; }
        public SystemActivity()
        {
            Time = DateTime.Now;
        }
    }
}
