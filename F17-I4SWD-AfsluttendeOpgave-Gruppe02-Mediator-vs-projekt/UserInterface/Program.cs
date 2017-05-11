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

            one.Text(4040, "I am a regular phone .. ");

            //two.TextAll("Hi everybody!");

            //three.Call(4040);
            //three.Text(4040, "I tried to call you, please call back!");

            Console.ReadLine();
        }
    }
}
