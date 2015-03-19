using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.BankAccounts
{
    class InavalidAmountException : ApplicationException
    {
        public InavalidAmountException(string msg)
            : base(msg)
        { }

        public InavalidAmountException(string msg, Exception innerEx)
            : base(msg, innerEx)
        { }
    }
}
