using System;


namespace sess02_DataTypes
{
    /// <summary>
    /// C# program that accepts the user's name and greets them.
    /// </summary>
    public class GreetUser
    {
        //Main method begins program executoion
        static void Main(string[] args)
        {
            //String variable to hold the user's name
            string username;
            //prompt the user for their name
            Console.WriteLine("Please enter your name ->");
            username = Console.ReadLine();
            //Greet the user
            Console.WriteLine("Hello " + username + " from C# programming!");
            Console.WriteLine("Hello {0} from C# programming!",username);
            Console.WriteLine($"Hello {username} from C# programming!");
        }

    }
}
