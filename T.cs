using System;
using System.Collections.Generic;
using System.Text;

namespace L6
{
    class Transaction<T> where T: IAcount
{
    public void Operate(T acc1, T acc2, int sum)
    {
        if(acc1.CurrentSum >= sum)
        {
            acc1.Withdraw(sum);
            acc2.Put(sum);
            Console.WriteLine($"Liza : {acc1.CurrentSum}\nLena : {acc2.CurrentSum}");
        }
    }
}
}
