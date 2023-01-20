using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public  class educationdetails
    {
        public educationdetails() { }
        public int user_id { get; set; }
        public string university { get; set; }
        public string passoutyear { get; set; }
        public string grade { get; set; }
        public override string ToString()
        {
            return $" ID - {user_id} University - {university} Passout Year - {passoutyear}  Grade - {grade}";
        }
    }
}
           
