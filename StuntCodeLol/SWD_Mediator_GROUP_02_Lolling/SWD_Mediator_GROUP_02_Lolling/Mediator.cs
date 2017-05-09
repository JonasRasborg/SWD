using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWD_Mediator_GROUP_02_Lolling
{
    public abstract class Mediator
    {
        public abstract List<Private> privates { get; set; }

        public Mediator()
        {
            privates = new List<Private>();
        }

        public abstract void Send(string _message, Private _private);
    }
}
