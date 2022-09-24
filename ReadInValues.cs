using System;


namespace sess02_DataTypes
{
    /// <summary>
    /// C# program that demonstrates how to read in and display varoius c# data types.
    /// </summary>
    public class ReadInValues
    {
        static void Main(string[] args)
        {
            //Prompt the user for their name;
            Console.WriteLine("Please enter your name -> ");
            string username = Console.ReadLine();
            //Prompt the user for their age
            Console.WriteLine("Please enter your age -> ");
            byte userAge = Convert.ToByte(Console.ReadLine());
            //Prompt the user for their marital
            Console.WriteLine("Are you married? Y/y -> yes or N/n -> no: ");
            char maritalStatus = Convert.ToChar(Console.Read());
            //Create a boolean based on the user's marital status
            bool isMarried = maritalStatus.ToString().ToLower().Equals('y') ? true : false;
            //prompt the user for their weight in KG
            Console.WriteLine("Please enter your weight in KG -> ");
            float weight = float.Parse(Console.ReadLine());

            //Write code to display the user's name, age, marital status using the boolean, weight in KG
            Console.WriteLine($"The username is: {username}");
            Console.WriteLine($"\nThe user\'s age is: {userAge}");
            Console.WriteLine($"\nThe user\'s maritalStatus is: {maritalStatus}");
            Console.WriteLine($"\nThe user\'s weight is: {weight}");
            Console.WriteLine($"\nIs user married: {isMarried}");

        }
    }
}
