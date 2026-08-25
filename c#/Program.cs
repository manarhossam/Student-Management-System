namespace C__Bacis
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Welcome system Student");
            Console.WriteLine("1. Add student");
            Console.WriteLine("2. View Student");
            Console.WriteLine("3. Delete Student");
            Console.WriteLine("4. Exit");
           
                int userinput = Convert.ToInt32(Console.ReadLine());
                switch (userinput)
                {
                    case 1:
                        //add student
                        Methods.addstudent();

                        break;
                    case 2:
                        //View Students
                        Methods.viewstudents();
                        break;
                    case 3:
                        //Delete Stuent
                        Methods.deletestudent();
                        break;
                    case 4:
                        Environment.Exit(0);
                        break;
                }
            }
        }
    }
}
