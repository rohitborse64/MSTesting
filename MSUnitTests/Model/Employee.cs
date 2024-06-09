using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSUnitTests.Model
{
    // comment on employee
    public class Employee
    {
        public string GetName(string firstName, string lastName)
        {
            return string.Concat(firstName, " ", lastName);
        }
    }
}
