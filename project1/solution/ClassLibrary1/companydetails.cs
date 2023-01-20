using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class companydetails
    {
        public companydetails() { }
        public int company_id { get; set; }
        public string company_name { get; set;}
        public string startyear { get; set; }
        public string endyear { get; set; }
        public int user_id { get; set; }
        public override string ToString()
        {
            return $"  Company ID - {company_id}  Start Year - {startyear} End Year - {endyear} ID - {user_id}";
        }
    }
}
