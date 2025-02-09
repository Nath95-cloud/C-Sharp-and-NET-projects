using System;
namespace StudentReport{
    class program{
        static void Main(string[]args){
            Console.WriteLine("Academy of learning centre college");
            Console.WriteLine('Student Daily Report');
            Console.WriteLine('What is your name?');
            string name = Console.ReadLine();
            Console.WriteLine('What course are you on');
            string course = Console.ReadLine();
            Console.WriteLine('what page number');
            int pageNum = Convert.Toint32(Console.ReadLine());
            Console.WriteLine('Do you need help with anything?');
            string needHelpBool = Console.ReadLine();
            bool needHelpBool=bool.Parse(needHelp);
            Console.WriteLine('Were there any postive exeperiences?');
            string studyHours=Console.ReadLine();
            Console.WriteLine("How Many Hours did you study today?");
            int studyHoursNum = Convert.Toint32(studyHours);
            Console.WriteLine('Thank you for your answers');
            Console.ReadLine();
        }
    }
}