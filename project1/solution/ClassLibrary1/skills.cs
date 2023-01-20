using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class skills

    {
        public skills() { }
        public string skill_name { get; set; }
        public string skill_profficency { get; set; }
        public int user_id { get; set; }
        public override string ToString()
        {
            return $" Skill Name - {skill_name} Skill Profficency - {skill_profficency} ID - {user_id}";
        }
    }
}

