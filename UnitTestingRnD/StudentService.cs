using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestingRnD
{
    public class StudentService
    {
        public string CreateFullName(string firstName , string lastName)
        {
            return $"{firstName} {lastName}";
        }
    }
}
