using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWD_Mediator_GROUP_02_Lolling
{
    class PhoneCentral : IMediator
    {
        private readonly List<Phone> registeredPhones;

        public PhoneCentral()
        {
            registeredPhones = new List<Phone>();
        }

        // Communications

        public void Call(int recievingNumber,int callingNumber)
        {
            foreach (var s in registeredPhones)
            {
                if (s.myPhoneNumber == recievingNumber)
                {
                    s.RecieveCall(callingNumber);     
                }
            } 
        }

        public void Text(string message, int recievingNumber, int sendingNumber)
        {
            foreach (var s in registeredPhones)
            {
                if (s.myPhoneNumber == recievingNumber)
                {
                    s.RecieveText(sendingNumber, message);
                }
            }
        }

        public void TextAll(string message, int sendingnumber)
        {
            foreach (var s in registeredPhones)
            {
                if (s.myPhoneNumber!=sendingnumber)
                {
                    s.RecieveText(sendingnumber, message);
                }
            }
        }
      
        // Registering
        public void Register(Phone registeringSmartphone)
        {
            registeredPhones.Add(registeringSmartphone);
        }

       
    }
}
