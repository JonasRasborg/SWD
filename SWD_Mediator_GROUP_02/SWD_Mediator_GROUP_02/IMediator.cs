using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWD_Mediator_GROUP_02
{
    interface IMediator
    {
        List<IColleague> ColleagueList { get; set; }
        void DistributeMessage(string message, IColleague colleague);
        void Register(IColleague colleague);
    }
}
