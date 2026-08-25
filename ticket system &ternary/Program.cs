namespace Ticket_Price_System
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int price = 0;

            Console.WriteLine("Enter your age");
            int age = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter day of week (1-7): ");
            int day = int.Parse(Console.ReadLine());

            if (age < 5)
            {
                price = 0;
            }
            else if (age >= 5 && age <= 12)
            {
                price = 30;
            }
            else if (age >= 13 && age <= 59)
            {
                price = 50;
            }
            else
            {
                price = 25;
            }

            if ((day == 6 || day == 7) && price > 0)
            {
                int bonus = 10;
                price += bonus;
            }

            Console.WriteLine($"{price} ");

            //ternay operator 
            int tempature = 35;
            string weatheradvice = tempature < 0 ? "freezing " : tempature<15 ? "cold wear jacke" : tempature <25 ?"weather" :"Hot";

            Console.WriteLine(weatheradvice);



        }
    } 
}
