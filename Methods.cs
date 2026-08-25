using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace C__Bacis
{
     class Methods
    {
    static public   string[]namesstudent= new string[4];
    static  public  int count = 0;
      static  public int[] agenames=new int[4];
   
      static  public  void addstudent()
        {
            Console.WriteLine("Enter your name");
            string name = Console.ReadLine();
            Console.WriteLine("Enter your age");
            int age = Convert.ToInt32(Console.ReadLine());
            namesstudent[count] = name;
            agenames[count] = age;
            count++;
            Console.WriteLine("Student added successfully");
        }
        static public void viewstudents()

        {
            if (count == 0)
            {
                Console.WriteLine("NO students added");
            }
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine(namesstudent[i]);
                Console.WriteLine(agenames[i]);
            }
        }
        static public void deletestudent()
        {
            Console.WriteLine("Enter your name");
            string namedelete=Console.ReadLine();

            for (int i = 0; i < count; i++) {
                if (namesstudent[i] == namedelete)
                {
                    for (int j = i; j < count-1; j++)
                    {
                        namesstudent[j] = namesstudent[j + 1];
                        agenames[j] = agenames[j + 1];

                    }
                    count--;
                    Console.WriteLine("Student deleted successfully");
                    return;
                }
                }
                Console.WriteLine("Student not found");
            
        }
           
           
        }
    
}
