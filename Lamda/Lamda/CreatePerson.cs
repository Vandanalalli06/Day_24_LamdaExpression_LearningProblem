using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lamda
{
    public class CreatePerson
    {
        public string SSN;
        public string Name;
        public string Address;
        public int Age;
        public CreatePerson(string ssn, string name, string address, int age)
        {
            SSN = ssn;//Sub System Number
            Name = name;
            Address = address;
            Age = age;
        }
    }
}


