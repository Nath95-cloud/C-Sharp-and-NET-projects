using System;
namespace Overloading Operators{
    class Employee1ID{
        string employee1ID;
        Console.WriteLine Employee1ID = ("145687942");
    }
    class Employee2id{
        string employee2ID;
        Console.WriteLine Employee2ID =("154867942");
    }
    using system;
    namespace operators{
        class program{
            static void OverLoad()
        }
        int OverLoad (int x );
        float OverLoad(float x);
        double OverLoad(double x, double y);
        static int OverLoad(in x, int y ){
            return x + y;
        }
        static void Main(string[]args){
            int Employee1ID = PlusOverLoadInt(1456879420);
            double Employee2ID = PlusOverLoadDouble(154867942,145687942);
            Console.WriteLine('Int' + Employee1ID);
            Console.WriteLine('Double:' + Employee2ID)
        }
    }
}