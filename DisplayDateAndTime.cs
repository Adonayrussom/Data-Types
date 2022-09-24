using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sess02_DataTypes
{
    /// <summary>
    /// C# program that demonstrates how to format date and time
    /// 
    /// </summary>
    public class DisplayDateAndTime
    {
        static void Main(string[] args)
        {
            //Declare and initialise a dateTime object
            DateTime dt = DateTime.Now;

            //Display the date in short date format: dd/mm/yyyy NB: 4 English UK Locale 
            Console.WriteLine($"Today in short date format is : {dt:d} ");
            
            //Display the date in long date format: day, date, month, yr NB: 4 English UK Locale 
            Console.WriteLine($"Today in long date format is : {dt:D} ");
            
            //Display the full date without second format: day, month, date, year hh:mm NB: 4 English UK Locale 
            Console.WriteLine($"Today in full date format without seconds is : {dt:f} ");
            
            //Display the full date with second format: day, month, date, year hh:mm:ss NB: 4 English UK Locale 
            Console.WriteLine($"Today in full date format with seconds is : {dt:F} ");
            
            //Display the short date without second format: dd/mm/yyyy hh:mm NB: 4 English UK Locale
            Console.WriteLine($"Today in short date format without seconds is : {dt:g} ");
            
            //Display the short date with second format: dd/mm/yyyy hh:mm:ss NB: 4 English UK Locale 
            Console.WriteLine($"Today in short date format with seconds is : {dt:G} ");  
        }
    }
}
