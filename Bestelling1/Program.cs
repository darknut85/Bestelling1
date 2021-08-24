using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bestelling1
{
    class Program
    {
        static void Main(string[] args)
        {
            // parameters
            List<string> bought = new List<string>();
            List<string> article = new List<string>();
            List<double> cost = new List<double>();

            string name = "";
            string hold = "";

            int follow = 0;
            int current = 0;
            int h = 0;

            double total = 0;
            double currentProduct = 0;
            double discount = 0;
            double price = 0;

            bool stop = false;
            // data
            while (true)
            {
                try
                {
                    Console.WriteLine("What is the current year?");
                    current = Convert.ToInt32(Console.ReadLine());
                    break;
                }
                catch (Exception) { Console.WriteLine("Invalid. Please try again."); }
            }
            while (true)
            {
                while (true)
                {
                    try
                    {
                        Console.WriteLine("What is the name of the product? ");
                        name = Console.ReadLine();
                        bought.Add(name);
                        break;
                    }
                    catch (Exception) { Console.WriteLine("Invalid. Please try again."); }
                }
                while (true)
                {
                    try
                    {
                        Console.WriteLine("What is the price of the product?");
                        price = Convert.ToDouble(Console.ReadLine());
                        break;
                    }
                    catch (Exception) { Console.WriteLine("Invalid. Please try again."); }
                }
                while (true)
                {
                    try
                    {
                        Console.WriteLine("What is the year this product was produced?");
                        h = Convert.ToInt32(Console.ReadLine());
                        hold = h.ToString();
                        break;
                    }
                    catch (Exception) { Console.WriteLine("Invalid. Please try again."); }
                }
                while (true)
                {
                    try
                    {
                        Console.WriteLine("What is the follow number of the product?");
                        follow = Convert.ToInt32(Console.ReadLine());
                        hold += follow.ToString();
                        article.Add(hold);
                        break;
                    }
                    catch (Exception) { Console.WriteLine("Invalid. Please try again."); }
                }

                // math
                Console.WriteLine("The current year is: " + current);
                Console.WriteLine("The name is: " + name);
                Console.WriteLine("The price of the product is: " + price);
                Console.WriteLine("The production year of the product is: " + h);
                Console.WriteLine("The follow number of the product is: " + follow);
                Console.WriteLine("The article number is: " + hold);
                int between = current - h;
                if (between == 2) { discount = 5; }
                else if (between == 3 || between == 4) { discount = 10; }
                if (between >= 5) { discount = 25; }

                currentProduct = price - (price / 100 * discount);

                string p = follow.ToString();
                if (follow >= 10)
                {
                    p = p.Remove(p.Length - (p.Length - 1));
                }
                int first = Convert.ToInt32(p);
                if (first == 2 || first == 4 || first == 6 || first == 8 || first == 0)
                {
                    discount = 2;
                }
                else
                {
                    discount = 0;
                }
                currentProduct = currentProduct - (currentProduct / 100 * discount);
                total += currentProduct;
                cost.Add(currentProduct);

                // repeat until no
                while (true)
                {
                    try
                    {
                        Console.WriteLine("Would you like to purchase another product?");
                        string x = Console.ReadLine();
                        if (x == "yes" || x == "Yes" || x == "YES")
                        {
                            break;
                        }
                        if (x == "no" || x == "No" || x == "NO")
                        {
                            stop = true;
                            break;
                        }
                    }
                    catch (Exception) { Console.WriteLine("Invalid. Please try again."); }
                }
                if (stop == true)
                {
                    break;
                }
            }
            Console.WriteLine("List of bought articles: ");
            foreach (var a in bought)  { Console.WriteLine(a); }
            Console.WriteLine("List of article numbers: ");
            foreach (var b in article)  { Console.WriteLine(b); }
            Console.WriteLine("List of prices");
            foreach (var c in cost)  { Console.WriteLine(c); }
            Console.WriteLine("The total cost is: " + total);
            Console.WriteLine("The year of ordering is: " + current);
        }
    }
    // 6 digit number
        // 4 year
        // 2 follow number
    // korting afhankelijk van product leeftijd
        // 2 tot 3 jaar: 5%
        // 3 tot 5 jaar: 10%
        // 5 of meer jaar: 25%
    // als 5e cijver van artikelnummer even is: 2% korting

    // meerdere producten per bestelling
    // bepaal verontschuldigde bedrag
    // peildatum voor leeftijd van artikel
}
