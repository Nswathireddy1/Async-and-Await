using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Lambda2
    {

        delegate void MyDelegate(int i);//annoymuse objects created by only delegates
        delegate void MyDelegate1();
    
            static void Main(string[] args)
            {
                MyDelegate md = delegate (int val)
                {
                    Console.WriteLine("Inside Anonymous method. Value: {0}", val);
                };
                md(20);
                MyDelegate1 md1 = delegate () { Console.WriteLine("From AnnonMethod "); };
                md1();
            Console.Read();
            }

        }
    }



