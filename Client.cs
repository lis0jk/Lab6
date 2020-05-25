using System;
using System.Collections.Generic;
using System.Text;

namespace L6
{
    class Client : IAcount
    {
        int _sum; 
        public Client(int sum)
        {            
            _sum = sum;
        }       
        public int CurrentSum
        {
            get { return _sum; }
        }
        public void Put(int sum)
        {
            _sum += sum;
        }
        public void Withdraw(int sum)
        {
            try
            {
                if (sum <= _sum)
                {
                    _sum -= sum;
                }
            }
            catch { }
        }
    }
}
