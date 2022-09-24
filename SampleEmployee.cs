using System;


namespace sess02_DataTypes

{
    /// <summary>
    /// C# program that demonstrates how to write xml documentation for your classes/programs
    /// 
    /// The SampleEmployee class uses constructors to initialise the emploiyee id's & name and the display them
    /// 
    /// The class uses both non parameterised constructors
    /// </summary>
    public class SampleEmployee
    {
        byte age;
        private int _id;
        private string _name;

        public SampleEmployee()
        {
            this._id = -1;
            this._name = null;
        }

        public SampleEmployee(int id, string name)
        {
            this._id = id;
            this._name = name;
        }

        public void DisplayEmpDetails()
        {
            Console.WriteLine($"Emplyee ID: {this._id}\nEmployee Name: {this._name}");
        }

        static void Main(string[] args)
        {
            //Declare and instantiate a SampleEmployee object
            SampleEmployee emp = new SampleEmployee(1001, "David Kamau");
            emp.DisplayEmpDetails();
        }
    }
}
