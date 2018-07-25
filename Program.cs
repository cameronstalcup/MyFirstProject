using System;

namespace MyFirstC_Program
{
    class Program
    {
        public static void Main(string[] args)
        {
            Employee e1 = new Employee();
            e1.Id = 100;
            e1.FirstName = "Cameron";
            e1.LastName = "Stalcup";
            e1.Department = "Computer Science";
            e1.EmployeeId = 1001;
            e1.DateOfJoin = "July 23, 2018";

            Employee e2 = new Employee();
            e2.Id = 101;
            e2.FirstName = "Alex";
            e2.LastName = "Salcido";
            e2.Department = "Economics";
            e2.EmployeeId = 1002;
            e2.DateOfJoin = "July 23, 2018";

            Employee e3 = new Employee();
            e3.Id = 102;
            e3.FirstName = "Laura";
            e3.LastName = "Grohens";
            e3.Department = "Cognitive Science";
            e3.EmployeeId = 1003;
            e3.DateOfJoin = "July 23, 2018";

            Customer c1 = new Customer();
            c1.Id = 111;
            c1.FirstName = "Marie";
            c1.LastName = "Eberwein";
            c1.Address = "Nowhere";
            c1.City = "Oakland";
            c1.State = "California";

            Customer c2 = new Customer();
            c2.Id = 222;
            c2.FirstName = "Sam";
            c2.LastName = "Bell";
            c2.Address = "Tates Creek";
            c2.City = "Lexington";
            c2.State = "Kentucky";

            Customer c3 = new Customer();
            c3.Id = 333;
            c3.FirstName = "Cory";
            c3.LastName = "Laaker";
            c3.Address = "Nowhere";
            c3.City = "Cincinnati";
            c3.State = "Ohio";

            Employee[] Employees = new Employee[]{e1, e2, e2};
            Customer[] Customers = new Customer[]{c1,c2,c3};

            System.Console.WriteLine($"{e1.Id}-{e1.FirstName}-{e1.LastName}-{e1.Department}-{e1.EmployeeId}-{e1.DateOfJoin}");
            System.Console.WriteLine($"{e2.Id}-{e2.FirstName}-{e2.LastName}-{e2.Department}-{e2.EmployeeId}-{e2.DateOfJoin}");
            System.Console.WriteLine($"{e3.Id}-{e3.FirstName}-{e3.LastName}-{e3.Department}-{e3.EmployeeId}-{e3.DateOfJoin}");
            System.Console.WriteLine($"{c1.Id}-{c1.FirstName}-{c1.LastName}-{c1.Address}-{c1.City}-{c1.State}");
            System.Console.WriteLine($"{c2.Id}-{c2.FirstName}-{c2.LastName}-{c2.Address}-{c2.City}-{c2.State}");
            System.Console.WriteLine($"{c3.Id}-{c3.FirstName}-{c3.LastName}-{c3.Address}-{c3.City}-{c3.State}");
 
            for(int i = 0; i < Employees.Length-1; i++)
            {
                for(int j = i + 1; j < Employees.Length; j++)
                {
                    if(Employees[i].FirstName[0] > Employees[j].FirstName[0])
                    {
                        Employee temp = new Employee();
                        temp = Employees[i];
                        Employees[i] = Employees[j];
                        Employees[j] = temp;
                    }
                }
            }

            for(int i = 0; i < Customers.Length-1; i++)
            {
                for(int j = i + 1; j < Customers.Length; j++)
                {
                    if(Customers[i].FirstName[0] > Customers[j].FirstName[0])
                    {
                        Customer temp = new Customer();
                        temp = Customers[i];
                        Customers[i] = Customers[j];
                        Customers[j] = temp;
                    }
                }
            }

            for(int i = 0; i < Employees.Length; i++)
            {
                System.Console.WriteLine(Employees[i].FirstName);
            }

            for(int i = 0; i < Customers.Length; i++)
            {
                System.Console.WriteLine(Customers[i].FirstName);
            }
        }
    }
}
