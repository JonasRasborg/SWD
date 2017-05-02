using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWD_Mediator_GROUP_02
{
    class ConcreteMediator : IMediator
    {
        public List<IColleague> ColleagueList { get; set; }
        public void DistributeMessage(string message, IColleague colleague)
        {
            foreach (var c in ColleagueList)
            {
                if (c != colleague)
                {
                    c.ReceiveMessage();
                }
            }
        }

        public void Register(IColleague colleague)
        {
            ColleagueList.Add(colleague);
        }
    }
}
