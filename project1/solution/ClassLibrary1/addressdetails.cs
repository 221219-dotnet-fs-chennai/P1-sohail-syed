using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public  class addressdetails
    {
        public addressdetails() { }
        public string contact { get; set; }
        public string email { get; set; }
        public string state { get; set; }
        public string pincode { get; set; }
        public int user_id { get; set; }
        public override string ToString()
        {
            return $" Contact - {contact} Email - {email} State - {state} Pincode - {pincode} ID - {user_id}";
        }
    }
}
