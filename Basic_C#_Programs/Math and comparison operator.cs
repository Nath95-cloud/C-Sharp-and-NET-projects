using system ;
namespace MathandComparisonOperates
{
    class programs{
        static void Main(string[]args){
            Console.WriteLine("Anonymous Icome Comparison Program");
            Console.WriteLine('Person 1');
            Console.WriteLine("Hourly Rate?");
            string hourRate1= Console.ReadLine();
            Console.WriteLine('Hours Worked per week?');
            int salary1.Convert.ToInt32(hourRate1) * Convert.Toint32(hours1) * 52;
            Console.WriteLine('Person2');
            Console.WriteLine('HourlyRate?')
            string HourlyRate2=Console.ReadLine();
            Console.WriteLine('Hours worked per week?');
            string Hours2=Console.ReadLine();
            int salary2 = Convert.ToInt32(HourlyRate2) * Convert.ToInt32(Hours2) * 52;
            Console.WriteLine('Annual salary of person 1');
            Console.WriteLine(salary1);
            Console.WriteLine('Annual salary of person 2');
            Console.WriteLine(salary2);
            bool isMore = salary1 > salary2;
            Console.WriteLine(isMore);
            Console.ReadLine();
            
        }
    }
}