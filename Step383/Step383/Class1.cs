using System;
using System.Collections.Generic;
using System.Text;

namespace Step383
{
    class Class1
    {
        public int Id;
        public string name;
        //giving Class1 2 properties. An int Id and a string name.
        public Class1() : this(0, "")//constructor that has default values
        {

        }

        public Class1(int Id, string name)//this constructor is chained to the above and allows one to create an object with custom inputs for the properties instead of just the defaul ones
        {
            this.Id = Id;
            this.name = name;
        }
    }
}
