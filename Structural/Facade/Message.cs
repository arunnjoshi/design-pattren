using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Facade
{
    public class Message
    {
        private string _message;    

        public Message(string message)
        {
            _message = message;
        }
    }
}