using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciple3
{
    internal abstract  class Student:Person
    {
        
        public override string GetFullName()
        {
            return "Student full name";
        }
    }
}
