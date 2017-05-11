using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SWD_Mediator_GROUP_02;

namespace UserInterface
{
    class Program
    {
        static void Main(string[] args)
        {
            IMediator m = new PhoneCentral();

            Phone one = new RegularPhone(2020, m);
            Phone two = new RegularPhone(4040, m);
            Phone three = new SmartPhone(6060, m);

            one.TextAll("I am very old ...");

            three.Text(2020, "I am new.");

            one.Call(6060);
            one.Call(6060);
            one.Call(6060);

            one.Text(6060, "Pick up I kill U!");

            Console.ReadLine();
        }
    }
}
