using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SWD_Mediator_GROUP_02_Lolling
{
    public abstract class Phone
    {
        protected IMediator mediator;
        public int myPhoneNumber { get; }

        protected Phone(int _phoneNumber, IMediator _mediator)
        {
            myPhoneNumber = _phoneNumber;
            mediator = _mediator;
            mediator.Register(this);
        }

        public virtual void Call(int phonenumber)
        {
            mediator.Call(phonenumber, myPhoneNumber);
            Thread.Sleep(500);

        }
        public virtual void Text(int phoneNumber, string text)
        {
            mediator.Text(text, phoneNumber, myPhoneNumber);
            Thread.Sleep(500);

        }
        public virtual void TextAll(string message)
        {
            mediator.TextAll(message, myPhoneNumber);
            Thread.Sleep(500);

        }
        public virtual void RecieveCall(int phonenumber)
        {
            Console.WriteLine(phonenumber + " called " + myPhoneNumber);
            Thread.Sleep(500);

        }
        public virtual void RecieveText(int phonenumber, string text)
        {
            Console.WriteLine(phonenumber + " texted " + myPhoneNumber + ": " + text);
            Thread.Sleep(500);

        }
    }
}
