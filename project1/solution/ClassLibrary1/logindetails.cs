using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace ClassLibrary1
{
    public class logindetails
    {
        public logindetails() { }
        public int loginid { get; set; }
        public string password { get; set; }  
        public string Email { get; set; }

        public override string ToString()
        {
            return $" Login ID - {loginid} Password - {password} Email - {Email}";

        }

    }
}
