using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWD_Mediator_GROUP_02_Lolling
{
    public abstract class Private
    {
        protected Mediator mediator;
        protected string name;
        protected bool isDeaf;

        protected Private(string _name,bool _isdeaf,Mediator _mediator)
        {
            name = _name;
            mediator = _mediator;
            isDeaf = _isdeaf;
        }

        public abstract void Yell(string message);
        public abstract void Hear(string message);
    }
}
