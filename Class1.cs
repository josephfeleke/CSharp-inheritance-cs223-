using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labWork3
{
    public class Student
    {
        private int _id;

        public int Id { get; set; } //auto implemented property it will automatically create the variable and it will create a variable for it
        /*public int Id
        {
            get { return _id; }
            set { _id = value; }
        }*/
    }

    public class Program : Student
    {

    }
}
