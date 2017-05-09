using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWD_Mediator_GROUP_02
{
    class ConcreteColleague : IColleague
    {
        public void ReceiveMessage()
        {
            
        }

        public void SendMessage(IMediator mediator)
        {
            mediator.DistributeMessage("", this);
        }
    }
}
