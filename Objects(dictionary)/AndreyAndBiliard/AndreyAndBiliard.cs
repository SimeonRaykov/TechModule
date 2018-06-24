using System;
using System.Collections.Generic;
using System.Linq;

namespace AndreyAndBiliard
{
    class AndreyAndBiliard
    {
        static void Main(string[] args)
        {

            Dictionary<string, decimal> pricesDictionary
                = new Dictionary<string, decimal>();


            Dictionary<string, decimal> clientsBill
                = new Dictionary<string, decimal>();

            Dictionary<string, Dictionary<string, decimal>>
                clientsDictionary = new Dictionary<string, Dictionary<string, decimal>>();


            List<string> availableProducts = new List<string>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine();
                var tokens = input.Split("-", StringSplitOptions.RemoveEmptyEntries);

                var product = tokens[0];
                var price = decimal.Parse(tokens[1]);

                if (pricesDictionary.ContainsKey(product) == false)
                {
                    pricesDictionary.Add(product, 0);
                    availableProducts.Add(product);
                }

                pricesDictionary[product] = price;

            }

            var inputX = Console.ReadLine();

            while (inputX != "end of clients")
            {
                var tokens = inputX.Split(new char[] { '-', ',' }, StringSplitOptions.RemoveEmptyEntries);
                var name = tokens[0];
                var product = tokens[1];
                if (availableProducts.Contains(product) == false)
                {
                    inputX = Console.ReadLine();
                    continue;
                }
                var quantity = decimal.Parse(tokens[2]);

                if (clientsDictionary.ContainsKey(name) == false)
                {
                    clientsDictionary.Add(name, new Dictionary<string, decimal>());
                }

                if (clientsDictionary[name].ContainsKey(product) == false)
                {
                    clientsDictionary[name].Add(product, 0);
                }

                clientsDictionary[name][product] += quantity;
                var currentProductPrice = pricesDictionary[product];

                if (clientsBill.ContainsKey(name) == false)
                {
                    clientsBill.Add(name,0);
                }

                clientsBill[name] += quantity * currentProductPrice;

                inputX = Console.ReadLine();
            }

            var totalBill = 0M;
            var currentBill = 0M;


            foreach (var client in clientsDictionary.OrderBy(x=>x.Key))
            {
                Console.WriteLine($"{client.Key}");

                foreach (var product in client.Value)
                {

                    Console.WriteLine($"-- {product.Key} - {product.Value}");

                    
                }

                currentBill = clientsBill[client.Key];
                Console.WriteLine($"Bill: {currentBill:F2}");
                totalBill += currentBill;


            }

            Console.WriteLine($"Total bill: {totalBill:F2}");



        }
    }
}
