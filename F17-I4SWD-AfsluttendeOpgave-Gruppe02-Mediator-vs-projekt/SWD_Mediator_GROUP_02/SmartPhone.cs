using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWD_Mediator_GROUP_02
{
    public class SmartPhone : Phone
    {
        public SmartPhone(int _phoneNumber, IMediator _mediator) : base(_phoneNumber, _mediator)
        {
        }
        public override void Text(int phoneNumber, string text)
        {
            mediator.Text(text + " Sent from my SmartPhone", phoneNumber, myPhoneNumber);
        }
        public override void TextAll(string text)
        {
            mediator.TextAll(text + " Sent from my SmartPhone", myPhoneNumber);
        }
    }
}
