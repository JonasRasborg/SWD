using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWD_Mediator_GROUP_02
{
    interface IColleague
    {
        void ReceiveMessage();
        void SendMessage(IMediator mediator);
    }
}
