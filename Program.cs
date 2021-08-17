using System;

namespace Assignment1608
{
    public class Assignment
    {
        //Enum Example
        //Example of enum with default values.
        public enum Vehicle
        {
            Moped,
            Bike,
            Car,
            Truck,
            Bus
        }

        //Example of enum with Custom values.
        public enum AreaCode
        {
            Pune = 12,
            Pimpri = 14,
            Kolhapur = 09,
            Nashik = 15
        }

        //Example of switch statement using enum
        public void VehicleType()
        {
            Console.WriteLine("Enter Code: ");
            int code = int.Parse(Console.ReadLine());
            switch (code)
            {
                case (int)Vehicle.Moped:
                    Console.WriteLine(Vehicle.Moped);
                    break;
                case (int)Vehicle.Bike:
                    Console.WriteLine(Vehicle.Bike);
                    break;
                case (int)Vehicle.Car:
                    Console.WriteLine(Vehicle.Car);
                    break;
                case (int)Vehicle.Truck:
                    Console.WriteLine(Vehicle.Truck);
                    break;
                case (int)Vehicle.Bus:
                    Console.WriteLine(Vehicle.Bus);
                    break;
                default:
                    Console.WriteLine("Invalid Input.");
                    break;
            }
        }
    }

    //Example of static class and static variable.
    public static class Names
    {
        static readonly string[] name = { "Atharva", "Murhe"};
        public static void PrintNames()
        {
            Console.WriteLine(name[0]+" "+ name[1]);
        }
    }

    //Example of value type and reference type.
    public class ValueType
    {
        public static void UpdateValue(int temp)
        {
            temp += 100;
            Console.WriteLine("New Value after passing and updating: {0}", temp);
        }

        public static void PrintValues()
        {
            int num = 10;
            Console.WriteLine("Original value before passing: {0}", num);
            UpdateValue(num);
            Console.WriteLine("Original value after passing: {0}", num);
        }
    }
    public class ReferenceType
    {
        public class Employee
        {
            public string Name { get; set; }
        }

        public static void UpdateValue(Employee emp2)
        {
            emp2.Name = "Atharva";
            Console.WriteLine("New Value after passing and updating: {0}", emp2.Name);
        }

        public static void PrintValue()
        {
            Employee emp1 = new Employee();
            emp1.Name = "Not Atharva";
            Console.WriteLine("Original value before passing: {0}", emp1.Name);
            UpdateValue(emp1);
            Console.WriteLine("Original value after passing: {0}", emp1.Name);
        }
    }

    //Example of Boxing and Unboxing.
    public class BoxingAndUnboxing
    {
        public static void Boxing()
        {
            int num = 100;
            object obj = num; //num is boxed
        }
        public static void Unboxing()
        {
            object obj = "Atharva";
            string name = (string)obj;//name is unboxed and casted to string explicitly.
        }
    }

    public class Program
    { 
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            ReferenceType.PrintValue();
        }
    }
}
