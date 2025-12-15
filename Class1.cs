using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_OOPs
{
    internal class Class1
    {
        int age = 10;
        public void display()
        {
            if (age < 18)
            {
                Console.WriteLine("Minor");
            }
            else
            {
                Console.WriteLine("Major");
            }

            while (age < 18)
            {
                Console.WriteLine("Age is " + age);
                age++;
            }
        }
    }
        class Demo
        {
            public static int x = 10;  
            public int y = 20;        
        }
    }


