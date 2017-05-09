using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWD_Mediator_GROUP_02_Lolling
{
    class Gunner : Private
    {
        public Gunner(string _name,bool _isdeaf, Mediator _mediator) : base(_name,_isdeaf, _mediator)
        {
        }

        public override void Yell(string message)
        {
            mediator.Send(message+" Orah!", this);
        }

        public override void Hear(string message)
        {
            if (isDeaf)
            {
                
            }
            else
            Console.WriteLine(name + " heard: " + message);
        }
    }
}
