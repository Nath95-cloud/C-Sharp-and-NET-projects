using System;
namespace BooleanLogic{
    class program {
        static void Main (string[]args){
            Console.WriteLine ("Car Insurance Applicatin");
            Console.WriteLine('What is your age?');
        }   int age = Convert.ToInt32(Console.ReadLine);
        Console.WriteLine('Have you ever had a DUI (yes or no)');
        string answer = Console.ReadLine(). ToLower();
        bool dui = answer == 'yes';
        Console.writeLine('how many speeding tickets do you have?');
        int tickets =Convert.ToInt32(Console.ReadLine());
        Console.WriteLine('Qualified For insurance?');
        bool qualified = (age>15) && !dui &&(tickets <=3);
        Console.WriteLine(qualified);  
    }
}