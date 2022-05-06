/*using System;

namespace HelloWorld 
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Avengers Assemble!");
        }
    }
} */

/*using System;

namespace Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = 2;
            var count = 10;
            var totalPrice = 20.95f;
            var character = 'A';
            var firstName = "Aneeqah";
            var isWorking = false;
            
            Console.WriteLine(number);
            Console.WriteLine(count);
            Console.WriteLine(totalPrice);
            Console.WriteLine(character);
            Console.WriteLine(firstName);
            Console.WriteLine(isWorking);
        }
    }
}*/

/*using System;

namespace TypeConversion
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
            var number = "1234";
            int i = Convert.ToByte(number);
            Console.WriteLine(i);

            }
            catch (Exception)
            {
                Console.WriteLine(" The number could not be converted to a byte.");
            }

        }
    }
}*/

/*using System;

namespace Operators
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = 1;
            var b = 2;       ;
            var c = 3;

            Console.WriteLine(!(c > b || c == a));
        }
    }
}*/

namespace CSharpFundamentals
{
    public class Person
    {
        public string FirstName;
        public string LastName;

        public void Introduce()
        {
            Console.WriteLine("My name is " + FirstName + " " + LastName);
        }
    }
}