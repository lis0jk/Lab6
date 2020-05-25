using System;
using System.Collections.Generic;
using System.Text;

namespace L6
{
    interface IAcount
    {
        int CurrentSum { get; }
        void Put(int sum);     
        void Withdraw(int sum); 
    }
}
