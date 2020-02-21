using System;
using System.Collections.Generic;
using System.Text;

namespace BankApp.Entities.Exceptions
{
    class AccountException : ApplicationException
    {
        public AccountException (string message) : base(message)
        {
        }
    }
}
