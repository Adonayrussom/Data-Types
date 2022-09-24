using System;


namespace sess02_DataTypes
{
    /// <summary>
    /// C program that accepts 2 numbers from the user, multiplies them and 
    /// displays their product
    /// </summary>
    class MultiplyNums
    {
        //1. Assignment
        static void Main(string[] args)
        {
            byte num1;
            byte num2;

            Console.WriteLine("Enter value of num1: ");
            num1 = Convert.ToByte(Console.Read());
            Console.WriteLine("Enter value of num2: ");
            num2 = Convert.ToByte(Console.Read());


            int multiplication =(int) (num1 * num2);
            //Display the results 
            Console.WriteLine($"The multiplication is {multiplication}");
        }
    }
}
