using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWD_Mediator_GROUP_02_Lolling
{
    class Program
    {
        static void Main(string[] args)
        {
            Mediator m = new ConcreteMediator();

            Private medic1 = new Medic("Medic 1",false,m);
            Private medic2 = new Medic("Medic 2",false,m);
            Private gunner1 = new Gunner("Gunner 1",true, m);

            m.privates.Add(medic1);
            m.privates.Add(medic2);
            m.privates.Add(gunner1);

            medic1.Yell("I'm Here to help");
            medic2.Yell("So am I!");
            gunner1.Yell("I am gunner!");

            Console.ReadLine();
        }
    }
}
