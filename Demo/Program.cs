using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            StudentInfo _instance = new StudentInfo(); //Instance / space
            _instance.setId("$100");
            _instance.setName("Tom");
            _instance.setMarks(60);
            Console.WriteLine(_instance.getId());
            Console.WriteLine(_instance.getName());
            Console.WriteLine(_instance.getMarks());

        }
    }
}
