namespace FinalProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Buyer , Welcome To the Islams Carpet Cleaning Service Charges :");
            Console.WriteLine(" Estimate for carpet cleaning service :");
            Console.WriteLine("Please , Enter the number of small carpet :");
            int Scnumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($" The number of small carpet is {Scnumber} ");
            Console.WriteLine("Please , Enter the number of Large carpet : ");
            int Lcnumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($" The number of small carpet is {Lcnumber} ");
            Console.WriteLine("Price per small carpet is $25");
            Console.WriteLine("Price per large carpet is $35");
            int Scost = Convert.ToInt32(Console.ReadLine());
            Scost = Scnumber * 25;
            Console.WriteLine($"The Small cost is {Scost}");
            int Lcost = Convert.ToInt32(Console.ReadLine());
            Lcost = Lcnumber * 35;
            Console.WriteLine($"The Large cost is {Lcost}");
            int Cost = Convert.ToInt32(Console.ReadLine());
            Cost = Scost + Lcost;
            Console.WriteLine($"Total Cost is {Cost} ");
            Console.WriteLine("Sales Tax rate is 6%");
            double tax = Convert.ToInt32(Console.ReadLine());
             tax = 0.06 * Cost;
            Console.WriteLine($"the Tax is {tax}");
            double TotalEstimate = Convert.ToInt32(Console.ReadLine());
            TotalEstimate = tax + Cost;
            Console.WriteLine($"The Total estimate is {TotalEstimate}");
            Console.WriteLine("This estimate is valid for 30 days");
        }
    }
}
