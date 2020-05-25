using System;

namespace L6
{   
    class Program
    {
        static void Main(string[] args)
        {
            Client account1 = new Client(400);
            Client account2 = new Client(470);
            Transaction<Client> transaction = new Transaction<Client>();
            transaction.Operate(account1, account2, 300);          
        }
    }
}



