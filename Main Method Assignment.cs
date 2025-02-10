//MathOperation1 
using System;
namespace MainMethodAssignment{
    class MathOperation1{
        public int MathOperation(y, int x=1)
        {
            int result = y * x;
            return result;
        }
    }
}
//Pefroming multiplacation

//Program.cs
using System;
namespace MainMethodAssignment{
    class Program{
        static void Main(string[]args);{

            MathOperation1 mathOp = new MathOperation1();
            Console.WriteLine('Enter an interger':);
            int num1 = Convert.ToInt32(Console.ReadLine());
            try{
                int num2 = Convert.ToInt32(Console.ReadLine());
                int results = mathOp.Mathoperation(num1, num2);
            }
            catch{
                int results = mathOp.MathOperations(num1);
                Console.WriteLine(num1 + 'x' + num2 + '=' + results);
            }
            Consile.ReadLine
        }
    }
}