using System;
using System.Collections.Generic;

namespace iotWork.Models
{
    public partial class Device
    {
        public int deviceID { get; set; }
        public string deviceName { get; set; }
        public Nullable<int> typeID { get; set; }
        public string deviceIP { get; set; }
        public Nullable<int> userID { get; set; }
        public string devicePassword { get; set; }
        public virtual Type Type { get; set; }
        public virtual User User { get; set; }
    }
}
