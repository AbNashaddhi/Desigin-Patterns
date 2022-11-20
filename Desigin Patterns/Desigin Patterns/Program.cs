using Desigin_Patterns.AdpatarPattern;
using Desigin_Patterns.Observer;
using Desigin_Patterns.ObserverPattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Desigin_Patterns.FactoryPattern;

namespace Desigin_Patterns
{
    class Program
    {
        static void Main(string[] args)
        {

            //Adapter
            string[,] employeesArray = new string[5, 4]
            {
                {"101","Chinna","SE","2500"},
                {"102","Rahul","SE","2000"},
                {"103","Rakhi","SSE","1500"},
                {"104","Pam","SE","4800"},
                {"105","Sara","SSE","5000"}
            };

            ITarget target = new EmployeeAdapter();
            Console.WriteLine("HR system passes employee string array to Adapter\n");
            target.ProcessCompanySalary(employeesArray);
            Console.WriteLine("End of Adapter");

            //observer
            //Create a Product with Out Of Stock Status
            Subject OnePlus = new Subject("Red MI Mobile", 10000, "Out Of Stock");
            //User Chinna will be created and user1 object will be registered to the subject
            OBSERVER user1 = new OBSERVER("Chinna", OnePlus);
            OBSERVER user2 = new OBSERVER("Nashaddhi", OnePlus);
            OBSERVER user3 = new OBSERVER("Haseena", OnePlus);

            Console.WriteLine("One Puls  Mobile current state : " + OnePlus.getAvailability());
            Console.WriteLine();
            // Now product is available
            OnePlus.setAvailability("Available");

            Console.WriteLine("End of Observer");

            //singleton
            Singleton Parent = Singleton.GetInstance;
            Parent.PrintDetails("From Parent");
            Singleton Child = Singleton.GetInstance;
            Child.PrintDetails("From Child");
            Console.WriteLine("End of Singleton");

            //factory
            CreditCard creditCard = new PlatinumFactory().CreateProduct();
            if (creditCard != null)
            {
                Console.WriteLine("Card Type : " + creditCard.GetCardType());
                Console.WriteLine("Credit Limit : " + creditCard.GetCreditLimit());
                Console.WriteLine("Annual Charge :" + creditCard.GetAnnualCharge());
            }
            else
            {
                Console.Write("Invalid Card Type");
            }
            Console.WriteLine("--------------");
            creditCard = new MoneyBackFactory().CreateProduct();
            if (creditCard != null)
            {
                Console.WriteLine("Card Type : " + creditCard.GetCardType());
                Console.WriteLine("Credit Limit : " + creditCard.GetCreditLimit());
                Console.WriteLine("Annual Charge :" + creditCard.GetAnnualCharge());
            }
            else
            {
                Console.Write("Invalid Card Type____");
            }

        }
    }
}
