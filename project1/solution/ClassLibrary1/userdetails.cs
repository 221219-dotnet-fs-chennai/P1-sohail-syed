using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ClassLibrary1
{
    public class User
    {
        public User() { }
        public int user_id { get; set; }
        public string First_name { get; set; }
        public string Last_name { get; set;}
        public int Age { get; set; }
        public string Gender { get; set; }

        public override string ToString()
        {
            return $"ID - {user_id}  First name - {First_name}  Last name - {Last_name} Age - {Age} Gender - {Gender}";
        }

    }
}