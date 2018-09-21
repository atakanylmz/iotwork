using System;
using System.Collections.Generic;

namespace iotWork.Models
{
    public partial class User
    {
        public User()
        {
            this.Devices = new List<Device>();
        }

        public int userID { get; set; }
        public string userName { get; set; }
        public string userPassword { get; set; }
        public string mail { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public Nullable<System.DateTime> birthDay { get; set; }
        public string city { get; set; }
        public virtual ICollection<Device> Devices { get; set; }
    }
}
