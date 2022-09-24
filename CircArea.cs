using System;


namespace sess02_DataTypes
{
    /// <summary>
    /// 
    /// </summary>
    public class CircArea
    {
        //Main method begins program execution
        static void Main(string[] args)
        {
            //Declare PI as a constant
            const float MYPI = 3.141592f;
            //Prompt the user for the radius of the circle
            Console.WriteLine("Please enter the radius of the circle in cm -> ");
            //Read in the value of the radius
            uint radius = uint.Parse(Console.ReadLine());
            //Calculate the area and circumference of the circle
            //float area = MYPI * radius * radius; old school way
            float area =(float) (MYPI * Math.Pow(radius, 2));
            float circumference = MYPI * (radius * 2);

            //Display the results 
            Console.WriteLine($"The area of the circle is {area: 0.000} cm2.");//3 decimal places.
            Console.WriteLine($"The circumference of the circle is {circumference: 0.##} cm.");//2 decimal places.
        }
    }
}
