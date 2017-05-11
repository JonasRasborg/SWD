using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWD_Mediator_GROUP_02
{
    public class RegularPhone : Phone
    {
        public RegularPhone(int _phoneNumber, IMediator _mediator) : base(_phoneNumber, _mediator)
        {
        }
        public override void Text(int phoneNumber, string text)
        {
            mediator.Text("Sent from RegualarPhone: " + text, phoneNumber, myPhoneNumber);
        }
        public override void TextAll(string message)
        {
            mediator.TextAll("Sent from RegualarPhone: " + message, myPhoneNumber);
        }


    }
}
