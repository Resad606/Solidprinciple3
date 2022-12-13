using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciple3
{
    internal class Developer:Person,Iexperience
    {
        public override string GetExperience()
        {
            return "Developer experience";
        }
        public override string GetFullName()
        {
            return "DEVELOPER FULL NAME";
        }

    }
}
