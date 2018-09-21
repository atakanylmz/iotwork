using System;
using System.Collections.Generic;

namespace iotWork.Models
{
    public partial class Type
    {
        public Type()
        {
            this.Devices = new List<Device>();
        }

        public int typeID { get; set; }
        public string typeName { get; set; }
        public virtual ICollection<Device> Devices { get; set; }
    }
}
