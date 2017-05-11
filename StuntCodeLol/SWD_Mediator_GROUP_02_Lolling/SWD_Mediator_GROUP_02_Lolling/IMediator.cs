using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWD_Mediator_GROUP_02_Lolling
{
    public interface IMediator
    {
        void Text(string message, int recievingNumber, int sendingNumber);
        void TextAll(string message, int sendingnumber);
        void Call(int recievingNumber, int callingNumber);
        void Register(Phone smartphone);

    }
}