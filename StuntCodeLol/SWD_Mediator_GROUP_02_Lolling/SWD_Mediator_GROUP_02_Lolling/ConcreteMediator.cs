using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWD_Mediator_GROUP_02_Lolling
{
    class ConcreteMediator : Mediator
    {
        public override List<Private> privates { get; set; }

        public ConcreteMediator() : base()
        {
        }

        public override void Send(string _message, Private yellingprivate)
        {
            
            foreach (var p in privates)
            {
                if (privates.Contains(yellingprivate))
                {
                    if (p != yellingprivate)
                    {
                        p.Hear(_message);
                    }
                }
               
            }
        }

       
    }
}
