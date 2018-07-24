using System;

namespace MyFirstC_Program
{
    class Program
    {
        public enum CustomerStatus
        {
            New = 1,
            AwaitingActivation = 2,
            Activated = 3,
            DeActivated = 4
        }
        public struct Customer
        {
            public int Id;
            public string FirstName;
            public string LastName;
            public CustomerStatus Status;
        }
        static void Main(string[] args)
        {
            Customer cust = new Customer();
            cust.Id = 101;
            cust.FirstName = "Ajay";
            cust.LastName = "Singala";
            //cust.Status = (CustomerStatus) 1;
            cust.Status = CustomerStatus.New;
            System.Console.WriteLine($"{cust.Id}-{cust.FirstName}-{cust.LastName}-{cust.Status}");
        }
    }
}
