//namn: Martin Líndenhöök
//klass: NET23

namespace MyFirstProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //number variable
            int num = 4;

            //checks if the variable is higher than 10.
            if (num > 10)
            {
                Console.WriteLine("Talet är stort!");
            }

            //checks if the variable is lower than 10.
            else if (num < 10)
            {
                Console.WriteLine("Oj. Lågt tal!");
            }

            Console.WriteLine("Vad heter du?\n");
            
            //reads user input from cli what their name is.
            string name = Console.ReadLine();

            Console.WriteLine($"Hej {name}!");

            for(int i = 0; i <= num; i++)
            {
                Console.WriteLine(i.ToString());
            }

        
        }
    }
}
