using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unit_Testing_Project
{
    public class Class1
    {
        public int FirstNumber { set; private get; }
        public int SecondNumber { set; private get; }
        public string MyName { set; private get; }

        public int Add()
        {
            return FirstNumber + SecondNumber;
        }

        public string Getname()
        {
            return MyName;
        }
    }
}
