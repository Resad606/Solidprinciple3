using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciple3
{
    internal class Teacher:Person,Iexperience
    {
        public override string GetExperience()
        {
            return "teacher experision";

        }
        public override string GetFullName()
        {
            return "teacher full name";
        }
    }
}
