using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Lambda5
    {
       
            delegate void Delegate5();
            static void Main(string[] args)
            {
                int i = 120;//it doesn't allow jump statements
                Delegate5 dg = () => { Console.WriteLine("The vales of I is :" + i); };
                dg();
            Console.Read();
            }
        }
    }



