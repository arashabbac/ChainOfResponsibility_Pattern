using ChainOfResponsibility_Pattern.CustomerChainOfResponsibility;
using System;

namespace ChainOfResponsibility_Pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var fromCustomer = new Models.Customer
            {
                AccountValue = 1000,
                IsActive = true,
                MaxDateValue = 100,
                Password = "1234",
            };

            var toCustomer = new Models.Customer
            {
                AccountValue = 10000,
                IsActive = true,
                MaxDateValue = 2000,
                Password = "1234",
            };

            var transfer = new CheckPassword(new CheckValue(new CheckActive(new FinalTransfer(null))));
            
            var response = transfer.Execute(new RequestContext
            {
                FromCustomer = fromCustomer,
                ToCustomer = toCustomer,
                Password = "1234",
                Value = 150,
            });

            Console.WriteLine($"Response is: { response.Message }");
            Console.WriteLine($"FromCustomer value: {fromCustomer.AccountValue}");
            Console.WriteLine($"ToCustomer value: {toCustomer.AccountValue}");
            Console.ReadLine();
        }
    }
}
